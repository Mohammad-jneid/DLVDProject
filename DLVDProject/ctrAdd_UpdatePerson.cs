using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Pipes;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;

namespace DLVDProject
{
    public partial class ctrAdd_UpdatePerson : UserControl
    {
        public string _ImagePath = "";

        public string _OldImagePath = ""; 
        public bool _WantToDelete = false;
        public bool IsTheFirstTime = true;
        public bool IsThereSavedImage = false;
        public bool _IsThePhotoExist;
        public string _SourceFile = "", _DestinationPath = "";
        public bool _IsTheImageWithoutSave = false;

        public enum enMode { Add, Update, };
        public enMode Mode;
        public ctrAdd_UpdatePerson()
        {
            InitializeComponent();

        }

        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
        private void ctrAdd_UpdatePerson_Load(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                pictureBox1.Image = Properties.Resources.person_boy1;

            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                pictureBox1.Image = Properties.Resources.person_girl;

            }
        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string sourceFile = "";
            if (pictureBox1.ImageLocation == null) // Here mean that there is no image and will add photo.
            {
                if (_WantToDelete && IsThereSavedImage)//Was removed before
                {
                    _IsTheImageWithoutSave = true;
                }
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    sourceFile = openFileDialog1.FileName;
                    _WantToDelete = false;
                    _IsThePhotoExist = true;

                    string destinationFolder = Path.Combine(Application.StartupPath, "Resources");
                    Directory.CreateDirectory(destinationFolder);

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceFile);
                    string destinationPath = Path.Combine(destinationFolder, fileName);

                    try
                    {
                        _SourceFile = sourceFile;
                        _DestinationPath = destinationPath;
                        //File.Copy(sourceFile, destinationPath, true);
                        using (FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                        {
                            pictureBox1.Image = Image.FromStream(fs);
                        }
                        pictureBox1.ImageLocation = sourceFile;

                        _ImagePath = _DestinationPath;
                        //_Person.ImagePath = ctrAdd_UpdatePerson._DestinationPath;

                        pictureBox1.Visible = true;
                         lbSetImage.Text = "Remove Photo";
                    }
                    catch (IOException ioex)
                    {
                        MessageBox.Show("Failed to copy image: " + ioex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

                try
                {
                    // ✅ Dispose image to release file lock
                    //_SourceFile = "";
                    //_DestinationPath = "";
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                        pictureBox1.Image = null;
                        //_ImagePath = pictureBox1.ImageLocation; 
                    }
                    _WantToDelete = true;
                    _IsThePhotoExist = false;
                    //_OldImagePath = _ImagePath = pictureBox1.ImageLocation;
                 /*   if(_DestinationPath!= "" )
                    {*/
                        if (IsTheFirstTime && !_IsTheImageWithoutSave)
                        {
                        _OldImagePath = pictureBox1.ImageLocation;
                       //_ImagePath = _DestinationPath;
                        IsTheFirstTime = false;

                        }

                    if (_DestinationPath != "")
                    {

                         _ImagePath = _DestinationPath;
                    }

                         _ImagePath = pictureBox1.ImageLocation;

                    _DestinationPath = "";
                    //                        _ImagePath =p;
                    pictureBox1.ImageLocation = null;
                    lbSetImage.Text = "Upload Photo";

                    // ✅ Delete the copied file from folder

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not delete image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys (like backspace), and digits only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ❌ Block the key press
            }
        }


        private void tbNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (Mode == enMode.Update && clsPerson.Find(Convert.ToInt32(lbPersonID.Text)).NationalNo == tbNationalNo.Text.ToString())
            {
                errorProvider1.SetError(tbNationalNo, ""); // Clear the error
                return;
            }
            if ((clsPerson.IsPersonExist(tbNationalNo.Text)))// && tbNationalNo.Text != ""
            {
                // Set error on the NationalNo textbox instead of the Phone textbox
                errorProvider1.SetError(tbNationalNo, "NationalNo is already used by another person.");
            }
            else
            {
                errorProvider1.SetError(tbNationalNo, ""); // Clear the error
            }
        }
        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(tbEmail.Text) && tbEmail.Text != "")
            {
                errorProvider1.SetError(tbEmail, "Invalid email format.");
                //  lblEmailError.Visible = true;
                //e.Cancel = true; // Stops focus from leaving
            }
            else
            {
                errorProvider1.SetError(tbEmail, ""); // Clear error
            }
        }

        private void tbNationalNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCountries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
