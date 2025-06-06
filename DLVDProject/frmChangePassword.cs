using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace DLVDProject
{
    public partial class frmChangePassword : Form
    {
        clsUsers _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
        }

        void AssignValues()
        {
            ctrShowPersonDetails.lbPersonID.Text = _User.Person.PersonID.ToString();
            ctrShowPersonDetails.lbName.Text = _User.Person.FirstName + " " + _User.Person.SecondName + " " + _User.Person.ThirdName + " " + _User.Person.LastName;
            ctrShowPersonDetails.lbEmail.Text = _User.Person.Email;
            ctrShowPersonDetails.lbNationalNo.Text = _User.Person.NationalNo;
            ctrShowPersonDetails.lbAddress.Text = _User.Person.Address;
            ctrShowPersonDetails.lbCountry.Text = clsCountries.Find(_User.Person.NationalityCountryID).CountryName;
            ctrShowPersonDetails.lbGendor.Text = _User.Person.Gendor;

            if (ctrShowPersonDetails.lbGendor.Text == "Male")
                ctrShowPersonDetails.pbGendor.Image = Properties.Resources.patient_boy;
            else if (ctrShowPersonDetails.lbGendor.Text == "Female")
                ctrShowPersonDetails.pbGendor.Image = Properties.Resources.user_female;

            ctrShowPersonDetails.lbPhone.Text = _User.Person.Phone.ToString();
            ctrShowPersonDetails.lbDateOfBirth.Text = _User.Person.DateOfBirth.ToString();

            if (!string.IsNullOrEmpty(_User.Person.ImagePath))
            {
                ctrShowPersonDetails.pictureBox1.Load(_User.Person.ImagePath);
            }
            else
            {
                if (ctrShowPersonDetails.lbGendor.Text == "Male")
                    ctrShowPersonDetails.pictureBox1.Image = Properties.Resources.patient_boy;
                else if (ctrShowPersonDetails.lbGendor.Text == "Female")
                    ctrShowPersonDetails.pictureBox1.Image = Properties.Resources.person_girl;
            }

            lbUserID.Text = _User.UserID.ToString();
            lbUserName.Text = _User.UserName;
            lbIsActive.Text = _User.IsActive ? "Yes" : "No";
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _User= clsUsers.Find(clsUsers.LoggedInUserID);
            if (_User != null)
            {
                AssignValues();
            }
        }


             private void mtbConfermNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (mtbNewPassword.Text != mtbConfermNewPassword.Text)
            {
                errorProvider1.SetError(mtbConfermNewPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermNewPassword, ""); // Clear the error
            }
        }


        private void mtbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (mtbNewPassword.Text != mtbConfermNewPassword.Text)
            {
                errorProvider1.SetError(mtbConfermNewPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermNewPassword, ""); // Clear the error
            }
        }

        private void mtbCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(clsUsers.Find(clsUsers.LoggedInUserID).Password.ToString() != mtbCurrentPassword.Text.ToString())
            {
                errorProvider1.SetError(mtbCurrentPassword, "You entered A worong password"); // Clear the error
                mtbConfermNewPassword.ReadOnly = true;
                mtbNewPassword.ReadOnly = true;
            }
            else
            {
                mtbConfermNewPassword.ReadOnly = false;
                mtbNewPassword.ReadOnly = false;
                errorProvider1.SetError(mtbCurrentPassword,""); // Clear the error

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AssignmentDataToObject()
        {
            _User.Password = mtbConfermNewPassword.Text;



        }

        private bool HasValidationErrors(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                // Check if this control has an error
                if (!string.IsNullOrEmpty(errorProvider1.GetError(c)))
                {
                    return true;
                }

                // Recursively check nested controls (like panels, groupboxes)
                if (c.HasChildren)
                {
                    if (HasValidationErrors(c))
                        return true;
                }
            }

            return false; // No errors found

        }

        public static void ReplaceLineInFile(string filePath, int lineNumber, string newLine)
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Check if the line number is valid
            if (lineNumber < 1 || lineNumber > lines.Length)
            {
                 return;
            }

            // Replace the specified line
            lines[lineNumber ] = newLine;

            // Write the modified content back to the file
            File.WriteAllLines(filePath, lines);

         }


        private void lbSave_Click(object sender, EventArgs e)
        {
            if (HasValidationErrors(this))
            {
                MessageBox.Show("Please fix validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AssignmentDataToObject();
            if (_User.Save())
            {
                MessageBox.Show("User saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string FileName = "C:\\Users\\messi\\Desktop\\DLVDProject\\DLVDProject\\LoginInfo.txt";
                ReplaceLineInFile(FileName,1,mtbConfermNewPassword.Text);
            }
            else
            {
                MessageBox.Show("Failed to save the user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
