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
    public partial class Register : Form
    {
        FileHandler HANDLER = new FileHandler();
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            var passWord = txtPassword.Text;
            var conpassword = txtConfirm.Text;

            if (passWord != conpassword)
            {
                MessageBox.Show("Passwords missmatch error", "Re-try", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); //NEW BUG ALERT
            }
            if (userName.Length == 0)
            {
                MessageBox.Show("Please enter a username");
            }
            if (passWord.Length == 0)
            {
                MessageBox.Show("Please enter a password");
            }
            if (passWord != conpassword && conpassword.Length == 0)
            {
                MessageBox.Show("Your passwords dont match", "Please try again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }



            FileHandler fh = new FileHandler();

            fh.AddUser(txtUsername.Text, txtPassword.Text);
            MessageBox.Show("Your user credentials have been added");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 reg = new Form1();
            reg.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string userInput = txtUsername.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            var userInput = txtPassword.Text;
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            var userInput = txtConfirm.Text;
        }
    }
    
}
