using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLVDProject
{
    public partial class frmAdd_UpdateUser : Form
    {

        enum enMode { Add, Update, };
        enMode Mode;
        clsUsers _User = new clsUsers();
        clsPerson _Person;

        int _UserID = 0;
        public frmAdd_UpdateUser(int UserID)
        
        {
            _UserID = UserID;
            if (UserID == -1)
            {
                Mode = enMode.Add;
            }

            else
            {
                Mode = enMode.Update;
            }
            InitializeComponent();
            cbFilter.SelectedIndex = 0;
           
        }
        void AssignmentDataToForm()
        {
            ctrShowDetails.lbPersonID.Text = _Person.PersonID.ToString();
            mtbFiltertext.Text = _Person.PersonID.ToString();
            ctrShowDetails.lbName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            ctrShowDetails.lbEmail.Text = _Person.Email;
            ctrShowDetails.lbNationalNo.Text = _Person.NationalNo;
            ctrShowDetails.lbAddress.Text = _Person.Address;
            ctrShowDetails.lbCountry.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;
            ctrShowDetails.lbGendor.Text = _Person.Gendor;

            if (ctrShowDetails.lbGendor.Text == "Male")
                ctrShowDetails.pbGendor.Image = Properties.Resources.patient_boy;
            else if (ctrShowDetails.lbGendor.Text == "Female")
                ctrShowDetails.pbGendor.Image = Properties.Resources.user_female;

            ctrShowDetails.lbNationalNo.Text = _Person.NationalNo;
            ctrShowDetails.lbPhone.Text = _Person.Phone.ToString();
            ctrShowDetails.lbDateOfBirth.Text = _Person.DateOfBirth.ToString();

            if (_Person.ImagePath != "")
            {
                ctrShowDetails.pictureBox1.Load(_Person.ImagePath);
            }
            else
            {
                if (ctrShowDetails.lbGendor.Text == "Male")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.patient_boy;
                else if (ctrShowDetails.lbGendor.Text == "Female")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.person_girl;
            }
            
            mtbUserName.Text = _User.UserName;
            mtbPassword.Text = _User.Password;
            mtbConfermPassword.Text = _User.Password;
            lbUserID.Text = _User.UserID.ToString();
            cbIsActive.Checked = _User.IsActive;
        }

        private void frmAdd_UdateUser_Load(object sender, EventArgs e)
        {
          //  mtbUserName.Text = DateTime.Now.ToString();
            if (Mode == enMode.Add)
            {
                lbTiltle.Text = "Add New User";
                _Person = new clsPerson();
                return;
            }
            _User = clsUsers.Find(Convert.ToInt32(_UserID));
            if (_User == null)
            {
                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            _Person = _User.Person;
            lbTiltle.Text = "Update User";
            mtbFiltertext.ReadOnly = true;
            btnAddUser.Enabled = false;
            AssignmentDataToForm();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mtbFiltertext.ReadOnly = string.IsNullOrWhiteSpace(cbFilter.Text);
            mtbFiltertext.Clear(); // Clear previous search text
           
        }

        void AssignValues()
        {
            if (_Person == null)
            {
Clear(); return;

            }
            //                Clear();

            ctrShowDetails.lbPersonID.Text = _Person.PersonID.ToString();
            ctrShowDetails.lbName.Text = _Person.FirstName + " " + _Person.SecondName + " " + _Person.ThirdName + " " + _Person.LastName;
            ctrShowDetails.lbEmail.Text = _Person.Email;
            ctrShowDetails.lbNationalNo.Text = _Person.NationalNo;
            ctrShowDetails.lbAddress.Text = _Person.Address;
            ctrShowDetails.lbCountry.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;
            ctrShowDetails.lbGendor.Text = _Person.Gendor;
            if (ctrShowDetails.lbGendor.Text == "Male")
                ctrShowDetails.pbGendor.Image = Properties.Resources.patient_boy;
            else if (ctrShowDetails.lbGendor.Text == "Female")
                ctrShowDetails.pbGendor.Image = Properties.Resources.user_female;

            ctrShowDetails.lbNationalNo.Text = _Person.NationalNo;
            ctrShowDetails.lbPhone.Text = _Person.Phone.ToString();
            ctrShowDetails.lbDateOfBirth.Text = _Person.DateOfBirth.ToString();
            if (_Person.ImagePath != "") { ctrShowDetails.pictureBox1.Load(_Person.ImagePath); }
            else
            {
                if (ctrShowDetails.lbGendor.Text == "Male")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.patient_boy;
                else if (ctrShowDetails.lbGendor.Text == "Female")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.person_girl;

            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (mtbFiltertext.Text == "") {

                MessageBox.Show("Please enter an ID or National Number to search.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  
            }
            
            if (cbFilter.Text == "PersonID")
            {
                if (clsUsers.IsUserExistByPersonID(Convert.ToInt32(mtbFiltertext.Text)) && (mtbFiltertext.Text) != "")
                {
                if (Mode == enMode.Add || Convert.ToInt32(ctrShowDetails.lbPersonID.Text) != clsPerson.Find(Convert.ToInt32(mtbFiltertext.Text)).PersonID)
                {
                    MessageBox.Show("Selected Person has already a user ,choose another one ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                }
                else if (!clsPerson.IsPersonExist(Convert.ToInt32(mtbFiltertext.Text)))
                {
                    MessageBox.Show("No Person With PersonID " + mtbFiltertext.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (cbFilter.Text == "NationalNo")
            {
                if (clsUsers.IsUserExistByPersonID(clsPerson.Find(mtbFiltertext.Text.ToString()).PersonID) && (mtbFiltertext.Text) != "")
                {
                    if (Mode == enMode.Add || Convert.ToInt32(ctrShowDetails.lbPersonID.Text) != clsPerson.Find(mtbFiltertext.Text.ToString()).PersonID)
                    {
                        MessageBox.Show("Selected Person has already a user ,choose another one ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else if (!clsPerson.IsPersonExist(mtbFiltertext.Text.ToString()))
                {
                    MessageBox.Show("No Person With NationalNO " + mtbFiltertext.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tabContbtrol1.SelectedIndex = 1;
        }
        void Clear()
        {
            _Person = null;

            // Set default "N/A" text
            ctrShowDetails.lbPersonID.Text = "N/A";
            ctrShowDetails.lbName.Text = "N/A";
            ctrShowDetails.lbEmail.Text = "N/A";
            ctrShowDetails.lbNationalNo.Text = "N/A";
            ctrShowDetails.lbAddress.Text = "N/A";
            ctrShowDetails.lbCountry.Text = "N/A";
            ctrShowDetails.lbGendor.Text = "N/A";
            ctrShowDetails.lbPhone.Text = "N/A";
            ctrShowDetails.lbDateOfBirth.Text = "N/A";
             
            // Reset profile picture
            ctrShowDetails.pictureBox1.Image = Properties.Resources.person_boy1; // or use a generic avatar
        }
        private void mtbFiltertext_TextChanged(object sender, EventArgs e)
        {
            if (mtbFiltertext.Text == "")
            { 
                Clear();
                return; }
            if (cbFilter.Text == "PersonID")
            {
                _Person = clsPerson.Find(Convert.ToInt32(mtbFiltertext.Text));
                AssignValues();
            }
            else 
            {
                _Person = clsPerson.Find(mtbFiltertext.Text.ToString());
                AssignValues();
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_UpdatePerson frmAddPerson = new frmAdd_UpdatePerson(-1);
            frmAddPerson.ShowDialog();
        }
        private void mtbFiltertext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "PersonID") return;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // ❌ Block the key press
            }
        }
        bool Check(string TextBoxText, string Missed)
        {
            if (TextBoxText == "")
            {
                MessageBox.Show("Please enter a " + Missed + " .", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

      
      bool DataNotCompletedYet()
        {
            if(_Person == null)
            {
                MessageBox.Show("Please Select a Person .", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (Check(mtbUserName.Text, "UserName")) return true;
            if (Check(mtbPassword.Text, "Password")) return true;
            if (Check(mtbConfermPassword.Text, "Confirm Password")) return true;

            return false;

        }
        private void AssignmentDataToObject()
        {
            _User.UserName = mtbUserName.Text;
            _User.Password = mtbPassword.Text;
            if (cbIsActive.Checked)
            {
                _User.IsActive = true;
            } else
                _User.IsActive = false;
            _User.Person = _Person;


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
        private void lbSave_Click(object sender, EventArgs e)
        {
          if (DataNotCompletedYet()) return;
                    if (HasValidationErrors(this))
                    {
                        MessageBox.Show("Please fix validation errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
            AssignmentDataToObject();
            if (_User.Save())
            {
                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lblTitle.Text = "Update New Person";
                Mode = enMode.Update;
                ctrShowDetails.lbPersonID.Text = _Person.PersonID.ToString();
            }
            else
                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
      
        }

        private void mtbConfermPassword_TextChanged(object sender, EventArgs e)
        {
            if (mtbPassword.Text != mtbConfermPassword.Text)
            {
                errorProvider1.SetError(mtbConfermPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermPassword, ""); // Clear the error
            }
        }

        private void mtbPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
          
        }
        private void mtbConfermPassword_Validating(object sender, CancelEventArgs e)
        {
            if (mtbPassword.Text != mtbConfermPassword.Text)
            {
                errorProvider1.SetError(mtbConfermPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermPassword, ""); // Clear the error
            }
        }


        private void mtbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (mtbPassword.Text != mtbConfermPassword.Text )
            {
                errorProvider1.SetError(mtbConfermPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermPassword, ""); // Clear the error
            }
        }
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Cancel tab switching by the user
            e.Cancel = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrShowDetails_Load(object sender, EventArgs e)
        {

        }

        private void mtbNewPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tpLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void mtbConfermPassword_Validating_1(object sender, CancelEventArgs e)
        {
            if (mtbPassword.Text != mtbConfermPassword.Text)
            {
                errorProvider1.SetError(mtbConfermPassword, "You entered a deiferent Password"); // Clear the error
                return;
            }
            else
            {
                errorProvider1.SetError(mtbConfermPassword, ""); // Clear the error
            }
        }

        private void lbTiltle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
