using ERP_Management_System.Configurazione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using System.Windows.Input;

namespace ERP_Management_System.Froms
{
	public partial class frmApuntamento : Form
	{
		// Metode Call
		// Create Obj of Class
		DataAccess objData = new DataAccess();
		Functions Con;
		SqlCommand command;
		SqlConnection connection;

		public string _nomeSocieta, _citta, _offerta, _email, _posizione, _oraColloquio;
		public int _contatto, Key = 0;
		public frmApuntamento()
		{
			InitializeComponent();
			objData = new DataAccess();
			Con = new Functions();
			MostraColloquio();
		}

		private void MostraColloquio()
		{
			string selectAllColloquio = "SELECT * FROM tab_Colloquio";
			listAppuntamento.DataSource = Con.GetData(selectAllColloquio);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtNameSocieta.Text == "" || listCitta.SelectedIndex == -1 || txtTipoOfferta.Text == ""  
					|| txtEmail.Text == "" || txtContatto.Text == "" || _ora.SelectedIndex == -1 || txtPosizione.Text == "")
				{
					MessageBox.Show("Errore!", "Dati mancanti!");
				}
				else
				{
					GetData(out _nomeSocieta, out _citta, out _offerta, out _email, out _contatto, out _posizione, out _oraColloquio);

					DateTime _dataColloquio;
					if (DateTime.TryParse(_Data.Value.ToString(), out _dataColloquio) == false)
					{
						MessageBox.Show("Data di colloquiio non valida!");
						return;
					}


					// Creazione di un oggetto SqlCommand per eseguire un'operazione di inserimento
					string insertQuery = "INSERT INTO tab_Colloquio (NomeSocieta, Citta, TipoOfferta, EmailSocieta, ContattoSocieta, Posizione, DataColloquio, OraColloquio) " +
										 "VALUES (@NomeSocieta, @Citta, @TipoOfferta, @EmailSocieta, @ContattoSocieta, @Posizione, @DataColloquio, @OraColloquio)";


					using (connection = new SqlConnection(objData.ConString()))
					{
						connection.Open();

						using (command = new SqlCommand(insertQuery, connection))
						{
							// Parametri per l'inserimento
							command.Parameters.AddWithValue("@NomeSocieta", _nomeSocieta);
							command.Parameters.AddWithValue("@Citta", _citta);
							command.Parameters.AddWithValue("@TipoOfferta", _offerta);
							command.Parameters.AddWithValue("@EmailSocieta", _email);
							command.Parameters.AddWithValue("@ContattoSocieta", _contatto);
							command.Parameters.AddWithValue("@Posizione", _posizione);
							command.Parameters.AddWithValue("@DataColloquio", _dataColloquio);
							command.Parameters.AddWithValue("@OraColloquio", _oraColloquio);

							int rowsAffected = command.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								MostraColloquio();
								MessageBox.Show("Colloquio  aggiunto");
								Cancella();
							}
							else
							{
								MessageBox.Show("Errore durante l'inserimento dell'colloquio.");
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

		private void GetData(out string _nomeSocieta, out string _citta, out string _offerta, out string _email, out int _contatto, out string _posizione, out string _oraColloquio)
		{
			_nomeSocieta = txtNameSocieta.Text;
			_citta = Convert.ToString(listCitta.SelectedItem);
			_offerta = txtTipoOfferta.Text;
			_email = txtEmail.Text;
			_contatto = Convert.ToInt32(txtContatto.Text.ToString());
			_posizione = Convert.ToString(txtPosizione.Text);
			_oraColloquio = Convert.ToString(_ora.SelectedItem);
		}

		private void listApuntamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// Verifica se è stata selezionata almeno una riga
			if (listAppuntamento.SelectedRows.Count > 0)
			{
				// Ottieni la riga selezionata
				DataGridViewRow selectedRow = listAppuntamento.SelectedRows[0];

				// Assegna i valori delle celle alla UI
				txtNameSocieta.Text = selectedRow.Cells["NomeSocieta"].Value.ToString();
				listCitta.SelectedValue = selectedRow.Cells["Citta"].Value.ToString();
				txtTipoOfferta.Text = selectedRow.Cells["TipoOfferta"].Value.ToString();
				txtEmail.Text = selectedRow.Cells["EmailSocieta"].Value.ToString();
				txtContatto.Text = selectedRow.Cells["ContattoSocieta"].Value.ToString();
				txtPosizione.Text = selectedRow.Cells["Posizione"].Value.ToString();
				_Data.Text = selectedRow.Cells["DataColloquio"].Value.ToString();
				_ora.SelectedValue = selectedRow.Cells["OraColloquio"].Value.ToString();


				// Verifica se il campo NomeSocieta è vuoto o nullo
				if (string.IsNullOrEmpty(txtNameSocieta.Text))
				{
					Key = 0; // Imposta la chiave su 0
				}
				else
				{
					// Assegna il valore ColId alla chiave se è disponibile
					Key = Convert.ToInt32(selectedRow.Cells["ColId"].Value);
				}
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			SqlConnection connection = null;

			try
			{
				if (txtNameSocieta.Text == "" || listCitta.SelectedIndex == -1 || txtTipoOfferta.Text == ""
					|| txtEmail.Text == "" || txtContatto.Text == "" || txtPosizione.Text == "" || _ora.SelectedIndex == -1)
				{
					MessageBox.Show("Errore!", "Dati mancanti!");
					return;
				}

				// Verifica che Key contenga un valore valido
				if (Key <= 0)
				{
					MessageBox.Show("Seleziona un Colloquio valido da aggiornare.");
					return;
				}

				GetData(out _nomeSocieta, out _citta, out _offerta, out _email, out _contatto, out _posizione, out _oraColloquio);


				DateTime _dataColloquio;
				if (DateTime.TryParse(_Data.Value.ToString(), out _dataColloquio) == false)
				{
					MessageBox.Show("Data di colloquiio non valida!");
					return;
				}

				// Ottieni la connessione dal tuo oggetto Con (supponendo che sia un'istanza di DatabaseHandler)
				connection = Con.GetConnection();

				// Apri la connessione
				connection.Open();

				// Definisci la query SQL con parametri
				string _query = "UPDATE tab_Colloquio " +
								"SET NomeSocieta = @NomeSocieta, " +
									"Citta = @Citta, " +
									"TipoOfferta = @TipoOfferta, " +
									"EmailSocieta = @EmailSocieta, " +
									"ContattoSocieta = @ContattoSocieta, " +
									"Posizione = @Posizione, " +
									"DataColloquio = @DataColloquio, " +
									"OraColloquio = @OraColloquio " +
								"WHERE ColId = @Key";

				// Crea un nuovo comando SQL con la query e la connessione
				using (command = new SqlCommand(_query, connection))
				{
					// Aggiungi i parametri con i valori appropriati
					command.Parameters.AddWithValue("@NomeSocieta", _nomeSocieta);
					command.Parameters.AddWithValue("@Citta", _citta);
					command.Parameters.AddWithValue("@TipoOfferta", _offerta);
					command.Parameters.AddWithValue("@EmailSocieta", _email);
					command.Parameters.AddWithValue("@ContattoSocieta", _contatto);
					command.Parameters.AddWithValue("@Posizione", _posizione);
					command.Parameters.AddWithValue("@DataColloquio", _dataColloquio);
					command.Parameters.AddWithValue("@OraColloquio", _oraColloquio);
					command.Parameters.AddWithValue("@Key", Key);

					// Esegui il comando SQL con parametri
					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show($"Il colloquio N°{Key} è stato modificato");
						MostraColloquio();

						// Cancella i campi del modulo dopo l'aggiornamento
						Cancella();
					}
					else
					{
						MessageBox.Show("Nessun Colloquio aggiornato.");
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

		private void Cancella()
		{
			txtNameSocieta.Text = "";
			listCitta.SelectedIndex = -1;
			txtEmail.Text = "";
			txtTipoOfferta.Text = "";
			txtContatto.Text = "";
			txtPosizione.Text = "";
			_ora.SelectedIndex = -1;
		}

		private void btnDelet_Click(object sender, EventArgs e)
		{
			try
			{
				if (Key == 0)
				{
					MessageBox.Show("Errore!", "Dati mancanti!");
					return;
				}

				string deleteQuery = "DELETE FROM tab_Colloquio WHERE ColId = @Key";

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
						MessageBox.Show($"Colloquio {Key} Cancellato");
						MostraColloquio();
						Cancella();
					}
					else
					{
						MessageBox.Show("Nessun Colloquio eliminato.");
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
	}
}
