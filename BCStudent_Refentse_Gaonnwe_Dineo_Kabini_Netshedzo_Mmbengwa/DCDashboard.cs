using BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    public partial class DCDashboard : Form
    {
        public DCDashboard()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();
        string filename;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pictureboxStd.SizeMode = PictureBoxSizeMode.StretchImage;
            using (OpenFileDialog odf = new OpenFileDialog() { Filter = "JPG|*.jpg", ValidateNames = true, Multiselect = false })

            {
                if (odf.ShowDialog() == DialogResult.OK)
                    filename = odf.FileName;
                MessageBox.Show("@" + "(" + filename + ")");

                pictureboxStd.Image = Image.FromFile(filename);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                dh.AddStudent(txtStdNr.Text, pictureboxStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
            else if (rbFemale.Checked)
            {
                dh.AddStudent(txtStdNr.Text, pictureboxStd.Image,txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Female", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                dh.UpdateStudent(txtStdNr.Text, pictureboxStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
            else if (rbFemale.Checked)
            {
                dh.UpdateStudent(txtStdNr.Text, pictureboxStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            dh.DeleteStudent(int.Parse(txtStdNr.Text));
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
           dgvStudents.DataSource=  dh.GetStudents();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = dh.SearchData(int.Parse(txtEnterId.Text));
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            ModuleForm mfm = new ModuleForm();
            mfm.Show();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DCDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
