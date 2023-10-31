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
		public static int AgregarMateria(ConstructorMateria Materia)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();
				string agregar = "INSERT INTO dbo.Materias (Nombre, Descripcion, IdDocente) VALUES (@Nombre, @Descripcion, @IdDocente)";
				SqlCommand cmd = new SqlCommand(agregar, conexion.establecerConexion());
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

        public static DataTable ListarDocentes()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            string queryLeerDocentes = "SELECT Id, Nombre FROM dbo.Usuarios WHERE IdRol = 1";
            SqlCommand cmd = new SqlCommand(queryLeerDocentes, conexion.establecerConexion());
            SqlDataAdapter dt = new SqlDataAdapter(cmd);
            dt.Fill(data);
			return data;
        }

        public static DataTable MostrarMateria()
		{
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
			try
			{
				string mostrar = "SELECT *FROM dbo.Materias";
				SqlCommand cmd = new SqlCommand(mostrar, conexion.establecerConexion());
				SqlDataAdapter dt = new SqlDataAdapter();
				dt.Fill(data);
				return data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return data;
			}
		}


		public static int AgregarCurso(ConstructorCurso Curso)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();
				string agregar = "INSERT INTO dbo.Cursos ( Nombre) VALUES ( @Nombre)";
				SqlCommand cmd = new SqlCommand(agregar, conexion.establecerConexion());
				//cmd.Parameters.AddWithValue("@Id", Curso.Id);
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
				string mostrar = "SELECT *FROM dbo.Cursos";
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

		public static int ActualizarCurso(ConstructorCurso Curso)
		{
            CConexion conexion = new CConexion();
            int retorno = 0;
			string actualizar = "Update dbo.Cursos SET Nombre = @nombreCurso WHERE Id = @idCurso";
			SqlCommand cmd = new SqlCommand(actualizar, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@idCurso",Curso.Id);
			cmd.Parameters.AddWithValue("@nombreCurso",Curso.Nombre);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
		}
	}
}
