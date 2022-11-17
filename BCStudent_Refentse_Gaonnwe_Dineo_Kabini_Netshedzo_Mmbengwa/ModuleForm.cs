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
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();

        private void btnAddModule_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.AddModule(txtModuleCode.Text, txtModuleName.Text, txtModuleDesc.Text, rtbModuleRes.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            DCDashboard dc = new DCDashboard();
            dc.Show();
        }

        private void dgModule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            DataHandler dh = new DataHandler();
            dh.UpdateModule(txtModuleCode.Text, txtModuleName.Text, txtModuleDesc.Text, rtbModuleRes.Text);
        }

        private void btnRemoveModule_Click(object sender, EventArgs e)
        {
            dh.DeleteModule(txtModuleCode.Text);
            
        }

        private void btnSerachModule_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = dh.SearchModule(txtModuleCode.Text);
        }

        private void btnViewAllModules_Click(object sender, EventArgs e)
        {
            dgvModules.DataSource = dh.GetModules();
        }
    }
}
