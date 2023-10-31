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
        public CursosForm()
        {
            InitializeComponent();
        }

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

        private void MostrarCursos()
        {
            dgvCursos.DataSource = FuncionesAdministrador.MostrarCurso();
            dgvCursos.Columns[0].HeaderText = "IdCurso";
            dgvCursos.Columns[1].HeaderText = "Nombre";
        }

        private void dgvCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Curso.Id = Convert.ToInt16(dgvCursos.CurrentRow.Cells[0].Value);
            txtNombreCurso.Text = dgvCursos.CurrentRow.Cells[1].ToString();
        }

        private void CursosForm_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Curso.Nombre = txtNombreCurso.Text;
            FuncionesAdministrador.ActualizarCurso(Curso);
            MostrarCursos();
        }
    }
}
