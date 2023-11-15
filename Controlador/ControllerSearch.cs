using SistemaDeNotas.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Controlador
{
    internal class ControllerSearch
    {
        public static int ObtenerIdAlumnoDocente(string nombre)
        {
            int idUsuario = -1;

            try
            {
                CConexion conexion = new CConexion();
                string query = "SELECT Id FROM dbo.Usuarios Where Nombre = @nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idUsuario = (int)reader["Id"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return idUsuario;
        }

        public static string ObtenerNombreDocente(int IdDocente)
        {
            CConexion conexion = new CConexion();

            try
            {
                string query = "SELECT Nombre FROM dbo.Usuarios WHERE Id = @idDocente";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idDocente", IdDocente);
                string nombreDocente = (string)cmd.ExecuteScalar();
                return nombreDocente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return null;
            }
        }

        public static int ObtenerIdAlumno(string nombre, string carnet)
        {
            int idUsuario = -1;

            try
            {
                CConexion conexion = new CConexion();
                string query = "SELECT Id FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND IdRol = 2";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@carnet", carnet);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idUsuario = (int)reader["Id"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return idUsuario;
        }

        public static int ObtenerIdMateria(string nombre)
        {
            int idMateria = -1;

            try
            {
                CConexion conexion = new CConexion();
                string query = "SELECT Id FROM dbo.Materias WHERE Nombre = @nombre";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@nombre", nombre);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idMateria = (int)reader["Id"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return idMateria;
        }
    }
}
