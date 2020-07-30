using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class DaoComprobantePago
    {
        private Conexion conexion = new Conexion();

        MySqlCommand comando = new MySqlCommand();
        public DataTable allCdpTypes()
        {
            MySqlDataReader leer;
            DataTable dataTableCDPType = new DataTable();
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_all_tipo_comprobante";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            dataTableCDPType.Load(leer);
            conexion.CloseConnection();
            return dataTableCDPType;

        }
    }
}
