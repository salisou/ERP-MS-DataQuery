using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Management_System.Data
{
    public class DbConnection
    {
        readonly string connectionString;

        public DbConnection()
        {
            connectionString = "Server=localhost\\sqlexpress;Database=NorthwindStore;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
