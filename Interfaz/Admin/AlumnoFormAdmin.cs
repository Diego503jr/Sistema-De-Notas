using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class AlumnoFormAdmin : Form
    {
        private AdminForm formularioPadre;
        public AlumnoFormAdmin(AdminForm padre)
        {
            InitializeComponent();
            formularioPadre = padre;
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            formularioPadre.AbrirFormHijo(new CrearUsuarioForm());
        }
    }
}
