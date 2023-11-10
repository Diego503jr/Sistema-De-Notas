namespace SistemaDeNotas
{
	partial class CursosAlumno
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
			this.lblCursos = new System.Windows.Forms.Label();
			this.dgvCursos = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCursos
			// 
			this.lblCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblCursos.AutoSize = true;
			this.lblCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCursos.ForeColor = System.Drawing.Color.White;
			this.lblCursos.Location = new System.Drawing.Point(319, 9);
			this.lblCursos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCursos.Name = "lblCursos";
			this.lblCursos.Padding = new System.Windows.Forms.Padding(34, 37, 34, 37);
			this.lblCursos.Size = new System.Drawing.Size(345, 110);
			this.lblCursos.TabIndex = 5;
			this.lblCursos.Text = "Consulta de Cursos";
			// 
			// dgvCursos
			// 
			this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCursos.Location = new System.Drawing.Point(63, 215);
			this.dgvCursos.Name = "dgvCursos";
			this.dgvCursos.Size = new System.Drawing.Size(903, 201);
			this.dgvCursos.TabIndex = 6;
			// 
			// CursosAlumno
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 548);
			this.Controls.Add(this.dgvCursos);
			this.Controls.Add(this.lblCursos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CursosAlumno";
			this.Text = "CursosAlumno";
			this.Load += new System.EventHandler(this.CursosAlumno_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCursos;
		private System.Windows.Forms.DataGridView dgvCursos;
	}
}