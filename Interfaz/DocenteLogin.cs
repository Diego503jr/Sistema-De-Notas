﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz
{
    public partial class DocenteLogin : Form
    {
        public DocenteLogin()
        {
            InitializeComponent();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocenteForm docenteForm = new DocenteForm();
            docenteForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
