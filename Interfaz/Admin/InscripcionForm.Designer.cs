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
            System.Windows.Forms.TextBox txtDocente;
            this.btnActualizarInscripcion = new System.Windows.Forms.Button();
            this.gBDatosInscribir = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.gBDatosPersonales = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            txtDocente = new System.Windows.Forms.TextBox();
            this.gBDatosInscribir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.gBDatosPersonales.SuspendLayout();
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
            this.btnActualizarInscripcion.Location = new System.Drawing.Point(640, 389);
            this.btnActualizarInscripcion.Name = "btnActualizarInscripcion";
            this.btnActualizarInscripcion.Size = new System.Drawing.Size(175, 41);
            this.btnActualizarInscripcion.TabIndex = 73;
            this.btnActualizarInscripcion.Text = "Actualizar";
            this.btnActualizarInscripcion.UseVisualStyleBackColor = false;
            // 
            // gBDatosInscribir
            // 
            this.gBDatosInscribir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDatosInscribir.Controls.Add(txtDocente);
            this.gBDatosInscribir.Controls.Add(this.label5);
            this.gBDatosInscribir.Controls.Add(this.cbMaterias);
            this.gBDatosInscribir.Controls.Add(this.label4);
            this.gBDatosInscribir.Controls.Add(this.cbCursos);
            this.gBDatosInscribir.Controls.Add(this.label2);
            this.gBDatosInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.gBDatosInscribir.Location = new System.Drawing.Point(609, 120);
            this.gBDatosInscribir.Name = "gBDatosInscribir";
            this.gBDatosInscribir.Size = new System.Drawing.Size(509, 234);
            this.gBDatosInscribir.TabIndex = 72;
            this.gBDatosInscribir.TabStop = false;
            this.gBDatosInscribir.Text = "Datos inscripción";
            // 
            // txtDocente
            // 
            txtDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            txtDocente.Cursor = System.Windows.Forms.Cursors.No;
            txtDocente.Enabled = false;
            txtDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtDocente.Location = new System.Drawing.Point(162, 165);
            txtDocente.Name = "txtDocente";
            txtDocente.Size = new System.Drawing.Size(309, 34);
            txtDocente.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 29);
            this.label5.TabIndex = 57;
            this.label5.Text = "Docente :";
            // 
            // cbMaterias
            // 
            this.cbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(162, 105);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(309, 37);
            this.cbMaterias.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 29);
            this.label4.TabIndex = 55;
            this.label4.Text = "Materia :";
            // 
            // cbCursos
            // 
            this.cbCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(162, 48);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(309, 37);
            this.cbCursos.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Curso :";
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
            this.btnInscribir.Location = new System.Drawing.Point(383, 389);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(175, 41);
            this.btnInscribir.TabIndex = 71;
            this.btnInscribir.Text = "Inscribir";
            this.btnInscribir.UseVisualStyleBackColor = false;
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInscripcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Location = new System.Drawing.Point(282, 462);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.RowHeadersWidth = 51;
            this.dgvInscripcion.RowTemplate.Height = 24;
            this.dgvInscripcion.Size = new System.Drawing.Size(611, 346);
            this.dgvInscripcion.TabIndex = 70;
            // 
            // gBDatosPersonales
            // 
            this.gBDatosPersonales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBDatosPersonales.Controls.Add(this.cbEstado);
            this.gBDatosPersonales.Controls.Add(this.label3);
            this.gBDatosPersonales.Controls.Add(this.txtCarnet);
            this.gBDatosPersonales.Controls.Add(this.txtNombre);
            this.gBDatosPersonales.Controls.Add(this.label6);
            this.gBDatosPersonales.Controls.Add(this.label8);
            this.gBDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBDatosPersonales.Location = new System.Drawing.Point(51, 109);
            this.gBDatosPersonales.Name = "gBDatosPersonales";
            this.gBDatosPersonales.Size = new System.Drawing.Size(509, 245);
            this.gBDatosPersonales.TabIndex = 69;
            this.gBDatosPersonales.TabStop = false;
            this.gBDatosPersonales.Text = "Datos personales :";
            // 
            // cbEstado
            // 
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Programacion Estructurada",
            "Logica de programacion",
            "Base de Datos",
            "Desarrollo Web"});
            this.cbEstado.Location = new System.Drawing.Point(166, 176);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(309, 37);
            this.cbEstado.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Estado :";
            // 
            // txtCarnet
            // 
            this.txtCarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(166, 116);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(309, 34);
            this.txtCarnet.TabIndex = 53;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(166, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(309, 34);
            this.txtNombre.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Carnet :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 29);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 68;
            this.label1.Text = "Inscripción";
            // 
            // InscripcionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 823);
            this.Controls.Add(this.btnActualizarInscripcion);
            this.Controls.Add(this.gBDatosInscribir);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.gBDatosPersonales);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InscripcionForm";
            this.Text = "InscripcionForm";
            this.Load += new System.EventHandler(this.InscripcionForm_Load);
            this.gBDatosInscribir.ResumeLayout(false);
            this.gBDatosInscribir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.gBDatosPersonales.ResumeLayout(false);
            this.gBDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarInscripcion;
        private System.Windows.Forms.GroupBox gBDatosInscribir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.GroupBox gBDatosPersonales;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}