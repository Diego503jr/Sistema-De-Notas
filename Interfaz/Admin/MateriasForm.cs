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
        public MateriasForm()
        {
            InitializeComponent();
        }

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			Insertar();
		}

		private void Insertar()
		{
			if (txtNombreMateria.Text == "" || txtDescripcionMateria.Text == "" )
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Materia.Nombre = txtNombreMateria.Text;
				Materia.Descripcion = txtDescripcionMateria.Text;
				Materia.IdDocente = Convert.ToInt32(cbDocente.SelectedValue);
                FuncionesAdministrador.AgregarMateria(Materia);
			}
		}

        private void MateriasForm_Load(object sender, EventArgs e)
		{
			MostrarMaterias();
			ListarDocentesMat();
		}

		public void ListarDocentesMat()
		{
            cbDocente.DataSource = FuncionesAdministrador.ListarDocentes();
            cbDocente.DisplayMember = "Nombre";
            cbDocente.ValueMember = "Id";
        }

		public void MostrarMaterias()
		{
			dgvMaterias.DataSource = FuncionesAdministrador.MostrarMateria();
			dgvMaterias.Columns[0].HeaderText = "IdMateria";
			dgvMaterias.Columns[1].HeaderText = "Materia";
			dgvMaterias.Columns[2].HeaderText = "Descripción";
			dgvMaterias.Columns[3].HeaderText = "Docente";
		}
		

    }
}
