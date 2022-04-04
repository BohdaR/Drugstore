using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    class Brend : DB
    {
        // оголошення полів таблиці
        private string name;
        private string company;
        private string company_profit;
        private string manufacturers_products;
        private int rating;

        // оголошення конструктора без параметрів 
        public Brend() { }

        // оголошення конструктора з параметрами
        public Brend(string name, string company, string company_profit, string manufacturers_products, int rating)
        {
            this.name = name;
            this.company = company;
            this.company_profit = company_profit;
            this.manufacturers_products = manufacturers_products;
            this.rating = rating;
        }

        // оголошення аксесорів

        public string Name
        {
            get
            {
                return name;    
            }
            set
            {
                name = value; 
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Company_profit
        {
            get
            {
                return company_profit;
            }
            set
            {
                company_profit = value;
            }
        }

        public string Manufacturers_products
        {
            get
            {
                return manufacturers_products;
            }
            set
            {
                manufacturers_products = value;
            }
        }

        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        // оголошення методів

        // пошук
        public DataSet search_brend(string request=null)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command = new SqlCommand("SELECT * FROM brend WHERE name LIKE @request", getConnection());
            command.Parameters.Add("@request", SqlDbType.NChar).Value = "%" + request + "%";

            adapter.SelectCommand = command;
            adapter.Fill(dataSet);

            return dataSet;
        }

        // створення
        public void create_brend(string name, string country, string company_profit = null, string manufacturers_products = null, int rating = 5)
        {
            SqlCommand command = new SqlCommand("INSERT INTO brend (name, country, company_profit, manufacturers_products, rating) VALUES (@name, @country, @company_profit, @manufacturers_products, @rating)", getConnection());
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@country", SqlDbType.NChar).Value = country;
            command.Parameters.Add("@company_profit", SqlDbType.Money).Value = company_profit;
            command.Parameters.Add("@manufacturers_products", SqlDbType.NChar).Value = manufacturers_products;
            command.Parameters.Add("@rating", SqlDbType.Int).Value = rating;

            openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Бренд успішно додано\n");
            else
                MessageBox.Show("Бренд не додано\n");

            closeConnection();
        }

        // видалення
        public void delete_brend(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM brend WHERE id = @id", getConnection());
            command.Parameters.Add("@id", SqlDbType.NChar).Value = Int16.Parse(id);

            openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Бренд видалено\n");
            else
                MessageBox.Show("Бренд не видалено\n");

            closeConnection();
        }

        // редагування
        public void update_brend(int id, string name, string country, string company_profit = null, string manufacturers_products = "N/A", int rating=5)
        {
            SqlCommand command = new SqlCommand("UPDATE brend SET name = @name, country = @country, company_profit = @company_profit, manufacturers_products = @manufacturers_products, rating = @rating WHERE id = @id", getConnection());
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NChar).Value = name;
            command.Parameters.Add("@country", SqlDbType.NChar).Value = country;
            command.Parameters.Add("@company_profit", SqlDbType.Money).Value = company_profit;
            command.Parameters.Add("@manufacturers_products", SqlDbType.NChar).Value = manufacturers_products;
            command.Parameters.Add("@rating", SqlDbType.Int).Value = rating;

            openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Дані обновлено\n");
            else
                MessageBox.Show("Дані не обновлено\n");

            closeConnection();
        }
    }
}
