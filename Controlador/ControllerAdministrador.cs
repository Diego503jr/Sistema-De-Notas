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
	internal class ControllerAdministrador
	{
        // Esta función realiza la inserción de usuarios en la base de datos
        public static int AgregarUsuarios(Usuario Usuarios)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                // Verificar si el usuario ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND Contraseña = @contraseña AND IdEstado = @idestado AND Telefono = @telefono";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                // Asignar los parámetros con los valores del objeto Usuario proporcionado
                cmdExiste.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                cmdExiste.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmdExiste.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                cmdExiste.Parameters.AddWithValue("@idestado", Usuarios.IdEstado);
                cmdExiste.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
                // Ejecutar la consulta para insertar datos y obtener el número de filas afectadas
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

                // Mostrar un mensaje de acuerdo al resultado de la inserción
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static DataTable MostrarUsuarios()
        {
            CConexion conexion = new CConexion();
            // Se crea un DataTable para almacenar los resultados de la consulta
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT U.Id, R.RolUsuario As Rol, U.Nombre, U.Carnet, U.Telefono, U.Contraseña ,E.EstadoValor As Estado " +
                    "FROM dbo.Usuarios AS U " +
                    "INNER JOIN dbo.Roles AS R ON U.IdRol = R.Id " +
                    "INNER JOIN dbo.Estado AS E ON U.IdEstado = E.Id";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                // Creación de un SqlDataAdapter para llenar el DataTable con los resultados de la consulta
                SqlDataAdapter dt = new SqlDataAdapter(cmd);
                dt.Fill(data);
                // Devuelve el DataTable con los datos recuperados de la base de datos
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

        public static int ActualizarUsuarios(Usuario Usuarios)
        {
            CConexion conexion = new CConexion();
            int retorno = 0;
            try
            {
                // Verificar si el usuario ya existe
                string existeQuery = "SELECT COUNT(*) FROM dbo.Usuarios WHERE Nombre = @nombre AND Carnet = @carnet AND Contraseña = @contraseña AND IdEstado = @idestado AND Telefono = @telefono AND IdRol = @idrol   ";
                SqlCommand cmdExiste = new SqlCommand(existeQuery, conexion.establecerConexion());
                cmdExiste.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                cmdExiste.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                cmdExiste.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                cmdExiste.Parameters.AddWithValue("@idestado", Usuarios.IdEstado);
                cmdExiste.Parameters.AddWithValue("@idrol", Usuarios.IdRole);
                cmdExiste.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
                int count = (int)cmdExiste.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Ya existe un registro con estos datos", "Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
                else
                {

                    //SI NO EXISTE SE ACTUALIZAN LOS DATOS
                    string query = "UPDATE dbo.Usuarios SET IdRol = @rol, Nombre = @nombre, Carnet = @carnet, Contraseña = @contraseña, Telefono = @telefono, IdEstado = @estadoUs WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                    cmd.Parameters.AddWithValue("@rol", Usuarios.IdRole);
                    cmd.Parameters.AddWithValue("@nombre", Usuarios.Nombre);
                    cmd.Parameters.AddWithValue("@carnet", Usuarios.Carnet);
                    cmd.Parameters.AddWithValue("@contraseña", Usuarios.Contraseña);
                    cmd.Parameters.AddWithValue("@telefono", Usuarios.Telefono);
                    cmd.Parameters.AddWithValue("@estadoUs", Usuarios.IdEstado);
                    cmd.Parameters.AddWithValue("@Id", Usuarios.Id);

                    // Actualizar Inscripciones
                    string queryInscripciones = "UPDATE dbo.Inscripcion SET IdEstado = @estadoIns WHERE IdAlumno = @IdUsuario";
                    SqlCommand cmdInscripciones = new SqlCommand(queryInscripciones, conexion.establecerConexion());
                    cmdInscripciones.Parameters.AddWithValue("@estadoIns", Usuarios.IdEstado);
                    cmdInscripciones.Parameters.AddWithValue("@IdUsuario", Usuarios.Id);
                    retorno += cmdInscripciones.ExecuteNonQuery();

                    // Actualizar Materias
                    string queryMaterias = "UPDATE dbo.Materias SET IdEstado = @estadoMat WHERE IdDocente = @IdUsuario";
                    SqlCommand cmdMaterias = new SqlCommand(queryMaterias, conexion.establecerConexion());
                    cmdMaterias.Parameters.AddWithValue("@estadoMat", Usuarios.IdEstado);
                    cmdMaterias.Parameters.AddWithValue("@IdUsuario", Usuarios.Id);
                    retorno += cmdMaterias.ExecuteNonQuery();

                    // Actualizar Notas
                    string queryNotas = "UPDATE dbo.Notas SET IdEstado = @estadoNota WHERE IdAlumno = @IdUsuario";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@estadoNota", Usuarios.IdEstado);
                    cmdNotas.Parameters.AddWithValue("@IdUsuario", Usuarios.Id);
                    retorno += cmdNotas.ExecuteNonQuery();

                    retorno = cmd.ExecuteNonQuery();
                    if (retorno >= 0)
                    {
                        MessageBox.Show("Los datos del usuario se actualizaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("Los datos no se actualizaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static int EliminarUsuario(Usuario Usuario)
        {
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                // Verificar si el usuario ya está marcado como eliminado
                string queryVerificarEstado = "SELECT IdEstado FROM dbo.Usuarios WHERE Id = @Id";
                SqlCommand cmdVerificarEstado = new SqlCommand(queryVerificarEstado, conexion.establecerConexion());
                cmdVerificarEstado.Parameters.AddWithValue("@Id", Usuario.Id);

                // Obtener el estado actual del usuario
                int estadoActual = (int)cmdVerificarEstado.ExecuteScalar();

                if (estadoActual == 0)
                {
                    MessageBox.Show("El usuario ya está marcado como eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de Eliminar el Usuario?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Actualizar Usuarios
                    string queryUsuarios = "UPDATE dbo.Usuarios SET IdEstado = 0 WHERE Id = @Id";
                    SqlCommand cmdUsuarios = new SqlCommand(queryUsuarios, conexion.establecerConexion());
                    cmdUsuarios.Parameters.AddWithValue("@Id", Usuario.Id);
                    retorno = cmdUsuarios.ExecuteNonQuery();

                    // Actualizar Inscripciones
                    string queryInscripciones = "UPDATE dbo.Inscripcion SET IdEstado = 0 WHERE IdAlumno = @IdUsuario";
                    SqlCommand cmdInscripciones = new SqlCommand(queryInscripciones, conexion.establecerConexion());
                    cmdInscripciones.Parameters.AddWithValue("@IdUsuario", Usuario.Id);
                    retorno += cmdInscripciones.ExecuteNonQuery();

                    // Actualizar Materias
                    string queryMaterias = "UPDATE dbo.Materias SET IdEstado = 0 WHERE IdDocente = @IdUsuario";
                    SqlCommand cmdMaterias = new SqlCommand(queryMaterias, conexion.establecerConexion());
                    cmdMaterias.Parameters.AddWithValue("@IdUsuario", Usuario.Id);
                    retorno += cmdMaterias.ExecuteNonQuery();

                    // Actualizar Notas
                    string queryNotas = "UPDATE dbo.Notas SET IdEstado = 0 WHERE IdAlumno = @IdUsuario";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@IdUsuario", Usuario.Id);
                    retorno += cmdNotas.ExecuteNonQuery();

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
                else
                {
                    MessageBox.Show("El usuario no se elimino", "Informacion!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        //Funciones para el formulario Materias
        public static int AgregarMateria(Materia Materia)
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

                string query = "INSERT INTO dbo.Materias (Nombre, Descripcion, IdDocente, IdEstado) VALUES (@Nombre, @Descripcion, @IdDocente, @idestado)";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.AddWithValue("@Nombre", Materia.Nombre);
				cmd.Parameters.AddWithValue("@Descripcion", Materia.Descripcion);
				cmd.Parameters.AddWithValue("@IdDocente", Materia.IdDocente);
                cmd.Parameters.AddWithValue("@idestado", Materia.IdEstado);
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

		public static int ActualizarMateria(Materia Materia)
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
		}

		public static int EliminarMateria(Materia Materia)
		{
            int retorno = 0;
            try
            {
                CConexion conexion = new CConexion();
                // Verificar si la materia ya está marcado como eliminado
                string queryVerificarEstado = "SELECT IdEstado FROM dbo.Materias WHERE Id = @Id";
                SqlCommand cmdVerificarEstado = new SqlCommand(queryVerificarEstado, conexion.establecerConexion());
                cmdVerificarEstado.Parameters.AddWithValue("@Id", Materia.Id);

                // Obtener el estado actual de la materia   
                int estadoActual = (int)cmdVerificarEstado.ExecuteScalar();

                if (estadoActual == 0)
                {
                    MessageBox.Show("La Materia ya está marcado como eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de Eliminar la Materia?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
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
                else
                {
                    MessageBox.Show("La materia no se elimino", "Informacion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
            
		}

		//Funciones para el formulario Curso

		public static int AgregarCurso(Cursos Curso)
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
			}
		}

		public static int ActualizarCurso(Cursos Curso)
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
		}

		public static int EliminarCurso(Cursos Curso)
		{
			CConexion conexion = new CConexion();
			int retorno = 0;
            try
            {
                // Verificar si el curso ya está marcado como eliminado
                string queryVerificarEstado = "SELECT IdEstado FROM dbo.Cursos WHERE Id = @Id";
                SqlCommand cmdVerificarEstado = new SqlCommand(queryVerificarEstado, conexion.establecerConexion());
                cmdVerificarEstado.Parameters.AddWithValue("@Id", Curso.Id);

                // Obtener el estado actual del curso
                int estadoActual = (int)cmdVerificarEstado.ExecuteScalar();

                if (estadoActual == 0)
                {
                    MessageBox.Show("El Curso ya está marcado como eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de Eliminar el Curso?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
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
                }
                else
                {
                    MessageBox.Show("El usuario no se elimino", "Informacion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
               
            } catch(Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
		}



		//Funciones para el formulario de inscripcion

		public static int AgregarInscripcion(Inscripcion Inscripcion)
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

                    string queryNotas = "INSERT INTO dbo.Notas(IdAlumno, IdMateria,Nota1, Nota2, Nota3, Nota4, Promedio, IdEstado, IdCurso) VALUES(@idAlumno, @idMateria,0,0,0,0,0, @idestado, @idCurso)";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@idAlumno",Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@idMateria",Inscripcion.IdMateria);
                    cmdNotas.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
			}
            catch (Exception ex)
			{
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return data;
            }
        }

		public static int ActualizarInscripcion(Inscripcion Inscripcion)
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

                string queryObtenerAntiguoIdCurso = "SELECT IdCurso FROM dbo.Inscripcion WHERE Id = @id";
                SqlCommand cmdObtenerAntiguoIdCurso = new SqlCommand(queryObtenerAntiguoIdCurso, conexion.establecerConexion());
                cmdObtenerAntiguoIdCurso.Parameters.AddWithValue("@id", Inscripcion.Id);
                int antiguoIdCurso = (int)cmdObtenerAntiguaIdMateria.ExecuteScalar();

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

                    string queryNotas = "UPDATE dbo.Notas SET IdMateria = @nuevaIdMateria, IdEstado= @nuevoEstado, IdCurso = @nuevaIdCurso WHERE IdAlumno = @idAlumno AND IdMateria = @viejaIdMateria AND IdEstado = @viejoIdEstado AND IdCurso = @viejoIdCurso";
                    SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                    cmdNotas.Parameters.AddWithValue("@nuevaIdMateria", Inscripcion.IdMateria);
                    cmdNotas.Parameters.AddWithValue("@nuevaIdCurso", Inscripcion.IdCurso);
                    cmdNotas.Parameters.AddWithValue("@nuevoEstado", Inscripcion.IdEstado);
                    cmdNotas.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                    cmdNotas.Parameters.AddWithValue("@viejoIdCurso", antiguoIdCurso);
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
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
			}
		}

        public static int EliminarInscripcion(Inscripcion Inscripcion)
        {
            CConexion conexion = new CConexion();
            int retorno = 0;
            try
            {
                // Verificar si la inscripcion ya está marcado como eliminado
                string queryVerificarEstado = "SELECT IdEstado FROM dbo.Inscripcion WHERE Id = @Id";
                SqlCommand cmdVerificarEstado = new SqlCommand(queryVerificarEstado, conexion.establecerConexion());
                cmdVerificarEstado.Parameters.AddWithValue("@Id", Inscripcion.Id);

                // Obtener el estado actual de la inscripcion   
                int estadoActual = (int)cmdVerificarEstado.ExecuteScalar();

                if (estadoActual == 0)
                {
                    MessageBox.Show("La Inscripcion ya está marcado como eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 0;
                }

                DialogResult resultado = MessageBox.Show("¿Estás seguro de Eliminar la inscripcion?", "Alerta!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    string query = "UPDATE dbo.Inscripcion SET IdEstado = 0 WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                    cmd.Parameters.AddWithValue("@Id", Inscripcion.Id);
                    retorno = cmd.ExecuteNonQuery();

                    if (retorno >= 0)
                    {
                        string queryNotas = "UPDATE dbo.Notas SET IdEstado = 0 WHERE IdAlumno = @idAlumno AND IdMateria = @idMateria AND IdCurso = @idCurso";
                        SqlCommand cmdNotas = new SqlCommand(queryNotas, conexion.establecerConexion());
                        cmdNotas.Parameters.AddWithValue("@idAlumno", Inscripcion.IdAlumno);
                        cmdNotas.Parameters.AddWithValue("@idCurso", Inscripcion.IdCurso);
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
                else
                {
                    MessageBox.Show("La Inscripcion no se elimino", "Informacion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }
    }
}
