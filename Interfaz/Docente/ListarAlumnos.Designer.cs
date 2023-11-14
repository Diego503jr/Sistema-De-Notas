namespace SistemaDeNotas.Interfaz.Docente
{
	partial class ListarAlumnos
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
			this.dgvListarAlumnos = new System.Windows.Forms.DataGridView();
			this.lblConsultaAlumnosInscritos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvListarAlumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvListarAlumnos
			// 
			this.dgvListarAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dgvListarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListarAlumnos.Location = new System.Drawing.Point(185, 335);
			this.dgvListarAlumnos.Name = "dgvListarAlumnos";
			this.dgvListarAlumnos.Size = new System.Drawing.Size(569, 186);
			this.dgvListarAlumnos.TabIndex = 0;
			// 
			// lblConsultaAlumnosInscritos
			// 
			this.lblConsultaAlumnosInscritos.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblConsultaAlumnosInscritos.AutoSize = true;
			this.lblConsultaAlumnosInscritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.lblConsultaAlumnosInscritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConsultaAlumnosInscritos.ForeColor = System.Drawing.Color.White;
			this.lblConsultaAlumnosInscritos.Location = new System.Drawing.Point(210, 159);
			this.lblConsultaAlumnosInscritos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblConsultaAlumnosInscritos.Name = "lblConsultaAlumnosInscritos";
			this.lblConsultaAlumnosInscritos.Padding = new System.Windows.Forms.Padding(34, 37, 34, 37);
			this.lblConsultaAlumnosInscritos.Size = new System.Drawing.Size(495, 110);
			this.lblConsultaAlumnosInscritos.TabIndex = 0;
			this.lblConsultaAlumnosInscritos.Text = "Consulta de Alumnos Inscritos.";
			// 
			// ListarAlumnos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 568);
			this.Controls.Add(this.lblConsultaAlumnosInscritos);
			this.Controls.Add(this.dgvListarAlumnos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ListarAlumnos";
			this.Text = "ListarAlumnos";
			this.Load += new System.EventHandler(this.ListarAlumnos_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvListarAlumnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvListarAlumnos;
		private System.Windows.Forms.Label lblConsultaAlumnosInscritos;
	}
}