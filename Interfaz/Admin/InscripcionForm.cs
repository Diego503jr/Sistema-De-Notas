﻿using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class InscripcionForm : Form
    {
        ConstructorInscripcion inscripcion = new ConstructorInscripcion();
        public InscripcionForm()
        {
            InitializeComponent();
        }
        private void InscripcionForm_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarInscripcion();
            ListarCursosIns();
            ListarMateriasIns();
        }
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvInscripcion.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvInscripcion.DefaultCellStyle.ForeColor = Color.Black;
            dgvInscripcion.DefaultCellStyle.BackColor = Color.White;
            dgvInscripcion.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInscripcion.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvInscripcion.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvInscripcion.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvInscripcion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInscripcion.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Alinear el contenido de las celdas al centro
            dgvInscripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Configurar la selección de celdas
            dgvInscripcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripcion.MultiSelect = false;

            // Autoajustar el ancho de las columnas
            dgvInscripcion.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        public void ListarMateriasIns()
        {
            cbMaterias.DataSource = FuncionesAdministrador.ListarMaterias();
            cbMaterias.DisplayMember = "Nombre";
            cbMaterias.ValueMember = "Id";
            cbMaterias.Text = null;
        }

        public void ListarCursosIns()
        {
            cbCursos.DataSource = FuncionesAdministrador.ListarCursos();
            cbCursos.DisplayMember = "Nombre";
            cbCursos.ValueMember = "Id";
            cbCursos.Text = null;
        }

        public void MostrarInscripcion()
        {
            dgvInscripcion.DataSource = FuncionesAdministrador.MostrarInscripcion();
            dgvInscripcion.Columns[0].HeaderText = "IdInscripcion";
            dgvInscripcion.Columns[1].HeaderText = "IdAlumno";
            dgvInscripcion.Columns[2].HeaderText = "IdCurso";
            dgvInscripcion.Columns[3].HeaderText = "IdMateria";

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "")
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nombre = txtNombre.Text;
                string carnet = txtCarnet.Text;
                int idAlumno = ObtenerIdUsuario(nombre, carnet);

                if (idAlumno > -1)
                {
                    inscripcion.IdAlumno = idAlumno;
                    inscripcion.IdCurso = Convert.ToInt32(cbCursos.SelectedValue);
                    inscripcion.IdMateria = Convert.ToInt32(cbMaterias.SelectedValue);
                    FuncionesAdministrador.AgregarInscripcion(inscripcion);
                    MostrarInscripcion();
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static int ObtenerIdUsuario(string nombre, string carnet)
        {
            int idUsuario = -1;

            try
            {
                CConexion conexion = new CConexion();
                string query = "SELECT Id FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND IdRol = 2";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@carnet", carnet);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idUsuario = (int)reader["Id"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return idUsuario;
        }
    }
}
