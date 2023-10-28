namespace SistemaDeNotas
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
			this.label1 = new System.Windows.Forms.Label();
			this.BarraTitulo = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.PictureBox();
			this.lblCarnet = new System.Windows.Forms.Label();
			this.lblContraseña = new System.Windows.Forms.Label();
			this.txtCarnet = new System.Windows.Forms.TextBox();
			this.txtContraseña = new System.Windows.Forms.TextBox();
			this.btnIniciarSesion = new System.Windows.Forms.Button();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(371, 98);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 29);
			this.label1.TabIndex = 7;
			this.label1.Text = "Inicio de sesión";
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.BarraTitulo.Controls.Add(this.btnCerrar);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(896, 38);
			this.BarraTitulo.TabIndex = 6;
			this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
			// 
			// btnCerrar
			// 
			this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCerrar.Image = global::SistemaDeNotas.Properties.Resources.cerrar;
			this.btnCerrar.Location = new System.Drawing.Point(859, 5);
			this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(26, 25);
			this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnCerrar.TabIndex = 7;
			this.btnCerrar.TabStop = false;
			this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
			// 
			// lblCarnet
			// 
			this.lblCarnet.AutoSize = true;
			this.lblCarnet.Location = new System.Drawing.Point(357, 191);
			this.lblCarnet.Name = "lblCarnet";
			this.lblCarnet.Size = new System.Drawing.Size(38, 13);
			this.lblCarnet.TabIndex = 0;
			this.lblCarnet.Text = "Carnet";
			// 
			// lblContraseña
			// 
			this.lblContraseña.AutoSize = true;
			this.lblContraseña.Location = new System.Drawing.Point(334, 250);
			this.lblContraseña.Name = "lblContraseña";
			this.lblContraseña.Size = new System.Drawing.Size(61, 13);
			this.lblContraseña.TabIndex = 0;
			this.lblContraseña.Text = "Contraseña";
			// 
			// txtCarnet
			// 
			this.txtCarnet.Location = new System.Drawing.Point(413, 188);
			this.txtCarnet.Name = "txtCarnet";
			this.txtCarnet.Size = new System.Drawing.Size(100, 20);
			this.txtCarnet.TabIndex = 1;
			// 
			// txtContraseña
			// 
			this.txtContraseña.Location = new System.Drawing.Point(413, 250);
			this.txtContraseña.Name = "txtContraseña";
			this.txtContraseña.Size = new System.Drawing.Size(100, 20);
			this.txtContraseña.TabIndex = 2;
			// 
			// btnIniciarSesion
			// 
			this.btnIniciarSesion.Location = new System.Drawing.Point(376, 323);
			this.btnIniciarSesion.Name = "btnIniciarSesion";
			this.btnIniciarSesion.Size = new System.Drawing.Size(115, 23);
			this.btnIniciarSesion.TabIndex = 3;
			this.btnIniciarSesion.Text = "Iniciar Sesión";
			this.btnIniciarSesion.UseVisualStyleBackColor = true;
			this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(896, 477);
			this.Controls.Add(this.btnIniciarSesion);
			this.Controls.Add(this.txtContraseña);
			this.Controls.Add(this.txtCarnet);
			this.Controls.Add(this.lblContraseña);
			this.Controls.Add(this.lblCarnet);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BarraTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "LoginForm";
			this.Text = "Inicio de Sesión";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
		private System.Windows.Forms.Label lblCarnet;
		private System.Windows.Forms.Label lblContraseña;
		private System.Windows.Forms.TextBox txtCarnet;
		private System.Windows.Forms.TextBox txtContraseña;
		private System.Windows.Forms.Button btnIniciarSesion;
	}
}

