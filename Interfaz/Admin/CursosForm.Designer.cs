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
			this.gbDetalleCurso = new System.Windows.Forms.GroupBox();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombreCurso = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvCursos = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtFiltroNombre = new System.Windows.Forms.TextBox();
			this.SubBarraTitulo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.gbDetalleCurso.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
			this.SubBarraTitulo.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbDetalleCurso
			// 
			this.gbDetalleCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gbDetalleCurso.Controls.Add(this.cbEstado);
			this.gbDetalleCurso.Controls.Add(this.label3);
			this.gbDetalleCurso.Controls.Add(this.txtNombreCurso);
			this.gbDetalleCurso.Controls.Add(this.label2);
			this.gbDetalleCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDetalleCurso.Location = new System.Drawing.Point(110, 110);
			this.gbDetalleCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbDetalleCurso.Name = "gbDetalleCurso";
			this.gbDetalleCurso.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbDetalleCurso.Size = new System.Drawing.Size(645, 152);
			this.gbDetalleCurso.TabIndex = 2;
			this.gbDetalleCurso.TabStop = false;
			this.gbDetalleCurso.Text = "Detalles curso";
			// 
			// cbEstado
			// 
			this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(198, 98);
			this.cbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(193, 30);
			this.cbEstado.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(99, 98);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Estado :";
			// 
			// txtNombreCurso
			// 
			this.txtNombreCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCurso.Location = new System.Drawing.Point(198, 42);
			this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNombreCurso.Name = "txtNombreCurso";
			this.txtNombreCurso.Size = new System.Drawing.Size(282, 28);
			this.txtNombreCurso.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(89, 46);
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
			this.dgvCursos.Location = new System.Drawing.Point(150, 348);
			this.dgvCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvCursos.Name = "dgvCursos";
			this.dgvCursos.ReadOnly = true;
			this.dgvCursos.RowHeadersWidth = 51;
			this.dgvCursos.RowTemplate.Height = 24;
			this.dgvCursos.Size = new System.Drawing.Size(350, 269);
			this.dgvCursos.TabIndex = 3;
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
			this.btnAgregar.Location = new System.Drawing.Point(557, 418);
			this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.btnEliminar.Location = new System.Drawing.Point(557, 473);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.btnActualizar.Location = new System.Drawing.Point(557, 535);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
			this.btnLimpiar.Location = new System.Drawing.Point(557, 301);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(131, 33);
			this.btnLimpiar.TabIndex = 73;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// lblFiltro
			// 
			this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltro.Location = new System.Drawing.Point(133, 301);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(168, 24);
			this.lblFiltro.TabIndex = 0;
			this.lblFiltro.Text = "Filtrar por Nombre:";
			// 
			// txtFiltroNombre
			// 
			this.txtFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFiltroNombre.Location = new System.Drawing.Point(307, 301);
			this.txtFiltroNombre.Multiline = true;
			this.txtFiltroNombre.Name = "txtFiltroNombre";
			this.txtFiltroNombre.Size = new System.Drawing.Size(186, 24);
			this.txtFiltroNombre.TabIndex = 0;
			this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
			// 
			// SubBarraTitulo
			// 
			this.SubBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.SubBarraTitulo.Controls.Add(this.label1);
			this.SubBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.SubBarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.SubBarraTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.SubBarraTitulo.Name = "SubBarraTitulo";
			this.SubBarraTitulo.Size = new System.Drawing.Size(862, 68);
			this.SubBarraTitulo.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(333, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "Registrar Cursos";
			// 
			// CursosForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(862, 640);
			this.Controls.Add(this.SubBarraTitulo);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.txtFiltroNombre);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.dgvCursos);
			this.Controls.Add(this.gbDetalleCurso);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "CursosForm";
			this.Text = "CursosForm";
			this.Load += new System.EventHandler(this.CursosForm_Load);
			this.gbDetalleCurso.ResumeLayout(false);
			this.gbDetalleCurso.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
			this.SubBarraTitulo.ResumeLayout(false);
			this.SubBarraTitulo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbDetalleCurso;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Label lblFiltro;
		private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Panel SubBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
    }
}