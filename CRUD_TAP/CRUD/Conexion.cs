using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_TAP.CRUD
{
    class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=clasetopicos");
            conexion.Open();
            return conexion;
        }
    }
}
