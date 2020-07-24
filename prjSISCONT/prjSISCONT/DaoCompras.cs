using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoCompras
    {
        private Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();


        public void insert(
            int mes, string nReg, string fechaEmision, string fechaPago, string cTipo, string cSeire, string cnDocumento,
            string pTipo, string pNumero, string pDocumento, string pRazonSocial, string cuenta, string descripcion, double baseImponible,
            double igv, double noGravada, double descuento, double importeTotal, double dolares, double tipoCambio, double percepcion, string destino,
            string descripcionDestino, string cuentaDestino, string pago, string codigo, string constanciaNumero, string constanciaFechapago,
            double constanciaMonto, string constanciaReferencia
            )
        {
            comando.Connection = conexion.openConnection();
            comando.CommandText = "sp_insert_registro_compras";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Mes", mes);
            comando.Parameters.AddWithValue("@NReg", nReg);
            comando.Parameters.AddWithValue("@FechaEmision", fechaEmision);
            comando.Parameters.AddWithValue("@FechaPago", fechaPago);
            comando.Parameters.AddWithValue("@CTipo",cTipo );
            comando.Parameters.AddWithValue("@CSerie", cSeire);
            comando.Parameters.AddWithValue("@CNDocumento", cnDocumento);
            comando.Parameters.AddWithValue("@PTipo", pTipo);
            comando.Parameters.AddWithValue("@PNumero", pNumero);
            comando.Parameters.AddWithValue("@PDocumento", pDocumento);
            comando.Parameters.AddWithValue("@PNombreRazonSocial", pRazonSocial);
            comando.Parameters.AddWithValue("@Cuenta", cuenta);
            comando.Parameters.AddWithValue("@Descripcion", descripcion);
            comando.Parameters.AddWithValue("@BaseImponible", baseImponible);
            comando.Parameters.AddWithValue("@IGV", igv);
            comando.Parameters.AddWithValue("@NoGravada", noGravada);
            comando.Parameters.AddWithValue("@Descuentos", descuento);
            comando.Parameters.AddWithValue("@ImporteTotal", importeTotal);
            comando.Parameters.AddWithValue("@Dolares", dolares);
            comando.Parameters.AddWithValue("@TipoCambio", tipoCambio);
            comando.Parameters.AddWithValue("@Percepcion", percepcion);
            comando.Parameters.AddWithValue("@Destino", destino);
            comando.Parameters.AddWithValue("@DescripcionDestino", descripcionDestino);
            comando.Parameters.AddWithValue("@CuentaDestino", cuentaDestino);
            comando.Parameters.AddWithValue("@Pgo", pago);
            comando.Parameters.AddWithValue("@Codigo", codigo);
            comando.Parameters.AddWithValue("@ConstanciaNumero", constanciaNumero);
            comando.Parameters.AddWithValue("@ConstanciaFechaPago", constanciaFechapago);
            comando.Parameters.AddWithValue("@ConstanciaMonto", constanciaMonto);
            comando.Parameters.AddWithValue("@ConstanciaReferencia", constanciaReferencia);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.closeConnection();
        }

    }
}