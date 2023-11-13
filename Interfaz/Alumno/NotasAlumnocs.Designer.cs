namespace SistemaDeNotas.Interfaz.Alumno
{
    partial class NotasAlumnocs
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
			this.txtpromedio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupbox = new System.Windows.Forms.GroupBox();
			this.dgvNotas = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEstadoMateria = new System.Windows.Forms.TextBox();
			this.groupbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtpromedio
			// 
			this.txtpromedio.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtpromedio.BackColor = System.Drawing.Color.White;
			this.txtpromedio.Enabled = false;
			this.txtpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpromedio.Location = new System.Drawing.Point(68, 47);
			this.txtpromedio.Margin = new System.Windows.Forms.Padding(2);
			this.txtpromedio.Multiline = true;
			this.txtpromedio.Name = "txtpromedio";
			this.txtpromedio.Size = new System.Drawing.Size(62, 38);
			this.txtpromedio.TabIndex = 7;
			this.txtpromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(318, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(34, 37, 34, 37);
			this.label1.Size = new System.Drawing.Size(336, 110);
			this.label1.TabIndex = 4;
			this.label1.Text = "Consulta de Notas.";
			// 
			// groupbox
			// 
			this.groupbox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupbox.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.groupbox.Controls.Add(this.txtpromedio);
			this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupbox.ForeColor = System.Drawing.Color.Black;
			this.groupbox.Location = new System.Drawing.Point(96, 521);
			this.groupbox.Margin = new System.Windows.Forms.Padding(2);
			this.groupbox.Name = "groupbox";
			this.groupbox.Padding = new System.Windows.Forms.Padding(2);
			this.groupbox.Size = new System.Drawing.Size(201, 109);
			this.groupbox.TabIndex = 0;
			this.groupbox.TabStop = false;
			this.groupbox.Text = "  Promedio Final";
			// 
			// dgvNotas
			// 
			this.dgvNotas.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNotas.Location = new System.Drawing.Point(21, 161);
			this.dgvNotas.Margin = new System.Windows.Forms.Padding(2);
			this.dgvNotas.Name = "dgvNotas";
			this.dgvNotas.RowHeadersWidth = 51;
			this.dgvNotas.RowTemplate.Height = 24;
			this.dgvNotas.Size = new System.Drawing.Size(955, 332);
			this.dgvNotas.TabIndex = 9;
			this.dgvNotas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotas_RowHeaderMouseClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.groupBox1.Controls.Add(this.txtEstadoMateria);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(594, 521);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(201, 109);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Estado Materia";
			// 
			// txtEstadoMateria
			// 
			this.txtEstadoMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtEstadoMateria.BackColor = System.Drawing.Color.White;
			this.txtEstadoMateria.Enabled = false;
			this.txtEstadoMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEstadoMateria.Location = new System.Drawing.Point(4, 47);
			this.txtEstadoMateria.Margin = new System.Windows.Forms.Padding(2);
			this.txtEstadoMateria.Multiline = true;
			this.txtEstadoMateria.Name = "txtEstadoMateria";
			this.txtEstadoMateria.Size = new System.Drawing.Size(193, 38);
			this.txtEstadoMateria.TabIndex = 0;
			this.txtEstadoMateria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// NotasAlumnocs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 640);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dgvNotas);
			this.Controls.Add(this.groupbox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "NotasAlumnocs";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "NotasAlumnocs";
			this.Load += new System.EventHandler(this.NotasAlumnocs_Load);
			this.groupbox.ResumeLayout(false);
			this.groupbox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.DataGridView dgvNotas;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtEstadoMateria;
	}
}