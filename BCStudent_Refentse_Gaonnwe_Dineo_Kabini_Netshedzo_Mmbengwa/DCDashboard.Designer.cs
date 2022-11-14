
namespace StudentBC
{
    partial class DCDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.pictureboxStd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStdNr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEnterId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.OFImage = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxStd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(204, 595);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(99, 31);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Register Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(343, 595);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 31);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modify Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 650);
            this.panel1.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(165, 31);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(184, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 67);
            this.panel2.TabIndex = 3;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(-3, 617);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(168, 31);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(496, 595);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(102, 31);
            this.btnDeleteStudent.TabIndex = 4;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // pictureboxStd
            // 
            this.pictureboxStd.Location = new System.Drawing.Point(236, 50);
            this.pictureboxStd.Name = "pictureboxStd";
            this.pictureboxStd.Size = new System.Drawing.Size(122, 96);
            this.pictureboxStd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxStd.TabIndex = 5;
            this.pictureboxStd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStdNr
            // 
            this.txtStdNr.Location = new System.Drawing.Point(318, 200);
            this.txtStdNr.Name = "txtStdNr";
            this.txtStdNr.Size = new System.Drawing.Size(216, 20);
            this.txtStdNr.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(318, 240);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(318, 282);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(216, 20);
            this.txtSurname.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Surname:";
            // 
            // DatePickerDOB
            // 
            this.DatePickerDOB.Location = new System.Drawing.Point(318, 322);
            this.DatePickerDOB.Name = "DatePickerDOB";
            this.DatePickerDOB.Size = new System.Drawing.Size(216, 20);
            this.DatePickerDOB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date Of Birth:";
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Location = new System.Drawing.Point(318, 401);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(216, 20);
            this.txtAddressLine1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Address Line 1:";
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Location = new System.Drawing.Point(318, 435);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(216, 20);
            this.txtAddressLine2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Address line 2:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(318, 505);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(216, 20);
            this.txtCity.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "City:";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(318, 470);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(216, 20);
            this.txtProvince.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 508);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Province:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(318, 359);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 22;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(404, 359);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 23;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Gender:";
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(606, 200);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 25;
            this.dgvStudents.Size = new System.Drawing.Size(558, 182);
            this.dgvStudents.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(510, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(367, 40);
            this.label11.TabIndex = 30;
            this.label11.Text = "Data Capturer Dashboard";
            // 
            // txtEnterId
            // 
            this.txtEnterId.Location = new System.Drawing.Point(755, 159);
            this.txtEnterId.Name = "txtEnterId";
            this.txtEnterId.Size = new System.Drawing.Size(201, 20);
            this.txtEnterId.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.button2.Location = new System.Drawing.Point(1234, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 27);
            this.button2.TabIndex = 32;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(982, 155);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(97, 26);
            this.btnFind.TabIndex = 33;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(252, 166);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(106, 22);
            this.btnBrowse.TabIndex = 34;
            this.btnBrowse.Text = "Add image";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(659, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Enter ID:";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(318, 541);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(216, 20);
            this.txtPostalCode.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 548);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "PostalCode:";
            // 
            // OFImage
            // 
            this.OFImage.FileName = "openFileDialog1";
            // 
            // DCDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 649);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEnterId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddressLine2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddressLine1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DatePickerDOB);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStdNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureboxStd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdate);
            this.Name = "DCDashboard";
            this.Text = "DCDashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxStd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.PictureBox pictureboxStd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStdNr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DatePickerDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEnterId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog OFImage;
    }
}