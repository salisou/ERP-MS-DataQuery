using ERP_Management_System.Configurazione;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_Management_System.Froms
{
	public partial class frmDipartimenti : Form
	{
		int Key = 0;
		Functions Con;
        public frmDipartimenti()
		{
			InitializeComponent();
            Con = new Functions();
            MostraDipartimenti();
		}

		private void MostraDipartimenti()
		{
            try
            {
			    string Query = "SELECT * FROM tab_Dipartimenti";
			    ListDip.DataSource = Con.GetData(Query);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ListDip_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se l'indice di riga è valido
            if (e.RowIndex >= 0 && e.RowIndex < ListDip.Rows.Count)
            {
                // Ottieni la riga selezionata dalla DataGridView
                DataGridViewRow selectedRow = ListDip.Rows[e.RowIndex];

                // Verifica se il valore nella cella [1] è diverso da null
                if (selectedRow.Cells[1].Value != null)
                {
                    // Imposta il testo del TextBox con il valore della cella [1]
                    txtNomeDipartimento.Text = selectedRow.Cells[1].Value.ToString();

                    // Verifica se il valore nella cella [0] è diverso da null
                    if (selectedRow.Cells[0].Value != null)
                    {
                        // Prova a convertire il valore della cella [0] in un intero (ID) e assegnalo a Key
                        if (int.TryParse(selectedRow.Cells[0].Value.ToString(), out int keyValue))
                        {
                            Key = keyValue;
                        }
                        else
                        {
                            // Se la conversione fallisce, imposta Key a 0
                            Key = 0;
                        }
                    }
                    else
                    {
                        // Se la cella [0] è null, imposta Key a 0
                        Key = 0;
                    }
                }
                else
                {
                    // Se la cella [1] è null, imposta il testo del TextBox su una stringa vuota
                    txtNomeDipartimento.Text = string.Empty;

                    // Imposta Key a 0
                    Key = 0;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se il campo del nome del dipartimento è vuoto
                if (txtNomeDipartimento.Text == "")
                {
                    MessageBox.Show("Errore!", "Dati mancanti!");
                }
                else
                {
                    // Recupera il nome del dipartimento dalla casella di testo
                    string _dipartimento = txtNomeDipartimento.Text;

                    // Definisci una query SQL per l'inserimento di un nuovo dipartimento
                    string _query = "INSERT INTO tab_Dipartimenti (NomeDipartimente) VALUES ('{0}')";

                    // Formatta la query SQL con il nome del dipartimento
                    _query = string.Format(_query, txtNomeDipartimento.Text);

                    // Esegui la query di inserimento nel database utilizzando l'oggetto Con
                    Con.SetData(_query);

                    // Aggiorna la visualizzazione dei dipartimenti
                    MostraDipartimenti();

                    // Mostra un messaggio di conferma
                    MessageBox.Show("Dipartimento Aggiunto");

                    // Cancella il testo nella casella di testo del nome del dipartimento
                    txtNomeDipartimento.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Gestisci le eccezioni mostrando un messaggio di errore
                MessageBox.Show(ex.Message);
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
		{
            try
            {
                // Verifica se il campo del nome del dipartimento è vuoto
                if (txtNomeDipartimento.Text == "")
                {
                    MessageBox.Show("Errore!", "Dati mancanti!");
                }
                else
                {
                    // Recupera il nome del dipartimento dalla casella di testo
                    string _dipartimento = txtNomeDipartimento.Text;

                    // Definisci una query SQL per l'aggiornamento del dipartimento
                    // Utilizza il valore di Key (presumibilmente l'ID del dipartimento) per specificare quale dipartimento aggiornare
                    string _query = "UPDATE tab_Dipartimenti SET NomeDipartimente = '{0}' WHERE DipId = {1}";

                    // Formatta la query SQL con il nome del dipartimento e il valore di Key
                    _query = string.Format(_query, txtNomeDipartimento.Text, Key);

                    // Esegui la query di aggiornamento nel database utilizzando l'oggetto Con
                    Con.SetData(_query);

                    // Aggiorna la visualizzazione dei dipartimenti
                    MostraDipartimenti();

                    // Mostra un messaggio di conferma
                    MessageBox.Show("Dipartimento Modificato");

                    // Cancella il testo nella casella di testo del nome del dipartimento
                    txtNomeDipartimento.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Gestisci le eccezioni mostrando un messaggio di errore
                MessageBox.Show(ex.Message);
            }
        }

		private void btnDelet_Click(object sender, EventArgs e)
		{
            try
            {
                // Verifica se il campo del nome del dipartimento è vuoto
                if (txtNomeDipartimento.Text == "")
                {
                    MessageBox.Show("Errore!", "Dati mancanti!");
                }
                else
                {
                    // Definisci una query SQL per la cancellazione del dipartimento
                    // Utilizza il valore di Key (presumibilmente l'ID del dipartimento) per specificare quale dipartimento cancellare
                    string _query = "DELETE FROM tab_Dipartimenti WHERE DipId = {0}";

                    // Formatta la query SQL con il valore di Key
                    _query = string.Format(_query, Key);

                    // Esegui la query di cancellazione nel database utilizzando l'oggetto Con
                    Con.SetData(_query);

                    // Aggiorna la visualizzazione dei dipartimenti
                    MostraDipartimenti();

                    // Mostra un messaggio di conferma
                    MessageBox.Show("Dipartimento Cancellato");

                    // Cancella il testo nella casella di testo del nome del dipartimento
                    txtNomeDipartimento.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Gestisci le eccezioni mostrando un messaggio di errore
                MessageBox.Show(ex.Message);
            }
        }

		private void lblDipendenti_Click(object sender, EventArgs e)
		{
            // Crea una nuova istanza del form frmImpiegati
            frmImpiegati dipendenti = new frmImpiegati();

            // Mostra il form frmImpiegati
            dipendenti.Show();

            // Nascondi il form corrente
            this.Hide();
        }

		private void lblDipartimenti_Click(object sender, EventArgs e)
		{
			// Crea una nuova istanza del form frmImpiegati
			frmDipartimenti dipartimenti = new frmDipartimenti();

			// Mostra il form frmImpiegati
			dipartimenti.Show();

			// Nascondi il form corrente
			this.Hide();
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

		private void lblEsci_Click(object sender, EventArgs e)
		{
            Close();
		}
	}
}
