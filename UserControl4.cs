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
    public partial class UserControl4 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl4 _instance;
        public static UserControl4 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl4();
                return _instance;

            }
        }
        public UserControl4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControl4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "INSERT INTO [Table1] VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + comboBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "' ) ";


            comman.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Record inserted successfully");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
