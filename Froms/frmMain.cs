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
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void Dipartimenti()
		{
			frmDipartimenti dipartimenti = new frmDipartimenti();
			dipartimenti.Show();
			this.Hide();
		}

		private void Impiegati()
		{
			frmImpiegati impiegati = new frmImpiegati();
			impiegati.Show();
			this.Hide();
		}

		private void Login()
		{
			frmDashboard login = new frmDashboard();
			login.Show();
			this.Hide();
		}

        private void Dashboard()
        {
            frmDashboard dash = new frmDashboard();
            dash.Show();
            this.Hide();
        }
    
        private void Stipendio()
		{
			frmStipendi stipendi = new frmStipendi();
			stipendi.Show();
			this.Hide();
		}

		private void Colloquio()
		{
			frmApuntamento apuntamento = new frmApuntamento();
			apuntamento.Show();
			this.Hide();
		}

		// code color teal = #008080

		private void lblDipartimenti_Click(object sender, EventArgs e)
		{
			Dipartimenti();
		}
		private void _dipartimento_Click(object sender, EventArgs e)
		{
			Dipartimenti();
		}

		private void _colloquio_Click(object sender, EventArgs e)
		{
			Colloquio();
		}

		private void lblColloquio_Click(object sender, EventArgs e)
		{
			Colloquio();
		}

		private void lblStipendio_Click(object sender, EventArgs e)
		{
			Stipendio();
		}

		private void lblStipendio_Click_1(object sender, EventArgs e)
		{
			Stipendio();
		}

		private void lblDipendenti_Click(object sender, EventArgs e)
		{
			Impiegati();
		}
		private void _impiegati_Click_1(object sender, EventArgs e)
		{
			Impiegati();
		}

        private void _dashboard_Click(object sender, EventArgs e)
        {
			Dashboard();
        }

        private void lblDasboard_Click(object sender, EventArgs e)
        {
			Dashboard();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
