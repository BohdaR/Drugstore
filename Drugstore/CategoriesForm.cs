﻿using System;
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
            // TODO: This line of code loads data into the 'dataSet1.drug_form' table. You can move, or remove it, as needed.
            this.drug_formTableAdapter.Fill(this.dataSet1.drug_form);
            // TODO: This line of code loads data into the 'dataSet1.use_categories' table. You can move, or remove it, as needed.
            this.use_categoriesTableAdapter.Fill(this.dataSet1.use_categories);

        }

        private void company_profitLabel1_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void searchCanselButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void addFieldbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
