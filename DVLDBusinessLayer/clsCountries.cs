using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer
{
    public class clsCountries
    {
        public int CountryID {  get; set; }
        public string CountryName { get; set; }

        public clsCountries()
        {
            CountryID = -1;
            CountryName = "";
        }

        private clsCountries (int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }
        public static clsCountries Find(string CountryName)
        {
            int countryID = clsCountriesData.GetCountryID(CountryName);
            if (countryID != -1)
                return new clsCountries(countryID, CountryName);
            else return null;
        }
        public static clsCountries Find(int CountryID)
        {
            string CountryName = clsCountriesData.GetCountryID(CountryID);
            if (CountryName != "")
                return new clsCountries(CountryID, CountryName);
            else return null;
        }
        public static DataTable GetData()
        {
            return clsCountriesData.GetData();
        }

    }
}
