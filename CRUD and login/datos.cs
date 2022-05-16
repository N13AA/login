using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_and_login
{
    public class datos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=arana20220025;Uid = root; pwd =info2022; ");
conectar.Open();
            return conectar;
        }
    }
}
