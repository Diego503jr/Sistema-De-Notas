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
		CConexion conexion = new CConexion();
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
			if (txtNombreMateria.Text == "" || txtDescripcionMateria.Text == "" || cboDocente == null)
			{
				MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				Materia.Nombre = txtNombreMateria.Text;
				Materia.Descripcion = txtDescripcionMateria.Text;
				FuncionesAdministrador.AgregarMateria(Materia);
			}
		}

		

		private void MateriasForm_Load(object sender, EventArgs e)
		{
			CargarCombo();
		}
		
		public void CargarCombo()
		{
			SqlCommand cmd = new SqlCommand("SELECT Nombre FROM dbo.Usuarios WHERE IdRol = 1", conexion.establecerConexion());
			SqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read()) 
			{
				cboDocente.Items.Add(reader["Nombre"].ToString());
			}
			reader.Close();

		}

	}
}
