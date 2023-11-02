using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class InscripcionForm : Form
    {
        public InscripcionForm()
        {
            InitializeComponent();
        }
        private void InscripcionForm_Load(object sender, EventArgs e)
        {
            MostrarInscripcion();
            ListarCursosIns();
            ListarMateriasIns();
            ListarEstadoIns();
            
        }

        public void ListarEstadoIns()
        {
            cbEstado.DataSource = FuncionesAdministrador.ListarEstado();
            cbEstado.DisplayMember = "EstadoValor";
            cbEstado.ValueMember = "Id";
            cbEstado.Text = null;
        }

        public void ListarMateriasIns()
        {
            cbMaterias.DataSource = FuncionesAdministrador.ListarMaterias();
            cbMaterias.DisplayMember = "Nombre";
            cbMaterias.ValueMember = "Id";
            cbMaterias.Text = null;
        }

        public void ListarCursosIns()
        {
            cbCursos.DataSource = FuncionesAdministrador.ListarCursos();
            cbCursos.DisplayMember = "Nombre";
            cbCursos.ValueMember = "Id";
            cbCursos.Text = null;
        }

        public void MostrarInscripcion()
        {
            dgvInscripcion.DataSource = FuncionesAdministrador.MostrarInscripcion();
            dgvInscripcion.Columns[0].HeaderText = "IdInscripcion";
            dgvInscripcion.Columns[1].HeaderText = "IdAlumno";
            dgvInscripcion.Columns[2].HeaderText = "IdCurso";
            dgvInscripcion.Columns[3].HeaderText = "IdMateria";

        }
    }
}
