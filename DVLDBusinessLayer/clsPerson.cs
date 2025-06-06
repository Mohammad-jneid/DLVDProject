using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPerson
    {
        // Auto-implemented Properties
        public enum enMode { Add, Update };
        public enMode Mode;
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gendor { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }
        public string ImagePath { get; set; }


        // Constructors
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.NationalNo = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = string.Empty;
            this.Address = string.Empty;
            this.Phone = 0;
            this.Email = string.Empty;
            NationalityCountryID = -1;
            this.ImagePath = string.Empty;
            Mode = enMode.Add;
        }
        public clsPerson(int personID, string firstName, string secondName, string thirdName,
                   string nationalNo, string lastName, DateTime dateOfBirth, string gendor,
                   string address, string email, int phone, int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.NationalNo = nationalNo;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;
            this.Mode = enMode.Update;
        }

        public static DataTable GetData()
        {
            return clsPersonData.GetData();
        }

        public static int GetCount()
        {
            return clsPersonData.GetCount();
        }
        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth,
                this.Gendor, this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return PersonID != -1;
        }

        private bool _UpdatePersonInfo()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                                              this.NationalNo, this.DateOfBirth, this.Gendor, this.Address, this.Phone,
                                              this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
            string firstName = ""; string secondName = ""; string thirdName = "";
            string nationalNo = ""; string lastName = ""; DateTime dateOfBirth = DateTime.Now; string gendor = "";
            string address = ""; string email = ""; int phone = 0; int nationalityCountryID = 0; string imagePath = "";
            if (clsPersonData.GetPersonById(PersonID, ref firstName, ref secondName, ref thirdName,
                   ref nationalNo, ref lastName, ref dateOfBirth, ref gendor,
                   ref address, ref email, ref phone, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(PersonID, firstName, secondName, thirdName, nationalNo, lastName, dateOfBirth, gendor
                    , address, email, phone, nationalityCountryID, imagePath);
            }
            return null;

        }

        public static clsPerson Find(string NationalNO)
        {
            string firstName = ""; string secondName = ""; string thirdName = "";
            int PersonID = -1; string lastName = ""; DateTime dateOfBirth = DateTime.Now; string gendor = "";
            string address = ""; string email = ""; int phone = 0; int nationalityCountryID = 0; string imagePath = "";
            if (clsPersonData.GetPersonByNationalNo(ref PersonID, ref firstName, ref secondName, ref thirdName,
                   NationalNO, ref lastName, ref dateOfBirth, ref gendor,
                   ref address, ref email, ref phone, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(PersonID, firstName, secondName, thirdName, NationalNO, lastName, dateOfBirth, gendor
                    , address, email, phone, nationalityCountryID, imagePath);
            }
            return null;

        }
        public static bool IsPersonExist(string NationalNO)
        {
            return clsPersonData.IsPersonExist(NationalNO);

        }
        public static bool IsPersonExist(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);

        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletePerson(PersonID);
        }
        virtual public bool Save()
        {
            if (true)//Validate())
            {
                switch (Mode)
                {
                    case enMode.Add:
                        if (_AddNewPerson()) { 
                        
                        Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    case enMode.Update:
                        return _UpdatePersonInfo();
                }
                return false;
            }
            else return false;
        }
    }
}

    /* 
        protected bool _DeletePerson(int PersonId)
        {
            return clsPersonData.DeletePerson(PersonId);
        }
        private bool _UpdatePersonInfo()
        {
            return clsPersonData.UpdatePersonInfo(this.PersonID, this.FirstName, this.Age, this.LastName, this.Phone, this.Address, this.Email);
        }
        public bool IsEmailExisting(string email)
        {
            return clsPersonData.IsEmailExisting(email);
        }
        protected static clsPerson FindPersonByID(int PersonID)
        {
            string FirstName = "", LastName = ""; string Phone = ""; string Address = ""; int Age = 0; string Email = "";

            if (clsPersonData.GetPersonInfoByID(PersonID, ref FirstName, ref Age, ref LastName, ref Phone, ref Address, ref Email))
            {
                return new clsPerson(PersonID, FirstName, LastName, Age, Email, Phone, Address);
            }
            return null;
        }
        protected static clsPerson FindPerson(string Email)
        {
            string FirstName = "", LastName = ""; string Phone = ""; string Address = ""; int PersonID = -1; int Age = 0;

            if (clsPersonData.GetPersonInfoByEmail(ref FirstName, ref PersonID, ref Age, ref LastName, ref Phone, ref Address, Email))
            {
                return new clsPerson(PersonID, FirstName, LastName, Age, Email, Phone, Address);
            }
            return null;
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // More comprehensive check while keeping it simple
                var trimmedEmail = email.Trim();

                // Must contain exactly one @
                if (trimmedEmail.Count(c => c == '@') != 1)
                    return false;

                // Split into local and domain parts
                var parts = trimmedEmail.Split('@');
                if (parts.Length != 2)
                    return false;

                var localPart = parts[0];
                var domainPart = parts[1];

                // Check local and domain parts aren't empty
                if (string.IsNullOrEmpty(localPart) || string.IsNullOrEmpty(domainPart))
                    return false;

                // Domain must contain at least one dot
                if (!domainPart.Contains('.'))
                    return false;

                // Domain's last dot can't be at the end
                if (domainPart.LastIndexOf('.') == domainPart.Length - 1)
                    return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool Validate()
        {
            // Check FirstName (2-50 characters)
            if (string.IsNullOrWhiteSpace(FirstName) || FirstName.Length < 2 || FirstName.Length > 50)
                return false;

            // Check Age (1-120 years)
            if (Age <= 0 || Age > 120)
                return false;

            // Check Email
            if (!IsValidEmail(Email))
                return false;

            // Check Phone (optional - basic check)
            if (!string.IsNullOrWhiteSpace(Phone) && Phone.Length < 7)
                return false;

            return true;
        }
        virtual public bool Save()
        {
            if (true)//Validate())
            {
                switch (Mode)
                {
                    case enMode.Add:
                        Mode = enMode.Update;
                        if (_AddNewPerson()) return true;
                        else
                            return false;
                    case enMode.Update:
                        return _UpdatePersonInfo();
                }
                return false;
            }
            else return false;
        }
    }*/