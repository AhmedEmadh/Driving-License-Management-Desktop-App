using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_License_Management_DataAccessLayer
{
    /// <summary>
    /// Provides settings for data access operations.
    /// </summary>
    static class clsDataAccessSettings
    {
        /// <summary>
        /// Gets the connection string used to connect to the database.
        /// </summary>
        /// <value>The connection string.</value>
        /// <remarks>This connection string is used to connect to the local SQL Server instance with the specified database and credentials.</remarks>
        public static string ConnectionString = null;

        static clsDataAccessSettings()
        {
            ConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
    }
}
