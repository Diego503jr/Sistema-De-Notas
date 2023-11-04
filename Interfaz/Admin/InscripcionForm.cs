using SistemaDeNotas.Clases;
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
        int posicion;
        public InscripcionForm()
        {
            InitializeComponent();
        }

        public void ConfigurarTextbox(string nombreAlumno, string carnetAlumno)
        {
            txtNombre.Text = nombreAlumno;
            txtCarnet.Text = carnetAlumno;
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

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvInscripcion.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvInscripcion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvInscripcion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvInscripcion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInscripcion.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvInscripcion.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvInscripcion.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }
        public void ListarMateriasIns()
        {
            cbMaterias.DataSource = FuncionesAdministrador.ListarMaterias();
            cbMaterias.DisplayMember = "Nombre";
            cbMaterias.ValueMember = "Id";
            cbMaterias.Text = null;

            cbMaterias.SelectedIndexChanged += (sender, e) =>
            {
                if (cbMaterias.SelectedIndex != -1)
                {
                    int IdDocente = Convert.ToInt32(((DataRowView)cbMaterias.SelectedItem)["IdDocente"]);
                    string nombreDocente = ObtenerNombreDocente(IdDocente);
                    txtDocente.Text = nombreDocente;
                }
                else
                {
                    txtDocente.Text = string.Empty;
                }
            };
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
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            Insertar();
        }

        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || cbCursos.SelectedIndex == -1 || cbMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nombre = txtNombre.Text;
                string carnet = txtCarnet.Text;
                int idAlumno = ObtenerIdAlumno(nombre, carnet);

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

        private void btnActualizarInscripcion_Click(object sender, EventArgs e)
        {
            ActualizarInscripcion();
        }

        public void ActualizarInscripcion()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || cbCursos.SelectedIndex == -1 || cbMaterias.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Nombre = txtNombre.Text;
                string Carnet = txtCarnet.Text;

                int idAlumno = ObtenerIdAlumno(Nombre, Carnet);

                if (idAlumno > -1)
                {
                    int id = (int)dgvInscripcion.SelectedRows[0].Cells["Id"].Value;
                    inscripcion.IdAlumno = idAlumno;
                    inscripcion.IdCurso = Convert.ToInt32(cbCursos.SelectedValue);
                    inscripcion.IdMateria = Convert.ToInt32(cbMaterias.SelectedValue);
                    inscripcion.Id = id;
                    FuncionesAdministrador.ActualizarInscripcion(inscripcion);
                    MostrarInscripcion();
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static string ObtenerNombreDocente(int IdDocente)
        {
            CConexion conexion = new CConexion();

            try
            {
                string query = "SELECT Nombre FROM dbo.Usuarios WHERE Id = @idDocente";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idDocente", IdDocente);
                string nombreDocente = (string)cmd.ExecuteScalar();
                return nombreDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static int ObtenerIdAlumno(string nombre, string carnet)
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

        private void dgvInscripcion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CConexion conexion = new CConexion();
            if (e.RowIndex >= 0)
            {
                //Obteniendo la fila seleccionada
                DataGridViewRow row = dgvInscripcion.Rows[e.RowIndex];

				//Obteniendo el valor del campo IdAlumno, IdCurso, IdMateria de la fila seleccionada
			
				string idAlumno = row.Cells["Nombre"].Value.ToString();
				string idCurso = row.Cells["Curso"].Value.ToString();
				string idMateria = row.Cells["Materia"].Value.ToString();

				//Se hacen las consulta SQL a las 3 tablas
				string queryAlumno = "SELECT Nombre, Carnet FROM dbo.Usuarios WHERE Nombre = @idAlumno";
                string queryCurso = "SELECT Nombre FROM dbo.Cursos WHERE Nombre = @idCurso";
                string queryMaterias = "SELECT Nombre, IdDocente FROM dbo.Materias WHERE Nombre = @idMateria";

                SqlCommand cmdAlumno = new SqlCommand(queryAlumno, conexion.establecerConexion());
                SqlCommand cmdCurso = new SqlCommand(queryCurso, conexion.establecerConexion());
                SqlCommand cmdMateria = new SqlCommand(queryMaterias, conexion.establecerConexion());
                cmdAlumno.Parameters.AddWithValue("@idAlumno", idAlumno);
                cmdCurso.Parameters.AddWithValue("@idCurso", idCurso);
                cmdMateria.Parameters.AddWithValue("@idMateria", idMateria);

                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                if (drAlumno.Read() && drCurso.Read() && drMateria.Read())
                {
                    string nombre = drAlumno["Nombre"].ToString();
                    string carnet = drAlumno["Carnet"].ToString();
                    string curso = drCurso["Nombre"].ToString();
                    string materia = drMateria["Nombre"].ToString();

                    txtNombre.Text = nombre;
                    txtCarnet.Text = carnet;
                    cbCursos.Text = curso;
                    cbMaterias.Text = materia;
                }
                else
                {
                    MessageBox.Show("No hay registros de un dato");
                }
                btnInscribir.Enabled = false;
                btnActualizarInscripcion.Enabled = true;
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            AlumnosListForm alumnosListForm = new AlumnosListForm(this);
            alumnosListForm.ShowDialog();
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltroNombre.Text.Trim();
            if (!string.IsNullOrEmpty(buscar))
            {
                // Realiza la búsqueda en la fuente de datos y filtra los resultados
                (dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = $"Materia LIKE '%{buscar}%'";
            }
            else
            {
                // Si el cuadro de búsqueda está vacío, muestra todos los datos
                (dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCarnet.Clear();
            txtFiltroNombre.Clear();
            cbCursos.Text = null; 
            cbMaterias.Text = null;

            if (dgvInscripcion.SelectedRows.Count > 0)
            {
                dgvInscripcion.SelectedRows[0].Selected = false;
            }
            foreach (DataGridViewRow row in dgvInscripcion.SelectedRows)
            {
                row.Selected = false;
            }
            btnActualizarInscripcion.Enabled = true;
        }
    }
}
