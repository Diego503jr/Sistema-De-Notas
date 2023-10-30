namespace SistemaDeNotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.BarraMenuLateral = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnMenuCursos = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnMenuPerfil = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnMenuAlumnos = new System.Windows.Forms.Button();
            this.ContPrincipalAdmin = new System.Windows.Forms.Panel();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.BarraFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.BarraMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ContPrincipalAdmin.SuspendLayout();
            this.BarraFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.BarraTitulo.Controls.Add(this.label4);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1155, 60);
            this.BarraTitulo.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Panel Admin";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SistemaDeNotas.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(1092, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BarraMenuLateral
            // 
            this.BarraMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.BarraMenuLateral.Controls.Add(this.pictureBox6);
            this.BarraMenuLateral.Controls.Add(this.label1);
            this.BarraMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.BarraMenuLateral.Controls.Add(this.pictureBox5);
            this.BarraMenuLateral.Controls.Add(this.btnMenuCursos);
            this.BarraMenuLateral.Controls.Add(this.pictureBox4);
            this.BarraMenuLateral.Controls.Add(this.btnMenuPerfil);
            this.BarraMenuLateral.Controls.Add(this.pictureBox3);
            this.BarraMenuLateral.Controls.Add(this.btnMenuAlumnos);
            this.BarraMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraMenuLateral.Location = new System.Drawing.Point(0, 60);
            this.BarraMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.BarraMenuLateral.Name = "BarraMenuLateral";
            this.BarraMenuLateral.Size = new System.Drawing.Size(410, 735);
            this.BarraMenuLateral.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SistemaDeNotas.Properties.Resources.ITCA_RemoveBG;
            this.pictureBox6.Location = new System.Drawing.Point(3, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(400, 161);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 658);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cerrar Sesion";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Image = global::SistemaDeNotas.Properties.Resources.cerrarSesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(58, 625);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(101, 95);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox5.Location = new System.Drawing.Point(0, 338);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(13, 46);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // btnMenuCursos
            // 
            this.btnMenuCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuCursos.FlatAppearance.BorderSize = 0;
            this.btnMenuCursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCursos.ForeColor = System.Drawing.Color.White;
            this.btnMenuCursos.Location = new System.Drawing.Point(13, 338);
            this.btnMenuCursos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuCursos.Name = "btnMenuCursos";
            this.btnMenuCursos.Size = new System.Drawing.Size(397, 46);
            this.btnMenuCursos.TabIndex = 7;
            this.btnMenuCursos.Text = "Cursos";
            this.btnMenuCursos.UseVisualStyleBackColor = false;
            this.btnMenuCursos.Click += new System.EventHandler(this.btnMenuCursos_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox4.Location = new System.Drawing.Point(0, 285);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(13, 46);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // btnMenuPerfil
            // 
            this.btnMenuPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuPerfil.FlatAppearance.BorderSize = 0;
            this.btnMenuPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPerfil.ForeColor = System.Drawing.Color.White;
            this.btnMenuPerfil.Location = new System.Drawing.Point(13, 285);
            this.btnMenuPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuPerfil.Name = "btnMenuPerfil";
            this.btnMenuPerfil.Size = new System.Drawing.Size(397, 46);
            this.btnMenuPerfil.TabIndex = 5;
            this.btnMenuPerfil.Text = "Perfil";
            this.btnMenuPerfil.UseVisualStyleBackColor = false;
            this.btnMenuPerfil.Click += new System.EventHandler(this.btnMenuPerfil_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.pictureBox3.Location = new System.Drawing.Point(0, 232);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 46);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnMenuAlumnos
            // 
            this.btnMenuAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.btnMenuAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuAlumnos.FlatAppearance.BorderSize = 0;
            this.btnMenuAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.btnMenuAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAlumnos.ForeColor = System.Drawing.Color.White;
            this.btnMenuAlumnos.Location = new System.Drawing.Point(13, 232);
            this.btnMenuAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuAlumnos.Name = "btnMenuAlumnos";
            this.btnMenuAlumnos.Size = new System.Drawing.Size(397, 46);
            this.btnMenuAlumnos.TabIndex = 3;
            this.btnMenuAlumnos.Text = "Usuarios";
            this.btnMenuAlumnos.UseVisualStyleBackColor = false;
            this.btnMenuAlumnos.Click += new System.EventHandler(this.btnMenuAlumnos_Click);
            // 
            // ContPrincipalAdmin
            // 
            this.ContPrincipalAdmin.AutoSize = true;
            this.ContPrincipalAdmin.Controls.Add(this.txtNombreUsuario);
            this.ContPrincipalAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContPrincipalAdmin.Location = new System.Drawing.Point(410, 60);
            this.ContPrincipalAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.ContPrincipalAdmin.Name = "ContPrincipalAdmin";
            this.ContPrincipalAdmin.Size = new System.Drawing.Size(745, 675);
            this.ContPrincipalAdmin.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreUsuario.BackColor = System.Drawing.Color.White;
            this.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(88, 64);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.Multiline = true;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(593, 45);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // BarraFooter
            // 
            this.BarraFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.BarraFooter.Controls.Add(this.label3);
            this.BarraFooter.Controls.Add(this.label2);
            this.BarraFooter.Controls.Add(this.lblFecha);
            this.BarraFooter.Controls.Add(this.lblHora);
            this.BarraFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BarraFooter.Location = new System.Drawing.Point(410, 735);
            this.BarraFooter.Name = "BarraFooter";
            this.BarraFooter.Size = new System.Drawing.Size(745, 60);
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
            this.label3.TabIndex = 3;
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
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora :";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(566, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(92, 32);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(102, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(92, 32);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label2";
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 795);
            this.Controls.Add(this.ContPrincipalAdmin);
            this.Controls.Add(this.BarraFooter);
            this.Controls.Add(this.BarraMenuLateral);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.BarraMenuLateral.ResumeLayout(false);
            this.BarraMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ContPrincipalAdmin.ResumeLayout(false);
            this.ContPrincipalAdmin.PerformLayout();
            this.BarraFooter.ResumeLayout(false);
            this.BarraFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenuLateral;
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
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel BarraFooter;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label4;
    }
}