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
            txtNombre.KeyPress += TxtNombre_KeyPress; //Se asocia la keypress a la funcion con el textbox
            txtCarnet.KeyPress += TxtCarnet_KeyPress;
            txtTelefono.KeyPress += TxtTelefono_KeyPress;
            txtFiltroNombre.KeyPress += TxtFiltroNombre_KeyPress;
            txtPassword.KeyPress += TxtPassword_KeyPress;
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAdministrador.ManejoErrores(e);
        }

        //Con estos keypress se maneja que no se pueda escribir caracteres que no se quieran escribir
        private void TxtFiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAdministrador.ManejoErrores(e);
        }

        private void TxtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAdministrador.ManejoErrores(e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            FuncionesAdministrador.ManejoErroresTelefono(e);
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se manda a llamar el manejo de errores desde la clase FuncionesAdministrador
            FuncionesAdministrador.ManejoErroresNombre(e);
        }
        private void UsuarioFormAdmin_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            MostrarRoles();
            MostrarEstado();
            MostrarUsuarios();
        }
        private void ConfigurarDataGridView()
        {
            // Establecer el estilo de las celdas
            dgvUsuarios.DefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvUsuarios.DefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.DefaultCellStyle.BackColor = Color.White;
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 28, 36);

            // Establecer el estilo de las filas alternas
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Establecer el estilo de las cabeceras de las columnas
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 28, 36);

            // Agregar relleno (padding) a todos los encabezados de las columnas
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Padding = new Padding(10);

            // Centrar los encabezados de las columnas
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Alinear el contenido de las celdas al centro
            dgvUsuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // Configurar la selección de celdas
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;

            // Agregar el evento DataBindingComplete para establecer el ancho de las columnas de manera segura
            dgvUsuarios.DataBindingComplete += (sender, e) =>
            {
                foreach (DataGridViewColumn column in dgvUsuarios.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    int width = column.Width;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = width;
                }
            };
        }
        private void btnAgregarAlumno_Click_1(object sender, EventArgs e)
        {
            Insertar();
			Limpiar();
		}
        private void Insertar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "" || cbRol.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"{txtCarnet.Text}");
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

        private void btnActualizarAlumno_Click(object sender, EventArgs e)
        {
            Actualizar();
			Limpiar();
		}
        private void Actualizar()
        {
            if (txtNombre.Text == "" || txtCarnet.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "" || cbRol.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Datos incompletos, por favor llene todos los campos", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                Usuario.Id = id;
                Usuario.IdRole = Convert.ToInt32(cbRol.SelectedValue);
                Usuario.Nombre = txtNombre.Text;
                Usuario.Carnet = txtCarnet.Text;
                Usuario.Contraseña = txtPassword.Text;
                Usuario.Telefono = txtTelefono.Text;
                Usuario.IdEstado = Convert.ToInt32(cbEstado.SelectedValue);
                FuncionesAdministrador.ActualizarUsuarios(Usuario);
                MostrarUsuarios();
            }
        }
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            Eliminar();
			Limpiar();
		}
        private void Eliminar()
        {
            if (dgvUsuarios.SelectedRows.Count < 0 || txtNombre.Text == "" || txtCarnet.Text == "" || txtPassword.Text == "" || txtTelefono.Text == "" || cbRol.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("No hay datos seleccionados para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = (int)dgvUsuarios.SelectedRows[0].Cells["Id"].Value;
                Usuario.Id = id;
                FuncionesAdministrador.EliminarUsuario(Usuario);
                MostrarUsuarios();
            }
        }
        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = FuncionesAdministrador.MostrarUsuarios();
            dgvUsuarios.Columns[5].Visible = false;
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
			Limpiar();
			

        }
        public void Limpiar()
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
                string contraseña = row.Cells["Contraseña"].Value.ToString();
                string telefono = row.Cells["Telefono"].Value.ToString();

                txtNombre.Text = nombre;
                txtCarnet.Text = carnet;
                txtTelefono.Text = telefono;
                txtPassword.Text = contraseña;

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
