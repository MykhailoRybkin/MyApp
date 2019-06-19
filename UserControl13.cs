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
    public partial class UserControl13 : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private static UserControl13 _instance;
        public static UserControl13 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl13();
                return _instance;

            }
        }
        public UserControl13()
        {
            InitializeComponent();
        }
        public void disp_data()
        {
            connect.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [Table3]", connect);
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridView1.DataSource = dtbl;
            connect.Close();



        }
        private void UserControl13_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
