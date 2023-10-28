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
    public partial class DocenteForm : Form
    {
        public DocenteForm(string nombre)
        {
            InitializeComponent();
            txtNombreUsuario.Text = "Bienvenido " + nombre;

        }
        public void AbrirFormHijo(object formHijo)
        {
            if (this.ContPrincipalDocente.Controls.Count > 0)

                this.ContPrincipalDocente.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            //AlumnoFormSecundario alumnFormSec = new AlumnoFormSecundario();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.ContPrincipalDocente.Controls.Add(fh);
            this.ContPrincipalDocente.Tag = fh;
            fh.Show();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnMenuCursos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CursoFormAlumno());
        }

        private void btnMenuPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Perfil());

        }
    }
}
