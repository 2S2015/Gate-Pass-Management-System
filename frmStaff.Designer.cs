namespace GPMS
{
    partial class frmStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtOffice_ID = new System.Windows.Forms.TextBox();
            this.txtVehicle_ID = new System.Windows.Forms.TextBox();
            this.txtPhone_Number = new System.Windows.Forms.TextBox();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.txtNational_ID = new System.Windows.Forms.TextBox();
            this.txtStaff_Name = new System.Windows.Forms.TextBox();
            this.txtStaff_ID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 401);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnNew);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(5, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 59);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(702, 24);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 29);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(563, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(424, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 29);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(289, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Sear&ch";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(145, 24);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 23;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(6, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtOffice_ID);
            this.groupBox1.Controls.Add(this.txtVehicle_ID);
            this.groupBox1.Controls.Add(this.txtPhone_Number);
            this.groupBox1.Controls.Add(this.rbnFemale);
            this.groupBox1.Controls.Add(this.rbnMale);
            this.groupBox1.Controls.Add(this.txtNational_ID);
            this.groupBox1.Controls.Add(this.txtStaff_Name);
            this.groupBox1.Controls.Add(this.txtStaff_ID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(543, 250);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(234, 73);
            this.txtRemark.TabIndex = 21;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Director",
            "Lecturer",
            "Cleaner",
            "Nurse",
            "Driver",
            "Chef",
            "ViceChancellor",
            "House Keeper"});
            this.cmbRole.Location = new System.Drawing.Point(543, 191);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(235, 21);
            this.cmbRole.TabIndex = 20;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(543, 128);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 20);
            this.txtAddress.TabIndex = 19;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(543, 69);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(234, 20);
            this.txtLocation.TabIndex = 18;
            // 
            // txtOffice_ID
            // 
            this.txtOffice_ID.Location = new System.Drawing.Point(543, 15);
            this.txtOffice_ID.Name = "txtOffice_ID";
            this.txtOffice_ID.Size = new System.Drawing.Size(234, 20);
            this.txtOffice_ID.TabIndex = 17;
            this.txtOffice_ID.TextChanged += new System.EventHandler(this.txtOffice_ID_TextChanged);
            // 
            // txtVehicle_ID
            // 
            this.txtVehicle_ID.Location = new System.Drawing.Point(145, 306);
            this.txtVehicle_ID.Name = "txtVehicle_ID";
            this.txtVehicle_ID.Size = new System.Drawing.Size(247, 20);
            this.txtVehicle_ID.TabIndex = 16;
            // 
            // txtPhone_Number
            // 
            this.txtPhone_Number.Location = new System.Drawing.Point(145, 248);
            this.txtPhone_Number.Name = "txtPhone_Number";
            this.txtPhone_Number.Size = new System.Drawing.Size(247, 20);
            this.txtPhone_Number.TabIndex = 15;
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFemale.Location = new System.Drawing.Point(242, 189);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(71, 23);
            this.rbnFemale.TabIndex = 14;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Checked = true;
            this.rbnMale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMale.Location = new System.Drawing.Point(145, 187);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(58, 23);
            this.rbnMale.TabIndex = 13;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // txtNational_ID
            // 
            this.txtNational_ID.Location = new System.Drawing.Point(145, 126);
            this.txtNational_ID.Name = "txtNational_ID";
            this.txtNational_ID.Size = new System.Drawing.Size(247, 20);
            this.txtNational_ID.TabIndex = 12;
            // 
            // txtStaff_Name
            // 
            this.txtStaff_Name.Location = new System.Drawing.Point(145, 71);
            this.txtStaff_Name.Name = "txtStaff_Name";
            this.txtStaff_Name.Size = new System.Drawing.Size(247, 20);
            this.txtStaff_Name.TabIndex = 11;
            // 
            // txtStaff_ID
            // 
            this.txtStaff_ID.Location = new System.Drawing.Point(145, 19);
            this.txtStaff_ID.Name = "txtStaff_ID";
            this.txtStaff_ID.Size = new System.Drawing.Size(247, 20);
            this.txtStaff_ID.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Remark";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Office_ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vehicle_ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone_Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "National_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff_Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff_ID";
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 410);
            this.Controls.Add(this.panel1);
            this.Name = "frmStaff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtOffice_ID;
        private System.Windows.Forms.TextBox txtVehicle_ID;
        private System.Windows.Forms.TextBox txtPhone_Number;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.TextBox txtNational_ID;
        private System.Windows.Forms.TextBox txtStaff_Name;
        private System.Windows.Forms.TextBox txtStaff_ID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}