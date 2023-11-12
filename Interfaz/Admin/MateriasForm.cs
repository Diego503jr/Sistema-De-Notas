using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
	public partial class MateriasForm : Form
	{
		ConstructorMateria Materia = new ConstructorMateria();
		int posicion; //Obtener la fila seleccionada del DataGridView

		public MateriasForm()
		{
			InitializeComponent();
            txtNombreMateria.KeyPress += TxtNombreMateria_KeyPress;
            txtFiltroNombre.KeyPress += TxtFiltroNombre_KeyPress;
		}

        private void TxtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
			FuncionesAdministrador.ManejoErrores(e);
        }

        private void TxtNombreMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
			FuncionesAdministrador.ManejoErrores(e);
        }

        //MOSTRAR MATERIA
        public void MostrarMaterias()
		{
			dgvMaterias.DataSource = FuncionesAdministrador.MostrarMateria();
		}

		private void MateriasForm_Load(object sender, EventArgs e)
		{
			ConfigurarDataGridView();
			MostrarMaterias();
			ListarDocentesMat();
		}

        //MOSTRAR MATERIA
        /*public void MostrarMaterias()
		{
			dgvMaterias.DataSource = FuncionesAdministrador.MostrarMateria();
		}*/

        //PERSONALIZACION DEL DATAGRID
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvMaterias.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvMaterias.DefaultCellStyle.ForeColor = Color.Black;
            dgvMaterias.DefaultCellStyle.BackColor = Color.White;
            dgvMaterias.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvMaterias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvMaterias.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvMaterias.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvMaterias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMaterias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvMaterias.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvMaterias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvMaterias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvMaterias.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvMaterias.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }

        //MOSTRAR ESTADO
        private void MostrarEstado()
        {
            cbEstado.DataSource = FuncionesAdministrador.ListarEstado();
            cbEstado.DisplayMember = "EstadoValor";
            cbEstado.ValueMember = "Id";
            cbEstado.Text = null;
        }

        //AGREGAR MATERIA
        private void btnAgregar_Click(object sender, EventArgs e)
		{
			Insertar();
			Limpiar();
		}

		private void Insertar()
		{
			if (txtNombreMateria.Text == "" || txtDescripcionMateria.Text == "" || cbDocente.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Materia.Nombre = txtNombreMateria.Text;
				Materia.Descripcion = txtDescripcionMateria.Text;
				Materia.IdDocente = Convert.ToInt32(cbDocente.SelectedValue);
                Materia.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                FuncionesAdministrador.AgregarMateria(Materia);
                MostrarMaterias();
            }
        }

		//ACTUALIZAR MATERIA
		private void Actualizar()
		{
			if (txtNombreMateria.Text == "" || txtDescripcionMateria.Text == "" || cbDocente.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                int id = (int)dgvMaterias.SelectedRows[0].Cells["Id"].Value;
                Materia.Id = id;
                Materia.Nombre = txtNombreMateria.Text;
				Materia.Descripcion = txtDescripcionMateria.Text;
				Materia.IdDocente = Convert.ToInt32(cbDocente.SelectedValue);
				Materia.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
				FuncionesAdministrador.ActualizarMateria(Materia);
                MostrarMaterias();
            }
        }

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			Actualizar();
			Limpiar();
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Eliminar();
			Limpiar();
		}

		private void Eliminar()
		{
			if (dgvMaterias.SelectedRows.Count < 0 || txtNombreMateria.Text == "" || txtDescripcionMateria.Text == "" || cbDocente.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
			{
                MessageBox.Show("No hay datos seleccionados para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
			{
                int id = (int)dgvMaterias.SelectedRows[0].Cells["Id"].Value;
                Materia.Id = id;
                FuncionesAdministrador.EliminarMateria(Materia);
                MostrarMaterias();
            }
        }

		//LISTAR DOCENTE
		public void ListarDocentesMat()
		{
			cbDocente.DataSource = FuncionesAdministrador.ListarDocentes();
			cbDocente.DisplayMember = "Nombre";
			cbDocente.ValueMember = "Id";
            cbDocente.Text = null;
        }

		//COMPLETA TEXTBOX Y COMBOBOX CON LA INFORMACIÓN SELECCIONADA EN EL DATAGRID
		private void dgvMaterias_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			if (e.RowIndex >= 0)
			{
				//Obteniendo la fila seleccionada
				DataGridViewRow row = dgvMaterias.Rows[e.RowIndex];
				
				string Nombre = row.Cells["Nombre"].Value.ToString();
				string Descripcion = row.Cells["Descripcion"].Value.ToString();
				string Docente = row.Cells["Docente"].Value.ToString();
                string Estado = row.Cells["Estado"].Value.ToString();

                txtNombreMateria.Text = Nombre;
				txtDescripcionMateria.Text = Descripcion;
				cbDocente.Text = Docente;
				cbEstado.Text = Estado;

				btnAgregar.Enabled = false;
				btnActualizar.Enabled = true;
				btnEliminar.Enabled = true;
			}
		}

		public void Limpiar()
		{
			txtNombreMateria.Clear();
			txtDescripcionMateria.Clear();
			txtFiltroNombre.Clear();
			cbDocente.Text = null;
			cbEstado.Text = null;
			if (dgvMaterias.SelectedRows.Count > 0)
			{
				dgvMaterias.SelectedRows[0].Selected = false;
			}
			foreach (DataGridViewRow row in dgvMaterias.SelectedRows)
			{
				row.Selected = false;
			}
			btnAgregar.Enabled = true;

		}
		//LIMPIAR BÚSQUEDA
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		//FILTRAR BÚSQUEDA
		private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
		{
			string buscar = txtFiltroNombre.Text.Trim();
			if (!string.IsNullOrEmpty(buscar))
			{
				// Realiza la búsqueda en la fuente de datos y filtra los resultados
				(dgvMaterias.DataSource as DataTable).DefaultView.RowFilter = $"Nombre LIKE '%{buscar}%' OR Docente LIKE '%{buscar}%'";
			}
			else
			{
				// Si el cuadro de búsqueda está vacío, muestra todos los datos
				(dgvMaterias.DataSource as DataTable).DefaultView.RowFilter = "";
			}

		}
	}
}
