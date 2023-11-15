namespace SistemaDeNotas.Interfaz.Admin
{
    partial class MateriasForm
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
			this.gbDetalleMateria = new System.Windows.Forms.GroupBox();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbDocente = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescripcionMateria = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreMateria = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvMaterias = new System.Windows.Forms.DataGridView();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.txtFiltroNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.SubBarraTitulo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.gbDetalleMateria.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
			this.SubBarraTitulo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbDetalleMateria
			// 
			this.gbDetalleMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbDetalleMateria.Controls.Add(this.cbEstado);
			this.gbDetalleMateria.Controls.Add(this.label6);
			this.gbDetalleMateria.Controls.Add(this.cbDocente);
			this.gbDetalleMateria.Controls.Add(this.label4);
			this.gbDetalleMateria.Controls.Add(this.txtDescripcionMateria);
			this.gbDetalleMateria.Controls.Add(this.label3);
			this.gbDetalleMateria.Controls.Add(this.txtNombreMateria);
			this.gbDetalleMateria.Controls.Add(this.label2);
			this.gbDetalleMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDetalleMateria.Location = new System.Drawing.Point(22, 98);
			this.gbDetalleMateria.Margin = new System.Windows.Forms.Padding(2);
			this.gbDetalleMateria.Name = "gbDetalleMateria";
			this.gbDetalleMateria.Padding = new System.Windows.Forms.Padding(2);
			this.gbDetalleMateria.Size = new System.Drawing.Size(1036, 168);
			this.gbDetalleMateria.TabIndex = 3;
			this.gbDetalleMateria.TabStop = false;
			this.gbDetalleMateria.Text = "Detalles materia";
			// 
			// cbEstado
			// 
			this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(726, 97);
			this.cbEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(293, 30);
			this.cbEstado.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(635, 99);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 24);
			this.label6.TabIndex = 12;
			this.label6.Text = "Estado :";
			// 
			// cbDocente
			// 
			this.cbDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbDocente.FormattingEnabled = true;
			this.cbDocente.Location = new System.Drawing.Point(726, 39);
			this.cbDocente.Margin = new System.Windows.Forms.Padding(2);
			this.cbDocente.Name = "cbDocente";
			this.cbDocente.Size = new System.Drawing.Size(293, 30);
			this.cbDocente.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(624, 41);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "Docente :";
			// 
			// txtDescripcionMateria
			// 
			this.txtDescripcionMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtDescripcionMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDescripcionMateria.Location = new System.Drawing.Point(132, 97);
			this.txtDescripcionMateria.Margin = new System.Windows.Forms.Padding(2);
			this.txtDescripcionMateria.Multiline = true;
			this.txtDescripcionMateria.Name = "txtDescripcionMateria";
			this.txtDescripcionMateria.Size = new System.Drawing.Size(474, 56);
			this.txtDescripcionMateria.TabIndex = 3;
			this.txtDescripcionMateria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionMateria_KeyPress);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 99);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "Descripcion :";
			// 
			// txtNombreMateria
			// 
			this.txtNombreMateria.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNombreMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreMateria.Location = new System.Drawing.Point(132, 41);
			this.txtNombreMateria.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombreMateria.Name = "txtNombreMateria";
			this.txtNombreMateria.Size = new System.Drawing.Size(325, 28);
			this.txtNombreMateria.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(42, 44);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Nombre :";
			// 
			// dgvMaterias
			// 
			this.dgvMaterias.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvMaterias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMaterias.Location = new System.Drawing.Point(22, 355);
			this.dgvMaterias.Margin = new System.Windows.Forms.Padding(2);
			this.dgvMaterias.Name = "dgvMaterias";
			this.dgvMaterias.ReadOnly = true;
			this.dgvMaterias.RowHeadersWidth = 51;
			this.dgvMaterias.RowTemplate.Height = 24;
			this.dgvMaterias.Size = new System.Drawing.Size(844, 306);
			this.dgvMaterias.TabIndex = 4;
			this.dgvMaterias.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterias_RowHeaderMouseClick);
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
			this.btnActualizar.Location = new System.Drawing.Point(900, 552);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(131, 33);
			this.btnActualizar.TabIndex = 71;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
			this.btnEliminar.Location = new System.Drawing.Point(900, 492);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(131, 33);
			this.btnEliminar.TabIndex = 70;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
			this.btnAgregar.Location = new System.Drawing.Point(900, 435);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(131, 33);
			this.btnAgregar.TabIndex = 69;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
			this.btnLimpiar.Location = new System.Drawing.Point(735, 293);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(131, 33);
			this.btnLimpiar.TabIndex = 72;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// txtFiltroNombre
			// 
			this.txtFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFiltroNombre.Location = new System.Drawing.Point(234, 274);
			this.txtFiltroNombre.Multiline = true;
			this.txtFiltroNombre.Name = "txtFiltroNombre";
			this.txtFiltroNombre.Size = new System.Drawing.Size(394, 24);
			this.txtFiltroNombre.TabIndex = 0;
			this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(55, 274);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 24);
			this.label5.TabIndex = 0;
			this.label5.Text = "Filtrar por Nombre :";
			// 
			// SubBarraTitulo
			// 
			this.SubBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.SubBarraTitulo.Controls.Add(this.label1);
			this.SubBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.SubBarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.SubBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
			this.SubBarraTitulo.Name = "SubBarraTitulo";
			this.SubBarraTitulo.Size = new System.Drawing.Size(1040, 68);
			this.SubBarraTitulo.TabIndex = 75;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(399, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(257, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "Registrar Materias";
			// 
			// cmbFiltroEstado
			// 
			this.cmbFiltroEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.cmbFiltroEstado.FormattingEnabled = true;
			this.cmbFiltroEstado.Location = new System.Drawing.Point(234, 321);
			this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cmbFiltroEstado.Name = "cmbFiltroEstado";
			this.cmbFiltroEstado.Size = new System.Drawing.Size(394, 30);
			this.cmbFiltroEstado.TabIndex = 82;
			this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(66, 321);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(162, 24);
			this.label7.TabIndex = 83;
			this.label7.Text = "Filtrar por Estado :";
			// 
			// MateriasForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1040, 640);
			this.Controls.Add(this.cmbFiltroEstado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SubBarraTitulo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtFiltroNombre);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvMaterias);
			this.Controls.Add(this.gbDetalleMateria);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MateriasForm";
			this.Text = "MateriasForm";
			this.Load += new System.EventHandler(this.MateriasForm_Load);
			this.gbDetalleMateria.ResumeLayout(false);
			this.gbDetalleMateria.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
			this.SubBarraTitulo.ResumeLayout(false);
			this.SubBarraTitulo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDetalleMateria;
        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.TextBox txtFiltroNombre;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel SubBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbFiltroEstado;
		private System.Windows.Forms.Label label7;
	}
}