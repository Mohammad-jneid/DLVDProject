using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;
using DVLDBusinessLayer;

namespace DLVDProject
{
    public class clsUsers
    {
        enum enMode { Add, Update }
        enMode Mode;
        public clsPerson Person = new clsPerson();
        static clsPerson StaticPerson = new clsPerson();
        
        public static int LoggedInUserID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUsers(int userID, string userName, string password, bool isActive,clsPerson person)
        {
            this.UserID = userID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this.Person = person;
            Mode = enMode.Update;
        }

        public clsUsers()
        {
            UserID = -1;
            UserName = "";
            Password = "";
            IsActive = false;
            Person = null;
            Mode = enMode.Add;
        }

        private bool _AddNewUser()
        {
                this.UserID = clsUsersData.AddUser(this.UserName , this.Password , this.IsActive ,this.Person.PersonID);
                return this.UserID != -1;
        }
        private bool _UpdateUser()
        {
            clsPerson person = new clsPerson();
            if ((person = clsPerson.Find(this.Person.PersonID)) != null)
            {
                if (person.Save())
                {
                    return clsUsersData.UpdateUser(this.UserID ,this.UserName, this.Password,  this.IsActive);
                }
            }
            
            return false;
            return false;
        }

        public static bool DeletedUser(int Userid)
        {
            return clsUsersData.DeleteUser(Userid);
        }
        public static clsUsers Find(string UserName , string PassWord )
        {
            clsPerson person;
            int UserId = 0; bool IsActive = false;int PersonID =-1;

            if (clsUsersData.GetUserInfo(UserName, PassWord, ref UserId, ref IsActive ,ref PersonID))
            {
                if ((person = clsPerson.Find(PersonID)) != null)
                {
                    return new clsUsers(UserId, UserName, PassWord, IsActive,person);
                } 
            else return null;
            }
            else return null;
            }
        public static clsUsers Find(int UserID)

        {
            clsPerson person;
            string UserName=""; bool IsActive = false;string Password=""; int PersonID = -1;

            if (clsUsersData.GetUserInfoByID(ref UserName,ref Password, UserID, ref IsActive, ref PersonID))
            {
                if (( person = clsPerson.Find(PersonID)) != null)
                {
                    return new clsUsers(UserID, UserName, Password, IsActive,person);
                }
                else return null;
            }
            else return null;
        }
        public static DataTable GetData()
        {
            return  clsUsersData.GetData();
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Add;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUsersData.IsUserExistByPersonID(PersonID);
        }
        
        
    }
}
