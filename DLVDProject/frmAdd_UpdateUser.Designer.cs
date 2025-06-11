namespace DLVDProject
{
    partial class frmAdd_UpdateUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_UpdateUser));
            this.lbSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbFiltertext = new System.Windows.Forms.MaskedTextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabContbtrol1 = new System.Windows.Forms.TabControl();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.mtbUserName = new System.Windows.Forms.MaskedTextBox();
            this.mtbConfermPassword = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbUserID = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pbGendor = new System.Windows.Forms.PictureBox();
            this.lbTiltle = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrShowDetails = new DLVDProject.ctrShowPersonDetails();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tbPersonInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabContbtrol1.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSave
            // 
            this.lbSave.BackColor = System.Drawing.Color.Transparent;
            this.lbSave.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSave.Location = new System.Drawing.Point(1005, 649);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(67, 41);
            this.lbSave.TabIndex = 51;
            this.lbSave.Text = "Save";
            this.lbSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSave.UseVisualStyleBackColor = false;
            this.lbSave.Click += new System.EventHandler(this.lbSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.ctrShowDetails);
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.groupBox2);
            this.tbPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 19);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(1138, 570);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(892, 507);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(67, 41);
            this.btnNext.TabIndex = 53;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.TextChanged += new System.EventHandler(this.btnNext_Click);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbFiltertext);
            this.groupBox2.Controls.Add(this.btnAddUser);
            this.groupBox2.Controls.Add(this.cbFilter);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(983, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // mtbFiltertext
            // 
            this.mtbFiltertext.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFiltertext.Location = new System.Drawing.Point(321, 48);
            this.mtbFiltertext.Name = "mtbFiltertext";
            this.mtbFiltertext.Size = new System.Drawing.Size(321, 38);
            this.mtbFiltertext.TabIndex = 56;
            this.mtbFiltertext.Click += new System.EventHandler(this.mtbFiltertext_TextChanged);
            this.mtbFiltertext.TextChanged += new System.EventHandler(this.mtbFiltertext_TextChanged);
            this.mtbFiltertext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbFiltertext_KeyPress);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.Location = new System.Drawing.Point(733, 21);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(58, 62);
            this.btnAddUser.TabIndex = 54;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.cbFilter.Location = new System.Drawing.Point(146, 48);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(169, 37);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.Tag = "";
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by : ";
            // 
            // tabContbtrol1
            // 
            this.tabContbtrol1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabContbtrol1.Controls.Add(this.tbPersonInfo);
            this.tabContbtrol1.Controls.Add(this.tpLoginInfo);
            this.tabContbtrol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabContbtrol1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabContbtrol1.ItemSize = new System.Drawing.Size(10, 15);
            this.tabContbtrol1.Location = new System.Drawing.Point(47, 50);
            this.tabContbtrol1.Name = "tabContbtrol1";
            this.tabContbtrol1.SelectedIndex = 0;
            this.tabContbtrol1.Size = new System.Drawing.Size(1146, 593);
            this.tabContbtrol1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabContbtrol1.TabIndex = 0;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.cbIsActive);
            this.tpLoginInfo.Controls.Add(this.mtbUserName);
            this.tpLoginInfo.Controls.Add(this.mtbConfermPassword);
            this.tpLoginInfo.Controls.Add(this.mtbPassword);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Controls.Add(this.lbUserID);
            this.tpLoginInfo.Controls.Add(this.lb);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.pictureBox9);
            this.tpLoginInfo.Controls.Add(this.pbGendor);
            this.tpLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 19);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1138, 570);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "Add Edit User";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            this.tpLoginInfo.Click += new System.EventHandler(this.tpLoginInfo_Click);
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(549, 426);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(135, 33);
            this.cbIsActive.TabIndex = 102;
            this.cbIsActive.Text = "Is Active :";
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // mtbUserName
            // 
            this.mtbUserName.Location = new System.Drawing.Point(418, 169);
            this.mtbUserName.Name = "mtbUserName";
            this.mtbUserName.Size = new System.Drawing.Size(284, 34);
            this.mtbUserName.TabIndex = 101;
            // 
            // mtbConfermPassword
            // 
            this.mtbConfermPassword.Location = new System.Drawing.Point(418, 288);
            this.mtbConfermPassword.Name = "mtbConfermPassword";
            this.mtbConfermPassword.Size = new System.Drawing.Size(284, 34);
            this.mtbConfermPassword.TabIndex = 100;
            this.mtbConfermPassword.Validating += new System.ComponentModel.CancelEventHandler(this.mtbConfermPassword_Validating_1);
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(418, 227);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(284, 34);
            this.mtbPassword.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 96;
            this.label4.Text = "Confirm Password : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(338, 291);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(430, 108);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(25, 29);
            this.lbUserID.TabIndex = 85;
            this.lbUserID.Text = "?";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(125, 223);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(138, 29);
            this.lb.TabIndex = 2;
            this.lb.Text = "Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "UserName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(338, 108);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(39, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 82;
            this.pictureBox9.TabStop = false;
            // 
            // pbGendor
            // 
            this.pbGendor.Image = global::DLVDProject.Properties.Resources.user__1_;
            this.pbGendor.Location = new System.Drawing.Point(338, 169);
            this.pbGendor.Name = "pbGendor";
            this.pbGendor.Size = new System.Drawing.Size(40, 41);
            this.pbGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGendor.TabIndex = 81;
            this.pbGendor.TabStop = false;
            // 
            // lbTiltle
            // 
            this.lbTiltle.AutoSize = true;
            this.lbTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiltle.ForeColor = System.Drawing.Color.Red;
            this.lbTiltle.Location = new System.Drawing.Point(475, 9);
            this.lbTiltle.Name = "lbTiltle";
            this.lbTiltle.Size = new System.Drawing.Size(241, 38);
            this.lbTiltle.TabIndex = 53;
            this.lbTiltle.Text = "Add New User";
            this.lbTiltle.Click += new System.EventHandler(this.lbTiltle_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(974, 649);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 41);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 52;
            this.pictureBox13.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(855, 649);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrShowDetails
            // 
            this.ctrShowDetails.Location = new System.Drawing.Point(55, 148);
            this.ctrShowDetails.Name = "ctrShowDetails";
            this.ctrShowDetails.Size = new System.Drawing.Size(1076, 342);
            this.ctrShowDetails.TabIndex = 54;
            this.ctrShowDetails.Load += new System.EventHandler(this.ctrShowDetails_Load);
            // 
            // frmAdd_UpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 755);
            this.Controls.Add(this.lbTiltle);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.tabContbtrol1);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.btnClose);
            this.Name = "frmAdd_UpdateUser";
            this.Text = "Add New User";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAdd_UdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tbPersonInfo.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabContbtrol1.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button lbSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabContbtrol1;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private ctrShowPersonDetails ctrShowDetails;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbFiltertext;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pbGendor;
        private System.Windows.Forms.Label lbTiltle;
        private System.Windows.Forms.MaskedTextBox mtbUserName;
        private System.Windows.Forms.MaskedTextBox mtbConfermPassword;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbIsActive;
    }
}