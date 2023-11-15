namespace SistemaDeNotas.Interfaz.Docente
{
	partial class NotasDocente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRegistroNotas = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.dgvNotasDocente = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cbRegistroNotas = new System.Windows.Forms.ComboBox();
            this.gfcNotas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtAprobados = new System.Windows.Forms.TextBox();
            this.txtReprobados = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDocente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblRegistroNotas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 68);
            this.panel1.TabIndex = 0;
            // 
            // lblRegistroNotas
            // 
            this.lblRegistroNotas.AutoSize = true;
            this.lblRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroNotas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegistroNotas.Location = new System.Drawing.Point(383, 20);
            this.lblRegistroNotas.Name = "lblRegistroNotas";
            this.lblRegistroNotas.Size = new System.Drawing.Size(303, 31);
            this.lblRegistroNotas.TabIndex = 1;
            this.lblRegistroNotas.Text = "REGISTRO DE NOTAS";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(366, 95);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(499, 29);
            this.txtNombre.TabIndex = 0;
            // 
            // txtNota1
            // 
            this.txtNota1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota1.Location = new System.Drawing.Point(222, 215);
            this.txtNota1.Multiline = true;
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(63, 34);
            this.txtNota1.TabIndex = 1;
            this.txtNota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota2
            // 
            this.txtNota2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota2.Location = new System.Drawing.Point(364, 215);
            this.txtNota2.Multiline = true;
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(63, 34);
            this.txtNota2.TabIndex = 2;
            this.txtNota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota3
            // 
            this.txtNota3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota3.Location = new System.Drawing.Point(504, 215);
            this.txtNota3.Multiline = true;
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(63, 34);
            this.txtNota3.TabIndex = 3;
            this.txtNota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNota4
            // 
            this.txtNota4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota4.Location = new System.Drawing.Point(663, 215);
            this.txtNota4.Multiline = true;
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(63, 34);
            this.txtNota4.TabIndex = 4;
            this.txtNota4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPromedio.Location = new System.Drawing.Point(870, 215);
            this.txtPromedio.Multiline = true;
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(63, 34);
            this.txtPromedio.TabIndex = 0;
            this.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvNotasDocente
            // 
            this.dgvNotasDocente.AllowUserToAddRows = false;
            this.dgvNotasDocente.AllowUserToDeleteRows = false;
            this.dgvNotasDocente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvNotasDocente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.dgvNotasDocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasDocente.Location = new System.Drawing.Point(166, 278);
            this.dgvNotasDocente.Name = "dgvNotasDocente";
            this.dgvNotasDocente.ReadOnly = true;
            this.dgvNotasDocente.RowHeadersWidth = 51;
            this.dgvNotasDocente.Size = new System.Drawing.Size(720, 195);
            this.dgvNotasDocente.TabIndex = 6;
            this.dgvNotasDocente.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNotasDocente_RowHeaderMouseClick);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(162, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(182, 24);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de Alumno:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Materia:";
            // 
            // lblNota1
            // 
            this.lblNota1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota1.AutoSize = true;
            this.lblNota1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota1.Location = new System.Drawing.Point(221, 179);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(64, 24);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota4
            // 
            this.lblNota4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota4.AutoSize = true;
            this.lblNota4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota4.Location = new System.Drawing.Point(662, 179);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(64, 24);
            this.lblNota4.TabIndex = 0;
            this.lblNota4.Text = "Nota 4";
            // 
            // lblNota3
            // 
            this.lblNota3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota3.AutoSize = true;
            this.lblNota3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota3.Location = new System.Drawing.Point(500, 179);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(64, 24);
            this.lblNota3.TabIndex = 0;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblNota2
            // 
            this.lblNota2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNota2.AutoSize = true;
            this.lblNota2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota2.Location = new System.Drawing.Point(363, 179);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(64, 24);
            this.lblNota2.TabIndex = 0;
            this.lblNota2.Text = "Nota 2";
            // 
            // lblPromedio
            // 
            this.lblPromedio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(866, 179);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(92, 24);
            this.lblPromedio.TabIndex = 0;
            this.lblPromedio.Text = "Promedio";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(893, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(169, 37);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar Filtros";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(908, 290);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 37);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar Nota";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(908, 357);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 36);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar Nota";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cbRegistroNotas
            // 
            this.cbRegistroNotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbRegistroNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbRegistroNotas.FormattingEnabled = true;
            this.cbRegistroNotas.Location = new System.Drawing.Point(367, 130);
            this.cbRegistroNotas.Margin = new System.Windows.Forms.Padding(2);
            this.cbRegistroNotas.Name = "cbRegistroNotas";
            this.cbRegistroNotas.Size = new System.Drawing.Size(498, 32);
            this.cbRegistroNotas.TabIndex = 7;
            this.cbRegistroNotas.SelectedIndexChanged += new System.EventHandler(this.cbRegistroNotas_SelectedIndexChanged);
            // 
            // gfcNotas
            // 
            this.gfcNotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.Name = "ChartArea1";
            this.gfcNotas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gfcNotas.Legends.Add(legend1);
            this.gfcNotas.Location = new System.Drawing.Point(332, 497);
            this.gfcNotas.Margin = new System.Windows.Forms.Padding(1);
            this.gfcNotas.Name = "gfcNotas";
            this.gfcNotas.Size = new System.Drawing.Size(306, 271);
            this.gfcNotas.TabIndex = 8;
            this.gfcNotas.Text = "chart1";
            // 
            // txtAprobados
            // 
            this.txtAprobados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAprobados.Location = new System.Drawing.Point(718, 544);
            this.txtAprobados.Name = "txtAprobados";
            this.txtAprobados.ReadOnly = true;
            this.txtAprobados.Size = new System.Drawing.Size(100, 29);
            this.txtAprobados.TabIndex = 9;
            // 
            // txtReprobados
            // 
            this.txtReprobados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtReprobados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtReprobados.Location = new System.Drawing.Point(879, 544);
            this.txtReprobados.Name = "txtReprobados";
            this.txtReprobados.ReadOnly = true;
            this.txtReprobados.Size = new System.Drawing.Size(100, 29);
            this.txtReprobados.TabIndex = 10;
            // 
            // NotasDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 583);
            this.Controls.Add(this.txtReprobados);
            this.Controls.Add(this.txtAprobados);
            this.Controls.Add(this.gfcNotas);
            this.Controls.Add(this.cbRegistroNotas);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvNotasDocente);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasDocente";
            this.Text = "NotasDocente";
            this.Load += new System.EventHandler(this.NotasDocente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasDocente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gfcNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblRegistroNotas;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtNota1;
		private System.Windows.Forms.TextBox txtNota2;
		private System.Windows.Forms.TextBox txtNota3;
		private System.Windows.Forms.TextBox txtNota4;
		private System.Windows.Forms.TextBox txtPromedio;
		private System.Windows.Forms.DataGridView dgvNotasDocente;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNota1;
		private System.Windows.Forms.Label lblNota4;
		private System.Windows.Forms.Label lblNota3;
		private System.Windows.Forms.Label lblNota2;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ComboBox cbRegistroNotas;
        private System.Windows.Forms.DataVisualization.Charting.Chart gfcNotas;
        private System.Windows.Forms.TextBox txtAprobados;
        private System.Windows.Forms.TextBox txtReprobados;
    }
}