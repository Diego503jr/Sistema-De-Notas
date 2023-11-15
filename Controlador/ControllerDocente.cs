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
    internal class ControllerDocente
    {
        public static DataTable MostrarNotas(int idDocente)
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT N.Id, U.Nombre, M.Nombre AS Materia , N.Nota1, N.Nota2, N.Nota3, N.Nota4, N.Promedio " +
                 "FROM dbo.Notas AS N " +
                 "INNER JOIN dbo.Usuarios AS U ON N.IdAlumno = U.Id " +
                 "INNER JOIN dbo.Materias AS M ON N.IdMateria = M.Id " +
                 "WHERE M.IdDocente = @IdDocente AND N.IdEstado = 1 AND U.IdEstado = 1 AND M.IdEstado = 1";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.Add(new SqlParameter("@IdDocente", idDocente));
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
        public static int AgregarNota(Notas NotasAlumno)
        {
            int retorno = 0;

            CConexion conexion = new CConexion();
            try
            {
                string query = "UPDATE Notas SET Nota1 = @nota1, Nota2 = @nota2, Nota3 = @nota3 , Nota4 = @nota4, Promedio = @promedioA WHERE Id = @id AND IdAlumno = @idalumno AND IdMateria = @idmateria";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.Add(new SqlParameter("@nota1", NotasAlumno.Nota1 ));
                cmd.Parameters.Add(new SqlParameter("@nota2", NotasAlumno.Nota2));
                cmd.Parameters.Add(new SqlParameter("@nota3", NotasAlumno.Nota3));
                cmd.Parameters.Add(new SqlParameter("@nota4", NotasAlumno.Nota4));
                cmd.Parameters.Add(new SqlParameter("@promedioA", NotasAlumno.Promedio));
                cmd.Parameters.Add(new SqlParameter("@idalumno", NotasAlumno.IdAlumno));
                cmd.Parameters.Add(new SqlParameter("@idmateria", NotasAlumno.IdMateria));
                cmd.Parameters.Add(new SqlParameter("@id", NotasAlumno.Id));
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 0)
                {
                    MessageBox.Show("Las notas se agregaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Las notas no se agregaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }

        public static int ActualizarNota(Notas NotasAlumno)
        {
            int retorno = 0;

            CConexion conexion = new CConexion();
            try
            {
                string query = "UPDATE Notas SET Nota1 = @nota1, Nota2 = @nota2, Nota3 = @nota3 , Nota4 = @nota4, Promedio = @promedioA WHERE Id = @id AND IdAlumno = @idalumno AND IdMateria = @idmateria";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.Add(new SqlParameter("@nota1", NotasAlumno.Nota1));
                cmd.Parameters.Add(new SqlParameter("@nota2", NotasAlumno.Nota2));
                cmd.Parameters.Add(new SqlParameter("@nota3", NotasAlumno.Nota3));
                cmd.Parameters.Add(new SqlParameter("@nota4", NotasAlumno.Nota4));
                cmd.Parameters.Add(new SqlParameter("@promedioA", NotasAlumno.Promedio));
                cmd.Parameters.Add(new SqlParameter("@idalumno", NotasAlumno.IdAlumno));
                cmd.Parameters.Add(new SqlParameter("@idmateria", NotasAlumno.IdMateria));
                cmd.Parameters.Add(new SqlParameter("@id", NotasAlumno.Id));
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 0)
                {
                    MessageBox.Show("Las notas se actualizaron correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("Las notas no se actualizaron exitosamente", "Hubo un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión, compruebe su conexion a internet ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }
		public static DataTable MostrarAlumnos(int idDocente)
		{
			CConexion conexion = new CConexion();
			DataTable data = new DataTable();
			try
			{
				string query = "SELECT M.Id, U.Nombre AS Alumno, M.Nombre AS Materia, C.Nombre As Curso " +
				 "FROM dbo.Inscripcion AS I " +
				 "INNER JOIN dbo.Usuarios AS U ON I.IdAlumno = U.Id " +
				 "INNER JOIN dbo.Materias AS M ON I.IdMateria = M.Id " +
                 "INNER JOIN dbo.Cursos AS C ON I.IdCurso = C.ID " +
				 "WHERE M.IdDocente = @IdDocente AND I.IdEstado = 1 AND U.IdEstado = 1 AND M.IdEstado = 1 AND C.IdEstado = 1";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.Add(new SqlParameter("@IdDocente", idDocente));
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
	}
}
