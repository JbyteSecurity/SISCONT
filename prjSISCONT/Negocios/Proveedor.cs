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
        private DaoProveedor daoTipoCambio = new DaoProveedor();
        public string getSupplierName(string ruc)
        {
            string razonSocial;
            razonSocial = daoTipoCambio.showProveedor(ruc);
            return razonSocial;
        }

        public DataTable allSuppliers()
        {
            
            DataTable dataTableSuppliers = new DataTable("tblProveedores");
            dataTableSuppliers = daoTipoCambio.allSuppliers(); ;
            return dataTableSuppliers;
            
        }

        public bool save(string ruc, string razonSocial)
        {
            daoTipoCambio.insert(ruc, razonSocial);
            return true;
        }

        public bool edit(int id, string ruc, string razonSocial)
        {
            daoTipoCambio.update(id, ruc, razonSocial);
            return true;
        }

        public bool delete(int id)
        {
            daoTipoCambio.destroy(id);
            return true;
        }
    }
}
