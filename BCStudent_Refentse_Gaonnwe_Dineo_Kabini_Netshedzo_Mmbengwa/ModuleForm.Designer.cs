namespace BCStudent_Refentse_Gaonnwe_Dineo_Kabini_Netshedzo_Mmbengwa
{
    partial class ModuleForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModuleCode = new System.Windows.Forms.TextBox();
            this.txtModuleName = new System.Windows.Forms.TextBox();
            this.txtModuleDesc = new System.Windows.Forms.TextBox();
            this.btnAddModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnRemoveModule = new System.Windows.Forms.Button();
            this.dgModule = new System.Windows.Forms.DataGridView();
            this.rtbModuleRes = new System.Windows.Forms.RichTextBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModule)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbModuleRes);
            this.groupBox1.Controls.Add(this.txtModuleDesc);
            this.groupBox1.Controls.Add(this.txtModuleName);
            this.groupBox1.Controls.Add(this.txtModuleCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(53, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Capture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Resource :";
            // 
            // txtModuleCode
            // 
            this.txtModuleCode.Location = new System.Drawing.Point(124, 54);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.Size = new System.Drawing.Size(177, 20);
            this.txtModuleCode.TabIndex = 1;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Location = new System.Drawing.Point(124, 115);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(177, 20);
            this.txtModuleName.TabIndex = 1;
            // 
            // txtModuleDesc
            // 
            this.txtModuleDesc.Location = new System.Drawing.Point(124, 171);
            this.txtModuleDesc.Name = "txtModuleDesc";
            this.txtModuleDesc.Size = new System.Drawing.Size(177, 20);
            this.txtModuleDesc.TabIndex = 1;
            // 
            // btnAddModule
            // 
            this.btnAddModule.Location = new System.Drawing.Point(53, 355);
            this.btnAddModule.Name = "btnAddModule";
            this.btnAddModule.Size = new System.Drawing.Size(110, 43);
            this.btnAddModule.TabIndex = 1;
            this.btnAddModule.Text = "Add Module";
            this.btnAddModule.UseVisualStyleBackColor = true;
            this.btnAddModule.Click += new System.EventHandler(this.btnAddModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.Location = new System.Drawing.Point(169, 355);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(110, 43);
            this.btnUpdateModule.TabIndex = 1;
            this.btnUpdateModule.Text = "Modify Module";
            this.btnUpdateModule.UseVisualStyleBackColor = true;
            // 
            // btnRemoveModule
            // 
            this.btnRemoveModule.Location = new System.Drawing.Point(285, 355);
            this.btnRemoveModule.Name = "btnRemoveModule";
            this.btnRemoveModule.Size = new System.Drawing.Size(110, 43);
            this.btnRemoveModule.TabIndex = 1;
            this.btnRemoveModule.Text = "Remove Module";
            this.btnRemoveModule.UseVisualStyleBackColor = true;
            // 
            // dgModule
            // 
            this.dgModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgModule.Location = new System.Drawing.Point(428, 97);
            this.dgModule.Name = "dgModule";
            this.dgModule.Size = new System.Drawing.Size(387, 238);
            this.dgModule.TabIndex = 2;
            this.dgModule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgModule_CellContentClick);
            // 
            // rtbModuleRes
            // 
            this.rtbModuleRes.Location = new System.Drawing.Point(124, 226);
            this.rtbModuleRes.Name = "rtbModuleRes";
            this.rtbModuleRes.Size = new System.Drawing.Size(177, 25);
            this.rtbModuleRes.TabIndex = 2;
            this.rtbModuleRes.Text = "";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(-5, 155);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(52, 34);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dgModule);
            this.Controls.Add(this.btnRemoveModule);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.btnAddModule);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModuleForm";
            this.Text = "ModuleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtModuleDesc;
        private System.Windows.Forms.TextBox txtModuleName;
        private System.Windows.Forms.TextBox txtModuleCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnRemoveModule;
        private System.Windows.Forms.DataGridView dgModule;
        private System.Windows.Forms.RichTextBox rtbModuleRes;
        private System.Windows.Forms.Button btnHome;
    }
}