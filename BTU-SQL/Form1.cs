using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;

namespace BTU_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            string host = LoginServerIPBox.Text;
            string username = LoginUsernameBox.Text;
            string password = LoginPassBox.Text;

            Main main = new Main(host,username,password);
            main.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginServerIPBox.Text = "localhost";
            LoginUsernameBox.Text = "root";
            LoginPassBox.Text = "password";

            LoginPassBox.ForeColor = Color.Gray;
            LoginServerIPBox.ForeColor = Color.Gray;
            LoginUsernameBox.ForeColor = Color.Gray;
        }

        private void LoginServerIPBox_Enter(object sender, EventArgs e)
        {
            if(LoginServerIPBox.Text == "localhost")
            {
                LoginServerIPBox.Text = "";
                LoginServerIPBox.ForeColor = Color.Black;
            }
        }

        private void LoginServerIPBox_Leave(object sender, EventArgs e)
        {
            if (LoginServerIPBox.Text == "")
            {
                LoginServerIPBox.Text = "localhost";
                LoginServerIPBox.ForeColor = Color.Gray;
            }
        }

        private void LoginUsernameBox_Enter(object sender, EventArgs e)
        {
            if (LoginUsernameBox.Text == "root")
            {
                LoginUsernameBox.Text = "";
                LoginUsernameBox.ForeColor = Color.Black;
            }
        }

        private void LoginUsernameBox_Leave(object sender, EventArgs e)
        {
            if (LoginUsernameBox.Text == "")
            {
                LoginUsernameBox.Text = "root";
                LoginUsernameBox.ForeColor = Color.Gray;
            }
        }

        private void LoginPassBox_Enter(object sender, EventArgs e)
        {
            if (LoginPassBox.Text == "password")
            {
                LoginPassBox.Text = "";
                LoginPassBox.ForeColor = Color.Black;
            }
        }

        private void LoginPassBox_Leave(object sender, EventArgs e)
        {
            if (LoginPassBox.Text == "")
            {
                LoginPassBox.Text = "password";
                LoginPassBox.ForeColor = Color.Gray;
            }
        }

    }
}
