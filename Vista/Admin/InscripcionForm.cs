using SistemaDeNotas.Clases;
using SistemaDeNotas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class InscripcionForm : Form
    {
        Inscripcion inscripcion = new Inscripcion();
        int posicion;
        public InscripcionForm()
        {
            InitializeComponent();
            txtNombre.KeyPress += TxtNombre_KeyPress;
            txtCarnet.KeyPress += TxtCarnet_KeyPress;
            txtFiltroNombre.KeyPress += TxtFiltroNombre_KeyPress;
        }

        private void TxtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControllerGlobales.ManejoErrores(e);
		}

        private void TxtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControllerGlobales.ManejoErrores(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControllerGlobales.ManejoErroresNombre(e);
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
            ListarEstado();
            btnActualizarInscripcion.Enabled = false;
            btnEliminarInscrip.Enabled = false;
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
            cbMaterias.DataSource = ControllerGlobales.ListarMaterias();
            cbMaterias.DisplayMember = "Nombre";
            cbMaterias.ValueMember = "Id";
            cbMaterias.Text = null;

            cbMaterias.SelectedIndexChanged += (sender, e) =>
            {
                if (cbMaterias.SelectedIndex != -1)
                {
                    int IdDocente = Convert.ToInt32(((DataRowView)cbMaterias.SelectedItem)["IdDocente"]);
                    string nombreDocente = ControllerSearch.ObtenerNombreDocente(IdDocente);
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
            cbCursos.DataSource = ControllerGlobales.ListarCursos();
            cbCursos.DisplayMember = "Nombre";
            cbCursos.ValueMember = "Id";
            cbCursos.Text = null;
        }

        public void MostrarInscripcion()
        {
            dgvInscripcion.DataSource = ControllerAdministrador.MostrarInscripcion();
        }

        public void ListarEstado()
        {
            cbEstado.DataSource = ControllerGlobales.ListarEstado();
            cbEstado.DisplayMember = "EstadoValor";
            cbEstado.ValueMember = "Id";
            cbEstado.Text = null;

			cmbFiltroEstado.DataSource = ControllerGlobales.ListarEstado();
			cmbFiltroEstado.DisplayMember = "EstadoValor";
			cmbFiltroEstado.ValueMember = "Id";
			cmbFiltroEstado.Text = null;
		}

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            Insertar();
			Limpiar();
		}

        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || cbCursos.SelectedIndex == -1 || cbMaterias.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nombre = txtNombre.Text;
                string carnet = txtCarnet.Text;
                int idAlumno = ControllerSearch.ObtenerIdAlumno(nombre, carnet);

                if (idAlumno > -1)
                {
                    inscripcion.IdAlumno = idAlumno;
                    inscripcion.IdCurso = Convert.ToInt32(cbCursos.SelectedValue);
                    inscripcion.IdMateria = Convert.ToInt32(cbMaterias.SelectedValue);
                    inscripcion.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                    ControllerAdministrador.AgregarInscripcion(inscripcion);
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
			Limpiar();
		}

        public void ActualizarInscripcion()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || cbCursos.SelectedIndex == -1 || cbMaterias.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string Nombre = txtNombre.Text;
                string Carnet = txtCarnet.Text;

                int idAlumno = ControllerSearch.ObtenerIdAlumno(Nombre, Carnet);

                if (idAlumno > -1)
                {
                    int id = (int)dgvInscripcion.SelectedRows[0].Cells["Id"].Value;
                    inscripcion.IdAlumno = idAlumno;
                    inscripcion.IdCurso = Convert.ToInt32(cbCursos.SelectedValue);
                    inscripcion.IdMateria = Convert.ToInt32(cbMaterias.SelectedValue);
                    inscripcion.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                    inscripcion.Id = id;
                    ControllerAdministrador.ActualizarInscripcion(inscripcion);
                    MostrarInscripcion();
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                string idEstado = row.Cells["Estado"].Value.ToString();

                //Se hacen las consulta SQL a las 3 tablas
                string queryAlumno = "SELECT Nombre, Carnet FROM dbo.Usuarios WHERE Nombre = @idAlumno";
                string queryCurso = "SELECT Nombre FROM dbo.Cursos WHERE Nombre = @idCurso";
                string queryMaterias = "SELECT Nombre, IdDocente FROM dbo.Materias WHERE Nombre = @idMateria";
                string queryEstado = "SELECT EstadoValor FROM dbo.Estado WHERE EstadoValor = @idestado";


                SqlCommand cmdAlumno = new SqlCommand(queryAlumno, conexion.establecerConexion());
                SqlCommand cmdCurso = new SqlCommand(queryCurso, conexion.establecerConexion());
                SqlCommand cmdMateria = new SqlCommand(queryMaterias, conexion.establecerConexion());
                SqlCommand cmdEstado = new SqlCommand(queryEstado, conexion.establecerConexion());
                cmdAlumno.Parameters.AddWithValue("@idAlumno", idAlumno);
                cmdCurso.Parameters.AddWithValue("@idCurso", idCurso);
                cmdMateria.Parameters.AddWithValue("@idMateria", idMateria);
                cmdEstado.Parameters.AddWithValue("@idestado", idEstado);


                SqlDataReader drAlumno = cmdAlumno.ExecuteReader();
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                SqlDataReader drEstado = cmdEstado.ExecuteReader();

                if (drAlumno.Read() && drCurso.Read() && drMateria.Read() && drEstado.Read())
                {
                    string nombre = drAlumno["Nombre"].ToString();
                    string carnet = drAlumno["Carnet"].ToString();
                    string curso = drCurso["Nombre"].ToString();
                    string materia = drMateria["Nombre"].ToString();
                    string estado = drEstado["EstadoValor"].ToString();

                    txtNombre.Text = nombre;
                    txtCarnet.Text = carnet;
                    cbCursos.Text = curso;
                    cbMaterias.Text = materia;
                    cbEstado.Text = estado;
                }
                else
                {
                    MessageBox.Show("No hay registros de un dato");
                }
                btnInscribir.Enabled = false;
                btnActualizarInscripcion.Enabled = true;
                btnEliminarInscrip.Enabled = true;
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
                (dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = $"Materia LIKE '%{buscar}%' OR Curso LIKE '%{buscar}%' OR Nombre LIKE '%{buscar}%' OR Carnet LIKE '%{buscar}%'";
            }
            else
            {
                // Si el cuadro de búsqueda está vacío, muestra todos los datos
                (dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar()
        {

			txtNombre.Clear();
			txtCarnet.Clear();
			txtFiltroNombre.Clear();
			cbCursos.Text = null;
			cbMaterias.Text = null;
            cbEstado.Text = null;
			cmbFiltroEstado.Text = null;
			if (dgvInscripcion.SelectedRows.Count > 0)
			{
				dgvInscripcion.SelectedRows[0].Selected = false;
			}
			foreach (DataGridViewRow row in dgvInscripcion.SelectedRows)
			{
				row.Selected = false;
			}
			btnInscribir.Enabled = true;
            btnActualizarInscripcion.Enabled = false;
            btnEliminarInscrip.Enabled = false;
        }

        private void btnEliminarInscrip_Click(object sender, EventArgs e)
        {
            Eliminar();
			Limpiar();
		}

        private void Eliminar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || cbCursos.SelectedIndex == -1 || cbMaterias.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = (int)dgvInscripcion.SelectedRows[0].Cells["Id"].Value;
                string idAlumno = dgvInscripcion.SelectedRows[0].Cells["Nombre"].Value.ToString();
                string IdCurso = dgvInscripcion.SelectedRows[0].Cells["Curso"].Value.ToString();
                string idCarnet = dgvInscripcion.SelectedRows[0].Cells["Carnet"].Value.ToString();
                string idMateria = dgvInscripcion.SelectedRows[0].Cells["Materia"].Value.ToString();

                inscripcion.Id = id;
                inscripcion.IdAlumno = ControllerSearch.ObtenerIdAlumno(idAlumno, idCarnet);
                inscripcion.IdMateria = ControllerSearch.ObtenerIdMateria(idMateria);
                inscripcion.IdCurso = ControllerSearch.ObtenerIdCurso(IdCurso);
                ControllerAdministrador.EliminarInscripcion(inscripcion);
                MostrarInscripcion();
            }
        }

		private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			string buscar = cmbFiltroEstado.Text.Trim();
			if (!string.IsNullOrEmpty(buscar))
			{
				// Realiza la búsqueda en la fuente de datos y filtra los resultados
				(dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = $"Estado = '{buscar}'";
			}
			else
			{
				// Si el cuadro de búsqueda está vacío, muestra todos los datos
				(dgvInscripcion.DataSource as DataTable).DefaultView.RowFilter = "";
			}
		}
    }
}
