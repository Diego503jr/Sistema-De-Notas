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
    internal class FuncionesDocente
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
                 "WHERE M.IdDocente = @IdDocente";
                SqlCommand cmd = new SqlCommand(query, conexion.establecerConexion());
                cmd.Parameters.Add(new SqlParameter("@IdDocente", idDocente));
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
    }
}
