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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void use_categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.use_categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void use_categoriesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.use_categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.use_categories' table. You can move, or remove it, as needed.
            this.use_categoriesTableAdapter.Fill(this.dataSet1.use_categories);
            countLabel.Text = $"Усього: {use_categoriesDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try{
                use_categoriesBindingSource.EndEdit();
                use_categoriesTableAdapter.Update(dataSet1);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            countLabel.Text = $"Усього: {use_categoriesDataGridView.Rows.Count - 1}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            use_categoriesBindingSource.Filter = "name LIKE\'%" + FilterInput.Text + "%\'";

            countLabel.Text = $"Усього: {use_categoriesDataGridView.Rows.Count - 1}";
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            FilterInput.Clear();
            use_categoriesBindingSource.Filter = null;

            countLabel.Text = $"Усього: {use_categoriesDataGridView.Rows.Count - 1}";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in use_categoriesDataGridView.SelectedRows)
                {
                    use_categoriesDataGridView.Rows.RemoveAt(row.Index);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            use_categoriesBindingSource.EndEdit();
            use_categoriesTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {use_categoriesDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            try
            {
                use_categoriesBindingSource.AddNew();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
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
