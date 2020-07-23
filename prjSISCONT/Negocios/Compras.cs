﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;

namespace Negocios
{
    public class Compras
    {

        private DaoCompras objCompras = new DaoCompras();

        public DataTable getAllCpdTypes()
        {
            DataTable dataTableCDPTypes = new DataTable();
            dataTableCDPTypes = objCompras.allCdpTypes();
            return dataTableCDPTypes;
        }

        public DataTable getProvider(string ruc)
        {
            DataTable dataTableProvider = new DataTable();
            dataTableProvider = objCompras.showProveedor(ruc);
            return dataTableProvider;
        }

        public void save(
            int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia
            )
        {
            objCompras.insert(
                mes,
                nReg,
                fechaEmision,
                fechaPago,
                cTipo,
                cSeire,
                cnDocumento,
                pTipo,
                pNumero,
                pDocumento,
                pRazonSocial,
                cuenta,
                descripcion,
                baseImponible,
                igv,
                noGravada,
                descuento,
                importeTotal,
                dolares,
                tipoCambio,
                percepcion,
                destino,
                descripcionDestino,
                cuentaDestino,
                pago,
                codigo,
                constanciaNumero,
                constanciaFechapago,
                constanciaMonto,
                constanciaReferencia
                );
        }
    }
}
