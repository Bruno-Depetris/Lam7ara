namespace Lam7ara.Forms.vender {
    partial class FormVender {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.txtBuscarCliente = new ReaLTaiizor.Controls.HopeTextBox();
            this.panelClienteCard = new System.Windows.Forms.Panel();
            this.lblClienteDNI = new System.Windows.Forms.Label();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblSecCliente = new System.Windows.Forms.Label();
            this.panelSepCliente = new System.Windows.Forms.Panel();
            this.panelProductos = new System.Windows.Forms.Panel();
            this.txtBuscarProducto = new ReaLTaiizor.Controls.HopeTextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantLabel = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.lblSecProductos = new System.Windows.Forms.Label();
            this.panelSepProductos = new System.Windows.Forms.Panel();
            this.panelPago = new System.Windows.Forms.Panel();
            this.btnConcretar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.cmbCuotas = new System.Windows.Forms.ComboBox();
            this.lblCuotasLabel = new System.Windows.Forms.Label();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.lblSecPago = new System.Windows.Forms.Label();
            this.colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_VerVentas = new System.Windows.Forms.Button();
            this.panelCliente.SuspendLayout();
            this.panelClienteCard.SuspendLayout();
            this.panelProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panelPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelCliente.Controls.Add(this.txtBuscarCliente);
            this.panelCliente.Controls.Add(this.panelClienteCard);
            this.panelCliente.Controls.Add(this.btnBuscarCliente);
            this.panelCliente.Controls.Add(this.lblSecCliente);
            this.panelCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(934, 102);
            this.panelCliente.TabIndex = 0;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtBuscarCliente.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtBuscarCliente.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtBuscarCliente.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscarCliente.Hint = "Buscar por nombre o DNI...";
            this.txtBuscarCliente.Location = new System.Drawing.Point(0, 22);
            this.txtBuscarCliente.MaxLength = 32767;
            this.txtBuscarCliente.Multiline = false;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.PasswordChar = '\0';
            this.txtBuscarCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarCliente.SelectedText = "";
            this.txtBuscarCliente.SelectionLength = 0;
            this.txtBuscarCliente.SelectionStart = 0;
            this.txtBuscarCliente.Size = new System.Drawing.Size(652, 38);
            this.txtBuscarCliente.TabIndex = 7;
            this.txtBuscarCliente.TabStop = false;
            this.txtBuscarCliente.UseSystemPasswordChar = false;
            // 
            // panelClienteCard
            // 
            this.panelClienteCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelClienteCard.Controls.Add(this.lblClienteDNI);
            this.panelClienteCard.Controls.Add(this.lblClienteNombre);
            this.panelClienteCard.Location = new System.Drawing.Point(0, 64);
            this.panelClienteCard.Name = "panelClienteCard";
            this.panelClienteCard.Size = new System.Drawing.Size(778, 33);
            this.panelClienteCard.TabIndex = 3;
            // 
            // lblClienteDNI
            // 
            this.lblClienteDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteDNI.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblClienteDNI.Location = new System.Drawing.Point(471, 7);
            this.lblClienteDNI.Name = "lblClienteDNI";
            this.lblClienteDNI.Size = new System.Drawing.Size(257, 19);
            this.lblClienteDNI.TabIndex = 1;
            this.lblClienteDNI.Text = "DNI: -";
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblClienteNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblClienteNombre.Location = new System.Drawing.Point(9, 7);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(386, 19);
            this.lblClienteNombre.TabIndex = 0;
            this.lblClienteNombre.Text = "Ningun cliente seleccionado";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(658, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(120, 33);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblSecCliente
            // 
            this.lblSecCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblSecCliente.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecCliente.Location = new System.Drawing.Point(0, 0);
            this.lblSecCliente.Name = "lblSecCliente";
            this.lblSecCliente.Size = new System.Drawing.Size(257, 19);
            this.lblSecCliente.TabIndex = 0;
            this.lblSecCliente.Text = "CLIENTE";
            // 
            // panelSepCliente
            // 
            this.panelSepCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepCliente.Location = new System.Drawing.Point(0, 106);
            this.panelSepCliente.Name = "panelSepCliente";
            this.panelSepCliente.Size = new System.Drawing.Size(934, 1);
            this.panelSepCliente.TabIndex = 1;
            // 
            // panelProductos
            // 
            this.panelProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelProductos.Controls.Add(this.txtBuscarProducto);
            this.panelProductos.Controls.Add(this.dgvProductos);
            this.panelProductos.Controls.Add(this.btnAgregarProducto);
            this.panelProductos.Controls.Add(this.nudCantidad);
            this.panelProductos.Controls.Add(this.lblCantLabel);
            this.panelProductos.Controls.Add(this.btnBuscarProducto);
            this.panelProductos.Controls.Add(this.lblSecProductos);
            this.panelProductos.Location = new System.Drawing.Point(0, 112);
            this.panelProductos.Name = "panelProductos";
            this.panelProductos.Size = new System.Drawing.Size(934, 258);
            this.panelProductos.TabIndex = 2;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtBuscarProducto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtBuscarProducto.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtBuscarProducto.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscarProducto.Hint = "Buscar un producto";
            this.txtBuscarProducto.Location = new System.Drawing.Point(0, 20);
            this.txtBuscarProducto.MaxLength = 32767;
            this.txtBuscarProducto.Multiline = false;
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.PasswordChar = '\0';
            this.txtBuscarProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarProducto.SelectedText = "";
            this.txtBuscarProducto.SelectionLength = 0;
            this.txtBuscarProducto.SelectionStart = 0;
            this.txtBuscarProducto.Size = new System.Drawing.Size(429, 38);
            this.txtBuscarProducto.TabIndex = 8;
            this.txtBuscarProducto.TabStop = false;
            this.txtBuscarProducto.UseSystemPasswordChar = false;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.ColumnHeadersHeight = 36;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNum,
            this.colProductoID,
            this.colProducto,
            this.colPrecio,
            this.colCantidad,
            this.colSubtotal,
            this.colQuitar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.dgvProductos.Location = new System.Drawing.Point(0, 64);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 40;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(934, 194);
            this.dgvProductos.TabIndex = 6;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(670, 23);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(129, 33);
            this.btnAgregarProducto.TabIndex = 5;
            this.btnAgregarProducto.Text = "+ Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.nudCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCantidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.nudCantidad.Location = new System.Drawing.Point(602, 24);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(60, 27);
            this.nudCantidad.TabIndex = 4;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantLabel
            // 
            this.lblCantLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCantLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCantLabel.Location = new System.Drawing.Point(550, 29);
            this.lblCantLabel.Name = "lblCantLabel";
            this.lblCantLabel.Size = new System.Drawing.Size(48, 19);
            this.lblCantLabel.TabIndex = 3;
            this.lblCantLabel.Text = "Cant.:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(435, 23);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(103, 33);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // lblSecProductos
            // 
            this.lblSecProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblSecProductos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecProductos.Location = new System.Drawing.Point(0, 0);
            this.lblSecProductos.Name = "lblSecProductos";
            this.lblSecProductos.Size = new System.Drawing.Size(257, 19);
            this.lblSecProductos.TabIndex = 0;
            this.lblSecProductos.Text = "PRODUCTOS";
            // 
            // panelSepProductos
            // 
            this.panelSepProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepProductos.Location = new System.Drawing.Point(0, 370);
            this.panelSepProductos.Name = "panelSepProductos";
            this.panelSepProductos.Size = new System.Drawing.Size(934, 1);
            this.panelSepProductos.TabIndex = 3;
            // 
            // panelPago
            // 
            this.panelPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelPago.Controls.Add(this.button_VerVentas);
            this.panelPago.Controls.Add(this.btnConcretar);
            this.panelPago.Controls.Add(this.btnCancelar);
            this.panelPago.Controls.Add(this.lblTotalValue);
            this.panelPago.Controls.Add(this.lblTotalLabel);
            this.panelPago.Controls.Add(this.cmbCuotas);
            this.panelPago.Controls.Add(this.lblCuotasLabel);
            this.panelPago.Controls.Add(this.rbCredito);
            this.panelPago.Controls.Add(this.rbTransferencia);
            this.panelPago.Controls.Add(this.rbEfectivo);
            this.panelPago.Controls.Add(this.lblSecPago);
            this.panelPago.Location = new System.Drawing.Point(0, 376);
            this.panelPago.Name = "panelPago";
            this.panelPago.Size = new System.Drawing.Size(934, 173);
            this.panelPago.TabIndex = 4;
            // 
            // btnConcretar
            // 
            this.btnConcretar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnConcretar.FlatAppearance.BorderSize = 0;
            this.btnConcretar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnConcretar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnConcretar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcretar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcretar.ForeColor = System.Drawing.Color.White;
            this.btnConcretar.Location = new System.Drawing.Point(782, 128);
            this.btnConcretar.Name = "btnConcretar";
            this.btnConcretar.Size = new System.Drawing.Size(153, 38);
            this.btnConcretar.TabIndex = 9;
            this.btnConcretar.Text = "Concretar venta";
            this.btnConcretar.UseVisualStyleBackColor = false;
            this.btnConcretar.Click += new System.EventHandler(this.btnConcretar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancelar.Location = new System.Drawing.Point(643, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblTotalValue.Location = new System.Drawing.Point(600, 38);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(240, 43);
            this.lblTotalValue.TabIndex = 7;
            this.lblTotalValue.Text = "$0,00";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(600, 17);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(69, 19);
            this.lblTotalLabel.TabIndex = 6;
            this.lblTotalLabel.Text = "TOTAL";
            // 
            // cmbCuotas
            // 
            this.cmbCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuotas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCuotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmbCuotas.Items.AddRange(new object[] {
            "1 cuota",
            "3 cuotas",
            "6 cuotas",
            "12 cuotas",
            "18 cuotas",
            "24 cuotas"});
            this.cmbCuotas.Location = new System.Drawing.Point(74, 57);
            this.cmbCuotas.Name = "cmbCuotas";
            this.cmbCuotas.Size = new System.Drawing.Size(129, 25);
            this.cmbCuotas.TabIndex = 5;
            this.cmbCuotas.Visible = false;
            // 
            // lblCuotasLabel
            // 
            this.lblCuotasLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblCuotasLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotasLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCuotasLabel.Location = new System.Drawing.Point(0, 61);
            this.lblCuotasLabel.Name = "lblCuotasLabel";
            this.lblCuotasLabel.Size = new System.Drawing.Size(67, 19);
            this.lblCuotasLabel.TabIndex = 4;
            this.lblCuotasLabel.Text = "Cuotas:";
            this.lblCuotasLabel.Visible = false;
            // 
            // rbCredito
            // 
            this.rbCredito.BackColor = System.Drawing.Color.Transparent;
            this.rbCredito.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.rbCredito.Location = new System.Drawing.Point(249, 28);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(94, 24);
            this.rbCredito.TabIndex = 3;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = false;
            this.rbCredito.CheckedChanged += new System.EventHandler(this.rbCredito_CheckedChanged);
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.BackColor = System.Drawing.Color.Transparent;
            this.rbTransferencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTransferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.rbTransferencia.Location = new System.Drawing.Point(111, 28);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(129, 24);
            this.rbTransferencia.TabIndex = 2;
            this.rbTransferencia.Text = "Transferencia";
            this.rbTransferencia.UseVisualStyleBackColor = false;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.BackColor = System.Drawing.Color.Transparent;
            this.rbEfectivo.Checked = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.rbEfectivo.Location = new System.Drawing.Point(0, 28);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(103, 24);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = false;
            // 
            // lblSecPago
            // 
            this.lblSecPago.BackColor = System.Drawing.Color.Transparent;
            this.lblSecPago.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecPago.Location = new System.Drawing.Point(0, 0);
            this.lblSecPago.Name = "lblSecPago";
            this.lblSecPago.Size = new System.Drawing.Size(257, 19);
            this.lblSecPago.TabIndex = 0;
            this.lblSecPago.Text = "MEDIO DE PAGO";
            // 
            // colNum
            // 
            this.colNum.HeaderText = "#";
            this.colNum.Name = "colNum";
            this.colNum.ReadOnly = true;
            this.colNum.Width = 40;
            // 
            // colProductoID
            // 
            this.colProductoID.HeaderText = "ID";
            this.colProductoID.Name = "colProductoID";
            // 
            // colProducto
            // 
            this.colProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio Unit.";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            this.colPrecio.Width = 110;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cant.";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 60;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 110;
            // 
            // colQuitar
            // button_VerVentas
            // 
            this.colQuitar.HeaderText = "";
            this.colQuitar.Name = "colQuitar";
            this.colQuitar.Text = "X";
            this.colQuitar.UseColumnTextForButtonValue = true;
            this.colQuitar.Width = 50;
            this.button_VerVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_VerVentas.FlatAppearance.BorderSize = 0;
            this.button_VerVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.button_VerVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.button_VerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VerVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_VerVentas.ForeColor = System.Drawing.Color.Black;
            this.button_VerVentas.Location = new System.Drawing.Point(13, 132);
            this.button_VerVentas.Name = "button_VerVentas";
            this.button_VerVentas.Size = new System.Drawing.Size(103, 38);
            this.button_VerVentas.TabIndex = 10;
            this.button_VerVentas.Text = "Ver Ventas";
            this.button_VerVentas.UseVisualStyleBackColor = false;
            this.button_VerVentas.Click += new System.EventHandler(this.button_VerVentas_Click);
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(921, 568);
            this.Controls.Add(this.panelPago);
            this.Controls.Add(this.panelSepProductos);
            this.Controls.Add(this.panelProductos);
            this.Controls.Add(this.panelSepCliente);
            this.Controls.Add(this.panelCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVender";
            this.panelCliente.ResumeLayout(false);
            this.panelClienteCard.ResumeLayout(false);
            this.panelProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panelPago.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label lblSecCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel panelClienteCard;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.Label lblClienteDNI;
        private System.Windows.Forms.Panel panelSepCliente;
        private System.Windows.Forms.Panel panelProductos;
        private System.Windows.Forms.Label lblSecProductos;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Label lblCantLabel;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panelSepProductos;
        private System.Windows.Forms.Panel panelPago;
        private System.Windows.Forms.Label lblSecPago;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.RadioButton rbTransferencia;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.Label lblCuotasLabel;
        private System.Windows.Forms.ComboBox cmbCuotas;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConcretar;
        private ReaLTaiizor.Controls.HopeTextBox txtBuscarCliente;
        private ReaLTaiizor.Controls.HopeTextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn colQuitar;
        private System.Windows.Forms.Button button_VerVentas;
    }
}