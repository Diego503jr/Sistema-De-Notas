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
    public partial class AlumnoForm : Form
    {
        public AlumnoForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
		private void AbrirFormHijo(object formHijo)
		{
			if (this.ContPrincipalAlumno.Controls.Count > 0)

				this.ContPrincipalAlumno.Controls.RemoveAt(0);
			Form fh = formHijo as Form;
			//AlumnoFormSecundario alumnFormSec = new AlumnoFormSecundario();
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.ContPrincipalAlumno.Controls.Add(fh);
			this.ContPrincipalAlumno.Tag = fh;
			fh.Show();

		}

		private void btnMenuCursos_Click(object sender, EventArgs e)
		{
			AbrirFormHijo(new CursoFormAlumno());
		}

		private void btnMenuDocentes_Click(object sender, EventArgs e)
		{
			AbrirFormHijo(new DocenteFormAlumno());
		}
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }
    }
}
