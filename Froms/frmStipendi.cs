using ERP_Management_System.Configurazione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ERP_Management_System.Froms
{
	public partial class frmStipendi : Form
	{
		DataAccess objData = new DataAccess();
		Functions Con;
		SqlCommand command;
		SqlConnection connection;
		public frmStipendi()
		{
			InitializeComponent();
			objData = new DataAccess();
			Con = new Functions();
			MostraStipendio();
			GetDipendenti();
		}

		private void GetDipendenti()
		{
			try
			{
				string Query = "SELECT * FROM tab_Impiegati";

				if (string.IsNullOrEmpty(Query))
				{
					MessageBox.Show($"Errore! durante la query {Query}");
				}
				else
				{
					_dipendente.DisplayMember = Con.GetData(Query).Columns["Nome"].ToString();
					_dipendente.ValueMember   = Con.GetData(Query).Columns["ImpId"].ToString();
					_dipendente.DataSource    = Con.GetData(Query);
				}

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void GetSaldo()
		{
			try
			{
				// Verifica che _dipendente.SelectedValue sia valido
				if (_dipendente.SelectedValue == null)
				{
					MessageBox.Show("Errore! Impiegato non valido.");
					return; // Esci dalla funzione in caso di errore
				}

				// Crea la query SQL correttamente utilizzando il parametro
				string impiegatoId = _dipendente.SelectedValue.ToString();
				int d = 1;
				int risultato = 0;
				string Query = $"SELECT StipendioGiornaliero FROM tab_Impiegati WHERE ImpId = {impiegatoId}";

				// Esegui la query
				foreach (DataRow row in Con.GetData(Query).Rows)
				{
					risultato = Convert.ToInt32(row["StipendioGiornaliero"]);
				}

				//recupero il valore dello Stipendio Giornaliero 
				if (txtGiorniPartecipazione.Text == "")
				{
					txtImporto.Text = "€ " + (d * risultato); ;
				}
				else if (Convert.ToInt32(txtGiorniPartecipazione.Text) > 31)
				{
					MessageBox.Show("I giorni non possono essere maggiori di 31");
				}
				else
				{
					d = Convert.ToInt32(txtImporto.Text);
					txtImporto.Text = "€ " + (d * risultato);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void MostraStipendio()
		{
			try
			{
				// Verifica che il controllo ListStipendi esista
				if (ListStipendi == null)
				{
					MessageBox.Show("Errore! Controllo ListStipendi non trovato.");
					return; // Esci dalla funzione in caso di errore
				}

				string selectStipendi = "SELECT * FROM tab_Stipendi";

				// Esegui la query SQL per ottenere gli stipendi
				DataTable stipendiTable = Con.GetData(selectStipendi);

				// Verifica se sono stati trovati stipendi
				if (stipendiTable != null && stipendiTable.Rows.Count > 0)
				{
					// Imposta la fonte dati del controllo ListStipendi
					ListStipendi.DataSource = stipendiTable;
				}
				else
				{
					MessageBox.Show("Nessun stipendio trovato.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Errore durante il recupero degli stipendi: {ex.Message}");
			}
		}

		private void ListStipendi_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_dipendente.SelectedIndex == -1 || txtGiorniPartecipazione.Text == "" || txtImporto.Text == "")
				{
					MessageBox.Show("Errore di caricameto dei dati! RIPROVA");
				}
				else
				{
					DateTime _data;
					if (DateTime.TryParse(_Periodo.Value.ToString(), out _data) == false)
					{
						MessageBox.Show("Data di colloquio non valida!");
						return;
					}

					// Creazione di un oggetto SqlCommand per eseguire un'operazione di inserimento
					string insertQuery = "INSERT INTO tab_Stipendi (Dipendente, GiorniPartecipazione, Periodo, ImportoStipendio) " +
										 "VALUES (@Dipendente, @GiorniPartecipazione, @Periodo, @ImportoStipendio)";

					// Recupera i valori dai controlli e convertili nei tipi di dati appropriati
					string dipendente = Convert.ToString(_dipendente.SelectedValue); // Supponendo che _dipendente contenga il nome del dipendente
					int giorni = Convert.ToInt32(txtGiorniPartecipazione.Text);
					string importo = Convert.ToString(txtImporto.Text);

					using (connection = new SqlConnection(objData.ConString()))
					{
						connection.Open();

						using (command = new SqlCommand(insertQuery, connection))
						{
							// Parametri per l'inserimento
							command.Parameters.AddWithValue("@Dipendente", dipendente);
							command.Parameters.AddWithValue("@GiorniPartecipazione", giorni);
							command.Parameters.AddWithValue("@Periodo", _data);
							command.Parameters.AddWithValue("@ImportoStipendio", importo);

							int rowsAffected = command.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								MostraStipendio();
								MessageBox.Show("Stipendio aggiunto");
								Cancella();
							}
							else
							{
								MessageBox.Show("Errore durante il salvataggio del saldo.");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		private void Cancella()
		{
			txtGiorniPartecipazione.Text = string.Empty; 
			_dipendente.SelectedIndex = -1;
			txtImporto.Text = string.Empty;
		}

		private void _dipendente_SelectionChangeCommitted(object sender, EventArgs e)
		{
			GetSaldo();
		}

		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void label11_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
