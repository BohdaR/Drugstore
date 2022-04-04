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
    public partial class BrendForm : Form
    {
        public BrendForm()
        {
            InitializeComponent();
        }

        private void brendBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brendBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void brendBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.brendBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }


        private void BrendForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.brend' table. You can move, or remove it, as needed.
            this.brendTableAdapter.Fill(this.dataSet1.brend);
            // TODO: This line of code loads data into the 'dataSet1.drug_form' table. You can move, or remove it, as needed.
            this.brendTableAdapter.Fill(this.dataSet1.brend);

            countLabel.Text = $"Усього: {brendDataGridView.Rows.Count - 1}";
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            brendBindingSource.Filter = null;
            FilterInput.Clear();

            countLabel.Text = $"Усього: {brendDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            brendBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in brendDataGridView.SelectedRows)
            {
                brendDataGridView.Rows.RemoveAt(row.Index);
            }

            brendBindingSource.EndEdit();
            brendTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {brendDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            brendBindingSource.EndEdit();
            brendTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {brendDataGridView.Rows.Count - 1}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            brendBindingSource.Filter = "name LIKE\'%" + FilterInput.Text + "%\'";

            countLabel.Text = $"Усього: {brendDataGridView.Rows.Count - 1}";
        }
    }
}
