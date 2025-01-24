using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_DataAccessLayer
{
    public static class clsCountryData
    {
        public static bool GetCountryInfoByID(int ID, ref string CountryName)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = reader["CountryName"].ToString();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                throw new Exception("Error in clsCountryData.GetCountryInfoByID(int ID, ref string CountryName) Method: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isSuccess = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ID = Convert.ToInt32(reader["CountryID"]);
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                isSuccess = false;
                throw new Exception("Error in clsCountryData.GetCountryInfoByName(string CountryName, ref int ID) Method: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return isSuccess;
        }
        public static DataTable GetAllCountries()
        {
            DataTable table = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Countries";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                table.Load(reader);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in clsCountryData.GetAllCountries() Method: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return table;
        }
    }
}
