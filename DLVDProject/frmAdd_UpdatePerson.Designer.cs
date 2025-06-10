namespace DLVDProject
{
    partial class frmAdd_UpdatePerson
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
        /// Required method for Designer support - do not modify frmAdd_UpdatePerson
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_UpdatePerson));
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lbSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrAdd_UpdatePerson = new DLVDProject.ctrAdd_UpdatePerson();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(932, 556);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(36, 41);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 51;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(1064, 556);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 41);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 50;
            this.pictureBox13.TabStop = false;
            // 
            // lbSave
            // 
            this.lbSave.BackColor = System.Drawing.Color.Transparent;
            this.lbSave.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSave.Location = new System.Drawing.Point(1095, 556);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(67, 41);
            this.lbSave.TabIndex = 49;
            this.lbSave.Text = "Save";
            this.lbSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSave.UseVisualStyleBackColor = false;
            this.lbSave.Click += new System.EventHandler(this.lbSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(956, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 41);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrAdd_UpdatePerson
            // 
            this.ctrAdd_UpdatePerson.Location = new System.Drawing.Point(133, 97);
            this.ctrAdd_UpdatePerson.Margin = new System.Windows.Forms.Padding(4);
            this.ctrAdd_UpdatePerson.Name = "ctrAdd_UpdatePerson";
            this.ctrAdd_UpdatePerson.Size = new System.Drawing.Size(1050, 462);
            this.ctrAdd_UpdatePerson.TabIndex = 0;
            this.ctrAdd_UpdatePerson.Load += new System.EventHandler(this.ctrAdd_UpdatePerson_Load);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(528, 33);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 38);
            this.lblTitle.TabIndex = 52;
            this.lblTitle.Text = "Add New Person";
            // 
            // frmAdd_UpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrAdd_UpdatePerson);
            this.Name = "frmAdd_UpdatePerson";
            this.Text = "Add_UpdatePerson";
            this.Load += new System.EventHandler(this.Add_UpdatePerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private ctrAdd_UpdatePerson ctrAdd_UpdatePerson;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button lbSave;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblTitle;
    }
}
