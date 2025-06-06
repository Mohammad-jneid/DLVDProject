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
    public class clsPersonData
    {
        public static int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime? DateOfBirth,
               string Gendor, string Address, int Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"INSERT INTO People (FirstName , SecondName , ThirdName ,LastName, NationalNO ,DateOfBirth , 
                            Gendor , Address ,  Phone, Email, NationalityCountryID, ImagePath)
                            VALUES (@FirstName , @SecondName , @ThirdName ,@LastName, @NationalNO ,@DateOfBirth , 
                            @Gendor , @Address ,  @Phone, @Email, @NationalityCountryID, @ImagePath);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("SecondName", SecondName);
            command.Parameters.AddWithValue("ThirdName", ThirdName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("NationalNo", NationalNo);
            command.Parameters.AddWithValue("DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("Gendor", Gendor);
            command.Parameters.AddWithValue("Address", Address);
            command.Parameters.AddWithValue("Phone", Phone);
            command.Parameters.AddWithValue("Email", Email);
            command.Parameters.AddWithValue("NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("ImagePath", ImagePath);

            int PersonID = -1;

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    PersonID = InsertedID;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return PersonID;
        }

        public static bool UpdatePerson(int personID, string FirstName, string SecondName, string ThirdName, string LastName  ,string NationalNo, DateTime DateOfBirth,
            string Gendor, string Address, int Phone,  string Email, int NationalityCountryID, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);

            string query = @"UPDATE People 
                     SET FirstName = @FirstName, 
                         SecondName = @SecondName, 
                         ThirdName = @ThirdName, 
                         LastName = @LastName, 
                         NationalNo = @NationalNo, 
                         DateOfBirth = @DateOfBirth, 
                         Gendor = @Gendor, 
                         Address = @Address, 
                         Phone = @Phone, 
                         Email = @Email, 
                         NationalityCountryID = @NationalityCountryID, 
                         ImagePath = @ImagePath
                     WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gendor", Gendor);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
            int rowsAffected;

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
                return rowsAffected > 0;
        }

        public static bool GetPersonById( int personID, ref string firstName,ref string secondName,ref string thirdName,
                   ref string nationalNo,ref string lastName,ref DateTime dateOfBirth,ref string gendor,
                 ref  string address,ref string email,ref int phone,ref int nationalityCountryID,ref string imagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT * FROM People WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("PersonID", personID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    firstName = Reader["FirstName"].ToString();
                    secondName = Reader["secondName"].ToString();
                    thirdName = Reader["thirdname"].ToString();
                    lastName = Reader["LastName"].ToString();
                    address = Reader["Address"].ToString();
                    nationalNo = Reader["nationalNo"].ToString();
                    dateOfBirth =Convert.ToDateTime( Reader["dateOfBirth"]);
                    gendor = Reader["gendor"].ToString();
                    imagePath = Reader["imagePath"].ToString();
                    phone = Convert.ToInt32( Reader["Phone"]);
                    nationalityCountryID = Convert.ToInt32( Reader["nationalityCountryID"]);
                    email = Reader["Email"].ToString();

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
        public static bool GetPersonByNationalNo(ref int personID, ref string firstName, ref string secondName, ref string thirdName,
                string nationalNo, ref string lastName, ref DateTime dateOfBirth, ref string gendor,
             ref string address, ref string email, ref int phone, ref int nationalityCountryID, ref string imagePath)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT * FROM People WHERE NationalNO = @NationalNO;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("nationalNo", nationalNo);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    firstName = Reader["FirstName"].ToString();
                    secondName = Reader["secondName"].ToString();
                    thirdName = Reader["thirdname"].ToString();
                    lastName = Reader["LastName"].ToString();
                    address = Reader["Address"].ToString();
                    dateOfBirth = Convert.ToDateTime(Reader["dateOfBirth"]);
                    gendor = Reader["gendor"].ToString();
                    imagePath = Reader["imagePath"].ToString();
                    phone = Convert.ToInt32(Reader["Phone"]);
                    nationalityCountryID = Convert.ToInt32(Reader["nationalityCountryID"]);
                    personID = Convert.ToInt32(Reader["PersonID"]);
                    email = Reader["Email"].ToString();

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


        public static bool IsPersonExist(string NationalNo)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT x = 1 FROM People WHERE NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("NationalNo", NationalNo);
            
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

        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "SELECT x = 1 FROM People WHERE PersonID = @PersonID;";

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

        public static DataTable GetData()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = @"select People.* , Countries.CountryName from People inner join Countries on 
Countries.CountryID = People.NationalityCountryID;

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

        public static bool DeletePerson(int personID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Delete from people where PersonID = @personID;";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("PersonID", personID);
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
        public static int GetCount()
        {
            int Count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionstring);
            string query = "Select Count(PersonID) from People ";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.Read())
                {
                    Count = (int)Reader[0];
                }
                Reader.Close();
            }
            catch (Exception ex) {/* Console.WriteLine("Error " + ex.ToString());*/ }
            finally { connection.Close(); }
            return Count;
        }


    }

}