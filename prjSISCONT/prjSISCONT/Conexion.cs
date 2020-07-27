using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    class Conexion
    { 
        private SqlConnection conexion = new SqlConnection("Data Source=192.168.1.40\\SQLEXPRESS;Initial Catalog=SISCONT; User ID=sa; Password=sasa");
        public SqlConnection openConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection closeConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }
    }
}
