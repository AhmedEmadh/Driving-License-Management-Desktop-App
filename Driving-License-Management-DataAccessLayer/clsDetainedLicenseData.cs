using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_DataAccessLayer
{
    public class clsDetainedLicenseData
    {
        public static bool GetDetainedLicenseInfoByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@DetainID", DetainID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    LicenseID = Convert.ToInt32(reader["LicenseID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);
                    ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);
                    ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public static bool GetDetainedLicenseInfoByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref float FineFees, ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    DetainID = Convert.ToInt32(reader["DetainID"]);
                    DetainDate = Convert.ToDateTime(reader["DetainDate"]);
                    FineFees = Convert.ToSingle(reader["FineFees"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    IsReleased = Convert.ToBoolean(reader["IsReleased"]);
                    ReleaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    ReleasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);
                    ReleaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dataTable = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }
        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int IDOfCreatedLicense = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                INSERT INTO DetainedLicenses
                                       (LicenseID
                                       ,DetainDate
                                       ,FineFees
                                       ,CreatedByUserID
                                       ,IsReleased
                                       ,ReleaseDate
                                       ,ReleasedByUserID
                                       ,ReleaseApplicationID)
                                 VALUES
                                       (@LicenseID
                                       ,@DetainDate
                                       ,@FineFees
                                       ,@CreatedByUserID
                                       ,@IsReleased
                                       ,@ReleaseDate
                                       ,@ReleasedByUserID
                                       ,@ReleaseApplicationID);
                                SELECT SCOPE_IDENTITY() AS DetainID;
            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID",LicenseID);
            command.Parameters.AddWithValue("@DetainDate",DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsReleased", 0);
            command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            command.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);
            try 
            {
                connection.Open();
                IDOfCreatedLicense = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IDOfCreatedLicense;
        }
        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                UPDATE DetainedLicenses
                                   SET LicenseID = @LicenseID
                                      ,DetainDate = @DetainDate
                                      ,FineFees = @FineFees
                                      ,CreatedByUserID = @CreatedByUserID
                                 WHERE DetainID = @DetainID;
            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@DetainDate", DetainDate);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"
                                UPDATE DetainedLicenses
                                   SET IsReleased = 1
                                      ,ReleaseDate = GETDATE()
                                      ,ReleasedByUserID = @ReleasedByUserID
                                      ,ReleaseApplicationID = @ReleaseApplicationID
                                 WHERE DetainID = @DetainID;
            ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isDetained = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isDetained = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isDetained;
        }

    }
}
