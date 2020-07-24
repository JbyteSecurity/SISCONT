using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Data;
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

        public DataTable allSuppliers()
        {
            
            DataTable dataTableSuppliers = new DataTable("tblProveedores");
            dataTableSuppliers = daoProveedor.allSuppliers(); ;
            return dataTableSuppliers;
            
        }

        public bool save(string ruc, string razonSocial)
        {
            daoProveedor.insert(ruc, razonSocial);
            return true;
        }

        public bool edit(int id, string ruc, string razonSocial)
        {
            daoProveedor.update(id, ruc, razonSocial);
            return true;
        }

        public bool delete(int id)
        {
            daoProveedor.destroy(id);
            return true;
        }
    }
}
