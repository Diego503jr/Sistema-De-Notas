﻿using SistemaDeNotas.Clases;
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
using System.Runtime.InteropServices;

namespace SistemaDeNotas
{
    public partial class LoginForm : Form
    {
        // Importar la función SendMessage de user32.dll para mover la ventana
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public LoginForm()
        {
            InitializeComponent();
            this.MouseDown += BarraTitulo_MouseDown;
            this.MouseMove += BarraTitulo_MouseMove;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void btnIniciarSesion_Click_1(object sender, EventArgs e)
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
				SqlCommand cmd = new SqlCommand("SELECT Nombre,IdRol,Carnet,Telefono,IdEstado, Id FROM dbo.Usuarios WHERE BINARY_CHECKSUM(Carnet) = BINARY_CHECKSUM(@Carnet) AND BINARY_CHECKSUM(Contraseña) = BINARY_CHECKSUM(@Contraseña) AND IdEstado = 1 ", conexion.establecerConexion());
				cmd.Parameters.AddWithValue("@Carnet", Carnet);
				cmd.Parameters.AddWithValue("@Contraseña", Contraseña);
				SqlDataAdapter sda = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				sda.Fill(dt);

				if (dt.Rows.Count == 1)
				{
					this.Hide();
					if (dt.Rows[0][1].ToString() == "0" )
					{
						new AdminForm(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString()).Show();
					}
					else if (dt.Rows[0][1].ToString() == "1")
					{
						new DocenteForm(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString()).Show();
					}
					else if (dt.Rows[0][1].ToString() == "2")
					{
						new AlumnoForm(dt.Rows[0][0].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString()).Show();
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
				MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtCarnet.Clear();
				txtContraseña.Clear();
			}
		}

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

		private void pbMostrar_Click(object sender, EventArgs e)
		{
			//Enviamos imagen ocultar al frente
			pbOcultar.BringToFront();
			//Mostramos la contraseña
			txtContraseña.PasswordChar = '\0';
		}

		private void pbOcultar_Click(object sender, EventArgs e)
		{
			//Enviamos imagen mostrar al frente
			pbMostrar.BringToFront();
			//Ocultamos la contraseña
			txtContraseña.PasswordChar = '*';
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			txtContraseña.PasswordChar = '*';
		}

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
        }
    }
}
