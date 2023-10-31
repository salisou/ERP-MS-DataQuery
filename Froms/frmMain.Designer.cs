namespace ERP_Management_System.Froms
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this._dashboard = new Guna.UI2.WinForms.Guna2ImageButton();
            this._dipartimento = new Guna.UI2.WinForms.Guna2ImageButton();
            this._impiegati = new Guna.UI2.WinForms.Guna2ImageButton();
            this._stipendio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDipartimenti = new System.Windows.Forms.Label();
            this.lblColloquio = new System.Windows.Forms.Label();
            this._colloquio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDasboard = new System.Windows.Forms.Label();
            this.lblStipendio = new System.Windows.Forms.Label();
            this.lblDipendenti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _dashboard
            // 
            this._dashboard.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this._dashboard.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this._dashboard.Image = ((System.Drawing.Image)(resources.GetObject("_dashboard.Image")));
            this._dashboard.ImageOffset = new System.Drawing.Point(0, 0);
            this._dashboard.ImageRotate = 0F;
            this._dashboard.Location = new System.Drawing.Point(348, 166);
            this._dashboard.Name = "_dashboard";
            this._dashboard.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this._dashboard.Size = new System.Drawing.Size(129, 124);
            this._dashboard.TabIndex = 0;
            this._dashboard.Click += new System.EventHandler(this._dashboard_Click);
            // 
            // _dipartimento
            // 
            this._dipartimento.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this._dipartimento.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this._dipartimento.Image = ((System.Drawing.Image)(resources.GetObject("_dipartimento.Image")));
            this._dipartimento.ImageOffset = new System.Drawing.Point(0, 0);
            this._dipartimento.ImageRotate = 0F;
            this._dipartimento.Location = new System.Drawing.Point(69, 25);
            this._dipartimento.Name = "_dipartimento";
            this._dipartimento.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this._dipartimento.Size = new System.Drawing.Size(143, 139);
            this._dipartimento.TabIndex = 1;
            this._dipartimento.Click += new System.EventHandler(this._dipartimento_Click);
            // 
            // _impiegati
            // 
            this._impiegati.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this._impiegati.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this._impiegati.Image = ((System.Drawing.Image)(resources.GetObject("_impiegati.Image")));
            this._impiegati.ImageOffset = new System.Drawing.Point(0, 0);
            this._impiegati.ImageRotate = 0F;
            this._impiegati.Location = new System.Drawing.Point(604, 301);
            this._impiegati.Name = "_impiegati";
            this._impiegati.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this._impiegati.Size = new System.Drawing.Size(129, 105);
            this._impiegati.TabIndex = 2;
            this._impiegati.Click += new System.EventHandler(this._impiegati_Click_1);
            // 
            // _stipendio
            // 
            this._stipendio.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this._stipendio.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this._stipendio.Image = ((System.Drawing.Image)(resources.GetObject("_stipendio.Image")));
            this._stipendio.ImageOffset = new System.Drawing.Point(0, 0);
            this._stipendio.ImageRotate = 0F;
            this._stipendio.Location = new System.Drawing.Point(69, 288);
            this._stipendio.Name = "_stipendio";
            this._stipendio.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this._stipendio.Size = new System.Drawing.Size(129, 130);
            this._stipendio.TabIndex = 4;
            // 
            // lblDipartimenti
            // 
            this.lblDipartimenti.AutoSize = true;
            this.lblDipartimenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipartimenti.ForeColor = System.Drawing.Color.Teal;
            this.lblDipartimenti.Location = new System.Drawing.Point(89, 131);
            this.lblDipartimenti.Name = "lblDipartimenti";
            this.lblDipartimenti.Size = new System.Drawing.Size(106, 20);
            this.lblDipartimenti.TabIndex = 5;
            this.lblDipartimenti.Text = "Dipartimenti";
            this.lblDipartimenti.Click += new System.EventHandler(this.lblDipartimenti_Click);
            // 
            // lblColloquio
            // 
            this.lblColloquio.AutoSize = true;
            this.lblColloquio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColloquio.ForeColor = System.Drawing.Color.Teal;
            this.lblColloquio.Location = new System.Drawing.Point(615, 122);
            this.lblColloquio.Name = "lblColloquio";
            this.lblColloquio.Size = new System.Drawing.Size(83, 20);
            this.lblColloquio.TabIndex = 6;
            this.lblColloquio.Text = "Colloquio";
            this.lblColloquio.Click += new System.EventHandler(this.lblColloquio_Click);
            // 
            // _colloquio
            // 
            this._colloquio.BackColor = System.Drawing.Color.Transparent;
            this._colloquio.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this._colloquio.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this._colloquio.HoverState.ImageSize = new System.Drawing.Size(90, 64);
            this._colloquio.Image = ((System.Drawing.Image)(resources.GetObject("_colloquio.Image")));
            this._colloquio.ImageOffset = new System.Drawing.Point(0, 0);
            this._colloquio.ImageRotate = 0F;
            this._colloquio.ImageSize = new System.Drawing.Size(90, 90);
            this._colloquio.Location = new System.Drawing.Point(582, 12);
            this._colloquio.Name = "_colloquio";
            this._colloquio.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this._colloquio.PressedState.ImageSize = new System.Drawing.Size(90, 64);
            this._colloquio.Size = new System.Drawing.Size(151, 166);
            this._colloquio.TabIndex = 3;
            this._colloquio.Click += new System.EventHandler(this._colloquio_Click);
            // 
            // lblDasboard
            // 
            this.lblDasboard.AutoSize = true;
            this.lblDasboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDasboard.ForeColor = System.Drawing.Color.Teal;
            this.lblDasboard.Location = new System.Drawing.Point(369, 270);
            this.lblDasboard.Name = "lblDasboard";
            this.lblDasboard.Size = new System.Drawing.Size(87, 20);
            this.lblDasboard.TabIndex = 7;
            this.lblDasboard.Text = "Dashbord";
            this.lblDasboard.Click += new System.EventHandler(this.lblDasboard_Click);
            // 
            // lblStipendio
            // 
            this.lblStipendio.AutoSize = true;
            this.lblStipendio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStipendio.ForeColor = System.Drawing.Color.Teal;
            this.lblStipendio.Location = new System.Drawing.Point(89, 386);
            this.lblStipendio.Name = "lblStipendio";
            this.lblStipendio.Size = new System.Drawing.Size(85, 20);
            this.lblStipendio.TabIndex = 8;
            this.lblStipendio.Text = "Stipendio";
            this.lblStipendio.Click += new System.EventHandler(this.lblStipendio_Click_1);
            // 
            // lblDipendenti
            // 
            this.lblDipendenti.AutoSize = true;
            this.lblDipendenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDipendenti.ForeColor = System.Drawing.Color.Teal;
            this.lblDipendenti.Location = new System.Drawing.Point(621, 386);
            this.lblDipendenti.Name = "lblDipendenti";
            this.lblDipendenti.Size = new System.Drawing.Size(96, 20);
            this.lblDipendenti.TabIndex = 9;
            this.lblDipendenti.Text = "Dipendenti";
            this.lblDipendenti.Click += new System.EventHandler(this.lblDipendenti_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDipendenti);
            this.Controls.Add(this.lblStipendio);
            this.Controls.Add(this.lblDasboard);
            this.Controls.Add(this.lblColloquio);
            this.Controls.Add(this.lblDipartimenti);
            this.Controls.Add(this._stipendio);
            this.Controls.Add(this._colloquio);
            this.Controls.Add(this._impiegati);
            this.Controls.Add(this._dipartimento);
            this.Controls.Add(this._dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2ImageButton _dashboard;
		private Guna.UI2.WinForms.Guna2ImageButton _dipartimento;
		private Guna.UI2.WinForms.Guna2ImageButton _impiegati;
		private Guna.UI2.WinForms.Guna2ImageButton _stipendio;
		private System.Windows.Forms.Label lblDipartimenti;
		private System.Windows.Forms.Label lblColloquio;
		private Guna.UI2.WinForms.Guna2ImageButton _colloquio;
		private System.Windows.Forms.Label lblDasboard;
		private System.Windows.Forms.Label lblStipendio;
		private System.Windows.Forms.Label lblDipendenti;
	}
}