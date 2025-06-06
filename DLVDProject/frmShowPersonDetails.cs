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
    public partial class frmShowPersonDetails : Form
    {
        int _PersonID = 0;
        public frmShowPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }
        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdd_UpdatePerson frm = new frmAdd_UpdatePerson(Convert.ToInt32(ctrShowDetails.lbPersonID.Text));
            frm.ShowDialog();


        }
        void AssignValues(clsPerson person)
        {

            ctrShowDetails.lbPersonID.Text = person.PersonID.ToString();
            ctrShowDetails.lbName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
            ctrShowDetails.lbEmail.Text = person.Email;
            ctrShowDetails.lbNationalNo.Text = person.NationalNo;
            ctrShowDetails.lbAddress.Text = person.Address;
            ctrShowDetails.lbCountry.Text = clsCountries.Find(person.NationalityCountryID).CountryName;
            ctrShowDetails.lbGendor.Text = person.Gendor;
            if (ctrShowDetails.lbGendor.Text == "Male")
                ctrShowDetails.pbGendor.Image = Properties.Resources.patient_boy;
            else if (ctrShowDetails.lbGendor.Text == "Female")
                ctrShowDetails.pbGendor.Image = Properties.Resources.user_female;

            ctrShowDetails.lbNationalNo.Text = person.NationalNo;
            ctrShowDetails.lbPhone.Text = person.Phone.ToString();
            ctrShowDetails.lbDateOfBirth.Text = person.DateOfBirth.ToString();
            if (person.ImagePath != "") { ctrShowDetails.pictureBox1.Load(person.ImagePath); }
            else
            {
                if (ctrShowDetails.lbGendor.Text == "Male")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.patient_boy;
                else if (ctrShowDetails.lbGendor.Text == "Female")
                    ctrShowDetails.pictureBox1.Image = Properties.Resources.person_girl;

            }

        }
        private void frmShowDetails_Load(object sender, EventArgs e)
        {
            clsPerson clsPerson = clsPerson.Find(_PersonID);
            AssignValues(clsPerson);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrShowDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
