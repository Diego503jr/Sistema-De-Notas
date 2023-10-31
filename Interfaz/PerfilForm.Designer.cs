namespace SistemaDeNotas
{
    partial class PerfilForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.txtcarnet = new System.Windows.Forms.TextBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtestado = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.PbLogoUsuario = new System.Windows.Forms.PictureBox();
			this.gBNombre = new System.Windows.Forms.GroupBox();
			this.gBCarnet = new System.Windows.Forms.GroupBox();
			this.gBEstado = new System.Windows.Forms.GroupBox();
			this.gBTelefono = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbLogoUsuario)).BeginInit();
			this.gBNombre.SuspendLayout();
			this.gBCarnet.SuspendLayout();
			this.gBEstado.SuspendLayout();
			this.gBTelefono.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.label1.Location = new System.Drawing.Point(443, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Perfil";
			// 
			// txtnombre
			// 
			this.txtnombre.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtnombre.BackColor = System.Drawing.Color.White;
			this.txtnombre.Enabled = false;
			this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(52, 43);
			this.txtnombre.Margin = new System.Windows.Forms.Padding(2);
			this.txtnombre.Multiline = true;
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(205, 36);
			this.txtnombre.TabIndex = 5;
			this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtcarnet
			// 
			this.txtcarnet.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtcarnet.BackColor = System.Drawing.Color.White;
			this.txtcarnet.Enabled = false;
			this.txtcarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcarnet.Location = new System.Drawing.Point(77, 43);
			this.txtcarnet.Margin = new System.Windows.Forms.Padding(2);
			this.txtcarnet.Multiline = true;
			this.txtcarnet.Name = "txtcarnet";
			this.txtcarnet.Size = new System.Drawing.Size(205, 36);
			this.txtcarnet.TabIndex = 6;
			this.txtcarnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txttelefono
			// 
			this.txttelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txttelefono.BackColor = System.Drawing.Color.White;
			this.txttelefono.Enabled = false;
			this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttelefono.Location = new System.Drawing.Point(44, 35);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(2);
			this.txttelefono.Multiline = true;
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(205, 36);
			this.txttelefono.TabIndex = 7;
			this.txttelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtestado
			// 
			this.txtestado.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.txtestado.BackColor = System.Drawing.Color.White;
			this.txtestado.Enabled = false;
			this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtestado.Location = new System.Drawing.Point(77, 35);
			this.txtestado.Margin = new System.Windows.Forms.Padding(2);
			this.txtestado.Multiline = true;
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(205, 36);
			this.txtestado.TabIndex = 8;
			this.txtestado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1053, 100);
			this.panel1.TabIndex = 9;
			// 
			// PbLogoUsuario
			// 
			this.PbLogoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PbLogoUsuario.Image = global::SistemaDeNotas.Properties.Resources.Logo_Usuario;
			this.PbLogoUsuario.Location = new System.Drawing.Point(456, 149);
			this.PbLogoUsuario.Name = "PbLogoUsuario";
			this.PbLogoUsuario.Size = new System.Drawing.Size(130, 88);
			this.PbLogoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PbLogoUsuario.TabIndex = 10;
			this.PbLogoUsuario.TabStop = false;
			// 
			// gBNombre
			// 
			this.gBNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.gBNombre.Controls.Add(this.txtnombre);
			this.gBNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.gBNombre.Location = new System.Drawing.Point(106, 312);
			this.gBNombre.Margin = new System.Windows.Forms.Padding(2);
			this.gBNombre.Name = "gBNombre";
			this.gBNombre.Padding = new System.Windows.Forms.Padding(2);
			this.gBNombre.Size = new System.Drawing.Size(329, 99);
			this.gBNombre.TabIndex = 0;
			this.gBNombre.TabStop = false;
			this.gBNombre.Text = "Nombre";
			// 
			// gBCarnet
			// 
			this.gBCarnet.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.gBCarnet.Controls.Add(this.txtcarnet);
			this.gBCarnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.gBCarnet.Location = new System.Drawing.Point(617, 312);
			this.gBCarnet.Margin = new System.Windows.Forms.Padding(2);
			this.gBCarnet.Name = "gBCarnet";
			this.gBCarnet.Padding = new System.Windows.Forms.Padding(2);
			this.gBCarnet.Size = new System.Drawing.Size(329, 99);
			this.gBCarnet.TabIndex = 0;
			this.gBCarnet.TabStop = false;
			this.gBCarnet.Text = "Carnet";
			// 
			// gBEstado
			// 
			this.gBEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.gBEstado.Controls.Add(this.txtestado);
			this.gBEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.gBEstado.Location = new System.Drawing.Point(617, 467);
			this.gBEstado.Margin = new System.Windows.Forms.Padding(2);
			this.gBEstado.Name = "gBEstado";
			this.gBEstado.Padding = new System.Windows.Forms.Padding(2);
			this.gBEstado.Size = new System.Drawing.Size(329, 99);
			this.gBEstado.TabIndex = 0;
			this.gBEstado.TabStop = false;
			this.gBEstado.Text = "Estado";
			// 
			// gBTelefono
			// 
			this.gBTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.gBTelefono.Controls.Add(this.txttelefono);
			this.gBTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.gBTelefono.Location = new System.Drawing.Point(106, 467);
			this.gBTelefono.Margin = new System.Windows.Forms.Padding(2);
			this.gBTelefono.Name = "gBTelefono";
			this.gBTelefono.Padding = new System.Windows.Forms.Padding(2);
			this.gBTelefono.Size = new System.Drawing.Size(329, 99);
			this.gBTelefono.TabIndex = 0;
			this.gBTelefono.TabStop = false;
			this.gBTelefono.Text = "Teléfono";
			// 
			// PerfilForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1053, 655);
			this.Controls.Add(this.gBTelefono);
			this.Controls.Add(this.gBEstado);
			this.Controls.Add(this.gBCarnet);
			this.Controls.Add(this.gBNombre);
			this.Controls.Add(this.PbLogoUsuario);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "PerfilForm";
			this.Text = "Perfil";
			this.Load += new System.EventHandler(this.PerfilForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PbLogoUsuario)).EndInit();
			this.gBNombre.ResumeLayout(false);
			this.gBNombre.PerformLayout();
			this.gBCarnet.ResumeLayout(false);
			this.gBCarnet.PerformLayout();
			this.gBEstado.ResumeLayout(false);
			this.gBEstado.PerformLayout();
			this.gBTelefono.ResumeLayout(false);
			this.gBTelefono.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcarnet;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtestado;
		public System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox PbLogoUsuario;
		private System.Windows.Forms.GroupBox gBNombre;
		private System.Windows.Forms.GroupBox gBCarnet;
		private System.Windows.Forms.GroupBox gBEstado;
		private System.Windows.Forms.GroupBox gBTelefono;
	}
}