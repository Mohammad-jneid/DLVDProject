namespace DLVDProject
{
    partial class frmMainScreen
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
            this.msAccountSetting = new System.Windows.Forms.MenuStrip();
            this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAccountSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAccountSetting
            // 
            this.msAccountSetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msAccountSetting.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAccountSetting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.applicationsToolStripMenuItem});
            this.msAccountSetting.Location = new System.Drawing.Point(0, 0);
            this.msAccountSetting.Name = "msAccountSetting";
            this.msAccountSetting.Size = new System.Drawing.Size(1262, 49);
            this.msAccountSetting.TabIndex = 1;
            this.msAccountSetting.Text = "menuStrip1";
            this.msAccountSetting.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msAccountSetting_ItemClicked);
            // 
            // jToolStripMenuItem
            // 
            this.jToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.jToolStripMenuItem.Name = "jToolStripMenuItem";
            this.jToolStripMenuItem.Size = new System.Drawing.Size(243, 45);
            this.jToolStripMenuItem.Text = "Account Setting";
            // 
            // changeUserInfoToolStripMenuItem
            // 
            this.changeUserInfoToolStripMenuItem.Image = global::DLVDProject.Properties.Resources.patient_information;
            this.changeUserInfoToolStripMenuItem.Name = "changeUserInfoToolStripMenuItem";
            this.changeUserInfoToolStripMenuItem.Size = new System.Drawing.Size(345, 46);
            this.changeUserInfoToolStripMenuItem.Text = "Current User Info";
            this.changeUserInfoToolStripMenuItem.Click += new System.EventHandler(this.changeUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::DLVDProject.Properties.Resources.password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(345, 46);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::DLVDProject.Properties.Resources.sign_out;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(345, 46);
            this.signOutToolStripMenuItem.Text = "Sign out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click_1);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::DLVDProject.Properties.Resources.Add_New_User_721;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(125, 45);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click_1);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(123, 45);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem,
            this.drivingLicensToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(195, 45);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // applicationTypesToolStripMenuItem
            // 
            this.applicationTypesToolStripMenuItem.Name = "applicationTypesToolStripMenuItem";
            this.applicationTypesToolStripMenuItem.Size = new System.Drawing.Size(436, 46);
            this.applicationTypesToolStripMenuItem.Text = "Application Types";
            this.applicationTypesToolStripMenuItem.Click += new System.EventHandler(this.applicationTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(436, 46);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // drivingLicensToolStripMenuItem
            // 
            this.drivingLicensToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicensesToolStripMenuItem});
            this.drivingLicensToolStripMenuItem.Name = "drivingLicensToolStripMenuItem";
            this.drivingLicensToolStripMenuItem.Size = new System.Drawing.Size(436, 46);
            this.drivingLicensToolStripMenuItem.Text = "Driving Licenses Services";
            this.drivingLicensToolStripMenuItem.Click += new System.EventHandler(this.drivingLicensToolStripMenuItem_Click);
            // 
            // newDrivingLicensesToolStripMenuItem
            // 
            this.newDrivingLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensesToolStripMenuItem,
            this.internalLicensesToolStripMenuItem});
            this.newDrivingLicensesToolStripMenuItem.Name = "newDrivingLicensesToolStripMenuItem";
            this.newDrivingLicensesToolStripMenuItem.Size = new System.Drawing.Size(390, 46);
            this.newDrivingLicensesToolStripMenuItem.Text = "New Driving Licenses";
            // 
            // localLicensesToolStripMenuItem
            // 
            this.localLicensesToolStripMenuItem.Name = "localLicensesToolStripMenuItem";
            this.localLicensesToolStripMenuItem.Size = new System.Drawing.Size(328, 46);
            this.localLicensesToolStripMenuItem.Text = "Local  Licenses";
            this.localLicensesToolStripMenuItem.Click += new System.EventHandler(this.localLicensesToolStripMenuItem_Click);
            // 
            // internalLicensesToolStripMenuItem
            // 
            this.internalLicensesToolStripMenuItem.Name = "internalLicensesToolStripMenuItem";
            this.internalLicensesToolStripMenuItem.Size = new System.Drawing.Size(328, 46);
            this.internalLicensesToolStripMenuItem.Text = "Internal Licenses";
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 394);
            this.Controls.Add(this.msAccountSetting);
            this.MainMenuStrip = this.msAccountSetting;
            this.Name = "frmMainScreen";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.msAccountSetting.ResumeLayout(false);
            this.msAccountSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msAccountSetting;
        private System.Windows.Forms.ToolStripMenuItem jToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internalLicensesToolStripMenuItem;
    }
}

