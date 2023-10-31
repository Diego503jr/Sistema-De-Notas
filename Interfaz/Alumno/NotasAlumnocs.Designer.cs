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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridviewconsultanotas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultanotas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(728, 421);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 41);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(538, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio Final:";
            // 
            // gridviewconsultanotas
            // 
            this.gridviewconsultanotas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridviewconsultanotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewconsultanotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewconsultanotas.ColumnHeadersHeight = 50;
            this.gridviewconsultanotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Materia,
            this.Evaluacion,
            this.Evaluacion2,
            this.Evaluacion3,
            this.Evaluacion4,
            this.Nota});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewconsultanotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewconsultanotas.Enabled = false;
            this.gridviewconsultanotas.Location = new System.Drawing.Point(39, 168);
            this.gridviewconsultanotas.Name = "gridviewconsultanotas";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(20);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewconsultanotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewconsultanotas.RowHeadersWidth = 51;
            this.gridviewconsultanotas.RowTemplate.Height = 24;
            this.gridviewconsultanotas.Size = new System.Drawing.Size(1259, 166);
            this.gridviewconsultanotas.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta de Notas.";
            // 
            // Nota
            // 
            this.Nota.HeaderText = "Nota Final";
            this.Nota.MinimumWidth = 6;
            this.Nota.Name = "Nota";
            this.Nota.Width = 125;
            // 
            // Evaluacion4
            // 
            this.Evaluacion4.HeaderText = "Evaluación 4";
            this.Evaluacion4.MinimumWidth = 6;
            this.Evaluacion4.Name = "Evaluacion4";
            this.Evaluacion4.Width = 125;
            // 
            // Evaluacion3
            // 
            this.Evaluacion3.HeaderText = "Evaluación 3";
            this.Evaluacion3.MinimumWidth = 6;
            this.Evaluacion3.Name = "Evaluacion3";
            this.Evaluacion3.Width = 125;
            // 
            // Evaluacion2
            // 
            this.Evaluacion2.HeaderText = "Evaluación 2";
            this.Evaluacion2.MinimumWidth = 6;
            this.Evaluacion2.Name = "Evaluacion2";
            this.Evaluacion2.Width = 125;
            // 
            // Evaluacion
            // 
            this.Evaluacion.HeaderText = "Evaluación 1";
            this.Evaluacion.MinimumWidth = 6;
            this.Evaluacion.Name = "Evaluacion";
            this.Evaluacion.Width = 125;
            // 
            // Materia
            // 
            this.Materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Materia.HeaderText = "Materia";
            this.Materia.MinimumWidth = 6;
            this.Materia.Name = "Materia";
            this.Materia.Width = 275;
            // 
            // NotasAlumnocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 540);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridviewconsultanotas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotasAlumnocs";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "NotasAlumnocs";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewconsultanotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridviewconsultanotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evaluacion4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}