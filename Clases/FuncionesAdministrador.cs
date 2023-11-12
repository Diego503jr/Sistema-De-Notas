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
        //Funciones para el formulario Usuarios
        public static int AgregarUsuarios(ConstructorUsuario Usuarios)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();

                string existeQuery = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Id = @id AND Nombre = @nombre AND carnet = @carnet";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre",Usuarios.Nombre);
                cmdExiste.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmdExiste.Parameters.AddWithValue("@id",Usuarios.Id);

                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string query = "INSERT INTO Usuarios(IdRol, Nombre, Carnet, Contraseña, Telefono, IdEstado) VALUES(@rol, @nombre, @carnet, @contraseña, @telefono, @estado)";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@rol",Usuarios.IdRole);
                cmd.Parameters.AddWithValue("@nombre",Usuarios.Nombre);
                cmd.Parameters.AddWithValue("@carnet",Usuarios.Carnet);
                cmd.Parameters.AddWithValue("@contraseña",Usuarios.Contraseña);
                cmd.Parameters.AddWithValue("@telefono",Usuarios.Telefono);
                cmd.Parameters.AddWithValue("@estado",Usuarios.IdEstado);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos del usuario se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static DataTable MostrarUsuarios()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT U.Id, R.RolUsuario As Rol, U.Nombre, U.Carnet, U.Telefono, E.EstadoValor As Estado " +
                    "FROM dbo.Usuarios AS U " +
                    "INNER JOIN dbo.Roles AS R ON U.IdRol = R.Id " +
                    "INNER JOIN dbo.Estado AS E ON U.IdEstado = E.Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

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
                string query = "SELECT m.Id, m.Nombre,m.Descripcion, U.Nombre AS Docente " + "FROM dbo.Materias AS m " + "INNER JOIN dbo.Usuarios AS U ON m.IdDocente = U.Id";
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

		public static int ActualizarMateria(ConstructorMateria Materia)
		{
			CConexion conexion = new CConexion();
			int retorno = 0;
			string actu = "UPDATE dbo.Materias SET Nombre = @Nombre, Descripcion= @Descripcion, IdDocente = @IdDocente WHERE Id= @Id";
			SqlCommand cmd = new SqlCommand(actu, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@Nombre", Materia.Nombre);
			cmd.Parameters.AddWithValue("@Descripcion", Materia.Descripcion);
			cmd.Parameters.AddWithValue("@Id", Materia.Id);
			cmd.Parameters.AddWithValue("@IdDocente", Materia.IdDocente);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
		}

		public static int EliminarMateria(ConstructorMateria Materia)
		{
			CConexion conexion = new CConexion();
			int retorno = 0;
			string query = "DELETE dbo.Materias  WHERE Id = @Id";
			SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@Id", Materia.Id);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
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
			string query = "Update dbo.Cursos SET Nombre = @Nombre WHERE Id = @Id";
			SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@Nombre", Curso.Nombre);
			cmd.Parameters.AddWithValue("@Id",Curso.Id);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
		}

		public static int EliminarCurso(ConstructorCurso Curso)
		{
			CConexion conexion = new CConexion();
			int retorno = 0;
			string query = "DELETE dbo.Cursos  WHERE Id = @Id";
			SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
			cmd.Parameters.AddWithValue("@Id", Curso.Id);
			retorno = cmd.ExecuteNonQuery();
			return retorno;
		}



		//Funciones para el formulario de inscripcion

		public static int AgregarInscripcion(ConstructorInscripcion Inscripcion)
		{
			int retorno = 0;
			try
			{
                CConexion conexion = new CConexion();

				string existeQuery = "SELECT COUNT(*) FROM dbo.Inscripcion WHERE IdAlumno = @idAlumno AND IdCurso = @idCurso AND IdMateria = @idMateria";
				SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
				cmdExiste.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
				cmdExiste.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
				cmdExiste.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);

				int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
				{
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                } 

                string query = "INSERT INTO dbo.Inscripcion(IdAlumno, IdCurso, IdMateria) VALUES(@idAlumno, @idCurso, @idMateria)";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmd.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmd.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos de la inscripción se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string queryNotas = "INSERT INTO dbo.Notas(IdAlumno, IdMateria) VALUES(@idAlumno, @idMateria)";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@idAlumno",Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@idMateria",Inscripcion.IdMateria);
                    cmdNotas.ExecuteNonQuery();
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
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
		}

        public static DataTable MostrarInscripcion()
		{
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
			try
			{
                string query = "SELECT I.Id, U.Nombre, U.Carnet, C.Nombre AS Curso,  M.Nombre AS Materia " +
                "FROM dbo.Inscripcion AS I " +
                "INNER JOIN dbo.Usuarios AS U ON I.IdAlumno = U.Id " +
                "INNER JOIN dbo.Cursos AS C ON I.IdCurso = C.Id " +
                "INNER JOIN dbo.Materias AS M ON I.IdMateria = M.Id";
				

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

		public static int ActualizarInscripcion(ConstructorInscripcion Inscripcion)
		{
			int retorno = 0;

			try
			{
				CConexion conexion = new CConexion();

                string existeQuery = "SELECT COUNT(*) FROM dbo.Inscripcion WHERE IdAlumno = @idAlumno AND IdCurso = @idCurso AND IdMateria = @idMateria";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmdExiste.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmdExiste.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string queryObtenerAntiguaIdMateria = "SELECT IdMateria FROM dbo.Inscripcion WHERE Id = @id";
                SqlCommand cmdObtenerAntiguaIdMateria = new SqlCommand(queryObtenerAntiguaIdMateria, conexion.establecerConexion());
                cmdObtenerAntiguaIdMateria.Parameters.AddWithValue("@id", Inscripcion.Id);
                int antiguaIdMateria = (int)cmdObtenerAntiguaIdMateria.ExecuteScalar();

                string query = "UPDATE dbo.Inscripcion SET IdAlumno = @idAlumno, IdCurso = @idCurso, IdMateria = @idMateria WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmd.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmd.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                cmd.Parameters.AddWithValue("@id", Inscripcion.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Se ha actualizado la información de curso con éxtio", "Actualizar Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string queryNotas = "UPDATE dbo.Notas SET IdMateria = @nuevaIdMateria WHERE IdAlumno = @idAlumno AND IdMateria = @viejaIdMateria";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@nuevaIdMateria", Inscripcion.IdMateria);
                    cmdNotas.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@viejaIdMateria", antiguaIdMateria);
                    cmdNotas.ExecuteNonQuery();
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Los datos no se actualizaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
			{
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
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
                string query = "SELECT Id, Nombre, IdDocente FROM dbo.Materias";
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
        public static DataTable ListarMateriaDocente(int ValorIdDocente)
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM Materias WHERE IdDocente = @iddocente";

                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@iddocente", ValorIdDocente);

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
    }
}
