using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Введіть ім'я";
            userNameField.ForeColor = Color.Gray;

            userMailField.Text = "Введіть пошту";
            userMailField.ForeColor = Color.Gray;

            loginField.Text = "Введіть логін";
            loginField.ForeColor = Color.Gray;

            passField.UseSystemPasswordChar = false;
            passField.Text = "Введіть пароль";
            passField.ForeColor = Color.Gray;

            passField2.UseSystemPasswordChar = false;
            passField2.Text = "Повторіть пароль";
            passField2.ForeColor = Color.Gray;
        }

        Point lastPoint;
        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(139, 0, 255);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            closeButton.ForeColor = Color.Red;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Введіть ім'я")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введіть ім'я";
                userNameField.ForeColor  = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введіть пароль")
            {
                passField.UseSystemPasswordChar = true;
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.UseSystemPasswordChar = false;
                passField.Text = "Введіть пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void passField2_Enter(object sender, EventArgs e)
        {
            if (passField2.Text == "Повторіть пароль")
            {
                passField2.UseSystemPasswordChar = true;
                passField2.Text = "";
                passField2.ForeColor = Color.Black;
            }
        }

        private void passField2_Leave(object sender, EventArgs e)
        {
            if (passField2.Text == "")
            {
                passField2.UseSystemPasswordChar = false;
                passField2.Text = "Повторіть пароль";
                passField2.ForeColor = Color.Gray;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введіть логін";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введіть логін")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void userMailField_Leave(object sender, EventArgs e)
        {
            if (userMailField.Text == "")
            {
                userMailField.Text = "Введіть пошту";
                userMailField.ForeColor = Color.Gray;
            }
        }

        private void userMailField_Enter(object sender, EventArgs e)
        {
            if (userMailField.Text == "Введіть пошту")
            {
                userMailField.Text = "";
                userMailField.ForeColor = Color.Black;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            String messageString = "";
            Boolean error = false;

            if (userNameField.Text == "Введіть ім'я" | userNameField.Text == "")
            {
                messageString += "Введіть ім'я\n";
                error = true;
            }

            if (userMailField.Text == "Введіть пошту" | userMailField.Text == "")
            {
                messageString += "Введіть пошту\n";
                error = true;
            }

            else 
            {
                if (!userMailField.Text.Contains("@"))
                {
                    messageString += "Введіть вірну пошту\n";
                    error = true;
                }
            }

            if (loginField.Text == "Введіть логін" | loginField.Text == "")
            {
                messageString += "Введіть логін\n";
                error = true;
            }

            if (passField.Text != passField2.Text)
            {
                messageString += "Паролі не співпадають\n";
                error = true;
            }

            if ((iskUserExists()) | (error))
            {
                MessageBox.Show(messageString);
                return;
            }

            DB db = new DB();
            SqlCommand command = new SqlCommand("INSERT INTO users (name, mail, login, password, user_is_authenticated) VALUES (@name, @mail, @login, @password, 'false')", db.getConnection());
            command.Parameters.Add("@name", SqlDbType.NChar).Value = userNameField.Text;
            command.Parameters.Add("@mail", SqlDbType.NChar).Value = userMailField.Text;
            command.Parameters.Add("@login", SqlDbType.NChar).Value = loginField.Text;
            command.Parameters.Add("@password", SqlDbType.NChar).Value = db.GetHashString(passField.Text);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                messageString += "Обліковий запис успішно створено\n";
            else
                messageString += "Обліковий запис не створено\n";

            db.closeConnection();

            MessageBox.Show(messageString);

        }

        public Boolean iskUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE login = @uL", db.getConnection());

            command.Parameters.Add("@uL", SqlDbType.NChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Користувач з таким логіном уже є");
                return true;
            }

            else
            {
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
