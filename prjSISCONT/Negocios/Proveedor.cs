using System;
using System.Collections.Generic;
using System.Text;
using Datos;

namespace Negocios
{
    public class Proveedor
    {
        private DaoProveedor daoProveedor = new DaoProveedor();
        public string getSupplierName(string ruc)
        {
            string razonSocial;
            razonSocial = daoProveedor.showProveedor(ruc);
            return razonSocial;
        }
    }
}
