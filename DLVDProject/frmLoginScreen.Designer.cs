namespace DLVDProject
{
    partial class frmLoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            this.lab = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.mtbUserName = new System.Windows.Forms.MaskedTextBox();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lbRememberMe = new System.Windows.Forms.CheckBox();
            this.btnLogIN = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(460, 52);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(322, 40);
            this.lab.TabIndex = 0;
            this.lab.Text = "Log in your Account";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(498, 179);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(147, 29);
            this.lbUserName.TabIndex = 1;
            this.lbUserName.Text = "User Name :";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(507, 239);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(138, 29);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Password : ";
            // 
            // mtbUserName
            // 
            this.mtbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbUserName.Location = new System.Drawing.Point(740, 170);
            this.mtbUserName.Name = "mtbUserName";
            this.mtbUserName.Size = new System.Drawing.Size(243, 38);
            this.mtbUserName.TabIndex = 45;
            // 
            // mtbPassword
            // 
            this.mtbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPassword.Location = new System.Drawing.Point(740, 230);
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(243, 38);
            this.mtbPassword.TabIndex = 46;
            // 
            // lbRememberMe
            // 
            this.lbRememberMe.AutoSize = true;
            this.lbRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRememberMe.Location = new System.Drawing.Point(532, 324);
            this.lbRememberMe.Name = "lbRememberMe";
            this.lbRememberMe.Size = new System.Drawing.Size(228, 36);
            this.lbRememberMe.TabIndex = 48;
            this.lbRememberMe.Text = "Remember  Me";
            this.lbRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnLogIN
            // 
            this.btnLogIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIN.Image = global::DLVDProject.Properties.Resources.login;
            this.btnLogIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogIN.Location = new System.Drawing.Point(686, 400);
            this.btnLogIN.Name = "btnLogIN";
            this.btnLogIN.Size = new System.Drawing.Size(187, 61);
            this.btnLogIN.TabIndex = 47;
            this.btnLogIN.Text = "Log In";
            this.btnLogIN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogIN.UseVisualStyleBackColor = true;
            this.btnLogIN.Click += new System.EventHandler(this.btnLogIN_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(664, 230);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(39, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 44;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(663, 171);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // frmLoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 493);
            this.Controls.Add(this.lbRememberMe);
            this.Controls.Add(this.btnLogIN);
            this.Controls.Add(this.mtbPassword);
            this.Controls.Add(this.mtbUserName);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lab);
            this.Name = "frmLoginScreen";
            this.Text = "frmLoginScreen";
            this.Load += new System.EventHandler(this.frmLoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbPassword;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.MaskedTextBox mtbUserName;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.Button btnLogIN;
        private System.Windows.Forms.CheckBox lbRememberMe;
    }
}