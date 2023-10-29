﻿namespace SistemaDeNotas
{
    partial class AlumnoForm
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
            this.components = new System.ComponentModel.Container();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContPrincipal = new System.Windows.Forms.Panel();
            this.BarraMenuLateral = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.btnMenuDocentes = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMenuCursos = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMenuPerfil = new System.Windows.Forms.Button();
            this.ContPrincipalAlumno = new System.Windows.Forms.Panel();
            this.BarraFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContPrincipal.SuspendLayout();
            this.BarraMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.ContPrincipalAlumno.SuspendLayout();
            this.BarraFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1154, 60);
            this.BarraTitulo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::SistemaDeNotas.Properties.Resources.cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(1091, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ContPrincipal
            // 
            this.ContPrincipal.Controls.Add(this.txtNombreUsuario);
            this.ContPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.ContPrincipal.Name = "ContPrincipal";
            this.ContPrincipal.Size = new System.Drawing.Size(744, 668);
            this.ContPrincipal.TabIndex = 2;
            // 
            // BarraMenuLateral
            // 
            this.BarraMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.BarraMenuLateral.Controls.Add(this.pictureBox6);
            this.BarraMenuLateral.Controls.Add(this.label1);
            this.BarraMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.BarraMenuLateral.Controls.Add(this.btnMenuDocentes);
            this.BarraMenuLateral.Controls.Add(this.pictureBox5);
            this.BarraMenuLateral.Controls.Add(this.pictureBox2);
            this.BarraMenuLateral.Controls.Add(this.btnMenuCursos);
            this.BarraMenuLateral.Controls.Add(this.pictureBox4);
            this.BarraMenuLateral.Controls.Add(this.btnMenuPerfil);
            this.BarraMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenuLateral.Location = new System.Drawing.Point(0, 60);
            this.BarraMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.BarraMenuLateral.Name = "BarraMenuLateral";
            this.BarraMenuLateral.Size = new System.Drawing.Size(410, 728);
            this.BarraMenuLateral.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SistemaDeNotas.Properties.Resources.ITCA_RemoveBG;
            this.pictureBox6.Location = new System.Drawing.Point(3, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(400, 161);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 651);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cerrar Sesion";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = global::SistemaDeNotas.Properties.Resources.cerrarSesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(58, 619);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(101, 95);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMenuDocentes
            // 
            this.btnMenuDocentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuDocentes.FlatAppearance.BorderSize = 0;
            this.btnMenuDocentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuDocentes.ForeColor = System.Drawing.Color.White;
            this.btnMenuDocentes.Location = new System.Drawing.Point(13, 241);
            this.btnMenuDocentes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuDocentes.Name = "btnMenuDocentes";
            this.btnMenuDocentes.Size = new System.Drawing.Size(397, 46);
            this.btnMenuDocentes.TabIndex = 11;
            this.btnMenuDocentes.Text = "Docentes";
            this.btnMenuDocentes.UseVisualStyleBackColor = false;
            this.btnMenuDocentes.Click += new System.EventHandler(this.btnMenuDocentes_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 347);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 46);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 241);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 46);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // btnMenuCursos
            // 
            this.btnMenuCursos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCursos.FlatAppearance.BorderSize = 0;
            this.btnMenuCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCursos.ForeColor = System.Drawing.Color.White;
            this.btnMenuCursos.Location = new System.Drawing.Point(13, 347);
            this.btnMenuCursos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuCursos.Name = "btnMenuCursos";
            this.btnMenuCursos.Size = new System.Drawing.Size(397, 46);
            this.btnMenuCursos.TabIndex = 17;
            this.btnMenuCursos.Text = "Cursos";
            this.btnMenuCursos.UseVisualStyleBackColor = false;
            this.btnMenuCursos.Click += new System.EventHandler(this.btnMenuCursos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 294);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 46);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // btnMenuPerfil
            // 
            this.btnMenuPerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMenuPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPerfil.FlatAppearance.BorderSize = 0;
            this.btnMenuPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPerfil.ForeColor = System.Drawing.Color.White;
            this.btnMenuPerfil.Location = new System.Drawing.Point(13, 294);
            this.btnMenuPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuPerfil.Name = "btnMenuPerfil";
            this.btnMenuPerfil.Size = new System.Drawing.Size(397, 46);
            this.btnMenuPerfil.TabIndex = 15;
            this.btnMenuPerfil.Text = "Perfil";
            this.btnMenuPerfil.UseVisualStyleBackColor = false;
            this.btnMenuPerfil.Click += new System.EventHandler(this.btnMenuPerfil_Click);
            // 
            // ContPrincipalAlumno
            // 
            this.ContPrincipalAlumno.Controls.Add(this.ContPrincipal);
            this.ContPrincipalAlumno.Controls.Add(this.BarraFooter);
            this.ContPrincipalAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContPrincipalAlumno.Location = new System.Drawing.Point(410, 60);
            this.ContPrincipalAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.ContPrincipalAlumno.Name = "ContPrincipalAlumno";
            this.ContPrincipalAlumno.Size = new System.Drawing.Size(744, 728);
            this.ContPrincipalAlumno.TabIndex = 2;
            // 
            // BarraFooter
            // 
            this.BarraFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.BarraFooter.Controls.Add(this.label3);
            this.BarraFooter.Controls.Add(this.label2);
            this.BarraFooter.Controls.Add(this.lblFecha);
            this.BarraFooter.Controls.Add(this.lblHora);
            this.BarraFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraFooter.Location = new System.Drawing.Point(0, 668);
            this.BarraFooter.Name = "BarraFooter";
            this.BarraFooter.Size = new System.Drawing.Size(744, 60);
            this.BarraFooter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(446, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hora :";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(565, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(92, 32);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(101, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(92, 32);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "label2";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(81, 51);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Multiline = true;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(593, 45);
            this.txtNombreUsuario.TabIndex = 8;
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 788);
            this.Controls.Add(this.ContPrincipalAlumno);
            this.Controls.Add(this.BarraMenuLateral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlumnoForm";
            this.Text = "AlumnoForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContPrincipal.ResumeLayout(false);
            this.ContPrincipal.PerformLayout();
            this.BarraMenuLateral.ResumeLayout(false);
            this.BarraMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ContPrincipalAlumno.ResumeLayout(false);
            this.BarraFooter.ResumeLayout(false);
            this.BarraFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenuLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox btnCerrarSesion;
		private System.Windows.Forms.Button btnMenuDocentes;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnMenuCursos;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button btnMenuPerfil;
		private System.Windows.Forms.Panel ContPrincipalAlumno;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel ContPrincipal;
        private System.Windows.Forms.Panel BarraFooter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.TextBox txtNombreUsuario;
    }
}