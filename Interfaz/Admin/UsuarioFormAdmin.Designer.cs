namespace SistemaDeNotas.Interfaz.Admin
{
    partial class UsuarioFormAdmin
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
			this.btnAgregarAlumno = new System.Windows.Forms.Button();
			this.btnActualizarAlumno = new System.Windows.Forms.Button();
			this.btnEliminarAlumno = new System.Windows.Forms.Button();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SubBarraTitulo = new System.Windows.Forms.Panel();
			this.label9 = new System.Windows.Forms.Label();
			this.cbRol = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbEstado = new System.Windows.Forms.ComboBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtCarnet = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblFiltro = new System.Windows.Forms.Label();
			this.txtFiltroNombre = new System.Windows.Forms.TextBox();
			this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SubBarraTitulo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAgregarAlumno
			// 
			this.btnAgregarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnAgregarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnAgregarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregarAlumno.FlatAppearance.BorderSize = 0;
			this.btnAgregarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarAlumno.ForeColor = System.Drawing.Color.White;
			this.btnAgregarAlumno.Location = new System.Drawing.Point(730, 431);
			this.btnAgregarAlumno.Margin = new System.Windows.Forms.Padding(2);
			this.btnAgregarAlumno.Name = "btnAgregarAlumno";
			this.btnAgregarAlumno.Size = new System.Drawing.Size(114, 33);
			this.btnAgregarAlumno.TabIndex = 46;
			this.btnAgregarAlumno.Text = "Agregar";
			this.btnAgregarAlumno.UseVisualStyleBackColor = false;
			this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click_1);
			// 
			// btnActualizarAlumno
			// 
			this.btnActualizarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnActualizarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnActualizarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActualizarAlumno.FlatAppearance.BorderSize = 0;
			this.btnActualizarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActualizarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizarAlumno.ForeColor = System.Drawing.Color.White;
			this.btnActualizarAlumno.Location = new System.Drawing.Point(730, 488);
			this.btnActualizarAlumno.Margin = new System.Windows.Forms.Padding(2);
			this.btnActualizarAlumno.Name = "btnActualizarAlumno";
			this.btnActualizarAlumno.Size = new System.Drawing.Size(114, 33);
			this.btnActualizarAlumno.TabIndex = 45;
			this.btnActualizarAlumno.Text = "Actualizar";
			this.btnActualizarAlumno.UseVisualStyleBackColor = false;
			this.btnActualizarAlumno.Click += new System.EventHandler(this.btnActualizarAlumno_Click);
			// 
			// btnEliminarAlumno
			// 
			this.btnEliminarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnEliminarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.btnEliminarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminarAlumno.FlatAppearance.BorderSize = 0;
			this.btnEliminarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarAlumno.ForeColor = System.Drawing.Color.White;
			this.btnEliminarAlumno.Location = new System.Drawing.Point(730, 545);
			this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(2);
			this.btnEliminarAlumno.Name = "btnEliminarAlumno";
			this.btnEliminarAlumno.Size = new System.Drawing.Size(114, 33);
			this.btnEliminarAlumno.TabIndex = 44;
			this.btnEliminarAlumno.Text = "Eliminar";
			this.btnEliminarAlumno.UseVisualStyleBackColor = false;
			this.btnEliminarAlumno.Click += new System.EventHandler(this.btnEliminarAlumno_Click);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToDeleteRows = false;
			this.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(28, 361);
			this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.RowHeadersWidth = 51;
			this.dgvUsuarios.RowTemplate.Height = 24;
			this.dgvUsuarios.Size = new System.Drawing.Size(652, 257);
			this.dgvUsuarios.TabIndex = 34;
			this.dgvUsuarios.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUsuarios_RowHeaderMouseClick);
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
			this.btnLimpiar.Location = new System.Drawing.Point(729, 308);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(114, 33);
			this.btnLimpiar.TabIndex = 51;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// SubBarraTitulo
			// 
			this.SubBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.SubBarraTitulo.Controls.Add(this.label9);
			this.SubBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.SubBarraTitulo.ForeColor = System.Drawing.Color.White;
			this.SubBarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.SubBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
			this.SubBarraTitulo.Name = "SubBarraTitulo";
			this.SubBarraTitulo.Size = new System.Drawing.Size(886, 68);
			this.SubBarraTitulo.TabIndex = 75;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(405, 19);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(127, 36);
			this.label9.TabIndex = 69;
			this.label9.Text = "Registro";
			// 
			// cbRol
			// 
			this.cbRol.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRol.FormattingEnabled = true;
			this.cbRol.Location = new System.Drawing.Point(122, 40);
			this.cbRol.Margin = new System.Windows.Forms.Padding(2);
			this.cbRol.Name = "cbRol";
			this.cbRol.Size = new System.Drawing.Size(233, 30);
			this.cbRol.TabIndex = 87;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(67, 42);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 24);
			this.label8.TabIndex = 86;
			this.label8.Text = "Rol :";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(544, 37);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(233, 28);
			this.txtPassword.TabIndex = 85;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(425, 40);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 24);
			this.label7.TabIndex = 84;
			this.label7.Text = "Contraseña :";
			// 
			// cbEstado
			// 
			this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEstado.FormattingEnabled = true;
			this.cbEstado.Location = new System.Drawing.Point(546, 134);
			this.cbEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cbEstado.Name = "cbEstado";
			this.cbEstado.Size = new System.Drawing.Size(233, 30);
			this.cbEstado.TabIndex = 83;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(546, 87);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(233, 28);
			this.txtTelefono.TabIndex = 82;
			// 
			// txtCarnet
			// 
			this.txtCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarnet.Location = new System.Drawing.Point(123, 136);
			this.txtCarnet.Margin = new System.Windows.Forms.Padding(2);
			this.txtCarnet.Name = "txtCarnet";
			this.txtCarnet.Size = new System.Drawing.Size(233, 28);
			this.txtCarnet.TabIndex = 81;
			// 
			// txtNombre
			// 
			this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(123, 89);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(233, 28);
			this.txtNombre.TabIndex = 80;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(461, 136);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 24);
			this.label5.TabIndex = 79;
			this.label5.Text = "Estado :";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(445, 89);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 24);
			this.label4.TabIndex = 78;
			this.label4.Text = "Telefono :";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(41, 139);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 24);
			this.label3.TabIndex = 77;
			this.label3.Text = "Carnet :";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 91);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 24);
			this.label2.TabIndex = 76;
			this.label2.Text = "Nombre :";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.groupBox1.Controls.Add(this.cbRol);
			this.groupBox1.Controls.Add(this.txtPassword);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbEstado);
			this.groupBox1.Controls.Add(this.txtCarnet);
			this.groupBox1.Controls.Add(this.txtTelefono);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.groupBox1.Location = new System.Drawing.Point(28, 84);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(815, 195);
			this.groupBox1.TabIndex = 88;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos personales";
			// 
			// lblFiltro
			// 
			this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lblFiltro.AutoSize = true;
			this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiltro.Location = new System.Drawing.Point(38, 284);
			this.lblFiltro.Name = "lblFiltro";
			this.lblFiltro.Size = new System.Drawing.Size(173, 24);
			this.lblFiltro.TabIndex = 0;
			this.lblFiltro.Text = "Filtrar por Nombre :";
			// 
			// txtFiltroNombre
			// 
			this.txtFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFiltroNombre.Location = new System.Drawing.Point(217, 284);
			this.txtFiltroNombre.Multiline = true;
			this.txtFiltroNombre.Name = "txtFiltroNombre";
			this.txtFiltroNombre.Size = new System.Drawing.Size(394, 24);
			this.txtFiltroNombre.TabIndex = 90;
			this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
			// 
			// cmbFiltroEstado
			// 
			this.cmbFiltroEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.cmbFiltroEstado.FormattingEnabled = true;
			this.cmbFiltroEstado.Location = new System.Drawing.Point(217, 313);
			this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(2);
			this.cmbFiltroEstado.Name = "cmbFiltroEstado";
			this.cmbFiltroEstado.Size = new System.Drawing.Size(394, 30);
			this.cmbFiltroEstado.TabIndex = 91;
			this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 313);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 24);
			this.label1.TabIndex = 92;
			this.label1.Text = "Filtrar por Estado :";
			// 
			// UsuarioFormAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(886, 635);
			this.Controls.Add(this.cmbFiltroEstado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFiltro);
			this.Controls.Add(this.txtFiltroNombre);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SubBarraTitulo);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnAgregarAlumno);
			this.Controls.Add(this.btnActualizarAlumno);
			this.Controls.Add(this.btnEliminarAlumno);
			this.Controls.Add(this.dgvUsuarios);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "UsuarioFormAdmin";
			this.Text = "AlumnoFormAdmin";
			this.Load += new System.EventHandler(this.UsuarioFormAdmin_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.SubBarraTitulo.ResumeLayout(false);
			this.SubBarraTitulo.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnActualizarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel SubBarraTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltroNombre;
		private System.Windows.Forms.ComboBox cmbFiltroEstado;
		private System.Windows.Forms.Label label1;
	}
}