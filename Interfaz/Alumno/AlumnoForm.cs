﻿using SistemaDeNotas.Interfaz.Alumno;
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
        public AlumnoForm(string nombre)
        {
            InitializeComponent();
			txtNombreUsuario.Text =  "Bienvenid@ " + nombre;

		}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnMenuPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new PerfilForm());
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new NotasAlumnocs());

        }
    }
}
