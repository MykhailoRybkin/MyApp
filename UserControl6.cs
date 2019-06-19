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
    public partial class UserControl6 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl6 _instance;
        public static UserControl6 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl6();
                return _instance;

            }
        }
        public UserControl6()
        {
            InitializeComponent();
        }
        public void disp_data()
        {
            connect.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Table1]", connect);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            connect.Close();



        }

        private void UserControl6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "select * from [Table1] where Surname= '" + textBox1.Text + "'";


            comman.ExecuteNonQuery();
            connect.Close();
            disp_data();
            MessageBox.Show("Record founded successfully");
        }
    }
}
