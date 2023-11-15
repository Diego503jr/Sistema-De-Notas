using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class CursosForm : Form
    {
        Cursos Curso = new Cursos();
		int posicion; //Devuelve la fila en el dataGrid
        public CursosForm()
        {
            InitializeComponent();
            txtNombreCurso.KeyPress += TxtNombreCurso_KeyPress;
            txtFiltroNombre.KeyPress += TxtFiltroNombre_KeyPress;
        }

        private void TxtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
			ControllerAdministrador.ManejoErrores(e);
		}

        private void TxtNombreCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
			ControllerAdministrador.ManejoErrores(e);
        }
        private void CursosForm_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarCursos();
            MostrarEstado();
        }

        //MOSTRAR CURSO
        private void MostrarCursos()
		{
			dgvCursos.DataSource = ControllerAdministrador.MostrarCurso();
		}

        //MOSTRAR ESTADO
        private void MostrarEstado()
		{
            cbEstado.DataSource = ControllerAdministrador.ListarEstado();
            cbEstado.DisplayMember = "EstadoValor";
            cbEstado.ValueMember = "Id";
            cbEstado.Text = null;

			cmbFiltroEstado.DataSource = ControllerAdministrador.ListarEstado();
			cmbFiltroEstado.DisplayMember = "EstadoValor";
			cmbFiltroEstado.ValueMember = "Id";
			cmbFiltroEstado.Text = null;
		}

		//PERSONALIZACION DEL DATAGRID
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvCursos.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvCursos.DefaultCellStyle.ForeColor = Color.Black;
            dgvCursos.DefaultCellStyle.BackColor = Color.White;
            dgvCursos.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCursos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvCursos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvCursos.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvCursos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCursos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvCursos.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvCursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvCursos.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvCursos.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvCursos.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }

		private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
			Limpiar();
		}
        //FUNCION PARA AGREGAR CURSO
        private void Insertar()
        {
            if (txtNombreCurso.Text == "" || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("No hay datos, por favor llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Curso.Nombre = txtNombreCurso.Text;
                Curso.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                ControllerAdministrador.AgregarCurso(Curso);
				MostrarCursos();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
			Actualizar();
			Limpiar();
		}

        //FUNCION PARA ACTUALIZAR 
        private void Actualizar()
		{
			if (txtNombreCurso.Text == "" || cbEstado.SelectedIndex == -1)
			{
				MessageBox.Show("No hay datos, por favor llene todos los campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                int id = (int)dgvCursos.SelectedRows[0].Cells["Id"].Value;
                Curso.Id = id;
                Curso.Nombre = txtNombreCurso.Text;
				Curso.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
				ControllerAdministrador.ActualizarCurso(Curso);
				MostrarCursos();
			}
		}

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Eliminar();
			Limpiar();
		}

        //FUNCION PARA ELIMINAR CURSO
        private void Eliminar()
		{
            if (dgvCursos.SelectedRows.Count < 0 || txtNombreCurso.Text == "" || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("No hay datos seleccionados para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = (int)dgvCursos.SelectedRows[0].Cells["Id"].Value;
                Curso.Id = id;
                ControllerAdministrador.EliminarCurso(Curso);
				MostrarCursos();
            }
        }

		//COMPLETAR TEXTBOX Y COMBOBX CON INFORMACIÓN DEL DATAGRID
		private void dgvCursos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				// Obtén la fila seleccionada
				DataGridViewRow selectedRow = dgvCursos.Rows[e.RowIndex];

				// Establece la selección de la fila completa
				selectedRow.Selected = true;
			}
			posicion = dgvCursos.CurrentRow.Index;
			txtNombreCurso.Text = dgvCursos[1, posicion].Value.ToString();
			cbEstado.Text = dgvCursos[2, posicion].Value.ToString();
			btnAgregar.Enabled = false;
			btnActualizar.Enabled = true;
			btnEliminar.Enabled = true;
			txtNombreCurso.Focus();
		}

        //FILTRO DE BUSQUEDA EN TEXTBOX
        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltroNombre.Text.Trim();
            if (!string.IsNullOrEmpty(buscar))
            {
                // Realiza la búsqueda en la fuente de datos y filtra los resultados
                (dgvCursos.DataSource as DataTable).DefaultView.RowFilter = $"Nombre LIKE '%{buscar}%' OR Estado LIKE '%{buscar}%'";
            }
            else
            {
                // Si el cuadro de búsqueda está vacío, muestra todos los datos
                (dgvCursos.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }

        //LIMPIAR BÚSQUEDA
        private void btnLimpiar_Click(object sender, EventArgs e)
		{
            Limpiar();	
		}
        public void Limpiar()
        {
			txtNombreCurso.Clear();
			txtFiltroNombre.Clear();
			cbEstado.Text = null;
			cmbFiltroEstado.Text = null;
			if (dgvCursos.SelectedRows.Count > 0)
			{
				dgvCursos.SelectedRows[0].Selected = false;
			}
			foreach (DataGridViewRow row in dgvCursos.SelectedRows)
			{
				row.Selected = false;
			}
			btnAgregar.Enabled = true;
		}

		private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
		{
			string buscar = cmbFiltroEstado.Text.Trim();

			if (!string.IsNullOrEmpty(buscar))
			{
				// Realiza la búsqueda en la fuente de datos y filtra los resultados
				(dgvCursos.DataSource as DataTable).DefaultView.RowFilter = $"Estado = '{buscar}'";
			}
			else
			{
				// Si el cuadro de búsqueda está vacío, muestra todos los datos
				(dgvCursos.DataSource as DataTable).DefaultView.RowFilter = "";
			}
		}
	}
}
