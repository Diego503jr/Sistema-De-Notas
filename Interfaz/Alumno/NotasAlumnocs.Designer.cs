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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.gridviewconsultanotas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultanotas)).BeginInit();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpromedio
            // 
            this.txtpromedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpromedio.BackColor = System.Drawing.Color.White;
            this.txtpromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpromedio.Location = new System.Drawing.Point(91, 58);
            this.txtpromedio.Multiline = true;
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(82, 46);
            this.txtpromedio.TabIndex = 7;
            this.txtpromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gridviewconsultanotas
            // 
            this.gridviewconsultanotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewconsultanotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gridviewconsultanotas.ColumnHeadersHeight = 50;
            this.gridviewconsultanotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Evaluacion,
            this.Evaluacion2,
            this.Evaluacion3,
            this.Evaluacion4,
            this.Nota});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewconsultanotas.DefaultCellStyle = dataGridViewCellStyle19;
            this.gridviewconsultanotas.Enabled = false;
            this.gridviewconsultanotas.EnableHeadersVisualStyles = false;
            this.gridviewconsultanotas.Location = new System.Drawing.Point(4, 340);
            this.gridviewconsultanotas.Name = "gridviewconsultanotas";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewconsultanotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gridviewconsultanotas.RowHeadersWidth = 51;
            this.gridviewconsultanotas.RowTemplate.Height = 24;
            this.gridviewconsultanotas.Size = new System.Drawing.Size(1316, 216);
            this.gridviewconsultanotas.TabIndex = 5;
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
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.Materia.DefaultCellStyle = dataGridViewCellStyle18;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.Width = 275;
            // 
            // Evaluacion
            // 
            this.Evaluacion.HeaderText = "Evaluación 1";
            this.Evaluacion.MinimumWidth = 6;
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Width = 135;
            // 
            // Evaluacion2
            // 
            this.Evaluacion2.HeaderText = "Evaluación 2";
            this.Evaluacion2.MinimumWidth = 6;
            this.Evaluacion2.Name = "Evaluacion2";
            this.Evaluacion2.Width = 135;
            // 
            // Evaluacion3
            // 
            this.Evaluacion3.HeaderText = "Evaluación 3";
            this.Evaluacion3.MinimumWidth = 6;
            this.Evaluacion3.Name = "Evaluacion3";
            this.Evaluacion3.Width = 135;
            // 
            // Evaluacion4
            // 
            this.Evaluacion4.HeaderText = "Evaluación 4";
            this.Evaluacion4.MinimumWidth = 6;
            this.Evaluacion4.Name = "Evaluacion4";
            this.Evaluacion4.Width = 135;
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota Final";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 135;
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
            // NotasAlumnocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 809);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.gridviewconsultanotas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasAlumnocs";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "NotasAlumnocs";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultanotas)).EndInit();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpromedio;
        private System.Windows.Forms.DataGridView gridviewconsultanotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
        private System.Windows.Forms.GroupBox groupbox;
    }
}