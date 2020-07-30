﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
<<<<<<< HEAD
using System.Data.SqlClient;
using System.Windows.Forms;
=======
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
>>>>>>> bc9dabc0394e45708667573b96790b42771d96f1

namespace Datos
{
    public class DaoTipoCambio
    {
        Conexion conexion = new Conexion();
        MySqlCommand comando = new MySqlCommand();

        public DataTable all()
        {
            MySqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_all_tipo_cambio";
            comando.CommandType = CommandType.StoredProcedure;
            sqlDataReader = comando.ExecuteReader();
            dataTable.Load(sqlDataReader);
            conexion.CloseConnection();
            return dataTable;
        }

        public DataTable show(string fecha)
        {
            MySqlDataReader sqlDataReader;
            DataTable dataTable = new DataTable();

            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_show_tipo_cambio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Fecha", Convert.ToDateTime(fecha));

            comando.ExecuteNonQuery();
            sqlDataReader = comando.ExecuteReader();
            dataTable.Load(sqlDataReader);
            comando.Parameters.Clear();

            conexion.CloseConnection();
            return dataTable;
        }

        public void insert(string fecha, double compra, double venta)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_insert_tipo_cambio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Compra", compra);
            comando.Parameters.AddWithValue("@Venta", venta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CloseConnection();
        }

        public void update(int id, string fecha, double compra, double venta)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_update_tipo_cambio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@Fecha", fecha);
            comando.Parameters.AddWithValue("@Compra", compra);
            comando.Parameters.AddWithValue("@Venta", venta);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CloseConnection();
        }

        public void destroy(int id)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "sp_delete_tipo_cambio";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CloseConnection();
        }
    }
}
