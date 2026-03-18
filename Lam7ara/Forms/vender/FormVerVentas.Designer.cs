namespace Lam7ara.Forms.vender {
    partial class FormVerVentas {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null ))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFiltrosLabel = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.panelSepTop = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelIzq = new System.Windows.Forms.Panel();
            this.lblSecVentas = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colVID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelVSep = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.lblSecDetalle = new System.Windows.Forms.Label();
            this.panelSepDetalle = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.colDProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelIzq.SuspendLayout();
            this.panelDer.SuspendLayout();
            this.panelAcciones.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvVentas ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvDetalle ) ).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.panelTop.Controls.Add(this.btnLimpiarFiltros);
            this.panelTop.Controls.Add(this.btnFiltrar);
            this.panelTop.Controls.Add(this.cmbMedioPago);
            this.panelTop.Controls.Add(this.lblMedioPago);
            this.panelTop.Controls.Add(this.dtpHasta);
            this.panelTop.Controls.Add(this.lblHasta);
            this.panelTop.Controls.Add(this.dtpDesde);
            this.panelTop.Controls.Add(this.lblDesde);
            this.panelTop.Controls.Add(this.lblFiltrosLabel);
            this.panelTop.Controls.Add(this.lblTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1100, 100);
            this.panelTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.lblTitulo.Location = new System.Drawing.Point(16, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Historial de Ventas";
            // 
            // lblFiltrosLabel
            // 
            this.lblFiltrosLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrosLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblFiltrosLabel.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblFiltrosLabel.Location = new System.Drawing.Point(16, 50);
            this.lblFiltrosLabel.Name = "lblFiltrosLabel";
            this.lblFiltrosLabel.Size = new System.Drawing.Size(60, 16);
            this.lblFiltrosLabel.TabIndex = 1;
            this.lblFiltrosLabel.Text = "FILTROS";
            // 
            // lblDesde
            // 
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblDesde.Location = new System.Drawing.Point(16, 70);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 18);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CalendarForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dtpDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(64, 68);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 23);
            this.dtpDesde.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblHasta.Location = new System.Drawing.Point(196, 70);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(40, 18);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.CalendarForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dtpHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(240, 68);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 23);
            this.dtpHasta.TabIndex = 5;
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.BackColor = System.Drawing.Color.Transparent;
            this.lblMedioPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblMedioPago.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblMedioPago.Location = new System.Drawing.Point(374, 70);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(76, 18);
            this.lblMedioPago.TabIndex = 6;
            this.lblMedioPago.Text = "Medio pago";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMedioPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.cmbMedioPago.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.cmbMedioPago.Items.AddRange(new object[] { "Todos", "Efectivo", "Transferencia", "Credito" });
            this.cmbMedioPago.Location = new System.Drawing.Point(454, 67);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(130, 24);
            this.cmbMedioPago.TabIndex = 7;
            this.cmbMedioPago.SelectedIndex = 0;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 79 ) ) ) ), ( (int)( ( (byte)( 82 ) ) ) ), ( (int)( ( (byte)( 221 ) ) ) ));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 119 ) ) ) ), ( (int)( ( (byte)( 122 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(596, 64);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 30);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnLimpiarFiltros.FlatAppearance.BorderSize = 1;
            this.btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 37 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 68 ) ) ) ));
            this.btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnLimpiarFiltros.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(706, 64);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(110, 30);
            this.btnLimpiarFiltros.TabIndex = 9;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // panelSepTop
            // 
            this.panelSepTop.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelSepTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSepTop.Name = "panelSepTop";
            this.panelSepTop.Size = new System.Drawing.Size(1100, 1);
            this.panelSepTop.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelContenido.Controls.Add(this.panelDer);
            this.panelContenido.Controls.Add(this.panelVSep);
            this.panelContenido.Controls.Add(this.panelIzq);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.TabIndex = 2;
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelIzq.Controls.Add(this.dgvVentas);
            this.panelIzq.Controls.Add(this.lblResumen);
            this.panelIzq.Controls.Add(this.lblSecVentas);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(660, 569);
            this.panelIzq.TabIndex = 0;
            // 
            // lblSecVentas
            // 
            this.lblSecVentas.BackColor = System.Drawing.Color.Transparent;
            this.lblSecVentas.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecVentas.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecVentas.Location = new System.Drawing.Point(0, 0);
            this.lblSecVentas.Name = "lblSecVentas";
            this.lblSecVentas.Size = new System.Drawing.Size(400, 22);
            this.lblSecVentas.TabIndex = 0;
            this.lblSecVentas.Text = "VENTAS";
            // 
            // lblResumen
            // 
            this.lblResumen.BackColor = System.Drawing.Color.Transparent;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.lblResumen.Location = new System.Drawing.Point(300, 2);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(360, 18);
            this.lblResumen.TabIndex = 1;
            this.lblResumen.Text = string.Empty;
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.dgvVentas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.dgvVentas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.dgvVentas.ColumnHeadersHeight = 34;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colVID,
                this.colVFecha,
                this.colVCliente,
                this.colVTotal,
                this.colVMedio,
                this.colVCuotas,
                this.colVEstado});
            this.dgvVentas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dgvVentas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvVentas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ), ( (int)( ( (byte)( 85 ) ) ) ));
            this.dgvVentas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvVentas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 52 ) ) ) ));
            this.dgvVentas.EnableHeadersVisualStyles = false;
            this.dgvVentas.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.dgvVentas.Location = new System.Drawing.Point(0, 28);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 38;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(660, 541);
            this.dgvVentas.TabIndex = 2;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // colVID
            // 
            this.colVID.HeaderText = "ID";
            this.colVID.Name = "colVID";
            this.colVID.Visible = false;
            this.colVID.Width = 40;
            // 
            // colVFecha
            // 
            this.colVFecha.HeaderText = "Fecha";
            this.colVFecha.Name = "colVFecha";
            this.colVFecha.Width = 140;
            // 
            // colVCliente
            // 
            this.colVCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colVCliente.HeaderText = "Cliente";
            this.colVCliente.Name = "colVCliente";
            // 
            // colVTotal
            // 
            this.colVTotal.HeaderText = "Total";
            this.colVTotal.Name = "colVTotal";
            this.colVTotal.Width = 110;
            // 
            // colVMedio
            // 
            this.colVMedio.HeaderText = "Medio";
            this.colVMedio.Name = "colVMedio";
            this.colVMedio.Width = 100;
            // 
            // colVCuotas
            // 
            this.colVCuotas.HeaderText = "Cuotas";
            this.colVCuotas.Name = "colVCuotas";
            this.colVCuotas.Width = 60;
            // 
            // colVEstado
            // 
            this.colVEstado.HeaderText = "Estado";
            this.colVEstado.Name = "colVEstado";
            this.colVEstado.Width = 90;
            // 
            // panelVSep
            // 
            this.panelVSep.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelVSep.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVSep.Name = "panelVSep";
            this.panelVSep.Size = new System.Drawing.Size(1, 569);
            this.panelVSep.TabIndex = 1;
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelDer.Controls.Add(this.panelAcciones);
            this.panelDer.Controls.Add(this.dgvDetalle);
            this.panelDer.Controls.Add(this.panelSepDetalle);
            this.panelDer.Controls.Add(this.lblSecDetalle);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Name = "panelDer";
            this.panelDer.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panelDer.TabIndex = 2;
            // 
            // lblSecDetalle
            // 
            this.lblSecDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblSecDetalle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecDetalle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecDetalle.Location = new System.Drawing.Point(20, 0);
            this.lblSecDetalle.Name = "lblSecDetalle";
            this.lblSecDetalle.Size = new System.Drawing.Size(400, 22);
            this.lblSecDetalle.TabIndex = 0;
            this.lblSecDetalle.Text = "DETALLE DE VENTA";
            // 
            // panelSepDetalle
            // 
            this.panelSepDetalle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelSepDetalle.Location = new System.Drawing.Point(20, 26);
            this.panelSepDetalle.Name = "panelSepDetalle";
            this.panelSepDetalle.Size = new System.Drawing.Size(400, 1);
            this.panelSepDetalle.TabIndex = 1;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.dgvDetalle.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.dgvDetalle.ColumnHeadersHeight = 34;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDProd,
                this.colDCant,
                this.colDPrecio,
                this.colDSub});
            this.dgvDetalle.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dgvDetalle.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvDetalle.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ), ( (int)( ( (byte)( 85 ) ) ) ));
            this.dgvDetalle.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvDetalle.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 52 ) ) ) ));
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.dgvDetalle.Location = new System.Drawing.Point(20, 34);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowTemplate.Height = 36;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(400, 380);
            this.dgvDetalle.TabIndex = 2;
            // 
            // colDProd
            // 
            this.colDProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDProd.HeaderText = "Producto";
            this.colDProd.Name = "colDProd";
            // 
            // colDCant
            // 
            this.colDCant.HeaderText = "Cant.";
            this.colDCant.Name = "colDCant";
            this.colDCant.Width = 50;
            // 
            // colDPrecio
            // 
            this.colDPrecio.HeaderText = "Precio Unit.";
            this.colDPrecio.Name = "colDPrecio";
            this.colDPrecio.Width = 100;
            // 
            // colDSub
            // 
            this.colDSub.HeaderText = "Subtotal";
            this.colDSub.Name = "colDSub";
            this.colDSub.Width = 100;
            // 
            // panelAcciones
            // 
            this.panelAcciones.BackColor = System.Drawing.Color.Transparent;
            this.panelAcciones.Controls.Add(this.btnAnular);
            this.panelAcciones.Controls.Add(this.btnImprimir);
            this.panelAcciones.Controls.Add(this.lblTotalValor);
            this.panelAcciones.Controls.Add(this.lblTotalDetalle);
            this.panelAcciones.Location = new System.Drawing.Point(20, 424);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(400, 130);
            this.panelAcciones.TabIndex = 3;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTotalDetalle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblTotalDetalle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(80, 22);
            this.lblTotalDetalle.TabIndex = 0;
            this.lblTotalDetalle.Text = "TOTAL";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblTotalValor.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.lblTotalValor.Location = new System.Drawing.Point(0, 22);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(400, 44);
            this.lblTotalValor.TabIndex = 1;
            this.lblTotalValor.Text = "-";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 79 ) ) ) ), ( (int)( ( (byte)( 82 ) ) ) ), ( (int)( ( (byte)( 221 ) ) ) ));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 119 ) ) ) ), ( (int)( ( (byte)( 122 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(0, 80);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(190, 42);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir recibo";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnAnular.FlatAppearance.BorderSize = 1;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 185 ) ) ) ), ( (int)( ( (byte)( 28 ) ) ) ), ( (int)( ( (byte)( 28 ) ) ) ));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnAnular.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnAnular.Location = new System.Drawing.Point(206, 80);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(190, 42);
            this.btnAnular.TabIndex = 3;
            this.btnAnular.Text = "Anular venta";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // FormVerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.ClientSize = new System.Drawing.Size(1100, 670);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSepTop);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVerVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial de Ventas";
            this.Load += new System.EventHandler(this.FormVerVentas_Load);
            this.panelAcciones.ResumeLayout(false);
            this.panelDer.ResumeLayout(false);
            this.panelIzq.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize)( this.dgvVentas ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvDetalle ) ).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFiltrosLabel;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Panel panelSepTop;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Label lblSecVentas;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVMedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVEstado;
        private System.Windows.Forms.Panel panelVSep;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Label lblSecDetalle;
        private System.Windows.Forms.Panel panelSepDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDSub;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnular;
    }
}