﻿using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Alumno
{
    public partial class NotasAlumnocs : Form
    {
        private string IdAlumno;
		public NotasAlumnocs(string id)
        {
            this.IdAlumno = id;
            InitializeComponent();
        }
        public void MostrarNotas()
        {
            int idAlumno = Convert.ToInt32(IdAlumno);
            dgvNotas.DataSource = ControllerAlumno.MostrarNotas(idAlumno);

        }

        private void NotasAlumnocs_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarNotas();
        }

        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvNotas.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNotas.DefaultCellStyle.ForeColor = Color.Black;
            dgvNotas.DefaultCellStyle.BackColor = Color.White;
            dgvNotas.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNotas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvNotas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvNotas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvNotas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotas.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvNotas.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvNotas.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }

		private void dgvNotas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            // Verifica si la fila seleccionada no es nula y si el índice de la celda es válido
            if (e.RowIndex >= 0 && dgvNotas.Rows[e.RowIndex].Cells["Promedio"].Value != null)
            {
                // Obtiene el valor de la celda "Promedio" solo si no es nulo
                if (double.TryParse(dgvNotas.Rows[e.RowIndex].Cells["Promedio"].Value.ToString(), out double promedio))
                {
                    // Muestra el promedio en el TextBox
                    txtpromedio.Text = promedio.ToString();

                    // Establece el estado de la materia
                    if (promedio >= 7)
                    {
                        txtEstadoMateria.Text = "APROBADO";
                    }
                    else
                    {
                        txtEstadoMateria.Text = "REPROBADO";
                    }
                }
                else
                {
                    MessageBox.Show("Promedio no valido", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No hay datos", "Upss!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

	}
}
