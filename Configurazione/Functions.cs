using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ERP_Management_System.Configurazione
{
	public class Functions
	{
        private SqlConnection connection;
        private SqlCommand command;
        private string conString;
        public Functions()
        {
            // Connessione al database
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DbAzienda;Integrated Security=True";

            // Imposta la stringa di connessione all'interno dell'istanza di DatabaseHandler
            this.conString = connectionString;

            // Crea una nuova connessione SQL utilizzando la stringa di connessione
            this.connection = new SqlConnection(this.conString);

            // Crea un oggetto SqlCommand per eseguire comandi SQL
            command = new SqlCommand();

            // Imposta la connessione per l'oggetto SqlCommand
            command.Connection = connection;
        }
		public SqlConnection GetConnection()
		{
            return connection;
		}

        public DataTable GetData(string query)
        {
            // Crea un nuovo oggetto DataTable per archiviare i dati
            DataTable dataTable = new DataTable();

            // Utilizza un oggetto SqlDataAdapter per eseguire la query e riempire il DataTable
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);
            }

            // Restituisci il DataTable contenente i dati ottenuti dalla query
            return dataTable;
        }


        public int SetData(string query)
        {
            // Verifica se la connessione è chiusa e, se necessario, aprila
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            // Imposta il comando SQL da eseguire
            command.CommandText = query;

            // Esegui il comando SQL e restituisci il numero di righe interessate
            return command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            // Rilascia le risorse gestite (connessione e comando SQL)
            connection.Dispose();
            command.Dispose();
        }

	}
}
