namespace SistemaDeNotas.Interfaz.Admin
{
    partial class CursosForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.gbDetalleCurso = new System.Windows.Forms.GroupBox();
			this.txtNombreCurso = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvCursos = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.gbDetalleCurso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(331, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Registrar Cursos";
			// 
			// gbDetalleCurso
			// 
			this.gbDetalleCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbDetalleCurso.Controls.Add(this.txtNombreCurso);
			this.gbDetalleCurso.Controls.Add(this.label2);
			this.gbDetalleCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDetalleCurso.Location = new System.Drawing.Point(64, 132);
			this.gbDetalleCurso.Margin = new System.Windows.Forms.Padding(2);
			this.gbDetalleCurso.Name = "gbDetalleCurso";
			this.gbDetalleCurso.Padding = new System.Windows.Forms.Padding(2);
			this.gbDetalleCurso.Size = new System.Drawing.Size(713, 116);
			this.gbDetalleCurso.TabIndex = 2;
			this.gbDetalleCurso.TabStop = false;
			this.gbDetalleCurso.Text = "Detalles curso";
			// 
			// txtNombreCurso
			// 
			this.txtNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCurso.Location = new System.Drawing.Point(146, 60);
			this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombreCurso.Name = "txtNombreCurso";
			this.txtNombreCurso.Size = new System.Drawing.Size(282, 28);
			this.txtNombreCurso.TabIndex = 1;
			this.txtNombreCurso.TextChanged += new System.EventHandler(this.txtNombreCurso_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 24);
			this.label2.TabIndex = 0;
			this.label2.Text = "Nombre :";
			// 
			// dgvCursos
			// 
			this.dgvCursos.AllowUserToAddRows = false;
			this.dgvCursos.AllowUserToDeleteRows = false;
			this.dgvCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCursos.GridColor = System.Drawing.Color.White;
			this.dgvCursos.Location = new System.Drawing.Point(116, 323);
			this.dgvCursos.Margin = new System.Windows.Forms.Padding(2);
			this.dgvCursos.Name = "dgvCursos";
			this.dgvCursos.ReadOnly = true;
			this.dgvCursos.RowHeadersWidth = 51;
			this.dgvCursos.RowTemplate.Height = 24;
			this.dgvCursos.Size = new System.Drawing.Size(330, 312);
			this.dgvCursos.TabIndex = 3;
			this.dgvCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellContentClick);
			this.dgvCursos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCursos_RowHeaderMouseClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.FlatAppearance.BorderSize = 0;
			this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.White;
			this.btnAgregar.Location = new System.Drawing.Point(533, 323);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(131, 33);
			this.btnAgregar.TabIndex = 66;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.FlatAppearance.BorderSize = 0;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.White;
			this.btnEliminar.Location = new System.Drawing.Point(533, 379);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(131, 33);
			this.btnEliminar.TabIndex = 67;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizar.FlatAppearance.BorderSize = 0;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.ForeColor = System.Drawing.Color.White;
			this.btnActualizar.Location = new System.Drawing.Point(533, 440);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(131, 33);
			this.btnActualizar.TabIndex = 68;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLimpiar.FlatAppearance.BorderSize = 0;
			this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.Color.White;
			this.btnLimpiar.Location = new System.Drawing.Point(490, 522);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(210, 33);
			this.btnLimpiar.TabIndex = 73;
			this.btnLimpiar.Text = "Limpiar Búsqueda";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// CursosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(862, 640);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvCursos);
			this.Controls.Add(this.gbDetalleCurso);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CursosForm";
			this.Text = "CursosForm";
			this.Load += new System.EventHandler(this.CursosForm_Load);
			this.gbDetalleCurso.ResumeLayout(false);
			this.gbDetalleCurso.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDetalleCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnLimpiar;
	}
}