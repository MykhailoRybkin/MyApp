using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void login_Click(object sender, EventArgs e)
        {

            if (username_textbox.Text == "" && password_textbox.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password");

            }
            else
            {
                SqlConnection Conn = new SqlConnection(@"Data Source=DESKTOP-TH71F2G\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from loginForm where Name=@Name and Pass=@Pass", Conn);
                cmd.Parameters.AddWithValue("@Name", username_textbox.Text);
                cmd.Parameters.AddWithValue("@Pass", password_textbox.Text);



                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adpt.Fill(ds);

                Conn.Open();
                cmd.ExecuteNonQuery();
                Conn.Close();


                if (ds.Rows.Count > 0)
                {
                    MessageBox.Show("Successfull Connection");
                    using (Form2 fn = new Form2())
                    {
                        fn.ShowDialog();
                    }


                }

                else
                {
                    MessageBox.Show("Invallid UserName and Password");
                }

                            
            }
           
            

            
        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            password_textbox.PasswordChar = '*';
        }
    }
}
