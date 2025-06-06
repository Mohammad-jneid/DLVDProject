//using DVLDBusinessLayer;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DLVDProject
//{
//    public partial class frmAdd_UpdatePerson : Form
//    {
//        enum enMode { Add, Update, };
//        enMode Mode;
//        clsPerson _Person = new clsPerson();
//        int _PersonID = 0;
//        public frmAdd_UpdatePerson(int PersonID)
//        {
//            InitializeComponent();

//            ctrAdd_UpdatePerson.lbPersonID.Text = PersonID.ToString();
//            _PersonID = PersonID;
//            if (PersonID == -1)
//            {
//                ctrAdd_UpdatePerson.Mode = ctrAdd_UpdatePerson.enMode.Add;
//                Mode = enMode.Add;
//            }

//            else
//            {
//                ctrAdd_UpdatePerson.Mode = ctrAdd_UpdatePerson.enMode.Update;
//                Mode = enMode.Update;
//            }
//        }

//        public void AssignmentDataToForm()
//        {
//            ctrAdd_UpdatePerson.tbFirstName.Text = _Person.FirstName;
//            ctrAdd_UpdatePerson.tbSecondName.Text = _Person.SecondName;
//            ctrAdd_UpdatePerson.tbThirdName.Text = _Person.ThirdName;
//            ctrAdd_UpdatePerson.tbLastName.Text = _Person.LastName;
//            ctrAdd_UpdatePerson.tbAddress.Text = _Person.Address;
//            ctrAdd_UpdatePerson.tbEmail.Text = _Person.Email;
//            ctrAdd_UpdatePerson.tbPhone.Text = _Person.Phone.ToString();
//            ctrAdd_UpdatePerson.tbNationalNo.Text = _Person.NationalNo;
//            ctrAdd_UpdatePerson.dtpDateOfBirth.Text = _Person.DateOfBirth.ToString();
//            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
//            {
//                using (FileStream fs = new FileStream(_Person.ImagePath, FileMode.Open, FileAccess.Read))
//                {
//                    ctrAdd_UpdatePerson.IsThereSavedImage = true;

//                    ctrAdd_UpdatePerson.pictureBox1.Image = Image.FromStream(fs);
//                    ctrAdd_UpdatePerson._IsThePhotoExist = true;
//                    ctrAdd_UpdatePerson.pictureBox1.ImageLocation = _Person.ImagePath; // optional, for tracking

//                }
//                ctrAdd_UpdatePerson.lbSetImage.Text = "Remove Photo";
//            }
//            else
//                ctrAdd_UpdatePerson._IsThePhotoExist = false;
//            ctrAdd_UpdatePerson.cbCountries.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;

//            if (_Person.Gendor == "Male") ctrAdd_UpdatePerson.rbMale.Checked = true;
//            else if (_Person.Gendor == "Female") ctrAdd_UpdatePerson.rbFemale.Checked = true;

//        }
//        private void AssignmentDataToObject()
//        {

//            _Person.FirstName = ctrAdd_UpdatePerson.tbFirstName.Text;
//            _Person.SecondName = ctrAdd_UpdatePerson.tbSecondName.Text;
//            _Person.ThirdName = ctrAdd_UpdatePerson.tbThirdName.Text;
//            _Person.LastName = ctrAdd_UpdatePerson.tbLastName.Text;
//            _Person.Address = ctrAdd_UpdatePerson.tbAddress.Text;
//            _Person.Email = ctrAdd_UpdatePerson.tbEmail.Text;
//            if (ctrAdd_UpdatePerson.tbPhone.Text != "")
//                _Person.Phone = Convert.ToInt32(ctrAdd_UpdatePerson.tbPhone.Text);
//            _Person.NationalNo = ctrAdd_UpdatePerson.tbNationalNo.Text;
//            if (ctrAdd_UpdatePerson.pictureBox1.ImageLocation != null)
//            {
//                ctrAdd_UpdatePerson.IsTheFirstTime = true;
//                ctrAdd_UpdatePerson.IsThereSavedImage = true;
//                if (ctrAdd_UpdatePerson._IsTheImageWithoutSave) {
//                    File.Delete(ctrAdd_UpdatePerson._OldImagePath);
//                    ctrAdd_UpdatePerson._IsTheImageWithoutSave = false;
//                }
//                _Person.ImagePath = ctrAdd_UpdatePerson._DestinationPath;
//                ctrAdd_UpdatePerson.pictureBox1.ImageLocation =ctrAdd_UpdatePerson._DestinationPath;
//                File.Copy(ctrAdd_UpdatePerson._SourceFile, ctrAdd_UpdatePerson._DestinationPath, true);
//                ctrAdd_UpdatePerson._IsThePhotoExist = true;
//                ctrAdd_UpdatePerson._ImagePath = ctrAdd_UpdatePerson._DestinationPath;
//            }
//            else
//            {
//                _Person.ImagePath = "";
//            }
//            if (!ctrAdd_UpdatePerson._IsThePhotoExist && ctrAdd_UpdatePerson._WantToDelete)
//            {
//                File.Delete(ctrAdd_UpdatePerson._ImagePath);
//            }
//            _Person.DateOfBirth = ctrAdd_UpdatePerson.dtpDateOfBirth.Value;
//            _Person.NationalityCountryID = clsCountries.Find(ctrAdd_UpdatePerson.cbCountries.Text).CountryID;

//            if (ctrAdd_UpdatePerson.rbMale.Checked) _Person.Gendor = "Male";
//            else if (ctrAdd_UpdatePerson.rbFemale.Checked) _Person.Gendor = "Female";
//        }
//        void _LoadData()
//        {
//            ctrAdd_UpdatePerson.dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);

//            DataTable dataTable = clsCountries.GetData();
//            foreach (DataRow row in dataTable.Rows)
//            {
//                ctrAdd_UpdatePerson.cbCountries.Items.Add(row["CountryName"]);
//            }
//            if (Mode == enMode.Add)
//            {
//                ctrAdd_UpdatePerson.cbCountries.SelectedIndex = 168;
//                ctrAdd_UpdatePerson.rbMale.Checked = true;

//                lblTitle.Text = "Add New Person";
//                _Person = new clsPerson();
//                return;
//            }

//            _Person = clsPerson.Find(_PersonID);

//            if (_Person == null)
//            {
//                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                this.Close();
//                return;
//            }
//            lblTitle.Text = "Update New Person";

//            AssignmentDataToForm();

//        }
//        private void Add_UpdatePerson_Load(object sender, EventArgs e)
//        {
//            _LoadData();
//        }

//        bool Check(string TextBoxText , string Missed)
//        {
//            if (TextBoxText == "")
//            {
//                MessageBox.Show("Please enter a "+Missed+" .", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                return true;
//            } return false;
//        }
//        bool NotCompleted()
//        {
//            if (Check(ctrAdd_UpdatePerson.tbFirstName.Text, "First Name")) return true;
//            if (Check(ctrAdd_UpdatePerson.tbLastName.Text, "Last Name")) return true;
//            if (Check(ctrAdd_UpdatePerson.tbNationalNo.Text, "National Number")) return true;
//            if (Check(ctrAdd_UpdatePerson.tbPhone.Text, "Phone")) return true;

//            return false;

//        }
//        bool IsErrorProviderAppear()
//        {
//            if (!string.IsNullOrEmpty(ctrAdd_UpdatePerson.errorProvider1.GetError(ctrAdd_UpdatePerson.tbEmail)) ||
//                !string.IsNullOrEmpty(ctrAdd_UpdatePerson.errorProvider1.GetError(ctrAdd_UpdatePerson.tbNationalNo)))
//            {
//                MessageBox.Show("Please correct the errors in the form.");
//                return true;
//            }
//            return false;

//        }
//        private void lbSave_Click(object sender, EventArgs e)
//        {
//            if (NotCompleted() || IsErrorProviderAppear()) { return; }
            
//            AssignmentDataToObject();

//            if (_Person.Save())
//            {
//                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                lblTitle.Text = "Update New Person";
//                Mode = enMode.Update;
//                ctrAdd_UpdatePerson.lbPersonID.Text = _Person.PersonID.ToString();
//            }
//            else
//                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

//        }

//        private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void ctrAdd_UpdatePerson_Load(object sender, EventArgs e)
//        {

//        }

//        private void frmAdd_UpdatePerson_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}












///*using DVLDBusinessLayer;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace DLVDProject
//{
//    public partial class frmAdd_UpdatePerson : Form
//    {
//        enum enMode { Add, Update, };
//        enMode Mode;
//        clsPerson _Person = new clsPerson();
//        int _PersonID = 0;
//        public frmAdd_UpdatePerson(int PersonID)
//        {
//            InitializeComponent();

//            ctrAdd_UpdatePerson.lbPersonID.Text = PersonID.ToString();
//            _PersonID = PersonID;
//            if (PersonID == -1) {
//                ctrAdd_UpdatePerson.Mode = ctrAdd_UpdatePerson.enMode.Add;
//                Mode = enMode.Add;
//            }

//            else
//            {
//                ctrAdd_UpdatePerson.Mode = ctrAdd_UpdatePerson.enMode.Update;
//                Mode = enMode.Update;
//            }
//        }

//        public void AssignmentDataToForm()
//        {
//            ctrAdd_UpdatePerson.tbFirstName.Text = _Person.FirstName;
//            ctrAdd_UpdatePerson.tbSecondName.Text = _Person.SecondName;
//            ctrAdd_UpdatePerson.tbThirdName.Text = _Person.ThirdName;
//            ctrAdd_UpdatePerson.tbLastName.Text = _Person.LastName;
//            ctrAdd_UpdatePerson.tbAddress.Text = _Person.Address;
//            ctrAdd_UpdatePerson.tbEmail.Text = _Person.Email;
//            ctrAdd_UpdatePerson.tbPhone.Text = _Person.Phone.ToString();
//            ctrAdd_UpdatePerson.tbNationalNo.Text = _Person.NationalNo;
//            ctrAdd_UpdatePerson.dtpDateOfBirth.Text = _Person.DateOfBirth.ToString();
//            if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
//            {
//                using (FileStream fs = new FileStream(_Person.ImagePath, FileMode.Open, FileAccess.Read))
//                {
//                    ctrAdd_UpdatePerson.pictureBox1.Image = Image.FromStream(fs);
//                    ctrAdd_UpdatePerson._IsThePhotoExist = true;
//                    ctrAdd_UpdatePerson.pictureBox1.ImageLocation = _Person.ImagePath; // optional, for tracking

//                }
//                ctrAdd_UpdatePerson.lbSetImage.Text = "Remove Photo";
//            }
//            else
//                ctrAdd_UpdatePerson._IsThePhotoExist = false;
//                ctrAdd_UpdatePerson.cbCountries.Text = clsCountries.Find(_Person.NationalityCountryID).CountryName;

//            if (_Person.Gendor == "Male") ctrAdd_UpdatePerson.rbMale.Checked = true;
//            else if (_Person.Gendor == "Female") ctrAdd_UpdatePerson.rbFemale.Checked = true;

//        }
//        private void AssignmentDataToObject()
//        {
//            _Person.FirstName = ctrAdd_UpdatePerson.tbFirstName.Text;
//            _Person.SecondName = ctrAdd_UpdatePerson.tbSecondName.Text;
//            _Person.ThirdName = ctrAdd_UpdatePerson.tbThirdName.Text;
//            _Person.LastName = ctrAdd_UpdatePerson.tbLastName.Text;
//            _Person.Address = ctrAdd_UpdatePerson.tbAddress.Text;
//            _Person.Email = ctrAdd_UpdatePerson.tbEmail.Text;
//            if (ctrAdd_UpdatePerson.tbPhone.Text != "")
//                _Person.Phone = Convert.ToInt32(ctrAdd_UpdatePerson.tbPhone.Text);
//            _Person.NationalNo = ctrAdd_UpdatePerson.tbNationalNo.Text;
//            if (ctrAdd_UpdatePerson.pictureBox1.ImageLocation != null)
//            {
//                _Person.ImagePath =ctrAdd_UpdatePerson._DestinationPath;
//                        File.Copy(ctrAdd_UpdatePerson._SourceFile,ctrAdd_UpdatePerson._DestinationPath, true);
//                ctrAdd_UpdatePerson._IsThePhotoExist = true;
//                ctrAdd_UpdatePerson._ImagePath = ctrAdd_UpdatePerson._DestinationPath;
//            }
//            else
//            {
//                _Person.ImagePath = "";
//            }  
//            if(ctrAdd_UpdatePerson._IsThePhotoExist && ctrAdd_UpdatePerson._ToDelete)
//            {
//                 File.Delete(ctrAdd_UpdatePerson._ImagePath);
//            }
//            _Person.DateOfBirth = ctrAdd_UpdatePerson.dtpDateOfBirth.Value;
//            _Person.NationalityCountryID = clsCountries.Find(ctrAdd_UpdatePerson.cbCountries.Text).CountryID;

//            if (ctrAdd_UpdatePerson.rbMale.Checked) _Person.Gendor = "Male";
//            else if (ctrAdd_UpdatePerson.rbFemale.Checked) _Person.Gendor = "Female";
//        }
//        void _LoadData()
//        {
//            ctrAdd_UpdatePerson.dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
        
//                DataTable dataTable = clsCountries.GetData();
//                foreach (DataRow row in dataTable.Rows)
//                {
//                    ctrAdd_UpdatePerson.cbCountries.Items.Add(row["CountryName"]);
//                }
//            if (Mode == enMode.Add)
//            {
//                ctrAdd_UpdatePerson.cbCountries.SelectedIndex = 168;
//                ctrAdd_UpdatePerson.rbMale.Checked = true;
               
//                ctrAdd_UpdatePerson.lblTitle.Text = "Add New Person";
//                _Person = new clsPerson();
//                return;
//            }

//            _Person = clsPerson.Find(_PersonID);

//            if (_Person == null)
//            {
//                MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                this.Close();
//                return;
//            }
//            ctrAdd_UpdatePerson.lblTitle.Text = "Update New Person";

//            AssignmentDataToForm();

//        }
//        private void Add_UpdatePerson_Load(object sender, EventArgs e)
//        {
//            _LoadData();
//        }
//        *//*  private void lbSave_Click(object sender, EventArgs e)
//        {
//            // 1) Pull all form fields into _Person
//            _Person.FirstName = ctrAdd_UpdatePerson.tbFirstName.Text;
//            _Person.SecondName = ctrAdd_UpdatePerson.tbSecondName.Text;
//            _Person.ThirdName = ctrAdd_UpdatePerson.tbThirdName.Text;
//            _Person.LastName = ctrAdd_UpdatePerson.tbLastName.Text;
//            _Person.Address = ctrAdd_UpdatePerson.tbAddress.Text;
//            _Person.Email = ctrAdd_UpdatePerson.tbEmail.Text;
//            _Person.Phone = int.TryParse(ctrAdd_UpdatePerson.tbPhone.Text, out var ph) ? ph : 0;
//            _Person.NationalNo = ctrAdd_UpdatePerson.tbNationalNo.Text;
//            _Person.DateOfBirth = ctrAdd_UpdatePerson.dtpDateOfBirth.Value;
//            _Person.NationalityCountryID = clsCountries.Find(ctrAdd_UpdatePerson.cbCountries.Text).CountryID;
//            _Person.Gendor = ctrAdd_UpdatePerson.rbMale.Checked ? "Male" : "Female";

//            // 2) Handle image persistence on Save
//            var ctrl = this.ctrAdd_UpdatePerson;
//            if (ctrl.SourceFile != null)
//            {
//                // Copy the chosen file into Resources
//                string destFolder = Path.Combine(Application.StartupPath, "Resources");
//                Directory.CreateDirectory(destFolder);

//                string fileName = Guid.NewGuid() + Path.GetExtension(ctrl.SourceFile);
//                string destPath = Path.Combine(destFolder, fileName);

//                File.Copy(ctrl.SourceFile, destPath, true);
//                _Person.ImagePath = destPath;
//            }
//            else if (ctrl.PhotoRemoved)
//            {
//                // User removed the existing photo before saving
//                _Person.ImagePath = "";
//            }
//            // else: neither added nor removed → leave existing ImagePath untouched

//            // 3) Persist to database
//            if (_Person.Save())
//            {
//                MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                Mode = enMode.Update;
//                // Reset tracking flags so next edit is clean
//                ctrl.SourceFile = null;
//                ctrl.PhotoRemoved = false;
//            }
//            else
//            {
//                MessageBox.Show("Error saving record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//     *//*
//        private void lbSave_Click(object sender, EventArgs e)
//           {
//               AssignmentDataToObject();

//               if (_Person.Save())
//               {
//                   MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                   ctrAdd_UpdatePerson.lblTitle.Text = "Update New Person";
//                   Mode = enMode.Update;
//               }
//               else
//                   MessageBox.Show($"An error occurred:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

//           }
//         private void btnClose_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void ctrAdd_UpdatePerson_Load(object sender, EventArgs e)
//        {

//        }
//    } }


      

//*//*      private void Save(clsPerson Person)
//      {

//          clsPerson person = ctrAdd_UpdatePerson._Person;
//          this.BackColor = Color.Aqua;
//      }*/
///*

//private void btnClose_Click(object sender, EventArgs e)
//{
//}
//private void ctrAdd_UpdatePerson1_Load(object sender, EventArgs e)
//{

//}
//private void ctrAdd_UpdatePerson1_Load_1(object sender, EventArgs e)
//{

//}

// * private void ctrAdd_UpdatePerson1_Load_2(object sender, EventArgs e)
//{
//    ctrAdd_UpdatePerson ctrAdd_UpdatePerson = new ctrAdd_UpdatePerson(_PersonID);
//}

//private void btnClose_Click_1(object sender, EventArgs e)
//{
//    this.Close();
//}


//    }
//}*/
