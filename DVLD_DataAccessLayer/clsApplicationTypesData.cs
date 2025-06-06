using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace DVLD_DataAccessLayer
{
    public class clsApplicationTypesData
    {
        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from ApplicationTypes
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

        public static bool GetInfoByID(ref int ApplicationTypeID ,ref string ApplicationTypeTitle ,ref double ApplicationFees )
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ApplicationTypeID", ApplicationTypeID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    ApplicationFees = Convert.ToDouble(Reader["ApplicationFees"]);
                    ApplicationTypeTitle = Reader["ApplicationTypeTitle"].ToString();
                }
                Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool UpdateApplicationType(int ApplicationTypeID,double Fees , string ApplicationTypeTitle)
        {
            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"update ApplicationTypes 
                       set  ApplicationFees = @Fees ,
                            ApplicationTypeTitle = @ApplicationTypeTitle
                        where ApplicationTypeID = @ApplicationTypeID;
"
                ;

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("Fees", Fees);
            command.Parameters.AddWithValue("ApplicationTypeTitle", ApplicationTypeTitle);


            try
            {
                connection.Open();
                AffectedRows = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw;
            }
            finally { connection.Close(); }

            return AffectedRows > 0;
        }

    }

}
