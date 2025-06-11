using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;

namespace DLVDProject
{
    public partial class frmAdd_UpdateLocalDriving : Form   
    {

        enum enMode { Add, Update, };
        enMode Mode;
        clsUsers _User = new clsUsers();
        clsPerson _Person;

        int _DrivingID = 0;
        public frmAdd_UpdateLocalDriving(int DrivingID)

        {
            _DrivingID = DrivingID;
            if (DrivingID == -1)
            {
                Mode = enMode.Add;
            }

            else
            {
                Mode = enMode.Update;
            }
            cbFilter.SelectedIndex = 0;
            InitializeComponent();

        }

        public frmAdd_UpdateLocalDriving()
        {
            InitializeComponent();
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
/*
            cbLicenseClass.Text = _User.UserName;
            mtbPassword.Text = _User.Password;
            mtbConfermPassword.Text = _User.Password;
            lbApplicationID.Text = _User.UserID.ToString();
            cbIsActive.Checked = _User.IsActive;*/
        }

        private void frmAdd_UpdateLocalDriving_Load(object sender, EventArgs e)
        {

        }

        private void tpLoginInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
