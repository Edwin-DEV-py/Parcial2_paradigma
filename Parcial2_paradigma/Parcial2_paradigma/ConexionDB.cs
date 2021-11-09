using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Parcial2_paradigma
{
    class ConexionDB
    {
        static private string CadenaConexion = "Server=LAPTOP-5I9GTG2B; DataBase=Parcial2; Integrated Security= True";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarCoonexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
