using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

       

        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(Add_Player.Instance))
            {

                panel1.Controls.Add(Add_Player.Instance);
                Add_Player.Instance.Dock = DockStyle.Fill;
                Add_Player.Instance.BringToFront();

            }
            else
                Add_Player.Instance.BringToFront();
        }

        private void addOCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl4.Instance))
            {

                panel1.Controls.Add(UserControl4.Instance);
                UserControl4.Instance.Dock = DockStyle.Fill;
                UserControl4.Instance.BringToFront();

            }
            else
                UserControl4.Instance.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void viewAllPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl1.Instance))
            {

                panel1.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
               UserControl1.Instance.BringToFront();

            }
            else
                UserControl1.Instance.BringToFront();
        }

        private void deleteAPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl2.Instance))
            {

                panel1.Controls.Add(UserControl2.Instance);
                UserControl2.Instance.Dock = DockStyle.Fill;
                UserControl2.Instance.BringToFront();

            }
            else
                UserControl2.Instance.BringToFront();

        }

        private void searchAPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl3.Instance))
            {

                panel1.Controls.Add(UserControl3.Instance);
                UserControl3.Instance.Dock = DockStyle.Fill;
                UserControl3.Instance.BringToFront();

            }
            else
                UserControl3.Instance.BringToFront();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl5.Instance))
            {

                panel1.Controls.Add(UserControl5.Instance);
                UserControl5.Instance.Dock = DockStyle.Fill;
                UserControl5.Instance.BringToFront();

            }
            else
                UserControl5.Instance.BringToFront();


        }

        private void searchACoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl6.Instance))
            {

                panel1.Controls.Add(UserControl6.Instance);
                UserControl6.Instance.Dock = DockStyle.Fill;
                UserControl6.Instance.BringToFront();

            }
            else
                UserControl6.Instance.BringToFront();


        }

        private void viewAllCoachesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl7.Instance))
            {

                panel1.Controls.Add(UserControl7.Instance);
                UserControl7.Instance.Dock = DockStyle.Fill;
                UserControl7.Instance.BringToFront();

            }
            else
                UserControl7.Instance.BringToFront();


        
    }

        private void addAMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl8.Instance))
            {

                panel1.Controls.Add(UserControl8.Instance);
                UserControl8.Instance.Dock = DockStyle.Fill;
                UserControl8.Instance.BringToFront();

            }
            else
                UserControl8.Instance.BringToFront();


        }

        private void viewAllEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl9.Instance))
            {

                panel1.Controls.Add(UserControl9.Instance);
                UserControl9.Instance.Dock = DockStyle.Fill;
                UserControl9.Instance.BringToFront();

            }
            else
                UserControl9.Instance.BringToFront();


        }

        private void addAWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl10.Instance))
            {

                panel1.Controls.Add(UserControl10.Instance);
                UserControl10.Instance.Dock = DockStyle.Fill;
                UserControl10.Instance.BringToFront();

            }
            else
                UserControl10.Instance.BringToFront();
        }

        private void searchAWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl11.Instance))
            {

                panel1.Controls.Add(UserControl11.Instance);
                UserControl11.Instance.Dock = DockStyle.Fill;
                UserControl11.Instance.BringToFront();

            }
            else
                UserControl11.Instance.BringToFront();
        }

        private void deleteAWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl12.Instance))
            {

                panel1.Controls.Add(UserControl12.Instance);
                UserControl12.Instance.Dock = DockStyle.Fill;
                UserControl12.Instance.BringToFront();

            }
            else
                UserControl12.Instance.BringToFront();
        }

        private void viewAllPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControl13.Instance))
            {

                panel1.Controls.Add(UserControl13.Instance);
                UserControl13.Instance.Dock = DockStyle.Fill;
                UserControl13.Instance.BringToFront();

            }
            else
                UserControl13.Instance.BringToFront();
        }
    
    }
} 
