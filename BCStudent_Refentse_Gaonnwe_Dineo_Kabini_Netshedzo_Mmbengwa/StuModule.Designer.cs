
namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    partial class StuModule
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStuNumber = new System.Windows.Forms.TextBox();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.btnAddStuCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Code:";
            // 
            // txtStuNumber
            // 
            this.txtStuNumber.Location = new System.Drawing.Point(150, 40);
            this.txtStuNumber.Name = "txtStuNumber";
            this.txtStuNumber.Size = new System.Drawing.Size(164, 20);
            this.txtStuNumber.TabIndex = 2;
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(150, 75);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(164, 20);
            this.txtModuleCode.TabIndex = 3;
            // 
            // btnAddStuCourse
            // 
            this.btnAddStuCourse.Location = new System.Drawing.Point(128, 119);
            this.btnAddStuCourse.Name = "btnAddStuCourse";
            this.btnAddStuCourse.Size = new System.Drawing.Size(75, 23);
            this.btnAddStuCourse.TabIndex = 4;
            this.btnAddStuCourse.Text = "Add";
            this.btnAddStuCourse.UseVisualStyleBackColor = true;
            this.btnAddStuCourse.Click += new System.EventHandler(this.btnAddStuCourse_Click);
            // 
            // StuModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 157);
            this.Controls.Add(this.btnAddStuCourse);
            this.Controls.Add(this.txtModuleCode);
            this.Controls.Add(this.txtStuNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StuModule";
            this.Text = "StuModule";
            this.Load += new System.EventHandler(this.StuModule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStuNumber;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Button btnAddStuCourse;
    }
}