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
			if (this.ContPrincipal1.Controls.Count > 0)

				this.ContPrincipal1.Controls.RemoveAt(0);
			Form fh = formHijo as Form;
			//AlumnoFormSecundario alumnFormSec = new AlumnoFormSecundario();
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.ContPrincipal1.Controls.Add(fh);
			this.ContPrincipal1.Tag = fh;
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

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
