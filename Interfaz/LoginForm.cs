using SistemaDeNotas.Clases;
//using SistemaDeNotas.Interfaz;
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

namespace SistemaDeNotas
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //Ya no se va usar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.CConexion objConexion =  new Clases.CConexion();

            objConexion.establecerConexion();
            //if (txtEmail.Text != "" && txtContraseña.Text != "")
            //{
            //    this.Hide();
            //    //AdminForm adminForm = new AdminForm();
            //    //adminForm.Show();
            //    AlumnoForm alumnoForm = new AlumnoForm();
            //    alumnoForm.Show();
            //} else
            //{
            //    MessageBox.Show("Ingresa datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            
        }

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCarnet.Text) || string.IsNullOrEmpty(txtContraseña.Text))
			{
				MessageBox.Show("No puede dejar campos vacíos", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				
			}
			else
			{
				logear(this.txtCarnet.Text, this.txtContraseña.Text);
			}
		}

		public void logear(string Carnet, string Contraseña)
		{

			CConexion conexion = new CConexion();
			try
			{
				SqlCommand cmd = new SqlCommand("SELECT Nombre,IdRol FROM dbo.Usuarios WHERE Carnet = @Carnet AND Contraseña = @Contraseña", conexion.establecerConexion());

				cmd.Parameters.AddWithValue("Carnet", Carnet);
				cmd.Parameters.AddWithValue("Contraseña", Contraseña);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);

				if (dt.Rows.Count == 1)
				{
					this.Hide();
					if (dt.Rows[0][1].ToString() == "0" )
					{
						new AdminForm(dt.Rows[0][0].ToString()).Show();
					}
					else if (dt.Rows[0][1].ToString() == "1")
					{
						new AdminForm(dt.Rows[0][0].ToString()).Show();
					}
					else if (dt.Rows[0][1].ToString() == "2")
					{
						new AdminForm(dt.Rows[0][0].ToString()).Show();
					}
					
				}
				else
				{
					MessageBox.Show("Usuario y/o contraseña incorrectos", "Upsss!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtCarnet.Clear();
					txtContraseña.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error, {ex}");
				txtCarnet.Clear();
				txtContraseña.Clear();
			}
			finally
			{

			}
		}
	}
}
