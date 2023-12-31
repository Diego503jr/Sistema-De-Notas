﻿namespace SistemaDeNotas.Interfaz.Admin
{
    partial class AlumnosListForm
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
			this.dgvAlumnos = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCarnetAlumno = new System.Windows.Forms.TextBox();
			this.txtNombreAlumno = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAlumnos
			// 
			this.dgvAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAlumnos.Location = new System.Drawing.Point(34, 141);
			this.dgvAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvAlumnos.Name = "dgvAlumnos";
			this.dgvAlumnos.RowHeadersWidth = 51;
			this.dgvAlumnos.RowTemplate.Height = 24;
			this.dgvAlumnos.Size = new System.Drawing.Size(460, 284);
			this.dgvAlumnos.TabIndex = 0;
			this.dgvAlumnos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumnos_RowHeaderMouseClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Blue;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(530, 238);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 28);
			this.button1.TabIndex = 1;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(530, 283);
			this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(88, 28);
			this.button2.TabIndex = 2;
			this.button2.Text = "Cancelar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(227, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Alumnos registrados";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(451, 65);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Carnet";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(161, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Nombre";
			// 
			// txtCarnetAlumno
			// 
			this.txtCarnetAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtCarnetAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtCarnetAlumno.Enabled = false;
			this.txtCarnetAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarnetAlumno.Location = new System.Drawing.Point(414, 102);
			this.txtCarnetAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCarnetAlumno.Name = "txtCarnetAlumno";
			this.txtCarnetAlumno.Size = new System.Drawing.Size(141, 26);
			this.txtCarnetAlumno.TabIndex = 9;
			// 
			// txtNombreAlumno
			// 
			this.txtNombreAlumno.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtNombreAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.txtNombreAlumno.Enabled = false;
			this.txtNombreAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreAlumno.Location = new System.Drawing.Point(81, 102);
			this.txtNombreAlumno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNombreAlumno.Name = "txtNombreAlumno";
			this.txtNombreAlumno.Size = new System.Drawing.Size(234, 26);
			this.txtNombreAlumno.TabIndex = 8;
			// 
			// AlumnosListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(656, 435);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCarnetAlumno);
			this.Controls.Add(this.txtNombreAlumno);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvAlumnos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AlumnosListForm";
			this.Text = "AlumnosListForm";
			this.Load += new System.EventHandler(this.AlumnosListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarnetAlumno;
        private System.Windows.Forms.TextBox txtNombreAlumno;
    }
}