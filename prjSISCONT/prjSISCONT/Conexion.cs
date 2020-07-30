using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Datos
{
    class Conexion
    {
<<<<<<< HEAD
        //private SqlConnection conexion = new SqlConnection("Data Source=192.168.1.40\\SQLEXPRESS;Initial Catalog=SISCONT; User ID=sa; Password=sasa");
        private SqlConnection conexion = new SqlConnection("Data Source=198.12.230.10;Initial Catalog=SISCONT; User ID=procont; Password=Lampara1988");
=======
        #region Connection to MySQL
        private MySqlConnection mySqlConnection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Conexion()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "198.12.230.10";
            database = "siscont";
            uid = "usuario";
            password = "Lampara1988";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            mySqlConnection = new MySqlConnection(connectionString);
        }

        public MySqlConnection OpenConnection()
        {
            if (mySqlConnection.State == ConnectionState.Closed)
                mySqlConnection.Open();
            return mySqlConnection;
        }

        //Close connection
        public MySqlConnection CloseConnection()
        {
            if (mySqlConnection.State == ConnectionState.Open)
                mySqlConnection.Close();
            return mySqlConnection;
        }

        #endregion

        #region Connection to SQL Server
        /*private SqlConnection conexion = new SqlConnection("Data Source=192.168.1.40\\SQLEXPRESS;Initial Catalog=SISCONT; User ID=sa; Password=sasa");
>>>>>>> bc9dabc0394e45708667573b96790b42771d96f1
        public SqlConnection OpenConnection()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection CloseConnection()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }*/
        #endregion
    }
}
