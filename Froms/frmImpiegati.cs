using ERP_Management_System.Configurazione;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Management_System.Froms
{
	public partial class frmImpiegati : Form
	{
        Functions Con;

        // Stringa di connessione al tuo database SQL Server
        public static string ConStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=DbAzienda;Integrated Security=True";

        public frmImpiegati()
		{
			InitializeComponent();
            Con = new Functions();
            MostraDipartimenti();
            GetDipartimenti();
        }

		private void MostraDipartimenti()
		{
            string Query = "SELECT * FROM tab_Impiegati";
            LDipendenti.DataSource = Con.GetData(Query);
        }

        private void GetDipartimenti()
        {
            string Query = "SELECT DipId, NomeDipartimente FROM tab_Dipartimenti";
            comboDip.DisplayMember = Con.GetData(Query).Columns["NomeDipartimente"].ToString(); // Nome della colonna da visualizzare
            comboDip.ValueMember = Con.GetData(Query).Columns["DipId"].ToString(); // Nome della colonna che sarà il valore selezionato
            comboDip.DataSource = Con.GetData(Query); // Imposta la tabella come origine dati

        }
        private void btnAdd_Click(object sender, EventArgs e)
		{
            try
            {
                if (txtNome.Text == "" || comboGenere.SelectedIndex == -1 || comboDip.SelectedIndex == -1 || txtStipendioGiornaliero.Text == "")
                {
                    MessageBox.Show("Errore!", "Dati mancanti!");
                }
                else
                {
                    string _nome = txtNome.Text;
                    string _genere = Convert.ToString(comboGenere.SelectedItem);
                    int _dipartimento = Convert.ToInt32(comboDip.SelectedValue);

                    DateTime _nascita;
                    if (DateTime.TryParse(_DataNascita.Value.ToString(), out _nascita) == false)
                    {
                        MessageBox.Show("Data di nascita non valida!");
                        return;
                    }

                    DateTime _iscrizione;
                    if (DateTime.TryParse(_DataIscrizione.Value.ToString(), out _iscrizione) == false)
                    {
                        MessageBox.Show("Data di iscrizione non valida!");
                        return;
                    }

                    int _stipendio;
                    if (int.TryParse(txtStipendioGiornaliero.Text, out _stipendio) == false)
                    {
                        MessageBox.Show("Stipendio non valido!");
                        return;
                    }

                    // Creazione di un oggetto SqlCommand per eseguire un'operazione di inserimento
                    string insertQuery = "INSERT INTO tab_Impiegati (Nome, Genere, Dipartimento, DataNascita, DataIscrizione, StipendioGiornaliero) " +
                                         "VALUES (@Nome, @Genere, @Dipartimento, @DataNascita, @DataIscrizione, @StipendioGiornaliero)";


                    using (SqlConnection connection = new SqlConnection(ConStr))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Parametri per l'inserimento
                            command.Parameters.AddWithValue("@Nome", _nome);
                            command.Parameters.AddWithValue("@Genere", _genere);
                            command.Parameters.AddWithValue("@Dipartimento", _dipartimento);
                            command.Parameters.AddWithValue("@DataNascita", _nascita);
                            command.Parameters.AddWithValue("@DataIscrizione", _iscrizione);
                            command.Parameters.AddWithValue("@StipendioGiornaliero", _stipendio);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MostraDipartimenti();
                                MessageBox.Show("Impiegato Aggiunto");
                                txtNome.Text = "";
                                txtStipendioGiornaliero.Text = "";
                                comboGenere.SelectedIndex = -1;
                                comboDip.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("Errore durante l'inserimento dell'impiegato.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        int Key = 0;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            txtNome.Text                 = LDipendenti.SelectedRows[0].Cells[1].Value.ToString();
            comboGenere.Text             = LDipendenti.SelectedRows[0].Cells[2].Value.ToString();
            comboDip.SelectedValue       = LDipendenti.SelectedRows[0].Cells[3].Value.ToString();
            _DataNascita.Text            = LDipendenti.SelectedRows[0].Cells[4].Value.ToString();
            _DataIscrizione.Text         = LDipendenti.SelectedRows[0].Cells[4].Value.ToString();
            txtStipendioGiornaliero.Text = LDipendenti.SelectedRows[0].Cells[6].Value.ToString();

            if (txtNome.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LDipendenti.SelectedRows[0].Cells[0].Value.ToString());    
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;

            try
            {
                if (txtNome.Text == "" || comboGenere.SelectedIndex == -1 || comboDip.SelectedIndex == -1 || txtStipendioGiornaliero.Text == "")
                {
                    MessageBox.Show("Errore!", "Dati mancanti!");
                    return;
                }

                // Verifica che Key contenga un valore valido
                if (Key <= 0)
                {
                    MessageBox.Show("Seleziona un impiegato valido da aggiornare.");
                    return;
                }

                string _nome = txtNome.Text;
                string _genere = Convert.ToString(comboGenere.SelectedItem);
                string _dipartimento = Convert.ToString(comboDip.SelectedValue);
                DateTime _nascita = Convert.ToDateTime(_DataNascita.Value);
                DateTime _iscrizione = Convert.ToDateTime(_DataIscrizione.Value);
                decimal _stipendio = Convert.ToDecimal(txtStipendioGiornaliero.Text);

                // Ottieni la connessione dal tuo oggetto Con (supponendo che sia un'istanza di DatabaseHandler)
                connection = Con.GetConnection();

                // Apri la connessione
                connection.Open();

                // Definisci la query SQL con parametri
                string _query = "UPDATE tab_Impiegati " +
                                "SET Nome = @Nome, " +
                                    "Genere = @Genere, " +
                                    "Dipartimento = @Dipartimento, " +
                                    "DataNascita = @DataNascita, " +
                                    "DataIscrizione = @DataIscrizione, " +
                                    "StipendioGiornaliero = @Stipendio " +
                                "WHERE DipId = @Key";

                // Crea un nuovo comando SQL con la query e la connessione
                using (SqlCommand command = new SqlCommand(_query, connection))
                {
                    // Aggiungi i parametri con i valori appropriati
                    command.Parameters.AddWithValue("@Nome", _nome);
                    command.Parameters.AddWithValue("@Genere", _genere);
                    command.Parameters.AddWithValue("@Dipartimento", _dipartimento);
                    command.Parameters.AddWithValue("@DataNascita", _nascita);
                    command.Parameters.AddWithValue("@DataIscrizione", _iscrizione);
                    command.Parameters.AddWithValue("@Stipendio", _stipendio);
                    command.Parameters.AddWithValue("@Key", Key);

                    // Esegui il comando SQL con parametri
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Impiegato Aggiornato");
                        MostraDipartimenti();

                        // Cancella i campi del modulo dopo l'aggiornamento
                        Cancella();
                    }
                    else
                    {
                        MessageBox.Show("Nessun impiegato aggiornato.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Errore SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore generale: " + ex.Message);
            }
            finally
            {
                // Chiudi la connessione nel blocco finally per garantire che venga chiusa anche in caso di eccezioni
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (Key == 0)
				{
					MessageBox.Show("Errore!", "Dati mancanti!");
					return;
				}

				string deleteQuery = "DELETE FROM tab_Impiegati WHERE ImpId = @Key";

				// Usa il comando SQL parametrizzato per l'eliminazione
				using (SqlCommand command = new SqlCommand(deleteQuery, Con.GetConnection()))
				{
					// Aggiungi il parametro per l'ID dell'impiegato da eliminare
					command.Parameters.AddWithValue("@Key", Key);

					// Apri la connessione
					command.Connection.Open();

					// Esegui il comando SQL
					int rowsAffected = command.ExecuteNonQuery();

					// Chiudi la connessione
					command.Connection.Close();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Impiegato Cancellato");
						MostraDipartimenti();
						Cancella();
					}
					else
					{
						MessageBox.Show("Nessun impiegato eliminato.");
					}
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Errore SQL: " + ex.Message);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Errore generale: " + ex.Message);
			}
		}

		private void Cancella()
		{
			txtNome.Text = "";
			txtStipendioGiornaliero.Text = "";
			comboGenere.SelectedIndex = -1;
			comboDip.SelectedIndex = -1;
		}

		private void lblStipendi_Click(object sender, EventArgs e)
		{
			// Crea una nuova istanza del form frmImpiegati
			frmStipendi stipendi = new frmStipendi();

			// Mostra il form frmImpiegati
			stipendi.Show();

			// Nascondi il form corrente
			this.Hide();
		}
	}
}
