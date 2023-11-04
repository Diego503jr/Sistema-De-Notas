using SistemaDeNotas.Clases;
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
    public partial class UsuarioFormAdmin : Form
    {
        ConstructorPersonas pe = new ConstructorPersonas();
        public UsuarioFormAdmin()
        {
            InitializeComponent();
        }

        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("DaITtos Incompletos. Por favor llene todos los campos", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pe.Nombre = txtNombre.Text;
                pe.Carnet = txtCarnet.Text;
                pe.Password = txtPassword.Text;
                pe.Telefono = Convert.ToInt16(txtTelefono.Text);
                FuncionesAdministrador.AgregarPersonas(pe);
            }
        }
        private void UsuarioFormAdmin_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            dataGridView1.DataSource = FuncionesAdministrador.MostrarPersonas();
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[6].Visible = false;
        }

        private void btnAgregarAlumno_Click_1(object sender, EventArgs e)
        {
            Insertar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pe.Id = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            txtNombre.Text = dataGridView1.CurrentRow.Cells[2].ToString();
            txtCarnet.Text = dataGridView1.CurrentRow.Cells[3].ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[4].ToString();
            txtTelefono.Text = dataGridView1.CurrentRow.Cells[5].ToString();
        }

        private void Modificar()
        {
            pe.Nombre = Convert.ToString(txtNombre.Text);
            pe.Carnet = Convert.ToString(txtCarnet.Text);
            pe.Password = Convert.ToString(txtPassword.Text);
            pe.Telefono = Convert.ToInt16(txtTelefono.Text);
            FuncionesAdministrador.ModificarUsuario(pe);
            Mostrar();
        }
        private void Eliminar()
        {
            pe.Nombre = Convert.ToString(txtNombre.Text);
            pe.Carnet = Convert.ToString(txtCarnet.Text);
            pe.Password = Convert.ToString(txtPassword.Text);
            pe.Telefono = Convert.ToInt16(txtTelefono.Text);
            FuncionesAdministrador.EliminarPersonas(pe);
            Mostrar();
        }
        
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        
    }
}
