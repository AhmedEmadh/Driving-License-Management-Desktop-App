using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Driving_License_Management_DataAccessLayer
{
    public static class clsLocalDrivingLicenseApplicationData
    {
        public static bool GetLocalDrivingLicenseApplicationInfoByID(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool GetLocalDrivingLicenseApplicationInfoByApplicationID(int ApplicationID, ref int LocalDrivingLicenseApplicationID, ref int LicenseClassID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications WHERE ApplicationID = @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    LocalDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable Result = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Result.Load(reader);
            }
            catch (Exception ex)
            {
                Result = null;
            }
            return Result;
        }
        public static int AddNewLocalDrivingLicenseApplication(int ApplicationID, int LicenseClassID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications (ApplicationID, LicenseClassID) VALUES (@ApplicationID, @LicenseClassID); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                LocalDrivingLicenseApplicationID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                LocalDrivingLicenseApplicationID = -1;
            }
            finally
            {
                connection.Close();
            }
            return LocalDrivingLicenseApplicationID;
        }
        public static bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE LocalDrivingLicenseApplications SET ApplicationID = @ApplicationID, LicenseClassID = @LicenseClassID WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                isSuccess = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool DoesPassTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                SELECT top 1 TestResult
                                FROM LocalDrivingLicenseApplications INNER JOIN
                                TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE
                                (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                                AND(TestAppointments.TestTypeID = @TestTypeID)
                                ORDER BY TestAppointments.TestAppointmentID desc
            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool DoesAttendTestType(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                SELECT TOP 1 FOUND=1 FROM LocalDrivingLicenseApplications INNER JOIN
                                TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                TESTS ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                WHERE LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestAppointments.TestTypeID = @TestTypeID;
";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                result = Convert.ToBoolean(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = false;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static byte TotalTrialsPerTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            byte result = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                    SELECT TotalTrialsPerTest = count(TestID)
                                    FROM LocalDrivingLicenseApplications INNER JOIN
                                         TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID INNER JOIN
                                         Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                                    WHERE
                                    (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID) 
                                    AND(TestAppointments.TestTypeID = @TestTypeID)
            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            try
            {
                connection.Open();
                result = Convert.ToByte(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                result = 0;
            }
            finally
            {
                connection.Close();
            }
            return result;
        }
        public static bool IsThereAnActiveScheduledTest(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            bool Result = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @" 
                            SELECT top 1 Found=1
                            FROM LocalDrivingLicenseApplications INNER JOIN
                                 TestAppointments ON LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = TestAppointments.LocalDrivingLicenseApplicationID 
                            WHERE
                            (LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID)  
                            AND(TestAppointments.TestTypeID = @TestTypeID) and isLocked=0
                            ORDER BY TestAppointments.TestAppointmentID desc
";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();


                if (result != null)
                {
                    Result = true;
                }

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return Result;

        }
    }
}
