﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaDeNotas.Clases
{
    internal class CConexion
    {
        static string servidor = "DBRegistroNotas.mssql.somee.com";
        static string db = "DBRegistroNotas";
        static string user = "DieCaris503_SQLLogin_1";
        static string password = "wyej8uij24";
        //static string port = "4096";

        string cadeConexion = "Data source=" + servidor /*+ "," + port */+ ";" + "user id=" + user + ";" + "password=" + password + ";" + "Initial Catalog=" + db + ";" + "Persist Security Info=true";

        public SqlConnection establecerConexion()
        {

			SqlConnection conexion = new SqlConnection(cadeConexion);
			try
			{
                conexion.ConnectionString = cadeConexion;
                conexion.Open();
            } 
            catch (SqlException e){
                MessageBox.Show("No se logro conectar a la nube");
            }

            return conexion;
        }
    }
}