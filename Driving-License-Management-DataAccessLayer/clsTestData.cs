using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;
namespace Driving_License_Management_DataAccessLayer
{
    public static class clsTestData
    {
        public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        { 
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests WHERE TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID"));
                    TestResult = reader.GetBoolean(reader.GetOrdinal("TestResult"));
                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    result = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool GetLastTestByPersonAndTestTypeAndLicenseClass(int PersonID, int LicenseClassID, int TestTypeID, ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TOP 1 * FROM Tests WHERE PersonID = @PersonID AND LicenseClassID = @LicenseClassID AND TestTypeID = @TestTypeID ORDER BY TestDate DESC";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    TestID = reader.GetInt32(reader.GetOrdinal("TestID"));
                    TestAppointmentID = reader.GetInt32(reader.GetOrdinal("TestAppointmentID"));
                    TestResult = reader.GetBoolean(reader.GetOrdinal("TestResult"));
                    Notes = reader.IsDBNull(reader.GetOrdinal("Notes")) ? null : reader.GetString(reader.GetOrdinal("Notes"));
                    CreatedByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                    isSuccess = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static DataTable GetAllTests()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Tests";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
        public static int AddNewTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int IDOfAddedTest = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID) VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                IDOfAddedTest = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IDOfAddedTest;
        }
        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Tests SET TestAppointmentID = @TestAppointmentID, TestResult = @TestResult, Notes = @Notes, CreatedByUserID = @CreatedByUserID WHERE TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isSuccess = (bool)(rowsAffected > 0);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static byte GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            byte PassedTestCount = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT COUNT(*) FROM Tests WHERE TestResult = 1 AND LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                PassedTestCount = Convert.ToByte(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return PassedTestCount;
        }

    }
}
