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

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Brend brend = new Brend();
            brendDataGridView.DataSource = brend.search_brend(FilterInput.Text).Tables[0];
        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {
            Brend brend = new Brend();
            brendDataGridView.DataSource = brend.search_brend().Tables[0];
        }
    }
}
