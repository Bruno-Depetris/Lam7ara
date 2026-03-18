namespace Lam7ara.Forms.inicio {
    partial class FormInicio {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null ))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCardVentasTotal = new System.Windows.Forms.Panel();
            this.lblCardVTitulo = new System.Windows.Forms.Label();
            this.lblCardVValor = new System.Windows.Forms.Label();
            this.lblCardVSub = new System.Windows.Forms.Label();
            this.panelCardCantVentas = new System.Windows.Forms.Panel();
            this.lblCardCVTitulo = new System.Windows.Forms.Label();
            this.lblCardCVValor = new System.Windows.Forms.Label();
            this.lblCardCVSub = new System.Windows.Forms.Label();
            this.panelCardClientes = new System.Windows.Forms.Panel();
            this.lblCardCLTitulo = new System.Windows.Forms.Label();
            this.lblCardCLValor = new System.Windows.Forms.Label();
            this.lblCardCLSub = new System.Windows.Forms.Label();
            this.panelCardCaja = new System.Windows.Forms.Panel();
            this.lblCardCJTitulo = new System.Windows.Forms.Label();
            this.lblCardCJValor = new System.Windows.Forms.Label();
            this.lblCardCJSub = new System.Windows.Forms.Label();
            this.panelSep1 = new System.Windows.Forms.Panel();
            this.panelMedio = new System.Windows.Forms.Panel();
            this.panelCotizaciones = new System.Windows.Forms.Panel();
            this.lblSecCotizaciones = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblEstadoCot = new System.Windows.Forms.Label();
            this.panelDolares = new System.Windows.Forms.Panel();
            this.panelDolarOficial = new System.Windows.Forms.Panel();
            this.lblDOTitulo = new System.Windows.Forms.Label();
            this.lblDOVenta = new System.Windows.Forms.Label();
            this.lblDOCompra = new System.Windows.Forms.Label();
            this.panelDolarBlue = new System.Windows.Forms.Panel();
            this.lblDBTitulo = new System.Windows.Forms.Label();
            this.lblDBVenta = new System.Windows.Forms.Label();
            this.lblDBCompra = new System.Windows.Forms.Label();
            this.panelDolarTarjeta = new System.Windows.Forms.Panel();
            this.lblDTTitulo = new System.Windows.Forms.Label();
            this.lblDTVenta = new System.Windows.Forms.Label();
            this.lblDTCompra = new System.Windows.Forms.Label();
            this.panelVSepMedio = new System.Windows.Forms.Panel();
            this.panelStockBajo = new System.Windows.Forms.Panel();
            this.lblSecStockBajo = new System.Windows.Forms.Label();
            this.dgvStockBajo = new System.Windows.Forms.DataGridView();
            this.colSBNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSBCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSBStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSep2 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblSecUltVentas = new System.Windows.Forms.Label();
            this.dgvUltimasVentas = new System.Windows.Forms.DataGridView();
            this.colUVFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUVCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUVMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUVEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop.SuspendLayout();
            this.panelCardVentasTotal.SuspendLayout();
            this.panelCardCantVentas.SuspendLayout();
            this.panelCardClientes.SuspendLayout();
            this.panelCardCaja.SuspendLayout();
            this.panelMedio.SuspendLayout();
            this.panelCotizaciones.SuspendLayout();
            this.panelDolares.SuspendLayout();
            this.panelDolarOficial.SuspendLayout();
            this.panelDolarBlue.SuspendLayout();
            this.panelDolarTarjeta.SuspendLayout();
            this.panelStockBajo.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvStockBajo ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvUltimasVentas ) ).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelTop.Controls.Add(this.panelCardCaja);
            this.panelTop.Controls.Add(this.panelCardClientes);
            this.panelTop.Controls.Add(this.panelCardCantVentas);
            this.panelTop.Controls.Add(this.panelCardVentasTotal);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1090, 134);
            this.panelTop.TabIndex = 0;
            // 
            // panelCardVentasTotal
            // 
            this.panelCardVentasTotal.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelCardVentasTotal.Controls.Add(this.lblCardVSub);
            this.panelCardVentasTotal.Controls.Add(this.lblCardVValor);
            this.panelCardVentasTotal.Controls.Add(this.lblCardVTitulo);
            this.panelCardVentasTotal.Location = new System.Drawing.Point(0, 8);
            this.panelCardVentasTotal.Name = "panelCardVentasTotal";
            this.panelCardVentasTotal.Size = new System.Drawing.Size(262, 118);
            this.panelCardVentasTotal.TabIndex = 0;
            // 
            // lblCardVTitulo
            // 
            this.lblCardVTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardVTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardVTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardVTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblCardVTitulo.Name = "lblCardVTitulo";
            this.lblCardVTitulo.Size = new System.Drawing.Size(234, 16);
            this.lblCardVTitulo.TabIndex = 0;
            this.lblCardVTitulo.Text = "VENTAS HOY";
            // 
            // lblCardVValor
            // 
            this.lblCardVValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardVValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardVValor.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.lblCardVValor.Location = new System.Drawing.Point(12, 32);
            this.lblCardVValor.Name = "lblCardVValor";
            this.lblCardVValor.Size = new System.Drawing.Size(238, 52);
            this.lblCardVValor.TabIndex = 1;
            this.lblCardVValor.Text = "$0,00";
            this.lblCardVValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardVSub
            // 
            this.lblCardVSub.BackColor = System.Drawing.Color.Transparent;
            this.lblCardVSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardVSub.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardVSub.Location = new System.Drawing.Point(14, 90);
            this.lblCardVSub.Name = "lblCardVSub";
            this.lblCardVSub.Size = new System.Drawing.Size(234, 18);
            this.lblCardVSub.TabIndex = 2;
            this.lblCardVSub.Text = "Total acumulado del dia";
            // 
            // panelCardCantVentas
            // 
            this.panelCardCantVentas.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelCardCantVentas.Controls.Add(this.lblCardCVSub);
            this.panelCardCantVentas.Controls.Add(this.lblCardCVValor);
            this.panelCardCantVentas.Controls.Add(this.lblCardCVTitulo);
            this.panelCardCantVentas.Location = new System.Drawing.Point(274, 8);
            this.panelCardCantVentas.Name = "panelCardCantVentas";
            this.panelCardCantVentas.Size = new System.Drawing.Size(262, 118);
            this.panelCardCantVentas.TabIndex = 1;
            // 
            // lblCardCVTitulo
            // 
            this.lblCardCVTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCVTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCVTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCVTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblCardCVTitulo.Name = "lblCardCVTitulo";
            this.lblCardCVTitulo.Size = new System.Drawing.Size(234, 16);
            this.lblCardCVTitulo.TabIndex = 0;
            this.lblCardCVTitulo.Text = "CANTIDAD DE VENTAS";
            // 
            // lblCardCVValor
            // 
            this.lblCardCVValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCVValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCVValor.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 74 ) ) ) ), ( (int)( ( (byte)( 222 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ));
            this.lblCardCVValor.Location = new System.Drawing.Point(12, 32);
            this.lblCardCVValor.Name = "lblCardCVValor";
            this.lblCardCVValor.Size = new System.Drawing.Size(238, 52);
            this.lblCardCVValor.TabIndex = 1;
            this.lblCardCVValor.Text = "0";
            this.lblCardCVValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardCVSub
            // 
            this.lblCardCVSub.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCVSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCVSub.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCVSub.Location = new System.Drawing.Point(14, 90);
            this.lblCardCVSub.Name = "lblCardCVSub";
            this.lblCardCVSub.Size = new System.Drawing.Size(234, 18);
            this.lblCardCVSub.TabIndex = 2;
            this.lblCardCVSub.Text = "Ventas completadas hoy";
            // 
            // panelCardClientes
            // 
            this.panelCardClientes.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelCardClientes.Controls.Add(this.lblCardCLSub);
            this.panelCardClientes.Controls.Add(this.lblCardCLValor);
            this.panelCardClientes.Controls.Add(this.lblCardCLTitulo);
            this.panelCardClientes.Location = new System.Drawing.Point(548, 8);
            this.panelCardClientes.Name = "panelCardClientes";
            this.panelCardClientes.Size = new System.Drawing.Size(262, 118);
            this.panelCardClientes.TabIndex = 2;
            // 
            // lblCardCLTitulo
            // 
            this.lblCardCLTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCLTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCLTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCLTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblCardCLTitulo.Name = "lblCardCLTitulo";
            this.lblCardCLTitulo.Size = new System.Drawing.Size(234, 16);
            this.lblCardCLTitulo.TabIndex = 0;
            this.lblCardCLTitulo.Text = "CLIENTES REGISTRADOS";
            // 
            // lblCardCLValor
            // 
            this.lblCardCLValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCLValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCLValor.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 146 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.lblCardCLValor.Location = new System.Drawing.Point(12, 32);
            this.lblCardCLValor.Name = "lblCardCLValor";
            this.lblCardCLValor.Size = new System.Drawing.Size(238, 52);
            this.lblCardCLValor.TabIndex = 1;
            this.lblCardCLValor.Text = "0";
            this.lblCardCLValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardCLSub
            // 
            this.lblCardCLSub.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCLSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCLSub.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCLSub.Location = new System.Drawing.Point(14, 90);
            this.lblCardCLSub.Name = "lblCardCLSub";
            this.lblCardCLSub.Size = new System.Drawing.Size(234, 18);
            this.lblCardCLSub.TabIndex = 2;
            this.lblCardCLSub.Text = "Total en base de datos";
            // 
            // panelCardCaja
            // 
            this.panelCardCaja.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelCardCaja.Controls.Add(this.lblCardCJSub);
            this.panelCardCaja.Controls.Add(this.lblCardCJValor);
            this.panelCardCaja.Controls.Add(this.lblCardCJTitulo);
            this.panelCardCaja.Location = new System.Drawing.Point(822, 8);
            this.panelCardCaja.Name = "panelCardCaja";
            this.panelCardCaja.Size = new System.Drawing.Size(262, 118);
            this.panelCardCaja.TabIndex = 3;
            // 
            // lblCardCJTitulo
            // 
            this.lblCardCJTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCJTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCJTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCJTitulo.Location = new System.Drawing.Point(14, 12);
            this.lblCardCJTitulo.Name = "lblCardCJTitulo";
            this.lblCardCJTitulo.Size = new System.Drawing.Size(234, 16);
            this.lblCardCJTitulo.TabIndex = 0;
            this.lblCardCJTitulo.Text = "ESTADO DE CAJA";
            // 
            // lblCardCJValor
            // 
            this.lblCardCJValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCJValor.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCJValor.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCJValor.Location = new System.Drawing.Point(12, 32);
            this.lblCardCJValor.Name = "lblCardCJValor";
            this.lblCardCJValor.Size = new System.Drawing.Size(238, 52);
            this.lblCardCJValor.TabIndex = 1;
            this.lblCardCJValor.Text = "Cerrada";
            this.lblCardCJValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardCJSub
            // 
            this.lblCardCJSub.BackColor = System.Drawing.Color.Transparent;
            this.lblCardCJSub.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCardCJSub.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblCardCJSub.Location = new System.Drawing.Point(14, 90);
            this.lblCardCJSub.Name = "lblCardCJSub";
            this.lblCardCJSub.Size = new System.Drawing.Size(234, 18);
            this.lblCardCJSub.TabIndex = 2;
            this.lblCardCJSub.Text = "Saldo: $0,00";
            // 
            // panelSep1
            // 
            this.panelSep1.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelSep1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSep1.Name = "panelSep1";
            this.panelSep1.Size = new System.Drawing.Size(1090, 1);
            this.panelSep1.TabIndex = 1;
            // 
            // panelMedio
            // 
            this.panelMedio.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelMedio.Controls.Add(this.panelStockBajo);
            this.panelMedio.Controls.Add(this.panelVSepMedio);
            this.panelMedio.Controls.Add(this.panelCotizaciones);
            this.panelMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedio.Name = "panelMedio";
            this.panelMedio.Size = new System.Drawing.Size(1090, 260);
            this.panelMedio.TabIndex = 2;
            // 
            // panelCotizaciones
            // 
            this.panelCotizaciones.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelCotizaciones.Controls.Add(this.panelDolares);
            this.panelCotizaciones.Controls.Add(this.lblEstadoCot);
            this.panelCotizaciones.Controls.Add(this.btnActualizar);
            this.panelCotizaciones.Controls.Add(this.lblSecCotizaciones);
            this.panelCotizaciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCotizaciones.Name = "panelCotizaciones";
            this.panelCotizaciones.Size = new System.Drawing.Size(550, 260);
            this.panelCotizaciones.TabIndex = 0;
            // 
            // lblSecCotizaciones
            // 
            this.lblSecCotizaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblSecCotizaciones.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecCotizaciones.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecCotizaciones.Location = new System.Drawing.Point(0, 0);
            this.lblSecCotizaciones.Name = "lblSecCotizaciones";
            this.lblSecCotizaciones.Size = new System.Drawing.Size(300, 22);
            this.lblSecCotizaciones.TabIndex = 0;
            this.lblSecCotizaciones.Text = "COTIZACIONES DOLAR";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 79 ) ) ) ), ( (int)( ( (byte)( 82 ) ) ) ), ( (int)( ( (byte)( 221 ) ) ) ));
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 119 ) ) ) ), ( (int)( ( (byte)( 122 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(400, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 22);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblEstadoCot
            // 
            this.lblEstadoCot.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoCot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblEstadoCot.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblEstadoCot.Location = new System.Drawing.Point(0, 24);
            this.lblEstadoCot.Name = "lblEstadoCot";
            this.lblEstadoCot.Size = new System.Drawing.Size(540, 18);
            this.lblEstadoCot.TabIndex = 2;
            this.lblEstadoCot.Text = "Presione Actualizar para cargar cotizaciones";
            // 
            // panelDolares
            // 
            this.panelDolares.BackColor = System.Drawing.Color.Transparent;
            this.panelDolares.Controls.Add(this.panelDolarOficial);
            this.panelDolares.Controls.Add(this.panelDolarBlue);
            this.panelDolares.Controls.Add(this.panelDolarTarjeta);
            this.panelDolares.Location = new System.Drawing.Point(0, 48);
            this.panelDolares.Name = "panelDolares";
            this.panelDolares.Size = new System.Drawing.Size(540, 200);
            this.panelDolares.TabIndex = 3;
            // 
            // panelDolarOficial
            // 
            this.panelDolarOficial.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelDolarOficial.Controls.Add(this.lblDOCompra);
            this.panelDolarOficial.Controls.Add(this.lblDOVenta);
            this.panelDolarOficial.Controls.Add(this.lblDOTitulo);
            this.panelDolarOficial.Location = new System.Drawing.Point(0, 0);
            this.panelDolarOficial.Name = "panelDolarOficial";
            this.panelDolarOficial.Size = new System.Drawing.Size(166, 190);
            this.panelDolarOficial.TabIndex = 0;
            // 
            // lblDOTitulo
            // 
            this.lblDOTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDOTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDOTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 59 ) ) ) ), ( (int)( ( (byte)( 130 ) ) ) ), ( (int)( ( (byte)( 246 ) ) ) ));
            this.lblDOTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblDOTitulo.Name = "lblDOTitulo";
            this.lblDOTitulo.Size = new System.Drawing.Size(142, 16);
            this.lblDOTitulo.TabIndex = 0;
            this.lblDOTitulo.Text = "DOLAR OFICIAL";
            // 
            // lblDOVenta
            // 
            this.lblDOVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblDOVenta.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDOVenta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.lblDOVenta.Location = new System.Drawing.Point(10, 36);
            this.lblDOVenta.Name = "lblDOVenta";
            this.lblDOVenta.Size = new System.Drawing.Size(146, 100);
            this.lblDOVenta.TabIndex = 1;
            this.lblDOVenta.Text = "-";
            this.lblDOVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDOCompra
            // 
            this.lblDOCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblDOCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDOCompra.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblDOCompra.Location = new System.Drawing.Point(12, 152);
            this.lblDOCompra.Name = "lblDOCompra";
            this.lblDOCompra.Size = new System.Drawing.Size(142, 28);
            this.lblDOCompra.TabIndex = 2;
            this.lblDOCompra.Text = "Compra: -";
            // 
            // panelDolarBlue
            // 
            this.panelDolarBlue.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelDolarBlue.Controls.Add(this.lblDBCompra);
            this.panelDolarBlue.Controls.Add(this.lblDBVenta);
            this.panelDolarBlue.Controls.Add(this.lblDBTitulo);
            this.panelDolarBlue.Location = new System.Drawing.Point(182, 0);
            this.panelDolarBlue.Name = "panelDolarBlue";
            this.panelDolarBlue.Size = new System.Drawing.Size(166, 190);
            this.panelDolarBlue.TabIndex = 1;
            // 
            // lblDBTitulo
            // 
            this.lblDBTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDBTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDBTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 74 ) ) ) ), ( (int)( ( (byte)( 222 ) ) ) ), ( (int)( ( (byte)( 128 ) ) ) ));
            this.lblDBTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblDBTitulo.Name = "lblDBTitulo";
            this.lblDBTitulo.Size = new System.Drawing.Size(142, 16);
            this.lblDBTitulo.TabIndex = 0;
            this.lblDBTitulo.Text = "DOLAR BLUE";
            // 
            // lblDBVenta
            // 
            this.lblDBVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblDBVenta.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDBVenta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.lblDBVenta.Location = new System.Drawing.Point(10, 36);
            this.lblDBVenta.Name = "lblDBVenta";
            this.lblDBVenta.Size = new System.Drawing.Size(146, 100);
            this.lblDBVenta.TabIndex = 1;
            this.lblDBVenta.Text = "-";
            this.lblDBVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDBCompra
            // 
            this.lblDBCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblDBCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDBCompra.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblDBCompra.Location = new System.Drawing.Point(12, 152);
            this.lblDBCompra.Name = "lblDBCompra";
            this.lblDBCompra.Size = new System.Drawing.Size(142, 28);
            this.lblDBCompra.TabIndex = 2;
            this.lblDBCompra.Text = "Compra: -";
            // 
            // panelDolarTarjeta
            // 
            this.panelDolarTarjeta.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.panelDolarTarjeta.Controls.Add(this.lblDTCompra);
            this.panelDolarTarjeta.Controls.Add(this.lblDTVenta);
            this.panelDolarTarjeta.Controls.Add(this.lblDTTitulo);
            this.panelDolarTarjeta.Location = new System.Drawing.Point(364, 0);
            this.panelDolarTarjeta.Name = "panelDolarTarjeta";
            this.panelDolarTarjeta.Size = new System.Drawing.Size(166, 190);
            this.panelDolarTarjeta.TabIndex = 2;
            // 
            // lblDTTitulo
            // 
            this.lblDTTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblDTTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDTTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 146 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.lblDTTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblDTTitulo.Name = "lblDTTitulo";
            this.lblDTTitulo.Size = new System.Drawing.Size(142, 16);
            this.lblDTTitulo.TabIndex = 0;
            this.lblDTTitulo.Text = "DOLAR TARJETA";
            // 
            // lblDTVenta
            // 
            this.lblDTVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblDTVenta.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDTVenta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.lblDTVenta.Location = new System.Drawing.Point(10, 36);
            this.lblDTVenta.Name = "lblDTVenta";
            this.lblDTVenta.Size = new System.Drawing.Size(146, 100);
            this.lblDTVenta.TabIndex = 1;
            this.lblDTVenta.Text = "-";
            this.lblDTVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDTCompra
            // 
            this.lblDTCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblDTCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDTCompra.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblDTCompra.Location = new System.Drawing.Point(12, 152);
            this.lblDTCompra.Name = "lblDTCompra";
            this.lblDTCompra.Size = new System.Drawing.Size(142, 28);
            this.lblDTCompra.TabIndex = 2;
            this.lblDTCompra.Text = "Compra: -";
            // 
            // panelVSepMedio
            // 
            this.panelVSepMedio.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelVSepMedio.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVSepMedio.Name = "panelVSepMedio";
            this.panelVSepMedio.Size = new System.Drawing.Size(1, 260);
            this.panelVSepMedio.TabIndex = 1;
            // 
            // panelStockBajo
            // 
            this.panelStockBajo.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelStockBajo.Controls.Add(this.dgvStockBajo);
            this.panelStockBajo.Controls.Add(this.lblSecStockBajo);
            this.panelStockBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStockBajo.Name = "panelStockBajo";
            this.panelStockBajo.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelStockBajo.TabIndex = 2;
            // 
            // lblSecStockBajo
            // 
            this.lblSecStockBajo.BackColor = System.Drawing.Color.Transparent;
            this.lblSecStockBajo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecStockBajo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecStockBajo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecStockBajo.Name = "lblSecStockBajo";
            this.lblSecStockBajo.Size = new System.Drawing.Size(539, 22);
            this.lblSecStockBajo.TabIndex = 0;
            this.lblSecStockBajo.Text = "STOCK BAJO (<=3 unidades)";
            // 
            // dgvStockBajo
            // 
            this.dgvStockBajo.AllowUserToAddRows = false;
            this.dgvStockBajo.AllowUserToDeleteRows = false;
            this.dgvStockBajo.AllowUserToResizeRows = false;
            this.dgvStockBajo.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvStockBajo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStockBajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStockBajo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStockBajo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.dgvStockBajo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.dgvStockBajo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.dgvStockBajo.ColumnHeadersHeight = 30;
            this.dgvStockBajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStockBajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colSBNombre,
                this.colSBCondicion,
                this.colSBStock});
            this.dgvStockBajo.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 66 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.dgvStockBajo.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 252 ) ) ) ), ( (int)( ( (byte)( 165 ) ) ) ), ( (int)( ( (byte)( 165 ) ) ) ));
            this.dgvStockBajo.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 90 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvStockBajo.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 252 ) ) ) ), ( (int)( ( (byte)( 165 ) ) ) ), ( (int)( ( (byte)( 165 ) ) ) ));
            this.dgvStockBajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockBajo.EnableHeadersVisualStyles = false;
            this.dgvStockBajo.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.dgvStockBajo.MultiSelect = false;
            this.dgvStockBajo.Name = "dgvStockBajo";
            this.dgvStockBajo.ReadOnly = true;
            this.dgvStockBajo.RowHeadersVisible = false;
            this.dgvStockBajo.RowTemplate.Height = 34;
            this.dgvStockBajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockBajo.TabIndex = 1;
            // 
            // colSBNombre
            // 
            this.colSBNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSBNombre.HeaderText = "Producto";
            this.colSBNombre.Name = "colSBNombre";
            // 
            // colSBCondicion
            // 
            this.colSBCondicion.HeaderText = "Condicion";
            this.colSBCondicion.Name = "colSBCondicion";
            this.colSBCondicion.Width = 90;
            // 
            // colSBStock
            // 
            this.colSBStock.HeaderText = "Stock";
            this.colSBStock.Name = "colSBStock";
            this.colSBStock.Width = 60;
            // 
            // panelSep2
            // 
            this.panelSep2.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelSep2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSep2.Name = "panelSep2";
            this.panelSep2.Size = new System.Drawing.Size(1090, 1);
            this.panelSep2.TabIndex = 3;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelBottom.Controls.Add(this.dgvUltimasVentas);
            this.panelBottom.Controls.Add(this.lblSecUltVentas);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.TabIndex = 4;
            // 
            // lblSecUltVentas
            // 
            this.lblSecUltVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblSecUltVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSecUltVentas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecUltVentas.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecUltVentas.Name = "lblSecUltVentas";
            this.lblSecUltVentas.Size = new System.Drawing.Size(1090, 22);
            this.lblSecUltVentas.TabIndex = 0;
            this.lblSecUltVentas.Text = "ULTIMAS 10 VENTAS";
            // 
            // dgvUltimasVentas
            // 
            this.dgvUltimasVentas.AllowUserToAddRows = false;
            this.dgvUltimasVentas.AllowUserToDeleteRows = false;
            this.dgvUltimasVentas.AllowUserToResizeRows = false;
            this.dgvUltimasVentas.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvUltimasVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUltimasVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUltimasVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUltimasVentas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.dgvUltimasVentas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.dgvUltimasVentas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.dgvUltimasVentas.ColumnHeadersHeight = 30;
            this.dgvUltimasVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUltimasVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colUVFecha,
                this.colUVCliente,
                this.colUVTotal,
                this.colUVMedio,
                this.colUVEstado});
            this.dgvUltimasVentas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dgvUltimasVentas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvUltimasVentas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ), ( (int)( ( (byte)( 85 ) ) ) ));
            this.dgvUltimasVentas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvUltimasVentas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 52 ) ) ) ));
            this.dgvUltimasVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUltimasVentas.EnableHeadersVisualStyles = false;
            this.dgvUltimasVentas.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.dgvUltimasVentas.MultiSelect = false;
            this.dgvUltimasVentas.Name = "dgvUltimasVentas";
            this.dgvUltimasVentas.ReadOnly = true;
            this.dgvUltimasVentas.RowHeadersVisible = false;
            this.dgvUltimasVentas.RowTemplate.Height = 36;
            this.dgvUltimasVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUltimasVentas.TabIndex = 1;
            // 
            // colUVFecha
            // 
            this.colUVFecha.HeaderText = "Fecha";
            this.colUVFecha.Name = "colUVFecha";
            this.colUVFecha.Width = 150;
            // 
            // colUVCliente
            // 
            this.colUVCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUVCliente.HeaderText = "Cliente";
            this.colUVCliente.Name = "colUVCliente";
            // 
            // colUVTotal
            // 
            this.colUVTotal.HeaderText = "Total";
            this.colUVTotal.Name = "colUVTotal";
            this.colUVTotal.Width = 120;
            // 
            // colUVMedio
            // 
            this.colUVMedio.HeaderText = "Medio de pago";
            this.colUVMedio.Name = "colUVMedio";
            this.colUVMedio.Width = 130;
            // 
            // colUVEstado
            // 
            this.colUVEstado.HeaderText = "Estado";
            this.colUVEstado.Name = "colUVEstado";
            this.colUVEstado.Width = 100;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.ClientSize = new System.Drawing.Size(1090, 680);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSep2);
            this.Controls.Add(this.panelMedio);
            this.Controls.Add(this.panelSep1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.panelDolarOficial.ResumeLayout(false);
            this.panelDolarBlue.ResumeLayout(false);
            this.panelDolarTarjeta.ResumeLayout(false);
            this.panelDolares.ResumeLayout(false);
            this.panelCotizaciones.ResumeLayout(false);
            this.panelStockBajo.ResumeLayout(false);
            this.panelMedio.ResumeLayout(false);
            this.panelCardVentasTotal.ResumeLayout(false);
            this.panelCardCantVentas.ResumeLayout(false);
            this.panelCardClientes.ResumeLayout(false);
            this.panelCardCaja.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize)( this.dgvStockBajo ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvUltimasVentas ) ).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCardVentasTotal;
        private System.Windows.Forms.Label lblCardVTitulo;
        private System.Windows.Forms.Label lblCardVValor;
        private System.Windows.Forms.Label lblCardVSub;
        private System.Windows.Forms.Panel panelCardCantVentas;
        private System.Windows.Forms.Label lblCardCVTitulo;
        private System.Windows.Forms.Label lblCardCVValor;
        private System.Windows.Forms.Label lblCardCVSub;
        private System.Windows.Forms.Panel panelCardClientes;
        private System.Windows.Forms.Label lblCardCLTitulo;
        private System.Windows.Forms.Label lblCardCLValor;
        private System.Windows.Forms.Label lblCardCLSub;
        private System.Windows.Forms.Panel panelCardCaja;
        private System.Windows.Forms.Label lblCardCJTitulo;
        private System.Windows.Forms.Label lblCardCJValor;
        private System.Windows.Forms.Label lblCardCJSub;
        private System.Windows.Forms.Panel panelSep1;
        private System.Windows.Forms.Panel panelMedio;
        private System.Windows.Forms.Panel panelCotizaciones;
        private System.Windows.Forms.Label lblSecCotizaciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblEstadoCot;
        private System.Windows.Forms.Panel panelDolares;
        private System.Windows.Forms.Panel panelDolarOficial;
        private System.Windows.Forms.Label lblDOTitulo;
        private System.Windows.Forms.Label lblDOVenta;
        private System.Windows.Forms.Label lblDOCompra;
        private System.Windows.Forms.Panel panelDolarBlue;
        private System.Windows.Forms.Label lblDBTitulo;
        private System.Windows.Forms.Label lblDBVenta;
        private System.Windows.Forms.Label lblDBCompra;
        private System.Windows.Forms.Panel panelDolarTarjeta;
        private System.Windows.Forms.Label lblDTTitulo;
        private System.Windows.Forms.Label lblDTVenta;
        private System.Windows.Forms.Label lblDTCompra;
        private System.Windows.Forms.Panel panelVSepMedio;
        private System.Windows.Forms.Panel panelStockBajo;
        private System.Windows.Forms.Label lblSecStockBajo;
        private System.Windows.Forms.DataGridView dgvStockBajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSBNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSBCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSBStock;
        private System.Windows.Forms.Panel panelSep2;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblSecUltVentas;
        private System.Windows.Forms.DataGridView dgvUltimasVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUVFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUVCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUVTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUVMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUVEstado;
    }
}