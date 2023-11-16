using SistemaDeNotas.Interfaz.Docente;
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
        public DocenteForm(string nombre, string carnet, string telefono, string idestado, string id)
        {
            InitializeComponent();
            lblNombreUser.Text = nombre;
			PerfilForm perfil = new PerfilForm();
			btnMenuPerfil.Click += (sender, e) =>
			{
				AbrirFormHijo(perfil);
				perfil.ConfigurarNombre(nombre, carnet, telefono, idestado); // Pasa el nombre al PerfilForm cuando se carga
				perfil.Show(); // Muestra el formulario PerfilForm después de que se carga
			};
            NotasDocente notasDocentes = new NotasDocente(id);
            btnMenuCursos.Click += (sender, e) =>
            {
                AbrirFormHijo(notasDocentes);
                notasDocentes.Show();
            };
			ListarAlumnos listarAlumnos = new ListarAlumnos(id);
			btnMenuDocentes.Click += (sender, e) =>
			{
				AbrirFormHijo(listarAlumnos);
				listarAlumnos.Show();
			};
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

        //private void btnMenuCursos_Click(object sender, EventArgs e)
        //{
        //    AbrirFormHijo(new NotasDocente());
        //}

        private void btnMenuPerfil_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new PerfilForm());

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
