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
    public partial class UserControl8 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl8 _instance;
        public static UserControl8 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl8();
                return _instance;

            }
        }
        public UserControl8()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "INSERT INTO [Table2] VALUES ('" + dateTimePicker1.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "' ) ";


            comman.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Record inserted successfully");
        }
    }
}
