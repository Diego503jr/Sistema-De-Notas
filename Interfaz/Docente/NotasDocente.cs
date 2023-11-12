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
using System.Data.SqlClient;

namespace SistemaDeNotas.Interfaz.Docente
{
	public partial class NotasDocente : Form
	{
        private string IDDOCENTE;

		public NotasDocente(string id)
		{
            this.IDDOCENTE = id;
			InitializeComponent();
		}

		private void MostrarNotas()
		{
            int idDocente = Convert.ToInt32(IDDOCENTE);
			dgvNotasDocente.DataSource = FuncionesDocente.MostrarNotas(idDocente);
		}

        private void DocentesNotas()
        {
            int idDocente = Convert.ToInt32(IDDOCENTE);
            cbRegistroNotas.DataSource = FuncionesAdministrador.ListarMateriaDocente(idDocente);
        }

        private void NotasDocente_Load(object sender, EventArgs e)
        {
			MostrarNotas();
            DocentesNotas();
            ListarMaterias();
			ConfigurarDataGridView();
        }
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvNotasDocente.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvNotasDocente.DefaultCellStyle.ForeColor = Color.Black;
            dgvNotasDocente.DefaultCellStyle.BackColor = Color.White;
            dgvNotasDocente.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvNotasDocente.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvNotasDocente.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvNotasDocente .ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvNotasDocente.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvNotasDocente .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvNotasDocente .SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotasDocente.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvNotasDocente.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvNotasDocente.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }

        private void dgvNotasDocente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CConexion conexion = new CConexion();
            if (e.RowIndex >= 0) 
            {
                //Obteniendo la fila seleccionada
                DataGridViewRow row = dgvNotasDocente.Rows[e.RowIndex];

                //Obteniendo el valor del campo IdAlumno, IdCurso, IdMateria de la fila seleccionada
                string UsuarioId = row.Cells["Nombre"].Value.ToString();
                string MateriaId = row.Cells["Materia"].Value.ToString();
                string NotasEvaluacion1 = row.Cells["Nota1"].Value.ToString();
                string NotasEvaluacion2 = row.Cells["Nota2"].Value.ToString();
                string NotasEvaluacion3 = row.Cells["Nota3"].Value.ToString();
                string NotasEvaluacion4 = row.Cells["Nota4"].Value.ToString();
                string NotasPromedio = row.Cells["Promedio"].Value.ToString();

                txtNota1.Text = NotasEvaluacion1;
                txtNota2.Text = NotasEvaluacion2;
                txtNota3.Text = NotasEvaluacion3;
                txtNota4.Text = NotasEvaluacion4;
                txtPromedio.Text = NotasPromedio;

                //Se hacen las consulta SQL a las 3 tablas

                string queryAlumno = "SELECT Nombre, Carnet FROM dbo.Usuarios WHERE Nombre = @UsuarioId";
                string queryMateria = "SELECT Nombre FROM dbo.Materias WHERE Nombre = @MateriaId";

                SqlCommand cmdAlumno = new SqlCommand(queryAlumno, conexion.establecerConexion());
                SqlCommand cmdMateria = new SqlCommand(queryMateria, conexion.establecerConexion());
                cmdAlumno.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                cmdMateria.Parameters.AddWithValue("@MateriaId", MateriaId);

                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                if (drAlumno.Read()  && drMateria.Read())
                {
                    string  NombreUsuario = drAlumno["Nombre"].ToString();
                    string NombreMateria = drMateria["Nombre"].ToString();


                    txtNombre.Text = NombreUsuario;
                    cbRegistroNotas.Text = NombreMateria;

                }
                else
                {
                    MessageBox.Show("No hay registros de un dato");
                }

            }
        }
        public void ListarMaterias()
        {
            cbRegistroNotas.DataSource = FuncionesAdministrador.ListarMaterias();
            cbRegistroNotas.DisplayMember = "Nombre";
            cbRegistroNotas.ValueMember = "Id";
            cbRegistroNotas.Text = null;
        }
    }
}
