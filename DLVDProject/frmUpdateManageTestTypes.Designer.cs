namespace DLVDProject
{
    partial class frmUpdateManageTestTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateManageTestTypes));
            this.mtbTitle = new System.Windows.Forms.MaskedTextBox();
            this.mtbFees = new System.Windows.Forms.MaskedTextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDescriptions = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbTitle
            // 
            this.mtbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTitle.Location = new System.Drawing.Point(365, 142);
            this.mtbTitle.Name = "mtbTitle";
            this.mtbTitle.Size = new System.Drawing.Size(306, 30);
            this.mtbTitle.TabIndex = 154;
            // 
            // mtbFees
            // 
            this.mtbFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbFees.Location = new System.Drawing.Point(372, 337);
            this.mtbFees.Name = "mtbFees";
            this.mtbFees.Size = new System.Drawing.Size(306, 30);
            this.mtbFees.TabIndex = 153;
            this.mtbFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbFees_KeyPress);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(360, 94);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(53, 29);
            this.lbID.TabIndex = 152;
            this.lbID.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 151;
            this.label4.Text = "Fees : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 29);
            this.label3.TabIndex = 150;
            this.label3.Text = "Title : ";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(266, 94);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(54, 29);
            this.lb.TabIndex = 149;
            this.lb.Text = "ID : ";
            // 
            // lbSave
            // 
            this.lbSave.BackColor = System.Drawing.Color.Transparent;
            this.lbSave.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbSave.Location = new System.Drawing.Point(735, 393);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(67, 41);
            this.lbSave.TabIndex = 147;
            this.lbSave.Text = "Save";
            this.lbSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSave.UseVisualStyleBackColor = false;
            this.lbSave.Click += new System.EventHandler(this.lbSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 145;
            this.label1.Text = "Update Test Type";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(704, 393);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(36, 41);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 148;
            this.pictureBox13.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(585, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 41);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 29);
            this.label2.TabIndex = 155;
            this.label2.Text = "Descriptions : ";
            // 
            // lbDescriptions
            // 
            this.lbDescriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDescriptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescriptions.Location = new System.Drawing.Point(0, 0);
            this.lbDescriptions.Name = "lbDescriptions";
            this.lbDescriptions.Size = new System.Drawing.Size(306, 144);
            this.lbDescriptions.TabIndex = 156;
            this.lbDescriptions.Text = "N/A";
            this.lbDescriptions.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDescriptions);
            this.panel1.Location = new System.Drawing.Point(372, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 144);
            this.panel1.TabIndex = 157;
            // 
            // frmUpdateManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbTitle);
            this.Controls.Add(this.mtbFees);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateManageTestTypes";
            this.Text = "frmUpdateManageTestTypes";
            this.Load += new System.EventHandler(this.frmUpdateManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbTitle;
        private System.Windows.Forms.MaskedTextBox mtbFees;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button lbSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDescriptions;
        private System.Windows.Forms.Panel panel1;
    }
}