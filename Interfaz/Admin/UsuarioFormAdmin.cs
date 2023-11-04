using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Interfaz.Admin
{
    public partial class UsuarioFormAdmin : Form
    {
        ConstructorUsuario Usuario = new ConstructorUsuario();
        int posicion;
        public UsuarioFormAdmin()
        {
            InitializeComponent();
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            //Aqui tiene que ir la funcion para crear alumno
        }
        private void UsuarioFormAdmin_Load(object sender, EventArgs e)
        {
            MostrarRoles();
            MostrarEstado();
            MostrarUsuarios();
        }
        private void btnAgregarAlumno_Click_1(object sender, EventArgs e)
        {
            Insertar();
        }
        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "" || cbRol.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuario.IdRole = Convert.ToInt32(cbRol.SelectedValue);
                Usuario.Nombre = txtNombre.Text;
                Usuario.Carnet = txtCarnet.Text;
                Usuario.Contraseña = txtPassword.Text;
                Usuario.Telefono = txtTelefono.Text;
                Usuario.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                FuncionesAdministrador.AgregarUsuarios(Usuario);
                MostrarUsuarios();
            }
        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = FuncionesAdministrador.MostrarUsuarios();
        }

        private void MostrarRoles()
        {
            cbRol.DataSource = FuncionesAdministrador.ListarRoles();
            cbRol.DisplayMember = "RolUsuario";
            cbRol.ValueMember = "Id";
            cbRol.Text = null;
        }

        private void MostrarEstado()
        {
            cbEstado.DataSource = FuncionesAdministrador.ListarEstado();
            cbEstado.DisplayMember = "EstadoValor";
            cbEstado.ValueMember = "Id";
            cbEstado.Text = null;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtFiltroNombre.Clear();
            txtTelefono.Clear();
            txtPassword.Clear();
            txtCarnet.Clear();
            cbRol.Text = null;
            cbEstado.Text = null;

            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                
            }
            foreach (DataGridViewRow row in dgvUsuarios.SelectedRows)
            {
                row.Selected = false;
            }
            btnAgregarAlumno.Enabled = true;

        }

        private void dgvUsuarios_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CConexion conexion = new CConexion();
            if (e.RowIndex >= 0)
            {
                //Obteniendo la fila seleccionada
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                //Obteniendo el valor del campo IdRol, IdEstado de la fila seleccionada
                string idRol = row.Cells["Rol"].Value.ToString();
                string idEstado = row.Cells["Estado"].Value.ToString();
                string nombre = row.Cells["Nombre"].Value.ToString();
                string carnet = row.Cells["Carnet"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();

                txtNombre.Text = nombre;
                txtCarnet.Text = carnet;
                txtTelefono.Text = telefono;

                //Se hacen las consulta SQL a las 3 tablas
                string queryRol = "SELECT RolUsuario FROM dbo.Roles WHERE RolUsuario = @rol";
                string queryEstado = "SELECT EstadoValor FROM dbo.Estado WHERE EstadoValor = @estado";

                SqlCommand cmdRol = new SqlCommand(queryRol, conexion.establecerConexion());
                SqlCommand cmdEstado = new SqlCommand(queryEstado, conexion.establecerConexion());
                cmdRol.Parameters.AddWithValue("@rol", idRol);
                cmdEstado.Parameters.AddWithValue("@estado", idEstado);

                SqlDataReader drRol = cmdRol.ExecuteReader();
                SqlDataReader drEstado = cmdEstado.ExecuteReader();

                if (drRol.Read() && drEstado.Read())
                {
                    string rol = drRol["RolUsuario"].ToString();
                    string estado = drEstado["EstadoValor"].ToString();
                    
                    cbRol.Text = rol;
                    cbEstado.Text = estado;
                }
                else
                {
                    MessageBox.Show("No hay registros de un dato");
                }
                btnAgregarAlumno.Enabled = false;
                btnActualizarAlumno.Enabled = true;
                btnEliminarAlumno.Enabled = true;
            }
        }

        private void txtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            string buscar = txtFiltroNombre.Text.Trim();
            if (!string.IsNullOrEmpty(buscar))
            {
                // Realiza la búsqueda en la fuente de datos y filtra los resultados
                (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter = $"Nombre LIKE '%{buscar}%' OR Carnet LIKE '%{buscar}%' OR Rol LIKE '%{buscar}%' OR Estado LIKE '%{buscar}%'";
            }
            else
            {
                // Si el cuadro de búsqueda está vacío, muestra todos los datos
                (dgvUsuarios.DataSource as DataTable).DefaultView.RowFilter = "";
            }
        }
    }
}
