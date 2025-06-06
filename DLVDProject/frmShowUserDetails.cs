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
    public partial class frmShowUserDetails : Form
    {
        int _UserID;
        public frmShowUserDetails(int Userid )
        {
            _UserID = Userid;
            InitializeComponent();
        }
        void AssignValues(clsUsers users)
        {
            ctrShowPersonDetails.lbPersonID.Text = users.Person.PersonID.ToString();
            ctrShowPersonDetails.lbName.Text = users.Person.FirstName + " " + users.Person.SecondName + " " + users.Person.ThirdName + " " + users.Person.LastName;
            ctrShowPersonDetails.lbEmail.Text = users.Person.Email;
            ctrShowPersonDetails.lbNationalNo.Text = users.Person.NationalNo;
            ctrShowPersonDetails.lbAddress.Text = users.Person.Address;
            ctrShowPersonDetails.lbCountry.Text = clsCountries.Find(users.Person.NationalityCountryID).CountryName;
            ctrShowPersonDetails.lbGendor.Text = users.Person.Gendor;

            if (ctrShowPersonDetails.lbGendor.Text == "Male")
                ctrShowPersonDetails.pbGendor.Image = Properties.Resources.patient_boy;
            else if (ctrShowPersonDetails.lbGendor.Text == "Female")
                ctrShowPersonDetails.pbGendor.Image = Properties.Resources.user_female;

            ctrShowPersonDetails.lbNationalNo.Text = users.Person.NationalNo;
            ctrShowPersonDetails.lbPhone.Text = users.Person.Phone.ToString();
            ctrShowPersonDetails.lbDateOfBirth.Text = users.Person.DateOfBirth.ToString();

            if (users.Person.ImagePath != "")
            {
                ctrShowPersonDetails.pictureBox1.Load(users.Person.ImagePath);
            }
            else
            {
                if (ctrShowPersonDetails.lbGendor.Text == "Male")
                    ctrShowPersonDetails.pictureBox1.Image = Properties.Resources.patient_boy;
                else if (ctrShowPersonDetails.lbGendor.Text == "Female")
                    ctrShowPersonDetails.pictureBox1.Image = Properties.Resources.person_girl;
            }

            lbUserID.Text = users.UserID.ToString();
            lbUserName.Text = users.UserName;

            if (users.IsActive)
                lbIsActive.Text = "Yes";
            else
                lbIsActive.Text = "No";

        }
        private void frmShowUserDetails_Load(object sender, EventArgs e)
        {
            clsUsers users = clsUsers.Find(_UserID);
            if (users != null)
            {
                AssignValues(users);
            }
            
            
        }

        private void ctrShowPersonDetails_Load(object sender, EventArgs e)
        {

        }

        private void lbSave_Click(object sender, EventArgs e)
        {

        }
    }
}
