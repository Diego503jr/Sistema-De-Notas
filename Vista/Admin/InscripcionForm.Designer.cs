namespace SistemaDeNotas.Interfaz.Admin
{
    partial class InscripcionForm
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
            this.btnActualizarInscripcion = new System.Windows.Forms.Button();
            this.gBDatosInscribir = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.SubBarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminarInscrip = new System.Windows.Forms.Button();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.gBDatosInscribir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.SubBarraTitulo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarInscripcion
            // 
            this.btnActualizarInscripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarInscripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnActualizarInscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarInscripcion.FlatAppearance.BorderSize = 0;
            this.btnActualizarInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnActualizarInscripcion.Location = new System.Drawing.Point(967, 541);
            this.btnActualizarInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarInscripcion.Name = "btnActualizarInscripcion";
            this.btnActualizarInscripcion.Size = new System.Drawing.Size(175, 41);
            this.btnActualizarInscripcion.TabIndex = 73;
            this.btnActualizarInscripcion.Text = "Actualizar";
            this.btnActualizarInscripcion.UseVisualStyleBackColor = false;
            this.btnActualizarInscripcion.Click += new System.EventHandler(this.btnActualizarInscripcion_Click);
            // 
            // gBDatosInscribir
            // 
            this.gBDatosInscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDatosInscribir.Controls.Add(this.cbEstado);
            this.gBDatosInscribir.Controls.Add(this.label3);
            this.gBDatosInscribir.Controls.Add(this.btnBuscarAlumno);
            this.gBDatosInscribir.Controls.Add(this.txtCarnet);
            this.gBDatosInscribir.Controls.Add(this.txtNombre);
            this.gBDatosInscribir.Controls.Add(this.label6);
            this.gBDatosInscribir.Controls.Add(this.label8);
            this.gBDatosInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.gBDatosInscribir.Location = new System.Drawing.Point(12, 119);
            this.gBDatosInscribir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosInscribir.Name = "gBDatosInscribir";
            this.gBDatosInscribir.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBDatosInscribir.Size = new System.Drawing.Size(531, 234);
            this.gBDatosInscribir.TabIndex = 72;
            this.gBDatosInscribir.TabStop = false;
            this.gBDatosInscribir.Text = "Datos personales";
            // 
            // cbEstado
            // 
            this.cbEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(140, 172);
            this.cbEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(184, 37);
            this.cbEstado.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 59;
            this.label3.Text = "Estado :";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscarAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnBuscarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarAlumno.FlatAppearance.BorderSize = 0;
            this.btnBuscarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnBuscarAlumno.Location = new System.Drawing.Point(379, 124);
            this.btnBuscarAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(131, 68);
            this.btnBuscarAlumno.TabIndex = 58;
            this.btnBuscarAlumno.Text = "Buscar alumno";
            this.btnBuscarAlumno.UseVisualStyleBackColor = false;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.btnBuscarAlumno_Click);
            // 
            // txtCarnet
            // 
            this.txtCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(140, 112);
            this.txtCarnet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(184, 34);
            this.txtCarnet.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(140, 55);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(369, 34);
            this.txtNombre.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = "Carnet :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 54;
            this.label8.Text = "Nombre :";
            // 
            // btnInscribir
            // 
            this.btnInscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnInscribir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscribir.FlatAppearance.BorderSize = 0;
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.ForeColor = System.Drawing.Color.White;
            this.btnInscribir.Location = new System.Drawing.Point(967, 465);
            this.btnInscribir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(175, 41);
            this.btnInscribir.TabIndex = 71;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInscripcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(27, 465);
            this.dgvInscripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.RowHeadersWidth = 51;
            this.dgvInscripcion.RowTemplate.Height = 24;
            this.dgvInscripcion.Size = new System.Drawing.Size(900, 346);
            this.dgvInscripcion.TabIndex = 70;
            this.dgvInscripcion.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInscripcion_RowHeaderMouseClick);
            // 
            // SubBarraTitulo
            // 
            this.SubBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.SubBarraTitulo.Controls.Add(this.label1);
            this.SubBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubBarraTitulo.ForeColor = System.Drawing.Color.White;
            this.SubBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.SubBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubBarraTitulo.Name = "SubBarraTitulo";
            this.SubBarraTitulo.Size = new System.Drawing.Size(1169, 84);
            this.SubBarraTitulo.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 69;
            this.label1.Text = "Inscripción";
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(27, 363);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(223, 29);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Filtrar por Nombre :";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.Location = new System.Drawing.Point(265, 359);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFiltroNombre.Multiline = true;
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(407, 29);
            this.txtFiltroNombre.TabIndex = 76;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
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
            this.btnLimpiar.Location = new System.Drawing.Point(752, 385);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(175, 41);
            this.btnLimpiar.TabIndex = 77;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtDocente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbMaterias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCursos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupBox1.Location = new System.Drawing.Point(580, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(577, 234);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de inscripción";
            // 
            // txtDocente
            // 
            this.txtDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocente.Enabled = false;
            this.txtDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocente.Location = new System.Drawing.Point(145, 172);
            this.txtDocente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(404, 34);
            this.txtDocente.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 94;
            this.label5.Text = "Docente :";
            // 
            // cbMaterias
            // 
            this.cbMaterias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(145, 112);
            this.cbMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(404, 37);
            this.cbMaterias.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "Materia :";
            // 
            // cbCursos
            // 
            this.cbCursos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(145, 55);
            this.cbCursos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(309, 37);
            this.cbCursos.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 90;
            this.label2.Text = "Curso :";
            // 
            // btnEliminarInscrip
            // 
            this.btnEliminarInscrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarInscrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnEliminarInscrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarInscrip.FlatAppearance.BorderSize = 0;
            this.btnEliminarInscrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarInscrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarInscrip.ForeColor = System.Drawing.Color.White;
            this.btnEliminarInscrip.Location = new System.Drawing.Point(967, 620);
            this.btnEliminarInscrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarInscrip.Name = "btnEliminarInscrip";
            this.btnEliminarInscrip.Size = new System.Drawing.Size(175, 41);
            this.btnEliminarInscrip.TabIndex = 79;
            this.btnEliminarInscrip.Text = "Eliminar";
            this.btnEliminarInscrip.UseVisualStyleBackColor = false;
            this.btnEliminarInscrip.Click += new System.EventHandler(this.btnEliminarInscrip_Click);
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(265, 423);
            this.cmbFiltroEstado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(407, 37);
            this.cmbFiltroEstado.TabIndex = 80;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 29);
            this.label7.TabIndex = 81;
            this.label7.Text = "Filtrar por Estado :";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerarReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGenerarReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarReporte.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporte.Location = new System.Drawing.Point(967, 707);
            this.btnGenerarReporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(175, 70);
            this.btnGenerarReporte.TabIndex = 82;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 788);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.cmbFiltroEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEliminarInscrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.SubBarraTitulo);
            this.Controls.Add(this.btnActualizarInscripcion);
            this.Controls.Add(this.gBDatosInscribir);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.dgvInscripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InscripcionForm";
            this.Text = "InscripcionForm";
            this.Load += new System.EventHandler(this.InscripcionForm_Load);
            this.gBDatosInscribir.ResumeLayout(false);
            this.gBDatosInscribir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.SubBarraTitulo.ResumeLayout(false);
            this.SubBarraTitulo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarInscripcion;
        private System.Windows.Forms.GroupBox gBDatosInscribir;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.Panel SubBarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarInscrip;
		private System.Windows.Forms.ComboBox cmbFiltroEstado;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}