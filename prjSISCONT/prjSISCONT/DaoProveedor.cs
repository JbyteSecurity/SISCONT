using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    
    public class DaoProveedor
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();

        public string showProveedor(string ruc)
        {
            SqlDataReader sqlDataReaderProvider;
            DataTable dataTableProvider = new DataTable("tblProveedores");

            comando.Connection = conexion.openConnection();
            comando.CommandText = "sp_show_name_proveedor";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@ruc", ruc);

            comando.ExecuteNonQuery();
            sqlDataReaderProvider = comando.ExecuteReader();
            dataTableProvider.Load(sqlDataReaderProvider);
            comando.Parameters.Clear();

            conexion.closeConnection();

            if (dataTableProvider.Rows.Count > 0)
                return dataTableProvider.Rows[0]["RazonSocial"].ToString();
            else
                return null;
        }
    }
}
