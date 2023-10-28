﻿namespace SistemaDeNotas
{
    partial class AdminForm
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
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.BarraMenuLateral = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnInicio = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.btnMenuCursos = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.btnMenuPerfil = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btnMenuAlumnos = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnMenuDocentes = new System.Windows.Forms.Button();
			this.ContPrincipalAdmin = new System.Windows.Forms.Panel();
			this.txtNombreUsuario = new System.Windows.Forms.TextBox();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			this.BarraMenuLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.ContPrincipalAdmin.SuspendLayout();
			this.SuspendLayout();
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.BarraTitulo.Controls.Add(this.btnCerrar);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(800, 38);
			this.BarraTitulo.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::SistemaDeNotas.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(763, 6);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(25, 25);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 0;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// BarraMenuLateral
			// 
			this.BarraMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.BarraMenuLateral.Controls.Add(this.pictureBox1);
			this.BarraMenuLateral.Controls.Add(this.btnInicio);
			this.BarraMenuLateral.Controls.Add(this.label1);
			this.BarraMenuLateral.Controls.Add(this.btnCerrarSesion);
			this.BarraMenuLateral.Controls.Add(this.pictureBox5);
			this.BarraMenuLateral.Controls.Add(this.btnMenuCursos);
			this.BarraMenuLateral.Controls.Add(this.pictureBox4);
			this.BarraMenuLateral.Controls.Add(this.btnMenuPerfil);
			this.BarraMenuLateral.Controls.Add(this.pictureBox3);
			this.BarraMenuLateral.Controls.Add(this.btnMenuAlumnos);
			this.BarraMenuLateral.Controls.Add(this.pictureBox2);
			this.BarraMenuLateral.Controls.Add(this.btnMenuDocentes);
			this.BarraMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
			this.BarraMenuLateral.Location = new System.Drawing.Point(0, 38);
			this.BarraMenuLateral.Name = "BarraMenuLateral";
			this.BarraMenuLateral.Size = new System.Drawing.Size(245, 501);
			this.BarraMenuLateral.TabIndex = 1;
			this.BarraMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraMenuLateral_Paint);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox1.Location = new System.Drawing.Point(5, 106);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(10, 37);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInicio.ForeColor = System.Drawing.Color.White;
			this.btnInicio.Location = new System.Drawing.Point(15, 106);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(224, 37);
			this.btnInicio.TabIndex = 11;
			this.btnInicio.Text = "Inicio";
			this.btnInicio.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(94, 438);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Cerrar Sesion";
			// 
			// btnCerrarSesion
			// 
			this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrarSesion.Image = global::SistemaDeNotas.Properties.Resources.salir;
			this.btnCerrarSesion.Location = new System.Drawing.Point(12, 412);
			this.btnCerrarSesion.Name = "btnCerrarSesion";
			this.btnCerrarSesion.Size = new System.Drawing.Size(76, 77);
			this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrarSesion.TabIndex = 9;
			this.btnCerrarSesion.TabStop = false;
			this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox5.Location = new System.Drawing.Point(5, 278);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 37);
			this.pictureBox5.TabIndex = 8;
			this.pictureBox5.TabStop = false;
			// 
			// btnMenuCursos
			// 
			this.btnMenuCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnMenuCursos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenuCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenuCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuCursos.ForeColor = System.Drawing.Color.White;
			this.btnMenuCursos.Location = new System.Drawing.Point(15, 278);
			this.btnMenuCursos.Name = "btnMenuCursos";
			this.btnMenuCursos.Size = new System.Drawing.Size(224, 37);
			this.btnMenuCursos.TabIndex = 7;
			this.btnMenuCursos.Text = "Cursos";
			this.btnMenuCursos.UseVisualStyleBackColor = false;
			this.btnMenuCursos.Click += new System.EventHandler(this.btnMenuCursos_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox4.Location = new System.Drawing.Point(5, 235);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(10, 37);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// btnMenuPerfil
			// 
			this.btnMenuPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnMenuPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenuPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuPerfil.ForeColor = System.Drawing.Color.White;
			this.btnMenuPerfil.Location = new System.Drawing.Point(15, 235);
			this.btnMenuPerfil.Name = "btnMenuPerfil";
			this.btnMenuPerfil.Size = new System.Drawing.Size(224, 37);
			this.btnMenuPerfil.TabIndex = 5;
			this.btnMenuPerfil.Text = "Perfil";
			this.btnMenuPerfil.UseVisualStyleBackColor = false;
			this.btnMenuPerfil.Click += new System.EventHandler(this.btnMenuPerfil_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox3.Location = new System.Drawing.Point(5, 192);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(10, 37);
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// btnMenuAlumnos
			// 
			this.btnMenuAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnMenuAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenuAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenuAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuAlumnos.ForeColor = System.Drawing.Color.White;
			this.btnMenuAlumnos.Location = new System.Drawing.Point(15, 192);
			this.btnMenuAlumnos.Name = "btnMenuAlumnos";
			this.btnMenuAlumnos.Size = new System.Drawing.Size(224, 37);
			this.btnMenuAlumnos.TabIndex = 3;
			this.btnMenuAlumnos.Text = "Alumnos";
			this.btnMenuAlumnos.UseVisualStyleBackColor = false;
			this.btnMenuAlumnos.Click += new System.EventHandler(this.btnMenuAlumnos_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox2.Location = new System.Drawing.Point(5, 149);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(10, 37);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// btnMenuDocentes
			// 
			this.btnMenuDocentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnMenuDocentes.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenuDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenuDocentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuDocentes.ForeColor = System.Drawing.Color.White;
			this.btnMenuDocentes.Location = new System.Drawing.Point(15, 149);
			this.btnMenuDocentes.Name = "btnMenuDocentes";
			this.btnMenuDocentes.Size = new System.Drawing.Size(224, 37);
			this.btnMenuDocentes.TabIndex = 0;
			this.btnMenuDocentes.Text = "Docentes";
			this.btnMenuDocentes.UseVisualStyleBackColor = false;
			this.btnMenuDocentes.Click += new System.EventHandler(this.btnMenuDocentes_Click);
			// 
			// ContPrincipalAdmin
			// 
			this.ContPrincipalAdmin.Controls.Add(this.txtNombreUsuario);
			this.ContPrincipalAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ContPrincipalAdmin.Location = new System.Drawing.Point(245, 38);
			this.ContPrincipalAdmin.Name = "ContPrincipalAdmin";
			this.ContPrincipalAdmin.Size = new System.Drawing.Size(555, 501);
			this.ContPrincipalAdmin.TabIndex = 2;
			// 
			// txtNombreUsuario
			// 
			this.txtNombreUsuario.Location = new System.Drawing.Point(138, 123);
			this.txtNombreUsuario.Name = "txtNombreUsuario";
			this.txtNombreUsuario.Size = new System.Drawing.Size(206, 20);
			this.txtNombreUsuario.TabIndex = 0;
			// 
			// AdminForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 539);
			this.Controls.Add(this.ContPrincipalAdmin);
			this.Controls.Add(this.BarraMenuLateral);
			this.Controls.Add(this.BarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AdminForm";
			this.Text = "AdminForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			this.BarraMenuLateral.ResumeLayout(false);
			this.BarraMenuLateral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ContPrincipalAdmin.ResumeLayout(false);
			this.ContPrincipalAdmin.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenuLateral;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMenuDocentes;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnMenuCursos;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnMenuPerfil;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnMenuAlumnos;
        private System.Windows.Forms.PictureBox btnCerrarSesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContPrincipalAdmin;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.TextBox txtNombreUsuario;
	}
}