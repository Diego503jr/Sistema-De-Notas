using SistemaDeNotas.Interfaz.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeNotas.Clases
{
	internal class FuncionesAdministrador
	{
		//Funciones para el formulario Materias
		public static int AgregarMateria(ConstructorMateria Materia)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();
				string query = "INSERT INTO dbo.Materias (Nombre, Descripcion, IdDocente) VALUES (@Nombre, @Descripcion, @IdDocente)";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.AddWithValue("@Nombre", Materia.Nombre);
				cmd.Parameters.AddWithValue("@Descripcion", Materia.Descripcion);
				cmd.Parameters.AddWithValue("@IdDocente", Materia.IdDocente);
				retorno = cmd.ExecuteNonQuery();
				if (retorno >= 0)
				{
					MessageBox.Show("Los datos de la materia se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return retorno;
				}
				else
				{
					MessageBox.Show("Los datos no se agregaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return retorno;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hubo un error de conexion {ex}" , "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return retorno;
			}

		}
        public static DataTable MostrarMateria()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT *FROM dbo.Materias";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        //Funciones para el formulario Curso

        public static int AgregarCurso(ConstructorCurso Curso)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();
				string query = "INSERT INTO dbo.Cursos ( Nombre) VALUES ( @Nombre)";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.AddWithValue("@Nombre", Curso.Nombre);
				retorno = cmd.ExecuteNonQuery();
				if (retorno >= 0)
				{
					MessageBox.Show("Los datos del curso se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return retorno;
				}
				else
				{
					MessageBox.Show("Los datos no se agregaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return retorno;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hubo un error de conexion" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				return retorno;
			}

		}
  
        public static DataTable MostrarCurso()
		{
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
			try
			{
				string query = "SELECT *FROM dbo.Cursos";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				SqlDataAdapter dt = new SqlDataAdapter(cmd);
				dt.Fill(data);
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return data;
			}
		}

		public static int ActualizarCurso(ConstructorCurso Curso)
		{
            CConexion conexion = new CConexion();
            int retorno = 0;
			string query = "Update dbo.Cursos SET Nombre = @nombreCurso WHERE Id = @idCurso";
			SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@idCurso",Curso.Id);
			cmd.Parameters.AddWithValue("@nombreCurso",Curso.Nombre);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
		}

        //Funciones para el formulario Materias

		public static DataTable MostrarInscripcion()
		{
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
			try
			{
				string query = "SELECT * FROM dbo.Inscripcion";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				SqlDataAdapter dt = new SqlDataAdapter(cmd);
				dt.Fill(data);
				return data;
			}catch (Exception ex)
			{
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

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
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			}catch (Exception ex)
			{
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
		}

        public static DataTable ListarMaterias()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT Id, Nombre FROM dbo.Materias";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static int AgregarPersonas(ConstructorPersonas Usuario)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                string query = "INSERT INTO dbo.Usuarios ( Nombre, Carnet, Contraseña, Telefono) VALUES ( @Nombre, @Carnet, @Contraseña, @Telefono)";
                SqlCommand add = new SqlCommand(query, conexion.establecerConexion());
                add.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
                add.Parameters.AddWithValue("@Carnet", Usuario.Carnet);
                add.Parameters.AddWithValue("@Contraseña", Usuario.Password);
                add.Parameters.AddWithValue("@Telefono", Usuario.Telefono);
                retorno = add.ExecuteNonQuery();
                if (retorno >= 0)
                {
                    MessageBox.Show("El usuario ha sido agregado correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Hay casillas vacías, no se ha guardado el Usuario", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de conexion" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static DataTable MostrarPersonas()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string mostrar = "SELECT *FROM dbo.Usuarios";
                SqlCommand cmd = new SqlCommand(mostrar, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }
        public static int ModificarUsuario(ConstructorPersonas Usuario)
        {
            int retorno = 0;
            CConexion conexion = new CConexion();
            string query = "Update dbo.Usuarios SET ( Id, IdRol, Nombre, Carnet, Contraseña, Telefono) WHERE ( @Id, @IdRol, @Nombre, @Carnet, @Contraseña, @Telefono)";
            SqlCommand mod = new SqlCommand(query, conexion.establecerConexion());
            mod.Parameters.AddWithValue("@Id", Usuario.Id);
            mod.Parameters.AddWithValue("@IdRol", Usuario.IdRol);
            mod.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            mod.Parameters.AddWithValue("@Carnet", Usuario.Carnet);
            mod.Parameters.AddWithValue("@Contraseña", Usuario.Password);
            mod.Parameters.AddWithValue("@Telefono", Usuario.Telefono);
            mod.Parameters.AddWithValue("@IdEstado", Usuario.IdEstado);
            return retorno;
        }

        public static void EliminarPersonas(ConstructorPersonas Usuario)
        {
            CConexion conexion = new CConexion();
            string query = "DELETE FROM dbo.Usuarios ( Id, IdRol, Nombre, Carnet, Contraseña, Telefono) WHERE ( @Id, @IdRol, @Nombre, @Carnet, @Contraseña, @Telefono)";
            SqlCommand delete = new SqlCommand(query, conexion.establecerConexion());
            delete.Parameters.AddWithValue("@Id", Usuario.Id);
            delete.Parameters.AddWithValue("@IdRol", Usuario.IdRol);
            delete.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
            delete.Parameters.AddWithValue("@Carnet", Usuario.Carnet);
            delete.Parameters.AddWithValue("@Contraseña", Usuario.Password);
            delete.Parameters.AddWithValue("@Telefono", Usuario.Telefono);
            delete.Parameters.AddWithValue("@IdEstado", Usuario.IdEstado);
            try
            {
                int filasAfectadas = delete.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Datos eliminados exitosamente.","Datos Eliminados",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han eliminado los datos.", "Datos NO ELIMINADOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error de conexión: " + ex,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
