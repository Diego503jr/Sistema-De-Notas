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
    public partial class PerfilForm : Form
    {
        public PerfilForm()
        {
            InitializeComponent();
		}

		public void ConfigurarNombre(string nombre, string carnet, string telefono, string idestado)
		{
			if (idestado.ToString() == "1")
			{
				txtestado.Text = "ACTIVO";
			}
			else if (idestado.ToString() == "0")
			{
				txtestado.Text = "INACTIVO";
			}


			txtnombre.Text = nombre;
			txtcarnet.Text = carnet;
			txttelefono.Text = telefono;
			//txtestado.Text = idestado;
		}

		private void PerfilForm_Load(object sender, EventArgs e)
		{
			
		}
	}
}
