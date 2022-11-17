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
    public partial class StuModule : Form
    {
        public StuModule()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        private void btnAddStuCourse_Click(object sender, EventArgs e)
        {
            dh.AddStuModule(int.Parse(txtStuNumber.Text), txtModuleCode.Text);
        }

        private void StuModule_Load(object sender, EventArgs e)
        {

        }
    }
}
