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

namespace BTU_SQL
{
    public partial class Main : Form
    {
        
        public string gelenhost, gelenusername, gelenpassword;
        public Main(string host,string username,string pass)
        {
            InitializeComponent();
            gelenhost = host;
            gelenusername = username;
            gelenpassword = pass;

            this.Load += new System.EventHandler(this.Main_Load);
            this.databaseView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databaseView_CellClick);

        }

        private void SetAllRowsHeight(int height)
        {
            databaseView.RowTemplate.Height = height;
            tableView.RowTemplate.Height = height;
            ResultsView.RowTemplate.Height = height;
            
            foreach (DataGridViewRow row in databaseView.Rows)
            {
                row.Height = height;
            }

            foreach(DataGridViewRow row in tableView.Rows)
            {
                row.Height = height;
            }
            foreach (DataGridViewRow row in ResultsView.Rows)
            {
                row.Height = height;
            }
        }

        private void SetAllColumnsWidth(int width)
        {
            foreach (DataGridViewColumn column in databaseView.Columns)
            {
                column.Width = width;
            }

            foreach (DataGridViewColumn column in tableView.Columns)
            {
                column.Width = width;
            }
            foreach (DataGridViewColumn column in ResultsView.Columns)
            {
                column.Width = width;
            }
        }

        


        private void ListTables(string databaseName)
        {
            
            string connectionString = $"Server={gelenhost};Database={databaseName};User ID={gelenusername};Password={gelenpassword};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("SHOW TABLES", connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable tables = new DataTable();
                    adapter.Fill(tables);
                    tableView.DataSource = tables;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                SetAllRowsHeight(25);
                SetAllColumnsWidth(226);
            }
        }

        //TABLE_VIEW
        private void databaseView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.databaseView.Rows[e.RowIndex];
                string databaseName = row.Cells[0].Value.ToString();
                ListTables(databaseName);
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.databaseView.Rows[e.RowIndex];
                selectedDatabase = row.Cells[0].Value.ToString();
                ListTables(selectedDatabase);
            }
        }


        private string selectedDatabase;
        private void tableView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.tableView.Rows[e.RowIndex];
                string tableName = row.Cells[0].Value.ToString();
                ListTableData(selectedDatabase, tableName);
            }
        }

        //RESULT_VIEW
        private void ListTableData(string databaseName, string tableName)
        {
            string connectionString = $"Server={gelenhost};Database={databaseName};User ID={gelenusername};Password={gelenpassword};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand($"SELECT * FROM `{tableName}`", connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable tableData = new DataTable();
                    adapter.Fill(tableData);
                    ResultsView.DataSource = tableData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                SetAllRowsHeight(25);
                SetAllColumnsWidth(200);
            }
        }

        //DATABASE_VIEW
        public void LoadDatabases()
        {
            string ConnectionString = $"Server={gelenhost};Uid={gelenusername};Pwd={gelenpassword};";

            MySqlConnection conn = new MySqlConnection(ConnectionString);
            try
            {
                conn.Open();
                string query = "show databases;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                databaseView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            SetAllRowsHeight(25);
            SetAllColumnsWidth(226);
        }


        private void Main_Load(object sender, EventArgs e)
        {
            LoadDatabases();
            databaseView.CellClick += new DataGridViewCellEventHandler(databaseView_CellClick);



        }
    }
}
