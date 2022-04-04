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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dataSet1.orders);
            countLabel.Text = $"Усього: {ordersDataGridView.Rows.Count - 1}";
        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {
            ordersBindingSource.AddNew();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ordersDataGridView.SelectedRows)
            {
                ordersDataGridView.Rows.RemoveAt(row.Index);
            }

            ordersBindingSource.EndEdit();
            ordersTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {ordersDataGridView.Rows.Count - 1}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ordersBindingSource.EndEdit();
            ordersTableAdapter.Update(dataSet1);

            countLabel.Text = $"Усього: {ordersDataGridView.Rows.Count - 1}";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Filter = "customers_full_name LIKE\'%" + FilterInput.Text + "%\'";

            countLabel.Text = $"Усього: {ordersDataGridView.Rows.Count - 1}";
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            ordersBindingSource.Filter = null;
            FilterInput.Clear();

            countLabel.Text = $"Усього: {ordersDataGridView.Rows.Count - 1}";
        }
    }
}
