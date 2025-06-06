using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DLVDProject
{
    public class clsUsersData
    {
        public static int AddUser(string UserName, string Password, bool IsActive, int PersonID)
        {
            int UserId = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "insert into users (UserName , Password , IsActive , PersonID)" +
                "               values (@UserName , @Password , @IsActive ,@PersonID);" +
                "select scope_Identity();"
                ;
           // SELECT SCOPE_IDENTITY(); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("PersonID", PersonID);
            command.Parameters.AddWithValue("IsActive", IsActive);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    UserId = InsertedID;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally { connection.Close(); }
            return UserId;
        }

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Delete from Users where UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            int AffectedRows = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"update users 
                       set  UserName = @UserName ,
                            Password = @Password,
                            IsActive = @IsActive
                        where UserID = @UserID;
"
                ;

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("UserID", UserID);
            command.Parameters.AddWithValue("IsActive", IsActive);


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

        public static DataTable GetData()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select * from Users

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

        public static bool GetUserInfo(string UserName, string PassWord, ref int UserID, ref bool IsActive, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT * FROM Users WHERE UserName = @UserName and PassWord = @PassWord;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("PassWord", PassWord);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = Convert.ToInt32(Reader["UserID"]);
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    IsActive = (bool)Reader["IsActive"];

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

        public static bool GetUserInfoByID(ref string UserName, ref string PassWord, int UserID, ref bool IsActive, ref int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT * FROM Users WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserID", UserID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserName = Reader["UserName"].ToString();
                    PassWord = Reader["PassWord"].ToString();
                    PersonID = Convert.ToInt32(Reader["PersonID"]);
                    IsActive = (bool)Reader["IsActive"];

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

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT x = 1 FROM Users WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;

                reader.Close();
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

    }
}
