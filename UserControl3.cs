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
    public partial class UserControl3 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl3 _instance;
        public static UserControl3 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl3();
                return _instance;

            }
        }


        public UserControl3()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            connect.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Table]", connect);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            connect.Close();



        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand comman = connect.CreateCommand();
            comman.CommandType = CommandType.Text;
            comman.CommandText = "select * from [Table] where Surname= '" + textBox1.Text + "'";


            comman.ExecuteNonQuery();
            connect.Close();
            disp_data();
            MessageBox.Show("Record founded successfully");
        }
    }
}
