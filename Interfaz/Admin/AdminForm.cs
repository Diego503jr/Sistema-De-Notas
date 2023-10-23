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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AbrirFormHijo(object formHijo)
        {
            if (this.ContPrincipal.Controls.Count > 0)
            
                this.ContPrincipal.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                //AlumnoFormSecundario alumnFormSec = new AlumnoFormSecundario();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.ContPrincipal.Controls.Add(fh);
                this.ContPrincipal.Tag = fh;
                fh.Show();
            
        }

        private void ContPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenuAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AlumnoFormSecundario());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void BarraMenuLateral_Paint(object sender, PaintEventArgs e)
		{

		}

        private void btnMenuPerfil_Click(object sender, EventArgs e)
        {
            perfildocente ventana = new perfildocente();
            ventana.Show();
            this.Hide();
        }

        private void btnMenuDocentes_Click(object sender, EventArgs e)
        {

        }
    }
}
