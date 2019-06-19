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
    public partial class Add_Player : UserControl
    {
       SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static Add_Player _instance;
        public static Add_Player Instance
        {
            get {
                if (_instance == null)
                    _instance = new Add_Player();
                return _instance;

            }

        }

        public Add_Player()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "INSERT INTO [Table] VALUES ('"+ textBox1.Text +"', '" + textBox2.Text+ "', '" + textBox3.Text +"', '" + textBox4.Text + "', '" + comboBox1.Text+ "', '" + textBox6.Text+"') ";

        
            comman.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Record inserted successfully");

        }
    }
}
