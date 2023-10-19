namespace SistemaDeNotas
{
    partial class DocenteForm
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BarraMenuLateral = new System.Windows.Forms.Panel();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.btnMenuCursos = new System.Windows.Forms.Button();
			this.BarraTitulo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.BarraMenuLateral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// BarraTitulo
			// 
			this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.BarraTitulo.Controls.Add(this.pictureBox1);
			this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
			this.BarraTitulo.Name = "BarraTitulo";
			this.BarraTitulo.Size = new System.Drawing.Size(800, 38);
			this.BarraTitulo.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::SistemaDeNotas.Properties.Resources.cerrar;
			this.pictureBox1.Location = new System.Drawing.Point(763, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// BarraMenuLateral
			// 
			this.BarraMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.BarraMenuLateral.Controls.Add(this.pictureBox5);
			this.BarraMenuLateral.Controls.Add(this.btnMenuCursos);
			this.BarraMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
			this.BarraMenuLateral.Location = new System.Drawing.Point(0, 38);
			this.BarraMenuLateral.Name = "BarraMenuLateral";
			this.BarraMenuLateral.Size = new System.Drawing.Size(245, 507);
			this.BarraMenuLateral.TabIndex = 1;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.pictureBox5.Location = new System.Drawing.Point(2, 210);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(10, 37);
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// btnMenuCursos
			// 
			this.btnMenuCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
			this.btnMenuCursos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMenuCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMenuCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenuCursos.ForeColor = System.Drawing.Color.White;
			this.btnMenuCursos.Location = new System.Drawing.Point(12, 210);
			this.btnMenuCursos.Name = "btnMenuCursos";
			this.btnMenuCursos.Size = new System.Drawing.Size(224, 37);
			this.btnMenuCursos.TabIndex = 9;
			this.btnMenuCursos.Text = "Cursos";
			this.btnMenuCursos.UseVisualStyleBackColor = false;
			// 
			// DocenteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 545);
			this.Controls.Add(this.BarraMenuLateral);
			this.Controls.Add(this.BarraTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "DocenteForm";
			this.Text = "DocenteForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.BarraTitulo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.BarraMenuLateral.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel BarraMenuLateral;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button btnMenuCursos;
	}
}