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
        ConstructorCurso Curso = new ConstructorCurso();
		int posicion; //Devuelve la fila en el dataGrid
        public CursosForm()
        {
            InitializeComponent();
        }

		//MOSTRAR CURSO
		private void MostrarCursos()
		{
			dgvCursos.DataSource = FuncionesAdministrador.MostrarCurso();
			dgvCursos.Columns[0].HeaderText = "IdCurso";
			dgvCursos.Columns[1].HeaderText = "Nombre";
		}

		private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//No se utiliza
		}

		private void CursosForm_Load(object sender, EventArgs e)
		{
			MostrarCursos();
		}

		//AGREGAR CURSO
		private void Insertar()
		{
			if (txtNombreCurso.Text == "" )
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Curso.Nombre = txtNombreCurso.Text;
				FuncionesAdministrador.AgregarCurso(Curso);
                MostrarCursos();
			}
		}
		private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCurso.Text) )
            {
                MessageBox.Show("No puede dejar campos vacíos", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
				Insertar();
            }
        }

        
		//ACTUALIZAR CURSO
        private void btnActualizar_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Se ha actualizado la información de curso con éxtio", "Actualizar Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			int id = (int)dgvCursos.SelectedRows[0].Cells["Id"].Value;
			curso.Id = id;
			Actualizar();
		}
		

		ConstructorCurso curso = new ConstructorCurso();
		private void Actualizar()
		{
			if (txtNombreCurso.Text == "" )
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				curso.Nombre = txtNombreCurso.Text;
				FuncionesAdministrador.ActualizarCurso(curso);
				MostrarCursos();

			}
				
		}

		//ELIMINAR CURSO
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			int id = (int)dgvCursos.SelectedRows[0].Cells["Id"].Value;
			curso.Id = id;
			FuncionesAdministrador.EliminarCurso(curso);
			MessageBox.Show("Curso eliminado con éxito", "Eliminar Curso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			MostrarCursos();
		}


		//FILTRO DE BUSQUEDA EN TEXTBOX
		private void txtNombreCurso_TextChanged(object sender, EventArgs e)
		{
			//string buscar = txtNombreCurso.Text.Trim();
			//if (!string.IsNullOrEmpty(buscar))
			//{
			//	// Realiza la búsqueda en la fuente de datos y filtra los resultados
			//	(dgvCursos.DataSource as DataTable).DefaultView.RowFilter = $"Nombre LIKE '%{buscar}%'";
			//}
			//else
			//{
			//	// Si el cuadro de búsqueda está vacío, muestra todos los datos
			//	(dgvCursos.DataSource as DataTable).DefaultView.RowFilter = "";
			//}
		}


		//COMPLETAR TEXTBOX CON INFORMACIÓN DE DATAGRID
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
			btnAgregar.Enabled = false;
			btnActualizar.Enabled = true;
			btnEliminar.Enabled = true;
			txtNombreCurso.Focus();
		}


		//LIMPIAR BÚSQUEDA
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtNombreCurso.Clear();
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
	}

	
}
