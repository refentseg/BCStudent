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
    }
}
