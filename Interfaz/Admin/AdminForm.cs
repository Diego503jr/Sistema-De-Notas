using SistemaDeNotas.Clases;
using SistemaDeNotas.Interfaz.Admin;
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
        
        public AdminForm(string nombre)
        {
            InitializeComponent();
            txtNombreUsuario.Text =  "Bienvenid@ " + nombre;
		}

        public void AbrirFormHijo(object formHijo)
        {
            if (this.ContPrincipalAdmin.Controls.Count > 0)
            
                this.ContPrincipalAdmin.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.ContPrincipalAdmin.Controls.Add(fh);
                this.ContPrincipalAdmin.Tag = fh;
                fh.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMenuPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new PerfilForm());
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnMenuCursos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new InscripcionForm());
        }        
        private void btnMenuAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new UsuarioFormAdmin());
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString(); 
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CursosForm());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new MateriasForm());
        }
    }
}
