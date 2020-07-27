namespace Presentacion
{
    partial class FrmProgramaLibrosElectronicos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvRegistroCompras = new System.Windows.Forms.DataGridView();
            this.comprasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.comprasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCdpNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorNumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasNoGravada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPercepcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasDescripcionDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasConstanciaReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionBco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BancarizacionOperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRegistroComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sISCONTDataSet = new Presentacion.SISCONTDataSet();
            this.tabRegistros = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminarCompras = new System.Windows.Forms.Button();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvRegistroVentas = new System.Windows.Forms.DataGridView();
            this.ventasMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasNumeroRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasFechapago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ventasCdpSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCdpNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasProveedorRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasValorExportacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasBaseImponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalExonerada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotalInafecta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDolares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasIgvRetencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCuentaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoCuentaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferenciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasConstanciaFechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasDetraccionSoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventasObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.testlabel = new System.Windows.Forms.Label();
            this.btnGuardarVentas = new System.Windows.Forms.Button();
            this.btnGuardarCompras = new System.Windows.Forms.Button();
            this.tblRegistroComprasTableAdapter = new Presentacion.SISCONTDataSetTableAdapters.tblRegistroComprasTableAdapter();
            this.tblTipoComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idLibroComprasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSerieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNombreRazonSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseImponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noGravadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCambioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percepcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDestinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pgoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaNumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaFechaPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaMontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constanciaReferenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionFechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionBcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bancarizacionOperacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONTDataSet)).BeginInit();
            this.tabRegistros.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoComprobanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistroCompras
            // 
            this.dgvRegistroCompras.AutoGenerateColumns = false;
            this.dgvRegistroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comprasID,
            this.comprasMes,
            this.comprasNumeroRegistro,
            this.comprasFechaEmision,
            this.comprasFechaPago,
            this.comprasCdpTipo,
            this.comprasCdpSerie,
            this.comprasCdpNumeroDocumento,
            this.comprasProveedorTipo,
            this.comprasProveedorNumeroDocumento,
            this.comprasProveedorTipoDocumento,
            this.comprasProveedorRazonSocial,
            this.comprasCuenta,
            this.comprasDescripcion,
            this.comprasBaseImponible,
            this.comprasIgv,
            this.comprasNoGravada,
            this.comprasDescuento,
            this.comprasImporteTotal,
            this.comprasDolares,
            this.comprasTipoCambio,
            this.comprasPercepcion,
            this.comprasDestino,
            this.comprasDescripcionDestino,
            this.comprasCuentaDestino,
            this.comprasPago,
            this.comprasCodigo,
            this.comprasConstanciaNumero,
            this.comprasConstanciaFechaPago,
            this.comprasConstanciaMonto,
            this.comprasConstanciaReferencia,
            this.BancarizacionFecha,
            this.BancarizacionBco,
            this.BancarizacionOperacion,
            this.idLibroComprasDataGridViewTextBoxColumn,
            this.mesDataGridViewTextBoxColumn,
            this.nRegDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaPagoDataGridViewTextBoxColumn,
            this.cTipoDataGridViewTextBoxColumn,
            this.cSerieDataGridViewTextBoxColumn,
            this.cNDocumentoDataGridViewTextBoxColumn,
            this.pTipoDataGridViewTextBoxColumn,
            this.pNumeroDataGridViewTextBoxColumn,
            this.pDocumentoDataGridViewTextBoxColumn,
            this.pNombreRazonSocialDataGridViewTextBoxColumn,
            this.cuentaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.baseImponibleDataGridViewTextBoxColumn,
            this.iGVDataGridViewTextBoxColumn,
            this.noGravadaDataGridViewTextBoxColumn,
            this.descuentosDataGridViewTextBoxColumn,
            this.importeTotalDataGridViewTextBoxColumn,
            this.dolaresDataGridViewTextBoxColumn,
            this.tipoCambioDataGridViewTextBoxColumn,
            this.percepcionDataGridViewTextBoxColumn,
            this.destinoDataGridViewTextBoxColumn,
            this.descripcionDestinoDataGridViewTextBoxColumn,
            this.cuentaDestinoDataGridViewTextBoxColumn,
            this.pgoDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.constanciaNumeroDataGridViewTextBoxColumn,
            this.constanciaFechaPagoDataGridViewTextBoxColumn,
            this.constanciaMontoDataGridViewTextBoxColumn,
            this.constanciaReferenciaDataGridViewTextBoxColumn,
            this.bancarizacionFechaDataGridViewTextBoxColumn,
            this.bancarizacionBcoDataGridViewTextBoxColumn,
            this.bancarizacionOperacionDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn});
            this.dgvRegistroCompras.DataSource = this.tblRegistroComprasBindingSource;
            this.dgvRegistroCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroCompras.Name = "dgvRegistroCompras";
            this.dgvRegistroCompras.Size = new System.Drawing.Size(1088, 446);
            this.dgvRegistroCompras.TabIndex = 0;
            this.dgvRegistroCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContentClickEvent);
            this.dgvRegistroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellEndEdit);
            this.dgvRegistroCompras.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroCompras_CellLeave_1);
            this.dgvRegistroCompras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellValueChanged);
            this.dgvRegistroCompras.TabIndexChanged += new System.EventHandler(this.tabIndexChangedEvent);
            this.dgvRegistroCompras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRegistroCompras_KeyDown);
            // 
            // comprasID
            // 
            this.comprasID.DataPropertyName = "idLibroCompras";
            this.comprasID.HeaderText = "#";
            this.comprasID.Name = "comprasID";
            this.comprasID.ReadOnly = true;
            this.comprasID.Width = 40;
            // 
            // comprasMes
            // 
            this.comprasMes.DataPropertyName = "Mes";
            this.comprasMes.HeaderText = "Mes";
            this.comprasMes.Name = "comprasMes";
            this.comprasMes.Width = 40;
            // 
            // comprasNumeroRegistro
            // 
            this.comprasNumeroRegistro.DataPropertyName = "NReg";
            this.comprasNumeroRegistro.HeaderText = "N° Registro";
            this.comprasNumeroRegistro.Name = "comprasNumeroRegistro";
            // 
            // comprasFechaEmision
            // 
            this.comprasFechaEmision.DataPropertyName = "FechaEmision";
            this.comprasFechaEmision.HeaderText = "Fecha de Emisión";
            this.comprasFechaEmision.Name = "comprasFechaEmision";
            this.comprasFechaEmision.Width = 80;
            // 
            // comprasFechaPago
            // 
            this.comprasFechaPago.DataPropertyName = "FechaPago";
            this.comprasFechaPago.HeaderText = "Fecha de Pago";
            this.comprasFechaPago.Name = "comprasFechaPago";
            this.comprasFechaPago.Width = 80;
            // 
            // comprasCdpTipo
            // 
            this.comprasCdpTipo.DataPropertyName = "CTipo";
            this.comprasCdpTipo.HeaderText = "Comprobante Tipo";
            this.comprasCdpTipo.Name = "comprasCdpTipo";
            this.comprasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.comprasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.comprasCdpTipo.Width = 120;
            // 
            // comprasCdpSerie
            // 
            this.comprasCdpSerie.DataPropertyName = "CSerie";
            this.comprasCdpSerie.HeaderText = "Comprobante Serie";
            this.comprasCdpSerie.Name = "comprasCdpSerie";
            // 
            // comprasCdpNumeroDocumento
            // 
            this.comprasCdpNumeroDocumento.DataPropertyName = "CNDocumento";
            this.comprasCdpNumeroDocumento.HeaderText = "Comprobante Número Documento";
            this.comprasCdpNumeroDocumento.Name = "comprasCdpNumeroDocumento";
            // 
            // comprasProveedorTipo
            // 
            this.comprasProveedorTipo.DataPropertyName = "PTipo";
            this.comprasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.comprasProveedorTipo.Name = "comprasProveedorTipo";
            // 
            // comprasProveedorNumeroDocumento
            // 
            this.comprasProveedorNumeroDocumento.DataPropertyName = "PNumero";
            this.comprasProveedorNumeroDocumento.HeaderText = "Proveedor Numero Documento";
            this.comprasProveedorNumeroDocumento.Name = "comprasProveedorNumeroDocumento";
            // 
            // comprasProveedorTipoDocumento
            // 
            this.comprasProveedorTipoDocumento.DataPropertyName = "PDocumento";
            this.comprasProveedorTipoDocumento.HeaderText = "Proveedor Tipo Documento";
            this.comprasProveedorTipoDocumento.Name = "comprasProveedorTipoDocumento";
            // 
            // comprasProveedorRazonSocial
            // 
            this.comprasProveedorRazonSocial.DataPropertyName = "PNombreRazonSocial";
            this.comprasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.comprasProveedorRazonSocial.Name = "comprasProveedorRazonSocial";
            this.comprasProveedorRazonSocial.Width = 200;
            // 
            // comprasCuenta
            // 
            this.comprasCuenta.DataPropertyName = "Cuenta";
            this.comprasCuenta.HeaderText = "Cuenta";
            this.comprasCuenta.Name = "comprasCuenta";
            // 
            // comprasDescripcion
            // 
            this.comprasDescripcion.DataPropertyName = "Descripcion";
            this.comprasDescripcion.HeaderText = "Descripción";
            this.comprasDescripcion.Name = "comprasDescripcion";
            // 
            // comprasBaseImponible
            // 
            this.comprasBaseImponible.DataPropertyName = "BaseImponible";
            this.comprasBaseImponible.HeaderText = "Base Imponible";
            this.comprasBaseImponible.Name = "comprasBaseImponible";
            // 
            // comprasIgv
            // 
            this.comprasIgv.DataPropertyName = "IGV";
            this.comprasIgv.HeaderText = "IGV";
            this.comprasIgv.Name = "comprasIgv";
            // 
            // comprasNoGravada
            // 
            this.comprasNoGravada.DataPropertyName = "NoGravada";
            this.comprasNoGravada.HeaderText = "No Gravada";
            this.comprasNoGravada.Name = "comprasNoGravada";
            // 
            // comprasDescuento
            // 
            this.comprasDescuento.DataPropertyName = "Descuentos";
            this.comprasDescuento.HeaderText = "Descuento";
            this.comprasDescuento.Name = "comprasDescuento";
            // 
            // comprasImporteTotal
            // 
            this.comprasImporteTotal.DataPropertyName = "ImporteTotal";
            this.comprasImporteTotal.HeaderText = "Importe Total";
            this.comprasImporteTotal.Name = "comprasImporteTotal";
            // 
            // comprasDolares
            // 
            this.comprasDolares.DataPropertyName = "Dolares";
            this.comprasDolares.HeaderText = "Dolares";
            this.comprasDolares.Name = "comprasDolares";
            // 
            // comprasTipoCambio
            // 
            this.comprasTipoCambio.DataPropertyName = "TipoCambio";
            this.comprasTipoCambio.HeaderText = "Tipo de Cambio";
            this.comprasTipoCambio.Name = "comprasTipoCambio";
            // 
            // comprasPercepcion
            // 
            this.comprasPercepcion.DataPropertyName = "Percepcion";
            this.comprasPercepcion.HeaderText = "Percepción";
            this.comprasPercepcion.Name = "comprasPercepcion";
            // 
            // comprasDestino
            // 
            this.comprasDestino.DataPropertyName = "Destino";
            this.comprasDestino.HeaderText = "Destino";
            this.comprasDestino.Name = "comprasDestino";
            // 
            // comprasDescripcionDestino
            // 
            this.comprasDescripcionDestino.DataPropertyName = "DescripcionDestino";
            this.comprasDescripcionDestino.HeaderText = "Descripción Destino";
            this.comprasDescripcionDestino.Name = "comprasDescripcionDestino";
            // 
            // comprasCuentaDestino
            // 
            this.comprasCuentaDestino.DataPropertyName = "CuentaDestino";
            this.comprasCuentaDestino.HeaderText = "Cuenta Destino";
            this.comprasCuentaDestino.Name = "comprasCuentaDestino";
            // 
            // comprasPago
            // 
            this.comprasPago.DataPropertyName = "Pgo";
            this.comprasPago.HeaderText = "Pago";
            this.comprasPago.Name = "comprasPago";
            // 
            // comprasCodigo
            // 
            this.comprasCodigo.DataPropertyName = "Codigo";
            this.comprasCodigo.HeaderText = "Código";
            this.comprasCodigo.Name = "comprasCodigo";
            // 
            // comprasConstanciaNumero
            // 
            this.comprasConstanciaNumero.DataPropertyName = "ConstanciaNumero";
            this.comprasConstanciaNumero.HeaderText = "Constancia Número";
            this.comprasConstanciaNumero.Name = "comprasConstanciaNumero";
            // 
            // comprasConstanciaFechaPago
            // 
            this.comprasConstanciaFechaPago.DataPropertyName = "ConstanciaFechaPago";
            this.comprasConstanciaFechaPago.HeaderText = "Constancia de Fecha de Pago";
            this.comprasConstanciaFechaPago.Name = "comprasConstanciaFechaPago";
            this.comprasConstanciaFechaPago.Width = 80;
            // 
            // comprasConstanciaMonto
            // 
            this.comprasConstanciaMonto.DataPropertyName = "ConstanciaMonto";
            this.comprasConstanciaMonto.HeaderText = "Constancia Monto";
            this.comprasConstanciaMonto.Name = "comprasConstanciaMonto";
            // 
            // comprasConstanciaReferencia
            // 
            this.comprasConstanciaReferencia.DataPropertyName = "ConstanciaReferencia";
            this.comprasConstanciaReferencia.HeaderText = "Constancia Referencia";
            this.comprasConstanciaReferencia.Name = "comprasConstanciaReferencia";
            // 
            // BancarizacionFecha
            // 
            this.BancarizacionFecha.DataPropertyName = "BancarizacionFecha";
            this.BancarizacionFecha.HeaderText = "Bancarizacion Fecha";
            this.BancarizacionFecha.Name = "BancarizacionFecha";
            this.BancarizacionFecha.Width = 80;
            // 
            // BancarizacionBco
            // 
            this.BancarizacionBco.DataPropertyName = "BancarizacionBco";
            this.BancarizacionBco.HeaderText = "Bancarizacion Bco";
            this.BancarizacionBco.Name = "BancarizacionBco";
            // 
            // BancarizacionOperacion
            // 
            this.BancarizacionOperacion.DataPropertyName = "BancarizacionOperacion";
            this.BancarizacionOperacion.HeaderText = "Bancarizacion Operacion";
            this.BancarizacionOperacion.Name = "BancarizacionOperacion";
            // 
            // tblRegistroComprasBindingSource
            // 
            this.tblRegistroComprasBindingSource.DataMember = "tblRegistroCompras";
            this.tblRegistroComprasBindingSource.DataSource = this.sISCONTDataSet;
            // 
            // sISCONTDataSet
            // 
            this.sISCONTDataSet.DataSetName = "SISCONTDataSet";
            this.sISCONTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabRegistros
            // 
            this.tabRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRegistros.Controls.Add(this.tabCompras);
            this.tabRegistros.Controls.Add(this.tabVentas);
            this.tabRegistros.Location = new System.Drawing.Point(12, 120);
            this.tabRegistros.Name = "tabRegistros";
            this.tabRegistros.SelectedIndex = 0;
            this.tabRegistros.Size = new System.Drawing.Size(1108, 544);
            this.tabRegistros.TabIndex = 1;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.panel4);
            this.tabCompras.Controls.Add(this.panel3);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(1100, 518);
            this.tabCompras.TabIndex = 0;
            this.tabCompras.Text = "Compras";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgvRegistroCompras);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1088, 446);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnEliminarCompras);
            this.panel3.Location = new System.Drawing.Point(6, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 54);
            this.panel3.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(15, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Guardar Compras";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarCompras
            // 
            this.btnEliminarCompras.BackColor = System.Drawing.Color.Red;
            this.btnEliminarCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCompras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCompras.Location = new System.Drawing.Point(142, 17);
            this.btnEliminarCompras.Name = "btnEliminarCompras";
            this.btnEliminarCompras.Size = new System.Drawing.Size(128, 23);
            this.btnEliminarCompras.TabIndex = 0;
            this.btnEliminarCompras.Text = "Eliminar Compras";
            this.btnEliminarCompras.UseVisualStyleBackColor = false;
            this.btnEliminarCompras.Click += new System.EventHandler(this.btnEliminarCompras_Click);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.panel6);
            this.tabVentas.Controls.Add(this.panel5);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(1100, 518);
            this.tabVentas.TabIndex = 1;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(6, 458);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1088, 54);
            this.panel6.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(555, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "Editar Ventas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Guardar Ventas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(384, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Eliminar Compras";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvRegistroVentas);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1088, 446);
            this.panel5.TabIndex = 2;
            // 
            // dgvRegistroVentas
            // 
            this.dgvRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventasMes,
            this.ventasNumeroRegistro,
            this.ventasFechaEmision,
            this.ventasFechapago,
            this.ventasCdpTipo,
            this.ventasCdpSerie,
            this.ventasCdpNumero,
            this.ventasProveedorTipo,
            this.ventasProveedorNumero,
            this.ventasProveedorRazonSocial,
            this.ventasCuenta,
            this.ventasDescripcion,
            this.ventasValorExportacion,
            this.ventasBaseImponible,
            this.ventasImporteTotalExonerada,
            this.ventasImporteTotalInafecta,
            this.ventasIgv,
            this.ventasImporteTotal,
            this.ventasTipoCambio,
            this.ventasDolares,
            this.ventasIgvRetencion,
            this.ventasCuentaDestino,
            this.destinoCuentaDescripcion,
            this.ventasPago,
            this.ventasReferenciaFecha,
            this.ventasReferenciaTipo,
            this.ventasReferenciaSerie,
            this.ventasReferenciaNumero,
            this.ventasCodigo,
            this.ventasConstanciaNumero,
            this.ventasConstanciaFechaPago,
            this.ventasDetraccionSoles,
            this.ventasReferencia,
            this.ventasObservacion});
            this.dgvRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegistroVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvRegistroVentas.Name = "dgvRegistroVentas";
            this.dgvRegistroVentas.Size = new System.Drawing.Size(1088, 446);
            this.dgvRegistroVentas.TabIndex = 1;
            this.dgvRegistroVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistroVentas_CellEndEdit);
            // 
            // ventasMes
            // 
            this.ventasMes.HeaderText = "Mes";
            this.ventasMes.Name = "ventasMes";
            // 
            // ventasNumeroRegistro
            // 
            this.ventasNumeroRegistro.HeaderText = "N° Registro";
            this.ventasNumeroRegistro.Name = "ventasNumeroRegistro";
            // 
            // ventasFechaEmision
            // 
            this.ventasFechaEmision.HeaderText = "Fecha de Emisión";
            this.ventasFechaEmision.Name = "ventasFechaEmision";
            // 
            // ventasFechapago
            // 
            this.ventasFechapago.HeaderText = "Fecha de Pago";
            this.ventasFechapago.Name = "ventasFechapago";
            // 
            // ventasCdpTipo
            // 
            this.ventasCdpTipo.HeaderText = "Comprobante Tipo";
            this.ventasCdpTipo.Name = "ventasCdpTipo";
            this.ventasCdpTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ventasCdpTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ventasCdpSerie
            // 
            this.ventasCdpSerie.HeaderText = "Comprobante Serie";
            this.ventasCdpSerie.Name = "ventasCdpSerie";
            // 
            // ventasCdpNumero
            // 
            this.ventasCdpNumero.HeaderText = "Comprobante Número Documento";
            this.ventasCdpNumero.Name = "ventasCdpNumero";
            // 
            // ventasProveedorTipo
            // 
            this.ventasProveedorTipo.HeaderText = "Proveedor Tipo";
            this.ventasProveedorTipo.Name = "ventasProveedorTipo";
            // 
            // ventasProveedorNumero
            // 
            this.ventasProveedorNumero.HeaderText = "Proveedor Numero Documento";
            this.ventasProveedorNumero.Name = "ventasProveedorNumero";
            // 
            // ventasProveedorRazonSocial
            // 
            this.ventasProveedorRazonSocial.HeaderText = "Proveedor Razón Social";
            this.ventasProveedorRazonSocial.Name = "ventasProveedorRazonSocial";
            // 
            // ventasCuenta
            // 
            this.ventasCuenta.HeaderText = "Cuenta";
            this.ventasCuenta.Name = "ventasCuenta";
            // 
            // ventasDescripcion
            // 
            this.ventasDescripcion.HeaderText = "Descripción";
            this.ventasDescripcion.Name = "ventasDescripcion";
            // 
            // ventasValorExportacion
            // 
            this.ventasValorExportacion.HeaderText = "Valor de Exportación";
            this.ventasValorExportacion.Name = "ventasValorExportacion";
            // 
            // ventasBaseImponible
            // 
            this.ventasBaseImponible.HeaderText = "Base Imponible";
            this.ventasBaseImponible.Name = "ventasBaseImponible";
            // 
            // ventasImporteTotalExonerada
            // 
            this.ventasImporteTotalExonerada.HeaderText = "Importe Total Exonerada";
            this.ventasImporteTotalExonerada.Name = "ventasImporteTotalExonerada";
            // 
            // ventasImporteTotalInafecta
            // 
            this.ventasImporteTotalInafecta.HeaderText = "Importe Total Inafecta";
            this.ventasImporteTotalInafecta.Name = "ventasImporteTotalInafecta";
            // 
            // ventasIgv
            // 
            this.ventasIgv.HeaderText = "IGV";
            this.ventasIgv.Name = "ventasIgv";
            // 
            // ventasImporteTotal
            // 
            this.ventasImporteTotal.HeaderText = "Importe Total";
            this.ventasImporteTotal.Name = "ventasImporteTotal";
            // 
            // ventasTipoCambio
            // 
            this.ventasTipoCambio.HeaderText = "Tipo de Cambio";
            this.ventasTipoCambio.Name = "ventasTipoCambio";
            // 
            // ventasDolares
            // 
            this.ventasDolares.HeaderText = "Dólares";
            this.ventasDolares.Name = "ventasDolares";
            // 
            // ventasIgvRetencion
            // 
            this.ventasIgvRetencion.HeaderText = "IGV Retención";
            this.ventasIgvRetencion.Name = "ventasIgvRetencion";
            // 
            // ventasCuentaDestino
            // 
            this.ventasCuentaDestino.HeaderText = "Cuenta Destino";
            this.ventasCuentaDestino.Name = "ventasCuentaDestino";
            // 
            // destinoCuentaDescripcion
            // 
            this.destinoCuentaDescripcion.HeaderText = "Cuenta Destino Descripción";
            this.destinoCuentaDescripcion.Name = "destinoCuentaDescripcion";
            // 
            // ventasPago
            // 
            this.ventasPago.HeaderText = "Pago";
            this.ventasPago.Name = "ventasPago";
            // 
            // ventasReferenciaFecha
            // 
            this.ventasReferenciaFecha.HeaderText = "Referencia Fecha";
            this.ventasReferenciaFecha.Name = "ventasReferenciaFecha";
            // 
            // ventasReferenciaTipo
            // 
            this.ventasReferenciaTipo.HeaderText = "Referencia Tipo";
            this.ventasReferenciaTipo.Name = "ventasReferenciaTipo";
            // 
            // ventasReferenciaSerie
            // 
            this.ventasReferenciaSerie.HeaderText = "Referencia Serie";
            this.ventasReferenciaSerie.Name = "ventasReferenciaSerie";
            // 
            // ventasReferenciaNumero
            // 
            this.ventasReferenciaNumero.HeaderText = "Referencia Número";
            this.ventasReferenciaNumero.Name = "ventasReferenciaNumero";
            // 
            // ventasCodigo
            // 
            this.ventasCodigo.HeaderText = "Código";
            this.ventasCodigo.Name = "ventasCodigo";
            // 
            // ventasConstanciaNumero
            // 
            this.ventasConstanciaNumero.HeaderText = "Constancia Número";
            this.ventasConstanciaNumero.Name = "ventasConstanciaNumero";
            // 
            // ventasConstanciaFechaPago
            // 
            this.ventasConstanciaFechaPago.HeaderText = "Constancia Fecha Pago";
            this.ventasConstanciaFechaPago.Name = "ventasConstanciaFechaPago";
            // 
            // ventasDetraccionSoles
            // 
            this.ventasDetraccionSoles.HeaderText = "Detracción en Soles";
            this.ventasDetraccionSoles.Name = "ventasDetraccionSoles";
            // 
            // ventasReferencia
            // 
            this.ventasReferencia.HeaderText = "Referencia";
            this.ventasReferencia.Name = "ventasReferencia";
            // 
            // ventasObservacion
            // 
            this.ventasObservacion.HeaderText = "Observación";
            this.ventasObservacion.Name = "ventasObservacion";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtBuscarProveedor);
            this.panel1.Controls.Add(this.btnBuscarProveedor);
            this.panel1.Controls.Add(this.testlabel);
            this.panel1.Controls.Add(this.btnGuardarVentas);
            this.panel1.Controls.Add(this.btnGuardarCompras);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 87);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 87);
            this.panel2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.Location = new System.Drawing.Point(140, 39);
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarProveedor.TabIndex = 4;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(59, 36);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProveedor.TabIndex = 3;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // testlabel
            // 
            this.testlabel.AutoSize = true;
            this.testlabel.Location = new System.Drawing.Point(255, 42);
            this.testlabel.Name = "testlabel";
            this.testlabel.Size = new System.Drawing.Size(35, 13);
            this.testlabel.TabIndex = 2;
            this.testlabel.Text = "label1";
            // 
            // btnGuardarVentas
            // 
            this.btnGuardarVentas.Location = new System.Drawing.Point(857, 25);
            this.btnGuardarVentas.Name = "btnGuardarVentas";
            this.btnGuardarVentas.Size = new System.Drawing.Size(119, 23);
            this.btnGuardarVentas.TabIndex = 1;
            this.btnGuardarVentas.Text = "Guardar Ventas";
            this.btnGuardarVentas.UseVisualStyleBackColor = true;
            this.btnGuardarVentas.Click += new System.EventHandler(this.btnGuardarVentas_Click);
            // 
            // btnGuardarCompras
            // 
            this.btnGuardarCompras.Location = new System.Drawing.Point(721, 25);
            this.btnGuardarCompras.Name = "btnGuardarCompras";
            this.btnGuardarCompras.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarCompras.TabIndex = 0;
            this.btnGuardarCompras.Text = "Guardar Compras";
            this.btnGuardarCompras.UseVisualStyleBackColor = true;
            this.btnGuardarCompras.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tblRegistroComprasTableAdapter
            // 
            this.tblRegistroComprasTableAdapter.ClearBeforeFill = true;
            // 
            // idLibroComprasDataGridViewTextBoxColumn
            // 
            this.idLibroComprasDataGridViewTextBoxColumn.DataPropertyName = "idLibroCompras";
            this.idLibroComprasDataGridViewTextBoxColumn.HeaderText = "idLibroCompras";
            this.idLibroComprasDataGridViewTextBoxColumn.Name = "idLibroComprasDataGridViewTextBoxColumn";
            this.idLibroComprasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesDataGridViewTextBoxColumn
            // 
            this.mesDataGridViewTextBoxColumn.DataPropertyName = "Mes";
            this.mesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.mesDataGridViewTextBoxColumn.Name = "mesDataGridViewTextBoxColumn";
            // 
            // nRegDataGridViewTextBoxColumn
            // 
            this.nRegDataGridViewTextBoxColumn.DataPropertyName = "NReg";
            this.nRegDataGridViewTextBoxColumn.HeaderText = "NReg";
            this.nRegDataGridViewTextBoxColumn.Name = "nRegDataGridViewTextBoxColumn";
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            // 
            // fechaPagoDataGridViewTextBoxColumn
            // 
            this.fechaPagoDataGridViewTextBoxColumn.DataPropertyName = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.HeaderText = "FechaPago";
            this.fechaPagoDataGridViewTextBoxColumn.Name = "fechaPagoDataGridViewTextBoxColumn";
            // 
            // cTipoDataGridViewTextBoxColumn
            // 
            this.cTipoDataGridViewTextBoxColumn.DataPropertyName = "CTipo";
            this.cTipoDataGridViewTextBoxColumn.HeaderText = "CTipo";
            this.cTipoDataGridViewTextBoxColumn.Name = "cTipoDataGridViewTextBoxColumn";
            // 
            // cSerieDataGridViewTextBoxColumn
            // 
            this.cSerieDataGridViewTextBoxColumn.DataPropertyName = "CSerie";
            this.cSerieDataGridViewTextBoxColumn.HeaderText = "CSerie";
            this.cSerieDataGridViewTextBoxColumn.Name = "cSerieDataGridViewTextBoxColumn";
            // 
            // cNDocumentoDataGridViewTextBoxColumn
            // 
            this.cNDocumentoDataGridViewTextBoxColumn.DataPropertyName = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn.HeaderText = "CNDocumento";
            this.cNDocumentoDataGridViewTextBoxColumn.Name = "cNDocumentoDataGridViewTextBoxColumn";
            // 
            // pTipoDataGridViewTextBoxColumn
            // 
            this.pTipoDataGridViewTextBoxColumn.DataPropertyName = "PTipo";
            this.pTipoDataGridViewTextBoxColumn.HeaderText = "PTipo";
            this.pTipoDataGridViewTextBoxColumn.Name = "pTipoDataGridViewTextBoxColumn";
            // 
            // pNumeroDataGridViewTextBoxColumn
            // 
            this.pNumeroDataGridViewTextBoxColumn.DataPropertyName = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn.HeaderText = "PNumero";
            this.pNumeroDataGridViewTextBoxColumn.Name = "pNumeroDataGridViewTextBoxColumn";
            // 
            // pDocumentoDataGridViewTextBoxColumn
            // 
            this.pDocumentoDataGridViewTextBoxColumn.DataPropertyName = "PDocumento";
            this.pDocumentoDataGridViewTextBoxColumn.HeaderText = "PDocumento";
            this.pDocumentoDataGridViewTextBoxColumn.Name = "pDocumentoDataGridViewTextBoxColumn";
            // 
            // pNombreRazonSocialDataGridViewTextBoxColumn
            // 
            this.pNombreRazonSocialDataGridViewTextBoxColumn.DataPropertyName = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn.HeaderText = "PNombreRazonSocial";
            this.pNombreRazonSocialDataGridViewTextBoxColumn.Name = "pNombreRazonSocialDataGridViewTextBoxColumn";
            // 
            // cuentaDataGridViewTextBoxColumn
            // 
            this.cuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.Name = "cuentaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // baseImponibleDataGridViewTextBoxColumn
            // 
            this.baseImponibleDataGridViewTextBoxColumn.DataPropertyName = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn.HeaderText = "BaseImponible";
            this.baseImponibleDataGridViewTextBoxColumn.Name = "baseImponibleDataGridViewTextBoxColumn";
            // 
            // iGVDataGridViewTextBoxColumn
            // 
            this.iGVDataGridViewTextBoxColumn.DataPropertyName = "IGV";
            this.iGVDataGridViewTextBoxColumn.HeaderText = "IGV";
            this.iGVDataGridViewTextBoxColumn.Name = "iGVDataGridViewTextBoxColumn";
            // 
            // noGravadaDataGridViewTextBoxColumn
            // 
            this.noGravadaDataGridViewTextBoxColumn.DataPropertyName = "NoGravada";
            this.noGravadaDataGridViewTextBoxColumn.HeaderText = "NoGravada";
            this.noGravadaDataGridViewTextBoxColumn.Name = "noGravadaDataGridViewTextBoxColumn";
            // 
            // descuentosDataGridViewTextBoxColumn
            // 
            this.descuentosDataGridViewTextBoxColumn.DataPropertyName = "Descuentos";
            this.descuentosDataGridViewTextBoxColumn.HeaderText = "Descuentos";
            this.descuentosDataGridViewTextBoxColumn.Name = "descuentosDataGridViewTextBoxColumn";
            // 
            // importeTotalDataGridViewTextBoxColumn
            // 
            this.importeTotalDataGridViewTextBoxColumn.DataPropertyName = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.HeaderText = "ImporteTotal";
            this.importeTotalDataGridViewTextBoxColumn.Name = "importeTotalDataGridViewTextBoxColumn";
            // 
            // dolaresDataGridViewTextBoxColumn
            // 
            this.dolaresDataGridViewTextBoxColumn.DataPropertyName = "Dolares";
            this.dolaresDataGridViewTextBoxColumn.HeaderText = "Dolares";
            this.dolaresDataGridViewTextBoxColumn.Name = "dolaresDataGridViewTextBoxColumn";
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            this.tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.HeaderText = "TipoCambio";
            this.tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            // 
            // percepcionDataGridViewTextBoxColumn
            // 
            this.percepcionDataGridViewTextBoxColumn.DataPropertyName = "Percepcion";
            this.percepcionDataGridViewTextBoxColumn.HeaderText = "Percepcion";
            this.percepcionDataGridViewTextBoxColumn.Name = "percepcionDataGridViewTextBoxColumn";
            // 
            // destinoDataGridViewTextBoxColumn
            // 
            this.destinoDataGridViewTextBoxColumn.DataPropertyName = "Destino";
            this.destinoDataGridViewTextBoxColumn.HeaderText = "Destino";
            this.destinoDataGridViewTextBoxColumn.Name = "destinoDataGridViewTextBoxColumn";
            // 
            // descripcionDestinoDataGridViewTextBoxColumn
            // 
            this.descripcionDestinoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionDestino";
            this.descripcionDestinoDataGridViewTextBoxColumn.HeaderText = "DescripcionDestino";
            this.descripcionDestinoDataGridViewTextBoxColumn.Name = "descripcionDestinoDataGridViewTextBoxColumn";
            // 
            // cuentaDestinoDataGridViewTextBoxColumn
            // 
            this.cuentaDestinoDataGridViewTextBoxColumn.DataPropertyName = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn.HeaderText = "CuentaDestino";
            this.cuentaDestinoDataGridViewTextBoxColumn.Name = "cuentaDestinoDataGridViewTextBoxColumn";
            // 
            // pgoDataGridViewTextBoxColumn
            // 
            this.pgoDataGridViewTextBoxColumn.DataPropertyName = "Pgo";
            this.pgoDataGridViewTextBoxColumn.HeaderText = "Pgo";
            this.pgoDataGridViewTextBoxColumn.Name = "pgoDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // constanciaNumeroDataGridViewTextBoxColumn
            // 
            this.constanciaNumeroDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn.HeaderText = "ConstanciaNumero";
            this.constanciaNumeroDataGridViewTextBoxColumn.Name = "constanciaNumeroDataGridViewTextBoxColumn";
            // 
            // constanciaFechaPagoDataGridViewTextBoxColumn
            // 
            this.constanciaFechaPagoDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn.HeaderText = "ConstanciaFechaPago";
            this.constanciaFechaPagoDataGridViewTextBoxColumn.Name = "constanciaFechaPagoDataGridViewTextBoxColumn";
            // 
            // constanciaMontoDataGridViewTextBoxColumn
            // 
            this.constanciaMontoDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaMonto";
            this.constanciaMontoDataGridViewTextBoxColumn.HeaderText = "ConstanciaMonto";
            this.constanciaMontoDataGridViewTextBoxColumn.Name = "constanciaMontoDataGridViewTextBoxColumn";
            // 
            // constanciaReferenciaDataGridViewTextBoxColumn
            // 
            this.constanciaReferenciaDataGridViewTextBoxColumn.DataPropertyName = "ConstanciaReferencia";
            this.constanciaReferenciaDataGridViewTextBoxColumn.HeaderText = "ConstanciaReferencia";
            this.constanciaReferenciaDataGridViewTextBoxColumn.Name = "constanciaReferenciaDataGridViewTextBoxColumn";
            // 
            // bancarizacionFechaDataGridViewTextBoxColumn
            // 
            this.bancarizacionFechaDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionFecha";
            this.bancarizacionFechaDataGridViewTextBoxColumn.HeaderText = "BancarizacionFecha";
            this.bancarizacionFechaDataGridViewTextBoxColumn.Name = "bancarizacionFechaDataGridViewTextBoxColumn";
            // 
            // bancarizacionBcoDataGridViewTextBoxColumn
            // 
            this.bancarizacionBcoDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionBco";
            this.bancarizacionBcoDataGridViewTextBoxColumn.HeaderText = "BancarizacionBco";
            this.bancarizacionBcoDataGridViewTextBoxColumn.Name = "bancarizacionBcoDataGridViewTextBoxColumn";
            // 
            // bancarizacionOperacionDataGridViewTextBoxColumn
            // 
            this.bancarizacionOperacionDataGridViewTextBoxColumn.DataPropertyName = "BancarizacionOperacion";
            this.bancarizacionOperacionDataGridViewTextBoxColumn.HeaderText = "BancarizacionOperacion";
            this.bancarizacionOperacionDataGridViewTextBoxColumn.Name = "bancarizacionOperacionDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "FechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            // 
            // FrmProgramaLibrosElectronicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 676);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabRegistros);
            this.Name = "FrmProgramaLibrosElectronicos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programa de Libros Electrónicos";
            this.Load += new System.EventHandler(this.frmRegistroCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistroComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sISCONTDataSet)).EndInit();
            this.tabRegistros.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTipoComprobanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistroCompras;
        private System.Windows.Forms.TabControl tabRegistros;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarCompras;
        private System.Windows.Forms.DataGridView dgvRegistroVentas;
        private System.Windows.Forms.Button btnGuardarVentas;
        private System.Windows.Forms.Label testlabel;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasFechapago;
        private System.Windows.Forms.DataGridViewComboBoxColumn ventasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCdpNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasValorExportacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalExonerada;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotalInafecta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasIgvRetencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoCuentaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferenciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasDetraccionSoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventasObservacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEliminarCompras;
        private System.Windows.Forms.Panel panel4;
        private SISCONTDataSet sISCONTDataSet;
        private System.Windows.Forms.BindingSource tblRegistroComprasBindingSource;
        private SISCONTDataSetTableAdapters.tblRegistroComprasTableAdapter tblRegistroComprasTableAdapter;
       // private SISCONTDataSet1 sISCONTDataSet1;
        private System.Windows.Forms.BindingSource tblTipoComprobanteBindingSource;
        //private SISCONTDataSet1TableAdapters.tblTipoComprobanteTableAdapter tblTipoComprobanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNumeroRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasFechaPago;
        private System.Windows.Forms.DataGridViewComboBoxColumn comprasCdpTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCdpNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorNumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasProveedorRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasBaseImponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasIgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasNoGravada;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPercepcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasDescripcionDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCuentaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaFechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprasConstanciaReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionBco;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancarizacionOperacion;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibroComprasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSerieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNombreRazonSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseImponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noGravadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolaresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percepcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDestinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pgoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaNumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaFechaPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaMontoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constanciaReferenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionFechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionBcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bancarizacionOperacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
    }
}

