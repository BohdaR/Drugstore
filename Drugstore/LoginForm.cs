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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private Boolean user_is_authenticated = false;
        private void LoginForm1_Load(object sender, EventArgs e)
        {
            if (this.user_is_authenticated)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.FromArgb(139, 0, 255);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String userLogin = loginField.Text;
            String userPassword = db.GetHashString(passField.Text);

            db.openConnection();

            SqlCommand command = new SqlCommand("SELECT user_is_authenticated FROM Users WHERE login = @uL AND password = @uP", db.getConnection());

            command.Parameters.Add("@uL", SqlDbType.NChar).Value = userLogin;
            command.Parameters.Add("@uP", SqlDbType.NChar).Value = userPassword;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                this.user_is_authenticated = true;
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("невірно", "Невірно", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            db.closeConnection();
            

        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Red;
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLabel_MouseHover(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.Aqua;
        }

        private void registerLabel_MouseLeave(object sender, EventArgs e)
        {
            registerLabel.ForeColor = Color.White;
        }
    }
}
