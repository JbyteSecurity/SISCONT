using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Presentacion
{
    public partial class FrmProgramaLibrosElectronicos : Form
    {
        private PlanContable planContable = new PlanContable();
        private Proveedor proveedor = new Proveedor();
        private ComprobantePago comprobantePago = new ComprobantePago();

        private Compras compras = new Compras();
        private Ventas ventas = new Ventas();
        public FrmProgramaLibrosElectronicos()
        {
            InitializeComponent();
        }

        private void frmRegistroCompra_Load(object sender, EventArgs e)
        {
            llenarComboTipoComprobante();
        }

        private void cellContentClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            //mostrarProveedor();

        }

        private void tabIndexChangedEvent(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarCompras();
        }

        //GUARDAR Compras 
        private void guardarCompras()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroCompras.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["comprasMes"].Value)))
                    {
                        compras.save(
                            Convert.ToInt32(row.Cells["comprasMes"].Value),
                            Convert.ToString(row.Cells["comprasNumeroRegistro"].Value),
                            Convert.ToString(row.Cells["comprasFechaEmision"].Value),
                            Convert.ToString(row.Cells["comprasFechaPago"].Value),
                            Convert.ToString(row.Cells["comprasCdpTipo"].Value),
                            Convert.ToString(row.Cells["comprasCdpSerie"].Value),
                            Convert.ToString(row.Cells["comprasCdpNumeroDocumento"].Value),
                            Convert.ToString(row.Cells["comprasProveedorTipo"].Value),
                            Convert.ToString(row.Cells["comprasProveedorNumeroDocumento"].Value),
                            Convert.ToString(row.Cells["comprasProveedorTipoDocumento"].Value),
                            Convert.ToString(row.Cells["comprasProveedorRazonSocial"].Value),
                            Convert.ToString(row.Cells["comprasCuenta"].Value),
                            Convert.ToString(row.Cells["comprasDescripcion"].Value),
                            Convert.ToDouble(row.Cells["comprasBaseImponible"].Value),
                            Convert.ToDouble(row.Cells["comprasIgv"].Value),
                            Convert.ToDouble(row.Cells["comprasNoGravada"].Value),
                            Convert.ToDouble(row.Cells["comprasDescuento"].Value),
                            Convert.ToDouble(row.Cells["comprasImporteTotal"].Value),
                            Convert.ToDouble(row.Cells["comprasDolares"].Value),
                            Convert.ToDouble(row.Cells["comprasTipoCambio"].Value),
                            Convert.ToDouble(row.Cells["comprasPercepcion"].Value),
                            Convert.ToString(row.Cells["comprasDestino"].Value),
                            Convert.ToString(row.Cells["comprasDescripcion"].Value),
                            Convert.ToString(row.Cells["comprasCuentaDestino"].Value),
                            Convert.ToString(row.Cells["comprasPago"].Value),
                            Convert.ToString(row.Cells["comprasCodigo"].Value),
                            Convert.ToString(row.Cells["comprasConstanciaNumero"].Value),
                            Convert.ToString(row.Cells["comprasConstanciaFechaPago"].Value),
                            Convert.ToDouble(row.Cells["comprasConstanciaMonto"].Value),
                            Convert.ToString(row.Cells["comprasConstanciaReferencia"].Value)
                        );
                    }
                }
                MessageBox.Show("se inserto correctamente los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
        }

        //GUARDAR Ventas 
        private void guardarVentas()
        {
            try
            {
                foreach (DataGridViewRow row in dgvRegistroVentas.Rows)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells["ventasMes"].Value)))
                    {
                        ventas.save(
                            Convert.ToInt32(row.Cells["ventasMes"].Value),
                            Convert.ToString(row.Cells["ventasNumeroRegistro"].Value),
                            Convert.ToString(row.Cells["ventasFechaEmision"].Value),
                            Convert.ToString(row.Cells["ventasFechaPago"].Value),
                            Convert.ToString(row.Cells["ventasCdpTipo"].Value),
                            Convert.ToString(row.Cells["ventasCdpSerie"].Value),
                            Convert.ToString(row.Cells["ventasCdpNumero"].Value),
                            Convert.ToString(row.Cells["ventasProveedorTipo"].Value),
                            Convert.ToString(row.Cells["ventasProveedorNumero"].Value),
                            Convert.ToString(row.Cells["ventasProveedorRazonSocial"].Value),

                            Convert.ToString(row.Cells["ventasCuenta"].Value),
                            Convert.ToString(row.Cells["ventasDescripcion"].Value),
                            Convert.ToDouble(row.Cells["ventasValorExportacion"].Value),
                            Convert.ToDouble(row.Cells["ventasBaseImponible"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotalExonerada"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotalInafecta"].Value),
                            Convert.ToDouble(row.Cells["ventasIgv"].Value),
                            Convert.ToDouble(row.Cells["ventasImporteTotal"].Value),
                            Convert.ToDouble(row.Cells["ventasTipoCambio"].Value),
                            Convert.ToDouble(row.Cells["ventasDolares"].Value),

                            Convert.ToDouble(row.Cells["ventasIgvRetencion"].Value),
                            Convert.ToString(row.Cells["ventasCuentaDestino"].Value),
                            Convert.ToString(row.Cells["ventasPago"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaFecha"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaTipo"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaSerie"].Value),
                            Convert.ToString(row.Cells["ventasReferenciaNumero"].Value),
                            Convert.ToString(row.Cells["ventasCodigo"].Value),
                            Convert.ToString(row.Cells["ventasConstanciaNumero"].Value),
                            Convert.ToString(row.Cells["ventasConstanciaFechaPago"].Value),
                            
                            Convert.ToDouble(row.Cells["ventasDetraccionSoles"].Value),
                            Convert.ToString(row.Cells["ventasReferencia"].Value),
                            Convert.ToString(row.Cells["ventasObservacion"].Value)
                        );
                        MessageBox.Show("Ventas registradas correctamente", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else
                    {
                        MessageBox.Show("No se han encontrado ventas a guardar", "Ventas .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo insertar los datos por: " + ex);
            }
        }

        private void llenarComboTipoComprobante()
        {
            //Compras
            comprasCdpTipo.DisplayMember = "Detail";
            comprasCdpTipo.ValueMember = "numero";
            comprasCdpTipo.DataSource = comprobantePago.getAllCpdTypes();

            //Ventas
            ventasCdpTipo.DisplayMember = "Detail";
            ventasCdpTipo.ValueMember = "numero";
            ventasCdpTipo.DataSource = comprobantePago.getAllCpdTypes();
        }


        private void btnGuardarVentas_Click(object sender, EventArgs e)
        {
            guardarVentas();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //
        }

        private void dgvRegistroCompras_KeyDown(object sender, KeyEventArgs e)
        {
            
         
        }

        private void dgvRegistroCompras_CellLeave_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvRegistroCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            switch (e.ColumnIndex)
            {
                case 8:
                    string ruc;
                    string razonSocial;
                    ruc = dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    razonSocial = proveedor.getSupplierName(ruc);
                    if (razonSocial == null)
                        MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = razonSocial;
                    break;
                case 11:
                case 21:
                    string codigo;
                    string cuenta;
                    codigo = dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    cuenta = planContable.getAcount(codigo);
                    if (cuenta == null)
                        MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroCompras.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                    break;
            }
            
        }

        private void dgvRegistroVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 8:
                    string ruc;
                    string razonSocial;
                    ruc = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    razonSocial = proveedor.getSupplierName(ruc);
                    if (razonSocial == null)
                        MessageBox.Show("No se encontro al proveedor con ruc: " + ruc, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = razonSocial;
                    break;
                case 10:
                case 21:
                    string codigo;
                    string cuenta;
                    codigo = dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    cuenta = planContable.getAcount(codigo);
                    if (cuenta == null)
                        MessageBox.Show("No se encontro una cuenta con código: " + codigo, "Compras .::. Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        dgvRegistroVentas.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = cuenta;
                    break;
            }
        }

        private void menuItemProveedores_Click(object sender, EventArgs e)
        {
           
        }
    }
}
