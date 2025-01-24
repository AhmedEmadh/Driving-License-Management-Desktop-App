using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_DataAccessLayer
{
    public static class clsTestTypeData
    {
        public static bool GetTestTypeInfoByID(int TestTypeID, ref string TestTypeTitle, ref string TestDescription, ref float TestFees)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TestTypeTitle = reader["TestTypeTitle"].ToString();
                    TestDescription = reader["TestDescription"].ToString();
                    TestFees = float.Parse(reader["TestFees"].ToString());
                    isSuccess = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting test type info: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static DataTable GetAllTestTypes()
        {
            DataTable testTypes = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM TestTypes;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                testTypes.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all test types: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return testTypes;
        }
        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int CreatedID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO TestTypes (TestTypeTitle, TestDescription, TestFees) OUTPUT INSERTED.TestTypeID VALUES (@Title, @Description, @Fees);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);
            try
            {
                connection.Open();
                CreatedID = (int)command.ExecuteScalar();
                Console.WriteLine($"New test type created with ID: {CreatedID}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding new test type: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return CreatedID;
        }
        public static bool UpdateTestType(int TestTypeID, string Title, string Description, float Fees)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestTypes SET TestTypeTitle=@Title, TestDescription=@Description, TestFees=@Fees WHERE TestTypeID=@TestTypeID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    isSuccess = true;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating test type: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
    }
}
