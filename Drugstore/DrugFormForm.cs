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

        }
    }
}
