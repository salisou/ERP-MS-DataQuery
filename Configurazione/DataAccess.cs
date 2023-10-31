using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Management_System.Configurazione
{
	public class DataAccess
	{
		public string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DbAzienda;Integrated Security=True";
	 	public SqlConnection Conn { get; set; }
		public SqlCommand Cmd { get; set; }

		public string ConString()
		{
			return connectionString;
		}

        public void insertData(string query)
        {
            Conn = new SqlConnection(ConString());
			Conn.Open();
			Cmd = new SqlCommand(query);
			Cmd.ExecuteNonQuery();
			Conn.Close();
        }
    }
}
