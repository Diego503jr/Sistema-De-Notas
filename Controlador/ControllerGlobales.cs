using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Clases
{
    internal class ControllerGlobales
    {
        //Listar en comboboxes
        public static DataTable ListarDocentes()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string queryLeerDocentes = "SELECT Id, Nombre FROM dbo.Usuarios WHERE IdRol = 1";
                SqlCommand cmd = new SqlCommand(queryLeerDocentes, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static DataTable ListarAlumnos()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string queryLeerDocentes = "SELECT Id, Nombre, Carnet, Telefono FROM dbo.Usuarios WHERE IdRol = 2";
                SqlCommand cmd = new SqlCommand(queryLeerDocentes, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static DataTable ListarCursos()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT Id, Nombre FROM dbo.Cursos";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static DataTable ListarMaterias()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT Id, Nombre, IdDocente FROM dbo.Materias";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static DataTable ListarMateriaDocente(int ValorIdDocente)
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT M.Id AS Id, M.Nombre AS nombre, M.IdDocente " +
                    "FROM dbo.Materias AS M " +
                    "INNER JOIN dbo.Usuarios AS U ON M.IdDocente = U.Id " +
                    "WHERE M.IdDocente = @IdDocente ";


                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@IdDocente", ValorIdDocente);

                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }


        public static DataTable ListarEstado()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT Id, EstadoValor FROM dbo.Estado";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static DataTable ListarRoles()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT Id, RolUsuario FROM dbo.Roles";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        //Mediante este manejo se evalua si la tecla presionada es letra o numero, se utilizara en cursos, carnets, contraseñas
        public static void ManejoErrores(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Formato de entrada incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //este es para el nombre
        public static void ManejoErroresNombre(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Ingrese únicamente letras por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //este es para el telefono
        public static void ManejoErroresTelefono(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Ingrese únicamente números por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
