using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class AlumnosListForm : Form
    {
        private string nombre;
        private string carnet;
        int position;
        public AlumnosListForm()
        {
            InitializeComponent();
        }

        private void AlumnosListForm_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        public void MostrarAlumnos()
        {
            dgvAlumnos.DataSource = FuncionesAdministrador.ListarAlumnos();
        }

        private void dgvAlumnos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dgvAlumnos.Rows[e.RowIndex];

                // Establece la selección de la fila completa
                selectedRow.Selected = true;
            }
            position = dgvAlumnos.CurrentRow.Index;
            txtNombreAlumno.Text = dgvAlumnos[1, position].Value.ToString();
            txtCarnetAlumno.Text = dgvAlumnos[2, position].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Pasar los datos de regreso al formulario principal
            InscripcionForm insForm = Owner as InscripcionForm;
           //PSDT Aun no sirve esto no se que podria ser
            //insForm.txt
            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
