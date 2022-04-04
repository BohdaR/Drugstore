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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrendForm brendForm = new BrendForm();
            brendForm.ShowDialog();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugFormForm drugFormForm = new DrugFormForm();
            drugFormForm.ShowDialog();
        }

        private void positionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugsForm drugsForm = new DrugsForm();
            drugsForm.ShowDialog();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm();
            ordersForm.ShowDialog();
        }

        private void visitingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
