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
        CConexion conexion = new CConexion();
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
			}
		}
		private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCurso.Text) )
            {
                MessageBox.Show("No puede dejar campos vacíos", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
				Insertar();
                //RegistrarCurso(this.txtNombreCurso.Text, this.txtDescripcionCurso.Text);
            }
        }
	}
}
