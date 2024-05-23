﻿using System;
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
    }
}
