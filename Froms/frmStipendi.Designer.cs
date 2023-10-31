namespace ERP_Management_System.Froms
{
	partial class frmStipendi
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStipendi));
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.ListStipendi = new Guna.UI2.WinForms.Guna2DataGridView();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblDipendente = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this._dipendente = new System.Windows.Forms.ComboBox();
			this.txtGiorniPartecipazione = new System.Windows.Forms.TextBox();
			this._Periodo = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.txtImporto = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.ListStipendi)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.LightSeaGreen;
			this.btnUpdate.FlatAppearance.BorderSize = 0;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(223, 743);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(145, 36);
			this.btnUpdate.TabIndex = 44;
			this.btnUpdate.Text = "Modifica";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Teal;
			this.btnAdd.FlatAppearance.BorderSize = 50;
			this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(43, 743);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(145, 36);
			this.btnAdd.TabIndex = 43;
			this.btnAdd.Text = "Aggiungi";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// ListStipendi
			// 
			dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
			this.ListStipendi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ListStipendi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
			this.ListStipendi.ColumnHeadersHeight = 25;
			this.ListStipendi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ListStipendi.DefaultCellStyle = dataGridViewCellStyle18;
			this.ListStipendi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListStipendi.Location = new System.Drawing.Point(676, 306);
			this.ListStipendi.Name = "ListStipendi";
			this.ListStipendi.RowHeadersVisible = false;
			this.ListStipendi.Size = new System.Drawing.Size(781, 473);
			this.ListStipendi.TabIndex = 40;
			this.ListStipendi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ListStipendi.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ListStipendi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ListStipendi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ListStipendi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ListStipendi.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ListStipendi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListStipendi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
			this.ListStipendi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ListStipendi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListStipendi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ListStipendi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ListStipendi.ThemeStyle.HeaderStyle.Height = 25;
			this.ListStipendi.ThemeStyle.ReadOnly = false;
			this.ListStipendi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ListStipendi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ListStipendi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ListStipendi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ListStipendi.ThemeStyle.RowsStyle.Height = 22;
			this.ListStipendi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ListStipendi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ListStipendi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListStipendi_CellContentClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(109, 128);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(150, 106);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 37;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Teal;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 855);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1578, 21);
			this.panel2.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Teal;
			this.label5.Location = new System.Drawing.Point(43, 537);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 20);
			this.label5.TabIndex = 32;
			this.label5.Text = "Importo dello stipendio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Teal;
			this.label4.Location = new System.Drawing.Point(43, 358);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 20);
			this.label4.TabIndex = 30;
			this.label4.Text = "Giorni di Partecipazione";
			// 
			// lblDipendente
			// 
			this.lblDipendente.AutoSize = true;
			this.lblDipendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDipendente.ForeColor = System.Drawing.Color.Teal;
			this.lblDipendente.Location = new System.Drawing.Point(43, 270);
			this.lblDipendente.Name = "lblDipendente";
			this.lblDipendente.Size = new System.Drawing.Size(102, 20);
			this.lblDipendente.TabIndex = 29;
			this.lblDipendente.Text = "Dipendente";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Teal;
			this.label2.Location = new System.Drawing.Point(975, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(174, 20);
			this.label2.TabIndex = 27;
			this.label2.Text = "Gestione Dipendenti";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(657, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(332, 31);
			this.label3.TabIndex = 0;
			this.label3.Text = "ERP Management System";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(657, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "ERP Management System";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Teal;
			this.label6.Location = new System.Drawing.Point(43, 449);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 20);
			this.label6.TabIndex = 31;
			this.label6.Text = "Periodo";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1578, 100);
			this.panel1.TabIndex = 26;
			// 
			// _dipendente
			// 
			this._dipendente.FormattingEnabled = true;
			this._dipendente.Location = new System.Drawing.Point(43, 293);
			this._dipendente.Name = "_dipendente";
			this._dipendente.Size = new System.Drawing.Size(321, 28);
			this._dipendente.TabIndex = 45;
			this._dipendente.SelectionChangeCommitted += new System.EventHandler(this._dipendente_SelectionChangeCommitted);
			// 
			// txtGiorniPartecipazione
			// 
			this.txtGiorniPartecipazione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtGiorniPartecipazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGiorniPartecipazione.Location = new System.Drawing.Point(39, 381);
			this.txtGiorniPartecipazione.Name = "txtGiorniPartecipazione";
			this.txtGiorniPartecipazione.Size = new System.Drawing.Size(325, 26);
			this.txtGiorniPartecipazione.TabIndex = 46;
			// 
			// _Periodo
			// 
			this._Periodo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this._Periodo.Checked = true;
			this._Periodo.FillColor = System.Drawing.Color.Teal;
			this._Periodo.Font = new System.Drawing.Font("Segoe UI", 9F);
			this._Periodo.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this._Periodo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this._Periodo.Location = new System.Drawing.Point(43, 472);
			this._Periodo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this._Periodo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this._Periodo.Name = "_Periodo";
			this._Periodo.Size = new System.Drawing.Size(321, 28);
			this._Periodo.TabIndex = 47;
			this._Periodo.Value = new System.DateTime(2023, 9, 29, 9, 51, 47, 973);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Teal;
			this.label11.Location = new System.Drawing.Point(1420, 214);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(43, 20);
			this.label11.TabIndex = 70;
			this.label11.Text = "Esci";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(1363, 187);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(51, 47);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 69;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Teal;
			this.label12.Location = new System.Drawing.Point(1210, 214);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(75, 20);
			this.label12.TabIndex = 68;
			this.label12.Text = "Stipendi";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(1153, 187);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(51, 47);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 67;
			this.pictureBox7.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Teal;
			this.label13.Location = new System.Drawing.Point(997, 214);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(106, 20);
			this.label13.TabIndex = 66;
			this.label13.Text = "Dipartimenti";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Teal;
			this.label14.Location = new System.Drawing.Point(755, 214);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(106, 20);
			this.label14.TabIndex = 65;
			this.label14.Text = "Dipartimenti";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(940, 187);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(51, 47);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 64;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(698, 187);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(51, 47);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox9.TabIndex = 63;
			this.pictureBox9.TabStop = false;
			// 
			// txtImporto
			// 
			this.txtImporto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtImporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImporto.ForeColor = System.Drawing.Color.Teal;
			this.txtImporto.Location = new System.Drawing.Point(43, 560);
			this.txtImporto.Name = "txtImporto";
			this.txtImporto.Size = new System.Drawing.Size(325, 19);
			this.txtImporto.TabIndex = 71;
			this.txtImporto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// frmStipendi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1578, 876);
			this.Controls.Add(this.txtImporto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this._Periodo);
			this.Controls.Add(this.txtGiorniPartecipazione);
			this.Controls.Add(this._dipendente);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.ListStipendi);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblDipendente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "frmStipendi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmStipendi";
			((System.ComponentModel.ISupportInitialize)(this.ListStipendi)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private Guna.UI2.WinForms.Guna2DataGridView ListStipendi;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblDipendente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox _dipendente;
		private System.Windows.Forms.TextBox txtGiorniPartecipazione;
		private Guna.UI2.WinForms.Guna2DateTimePicker _Periodo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.TextBox txtImporto;
	}
}