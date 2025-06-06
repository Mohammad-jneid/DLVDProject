using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVDProject
{
    public class clsTestTypes
    {
        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }

        public clsTestTypes()
        {
            TestTypeID = -1;
            TestTypeTitle = string.Empty;
            TestTypeDescription = string.Empty;
            TestTypeFees = 0;
        }

        public clsTestTypes(int testTypeID, string testTypeTitle, string testTypeDescription, double testTypeFees)
        {
            this.TestTypeID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFees = testTypeFees;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypesData.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public static clsTestTypes Find(int testTypeID)
        {
            string title = string.Empty;
            string description = string.Empty;
            double fees = 0;

            if (clsTestTypesData.GetInfoByID(ref testTypeID, ref title, ref description, ref fees))
            {
                return new clsTestTypes(testTypeID, title, description, fees);
            }

            return null;
        }

        public bool Save()
        {
            return _UpdateTestType();
        }

        public static DataTable GetData()
        {
            return clsTestTypesData.GetData();
        }
    }
}
