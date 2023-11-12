using SistemaDeNotas.Interfaz.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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
                // Verificar si el usuario ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND Contraseña = @contraseña AND IdEstado = @idestado AND Telefono = @telefono";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                cmdExiste.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmdExiste.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                cmdExiste.Parameters.AddWithValue("@idestado", Usuarios.IdEstado);
                cmdExiste.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
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
                string query = "SELECT U.Id, R.RolUsuario As Rol, U.Nombre, U.Carnet, U.Telefono, U.Contraseña ,E.EstadoValor As Estado " +
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

        public static int ActualizarUsuarios(ConstructorUsuario Usuarios)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();

                // Verificar si el usuario ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND Contraseña = @contraseña AND IdEstado = @idestado AND Telefono = @telefono";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                cmdExiste.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmdExiste.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                cmdExiste.Parameters.AddWithValue("@idestado", Usuarios.IdEstado);
                cmdExiste.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string query = "UPDATE dbo.Usuarios SET IdRol = @rol, Nombre = @nombre, Carnet = @carnet, Contraseña = @contraseña, Telefono = @telefono, IdEstado = @estado WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@rol", Usuarios.IdRole);
                cmd.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                cmd.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmd.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                cmd.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
                cmd.Parameters.AddWithValue("@estado", Usuarios.IdEstado);
                cmd.Parameters.AddWithValue("@Id", Usuarios.Id);

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

        public static int EliminarUsuario(ConstructorUsuario Usuario)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                string query = "UPDATE dbo.Usuarios SET IdEstado = 0 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Id", Usuario.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos del usuario se eliminaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //Funciones para el formulario Materias
        public static int AgregarMateria(ConstructorMateria Materia)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();

                // Verificar si la materia ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Materias WHERE Nombre = @nombre AND Descripcion = @descripcion AND IdDocente = @iddocente AND IdEstado = @idestado";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre", Materia.Nombre);
                cmdExiste.Parameters.AddWithValue("@descripcion", Materia.Descripcion);
                cmdExiste.Parameters.AddWithValue("@iddocente", Materia.IdDocente);
                cmdExiste.Parameters.AddWithValue("@idestado", Materia.IdEstado);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

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
                string query = "SELECT m.Id, m.Nombre,m.Descripcion, U.Nombre AS Docente, E.EstadoValor AS Estado " + 
                    "FROM dbo.Materias AS m " + 
                    "INNER JOIN dbo.Usuarios AS U ON m.IdDocente = U.Id " +
                    "INNER JOIN dbo.Estado AS E ON m.IdEstado = E.Id";
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
			int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                // Verificar si la materia ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Materias WHERE Nombre = @nombre AND Descripcion = @descripcion AND IdDocente = @iddocente AND IdEstado = @idestado";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre", Materia.Nombre);
                cmdExiste.Parameters.AddWithValue("@descripcion", Materia.Descripcion);
                cmdExiste.Parameters.AddWithValue("@iddocente", Materia.IdDocente);
                cmdExiste.Parameters.AddWithValue("@idestado", Materia.IdEstado);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string actu = "UPDATE dbo.Materias SET Nombre = @Nombre, Descripcion = @Descripcion, IdDocente = @IdDocente, IdEstado = @idestado WHERE Id= @Id";
                SqlCommand cmd = new SqlCommand(actu, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Nombre", Materia.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Materia.Descripcion);
                cmd.Parameters.AddWithValue("@IdDocente", Materia.IdDocente);
                cmd.Parameters.AddWithValue("@idestado", Materia.IdEstado);
                cmd.Parameters.AddWithValue("@Id", Materia.Id);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos de la materia se actualizaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public static int EliminarMateria(ConstructorMateria Materia)
		{
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                string query = "UPDATE dbo.Materias SET IdEstado = 0 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Id", Materia.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos de la materia se eliminaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Los datos no se eliminaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error de conexion {ex}", "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
            
		}

		//Funciones para el formulario Curso

		public static int AgregarCurso(ConstructorCurso Curso)
		{
			int retorno = 0;
			try
			{
				CConexion conexion = new CConexion();

                // Verificar si el curso ya existe
                string queryVerificar = "SELECT COUNT(*) FROM dbo.Cursos WHERE Nombre = @Nombre AND IdEstado = @idestado";
                SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion.establecerConexion());
                cmdVerificar.Parameters.AddWithValue("@Nombre", Curso.Nombre);
                cmdVerificar.Parameters.AddWithValue("@idestado", Curso.IdEstado);
                int cantidadCursos = (int)cmdVerificar.ExecuteScalar();

                if (cantidadCursos > 0)
                {
                    MessageBox.Show("Ya existe un curso con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string query = "INSERT INTO dbo.Cursos (Nombre, IdEstado) VALUES (@Nombre, @IdEstado)";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.AddWithValue("@Nombre", Curso.Nombre);
                cmd.Parameters.AddWithValue("@IdEstado", Curso.IdEstado);
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
                string query = "SELECT C.Id, C.Nombre, E.EstadoValor AS Estado " +
                    "FROM dbo.Cursos AS C " +
                    "INNER JOIN dbo.Estado AS E ON C.IdEstado = E.Id ";
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

            try
            {
                // Verificar si el curso ya existe
                string queryVerificar = "SELECT COUNT(*) FROM dbo.Cursos WHERE Nombre = @Nombre AND IdEstado = @idestado";
                SqlCommand cmdVerificar = new SqlCommand(queryVerificar, conexion.establecerConexion());
                cmdVerificar.Parameters.AddWithValue("@Nombre", Curso.Nombre);
                cmdVerificar.Parameters.AddWithValue("@idestado", Curso.IdEstado);
                int cantidadCursos = (int)cmdVerificar.ExecuteScalar();

                if (cantidadCursos > 0)
                {
                    MessageBox.Show("Ya existe un curso con el mismo nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

                string query = "Update dbo.Cursos SET Nombre = @Nombre, IdEstado = @IdEstado WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Nombre", Curso.Nombre);
                cmd.Parameters.AddWithValue("@IdEstado", Curso.IdEstado);
                cmd.Parameters.AddWithValue("@Id", Curso.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Se ha actualizado la información de curso con éxtio", "Actualizar Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		public static int EliminarCurso(ConstructorCurso Curso)
		{
			CConexion conexion = new CConexion();
			int retorno = 0;
            try
            {
                string query = "UPDATE dbo.Cursos SET IdEstado = 0 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Id", Curso.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
			        MessageBox.Show("Curso eliminado con éxito", "Eliminar Curso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Los datos no se eliminaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Hubo un error de conexión" + ex, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
		}



		//Funciones para el formulario de inscripcion

		public static int AgregarInscripcion(ConstructorInscripcion Inscripcion)
		{
			int retorno = 0;
			try
			{
                CConexion conexion = new CConexion();

                // Verificar si la inscripcion ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Inscripcion WHERE IdAlumno = @idAlumno AND IdCurso = @idCurso AND IdMateria = @idMateria AND IdEstado = @idestado";
				SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
				cmdExiste.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
				cmdExiste.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
				cmdExiste.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                cmdExiste.Parameters.AddWithValue("@idestado", Inscripcion.IdEstado);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
				{
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                } 

                string query = "INSERT INTO dbo.Inscripcion(IdAlumno, IdCurso, IdMateria, IdEstado) VALUES(@idAlumno, @idCurso, @idMateria, @idestado)";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmd.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmd.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                cmd.Parameters.AddWithValue("@idestado", Inscripcion.IdEstado);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Los datos de la inscripción se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string queryNotas = "INSERT INTO dbo.Notas(IdAlumno, IdMateria, IdEstado) VALUES(@idAlumno, @idMateria, @idestado)";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@idAlumno",Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@idMateria",Inscripcion.IdMateria);
                    cmdNotas.Parameters.AddWithValue("@idestado", Inscripcion.IdEstado);
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
                string query = "SELECT I.Id, U.Nombre, U.Carnet, C.Nombre AS Curso,  M.Nombre AS Materia, E.EstadoValor AS Estado " +
                "FROM dbo.Inscripcion AS I " +
                "INNER JOIN dbo.Usuarios AS U ON I.IdAlumno = U.Id " +
                "INNER JOIN dbo.Cursos AS C ON I.IdCurso = C.Id " +
                "INNER JOIN dbo.Materias AS M ON I.IdMateria = M.Id " + 
                "INNER JOIN dbo.Estado AS E ON I.IdEstado = E.Id";
				

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

                // Verificar si la inscripcion ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Inscripcion WHERE IdAlumno = @idAlumno AND IdCurso = @idCurso AND IdMateria = @idMateria AND IdEstado = @idestado";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmdExiste.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmdExiste.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                cmdExiste.Parameters.AddWithValue("@idestado", Inscripcion.IdEstado);
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

                string queryObtenerAntiguoEstado = "SELECT IdEstado FROM dbo.Inscripcion WHERE Id = @id";
                SqlCommand cmdObtenerAntiguoIdEstado = new SqlCommand(queryObtenerAntiguoEstado, conexion.establecerConexion());
                cmdObtenerAntiguoIdEstado.Parameters.AddWithValue("@id", Inscripcion.Id);
                int antiguoEstado = (int)cmdObtenerAntiguoIdEstado.ExecuteScalar();

                string query = "UPDATE dbo.Inscripcion SET IdAlumno = @idAlumno, IdCurso = @idCurso, IdMateria = @idMateria, IdEstado = @idestado WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                cmd.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
                cmd.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                cmd.Parameters.AddWithValue("@idestado", Inscripcion.IdEstado);
                cmd.Parameters.AddWithValue("@id", Inscripcion.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    MessageBox.Show("Se ha actualizado la información de curso con éxtio", "Actualizar Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string queryNotas = "UPDATE dbo.Notas SET IdMateria = @nuevaIdMateria, IdEstado= @nuevoEstado WHERE IdAlumno = @idAlumno AND IdMateria = @viejaIdMateria AND IdEstado = @viejoIdEstado";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@nuevaIdMateria", Inscripcion.IdMateria);
                    cmdNotas.Parameters.AddWithValue("@nuevoEstado", Inscripcion.IdEstado);
                    cmdNotas.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@viejaIdMateria", antiguaIdMateria);
                    cmdNotas.Parameters.AddWithValue("@viejoIdEstado", antiguoEstado);
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

        public static int EliminarInscripcion(ConstructorInscripcion Inscripcion)
        {
            CConexion conexion = new CConexion();
            int retorno = 0;
            try
            {
                string query = "UPDATE dbo.Inscripcion SET IdEstado = 0 WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.AddWithValue("@Id", Inscripcion.Id);
                retorno = cmd.ExecuteNonQuery();

                if (retorno >= 0)
                {
                    string queryNotas = "UPDATE dbo.Notas SET IdEstado = 0 WHERE IdAlumno = @idAlumno AND IdMateria = @idMateria";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@idMateria", Inscripcion.IdMateria);
                    int resultadoNotas = cmdNotas.ExecuteNonQuery();

                    MessageBox.Show("Inscripcion eliminada con éxito", "Eliminar Curso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Los datos no se eliminaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Mediante este manejo se evalua si la tecla presionada es letra o numero, se utilizara en cursos, carnets, contraseñas
        public static void ManejoErrores(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Ingrese únicamente letras por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //este es para el nombre
        public static void ManejoErroresNombre(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Ingrese únicamente números por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //este es para el telefono
        public static void ManejoErroresTelefono(KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true; //se ejecuta para suprimir la tecla presionada en caso no haya cumplido la condicion
                    MessageBox.Show("Ingrese únicamente números por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
