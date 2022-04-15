using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore
{
    public partial class DrugFormForm : Form
    {
        public DrugFormForm()
        {
            InitializeComponent();
        }

        private void drug_formBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.drug_formBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void drug_formBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.drug_formBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void DrugFormForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.drug_form' table. You can move, or remove it, as needed.
            this.drug_formTableAdapter.Fill(this.dataSet1.drug_form);
            countLabel.Text = $"Усього: {drug_formDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {   
            try
            {
                drug_formBindingSource.EndEdit();
                drug_formTableAdapter.Update(dataSet1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            countLabel.Text = $"Усього: {drug_formDataGridView.Rows.Count - 1}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            drug_formBindingSource.Filter = "name LIKE\'%" + FilterInput.Text + "%\'";

            countLabel.Text = $"Усього: {drug_formDataGridView.Rows.Count - 1}";
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            FilterInput.Clear();
            drug_formBindingSource.Filter = null;

            countLabel.Text = $"Усього: {drug_formDataGridView.Rows.Count - 1}";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in drug_formDataGridView.SelectedRows)
                {
                    drug_formDataGridView.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            drug_formBindingSource.EndEdit();
            drug_formTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {drug_formDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            drug_formBindingSource.AddNew();
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
