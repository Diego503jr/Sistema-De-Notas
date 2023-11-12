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
    internal class FuncionesAlumno
    {
        public static DataTable MostrarNotas(int idAlumno)
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT N.Id, U.Nombre AS Alumno, M.Nombre AS Materia, N.Nota1, N.Nota2, N.Nota3, N.Nota4, N.Promedio " +
                 "FROM dbo.Notas AS N " +
				 "INNER JOIN dbo.Usuarios AS U ON N.IdAlumno = U.Id " +
				 "INNER JOIN dbo.Materias AS M ON N.IdMateria = M.Id " +
                 "WHERE N.IdAlumno = @IdAlumno";
				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.Add(new SqlParameter("@IdAlumno", idAlumno));
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



		public static DataTable MostrarCursos(int idAlumno)
		{
			CConexion conexion = new CConexion();
			DataTable data = new DataTable();
			try
			{
				string query = "SELECT I.Id, U.Nombre AS Alumno, M.Nombre AS Materia, C.Nombre AS Curso " +
				 "FROM dbo.Inscripcion AS I " +
				 "INNER JOIN dbo.Usuarios AS U ON I.IdAlumno = U.Id " +
				 "INNER JOIN dbo.Materias AS M ON I.IdMateria = M.Id " +
				 "INNER JOIN dbo.Cursos   AS C ON I.IdCurso = C.Id " + 
				 "WHERE I.IdAlumno = @IdAlumno";

				SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
				cmd.Parameters.Add(new SqlParameter("@IdAlumno", idAlumno));
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
