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
            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            drugsBindingSource.EndEdit();
            drugsTableAdapter.Update(dataSet1);

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
            foreach (DataGridViewRow row in drugsDataGridView.SelectedRows)
            {
                drugsDataGridView.Rows.RemoveAt(row.Index);
            }

            drugsBindingSource.EndEdit();
            drugsTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {drugsDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            drugsBindingSource.AddNew();
        }
    }
}
