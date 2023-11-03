namespace SistemaDeNotas.Interfaz.Alumno
{
    partial class NotasAlumnocs
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
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpromedio
            // 
            this.txtpromedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpromedio.BackColor = System.Drawing.Color.White;
            this.txtpromedio.Enabled = false;
            this.txtpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpromedio.Location = new System.Drawing.Point(91, 58);
            this.txtpromedio.Multiline = true;
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(82, 46);
            this.txtpromedio.TabIndex = 7;
            this.txtpromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(45);
            this.label1.Size = new System.Drawing.Size(426, 132);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta de Notas.";
            // 
            // groupbox
            // 
            this.groupbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupbox.Controls.Add(this.txtpromedio);
            this.groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.ForeColor = System.Drawing.Color.Black;
            this.groupbox.Location = new System.Drawing.Point(526, 662);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(268, 134);
            this.groupbox.TabIndex = 8;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "  Promedio Final";
            // 
            // dgvNotas
            // 
            this.dgvNotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(28, 198);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.Size = new System.Drawing.Size(1273, 409);
            this.dgvNotas.TabIndex = 9;
            // 
            // NotasAlumnocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 809);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasAlumnocs";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "NotasAlumnocs";
            this.Load += new System.EventHandler(this.NotasAlumnocs_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.DataGridView dgvNotas;
    }
}