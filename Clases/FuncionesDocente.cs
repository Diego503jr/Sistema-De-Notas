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
        public static DataTable MostrarNotas()
        {
            CConexion conexion = new CConexion();
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM dbo.Notas";
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
    }
}
