using System;
using System.Collections.Generic;
using System.Text;
using Datos;
using System.Data;

namespace Negocios
{
    public class TipoCambio
    {
        private DaoTipoCambio daoProveedor = new DaoTipoCambio();
        public DataTable show(string fecha)
        {
            DataTable dataTable = new DataTable();
            dataTable = daoProveedor.show(fecha);
            return dataTable;
        }

        public DataTable all()
        {

            DataTable dataTableSuppliers = new DataTable();
            dataTableSuppliers = daoProveedor.all(); ;
            return dataTableSuppliers;

        }

        public bool save(string fecha, double compra, double venta)
        {
            daoProveedor.insert(fecha, compra, venta);
            return true;
        }

        public bool edit(int id, string fecha, double compra, double venta)
        {
            daoProveedor.update(id, fecha, compra, venta);
            return true;
        }

        public bool delete(int id)
        {
            daoProveedor.destroy(id);
            return true;
        }
    }
}
