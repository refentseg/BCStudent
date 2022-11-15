using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             FileHandler fh = new FileHandler();
            string name = fh.CheckUser().GetValue(0).ToString();
            string pass = fh.CheckUser().GetValue(1).ToString();
            

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (name == username && pass == password)
            {

                DCDashboard dc = new DCDashboard();
                this.Close();
                dc.Show();
            }
            else
            {
                MessageBox.Show("Please input the correct user credentials");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void lnkCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rec = new Register();
            rec.Show();
            this.Hide();
        }
    }
}
