using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVDProject
{
    public class clsApplicationTypes
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public double ApplicationFees { get; set; }
        
        clsApplicationTypes ()
        {
            ApplicationTypeID = -1;
            ApplicationTypeTitle = string.Empty;
            ApplicationFees = 0;

        }

        clsApplicationTypes(int applicationTypeID , string applicationTypeTitle , double applicationFees)
        {
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationFees = applicationFees;
        }

        private bool _UpdateApplicationTypes()
        {
            return clsApplicationTypesData.UpdateApplicationType(this.ApplicationTypeID,this.ApplicationFees , this.ApplicationTypeTitle);
        }
        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            string Applicationtypetitle = "";
            double ApplicationFees = 0;
            if(clsApplicationTypesData.GetInfoByID(ref ApplicationTypeID ,ref Applicationtypetitle , ref ApplicationFees))
            {
                return new clsApplicationTypes(ApplicationTypeID, Applicationtypetitle, ApplicationFees);
            }return null;
        }

        public  bool Save()
        {
            return _UpdateApplicationTypes();
        }
        public static DataTable GetData()
        {
            return clsApplicationTypesData.GetData();
        }
    }
}
