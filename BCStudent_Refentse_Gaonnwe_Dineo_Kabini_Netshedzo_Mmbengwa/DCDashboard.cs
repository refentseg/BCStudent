using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBC
{
    public partial class DCDashboard : Form
    {
        public DCDashboard()
        {
            InitializeComponent();
        }
        DataHandler dh = new DataHandler();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OFImage.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = OFImage.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbStd.Image = Image.FromFile(OFImage.FileName);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Image pimg = pbStd.Image;
            ImageConverter Converter= new ImageConverter();
            var ImageConvert = Converter.ConvertTo(pimg, typeof(byte[]));
            if (rbMale.Checked)
            {
                dh.AddStudent(txtStdNr.Text, pbStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
            else if (rbFemale.Checked)
            {
                dh.AddStudent(txtStdNr.Text, pbStd.Image,txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Female", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                dh.UpdateStudent(txtStdNr.Text, pbStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
            else if (rbFemale.Checked)
            {
                dh.UpdateStudent(txtStdNr.Text, pbStd.Image, txtName.Text, txtSurname.Text, DateTime.Parse(DatePickerDOB.Text), "Male", txtAddressLine1.Text, txtAddressLine2.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            dh.DeleteData(int.Parse(txtStdNr.Text));
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
           dgvStudents.DataSource=  dh.GetStudents();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = dh.SearchData(int.Parse(txtEnterId.Text));
        }
    }
}
