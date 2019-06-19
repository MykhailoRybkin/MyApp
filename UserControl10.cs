using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class UserControl10 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl10 _instance;
        public static UserControl10 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl10();
                return _instance;

            }

        }
        public UserControl10()
        {
            InitializeComponent();
        }

        private void UserControl10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "INSERT INTO [Table3] VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + dateTimePicker1.Text + "') ";


            comman.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Record inserted successfully");
        }
    }
}
