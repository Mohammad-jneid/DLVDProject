using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsCountriesData
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from Countries
";
            SqlCommand command = new SqlCommand(query, connection);
            //  command.Parameters.AddWithValue("Account_Number",AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return dt;
        }

        public static int GetCountryID(string CountryName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select countryid from Countries where countryname = @CountryName 
";  
            
            int CountryID = -1;
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CountryName", CountryName);
            //  command.Parameters.AddWithValue("Account_Number",AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    CountryID = Convert.ToInt32(Reader[0]);
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return CountryID;
        }

        public static string GetCountryID(int CountryID)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select CountryName from Countries where CountryID = @CountryID 
";

            string CountryName = "";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("CountryID", CountryID);
            //  command.Parameters.AddWithValue("Account_Number",AccountNumber);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    CountryName = Reader[0].ToString();
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            { connection.Close(); }
            return CountryName;
        }
    }
}

