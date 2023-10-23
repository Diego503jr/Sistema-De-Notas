using SistemaDeNotas.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnDocenteLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin docenteLogin = new AdminLogin();
            docenteLogin.ShowDialog();
        }

        private void btnAlumnoLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlumnoLogin alumnoLogin = new AlumnoLogin();
            alumnoLogin.ShowDialog();
        }
        private void btnDocenteLoginForm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DocenteLogin docenteLogin = new DocenteLogin();
            docenteLogin.ShowDialog();
        }
    }
}
