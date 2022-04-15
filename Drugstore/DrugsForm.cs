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
    public partial class DrugsForm : Form
    {
        public DrugsForm()
        {
            InitializeComponent();
        }

        private void drugsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drugsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void DrugsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.drugs' table. You can move, or remove it, as needed.
            this.drugsTableAdapter.Fill(this.dataSet1.drugs);

            DB db = new DB();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT id FROM use_categories", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            use_category_idComboBox.DisplayMember = "id";
            use_category_idComboBox.DataSource = table;
            use_category_idComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            use_category_idComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;


            DataTable table2 = new DataTable();
            SqlCommand command2 = new SqlCommand("SELECT id FROM brend", db.getConnection());

            adapter.SelectCommand = command2;
            adapter.Fill(table2);

            brend_idComboBox.DisplayMember = "id";
            brend_idComboBox.DataSource = table2;
            brend_idComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            brend_idComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;


            DataTable table3 = new DataTable();
            SqlCommand command3 = new SqlCommand("SELECT id FROM drug_form", db.getConnection());

            adapter.SelectCommand = command3;
            adapter.Fill(table3);

            form_of_drug_idComboBox.DisplayMember = "id";
            form_of_drug_idComboBox.DataSource = table3;
            form_of_drug_idComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            form_of_drug_idComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                drugsBindingSource.EndEdit();
                drugsTableAdapter.Update(dataSet1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            drugsBindingSource.Filter = "name LIKE\'%" + FilterInput.Text + "%\'";

            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            FilterInput.Clear();
            drugsBindingSource.Filter = null;

            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in drugsDataGridView.SelectedRows)
                {
                    drugsDataGridView.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            drugsBindingSource.EndEdit();
            drugsTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            drugsBindingSource.AddNew();
        }

        private void use_category_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
