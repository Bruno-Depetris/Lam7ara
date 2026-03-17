namespace Lam7ara.Forms.stock {
    partial class FormStock {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null ))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.panelIzq = new System.Windows.Forms.Panel();
            this.lblSecLista = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlmacenamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelVSep = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.lblSecForm = new System.Windows.Forms.Label();
            this.panelSepForm = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.lblBateria = new System.Windows.Forms.Label();
            this.txtBateria = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblEmailProv = new System.Windows.Forms.Label();
            this.txtEmailProv = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelIzq.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvProductos ) ).BeginInit();
            this.panelDer.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.nudStock ) ).BeginInit();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelIzq.Controls.Add(this.dgvProductos);
            this.panelIzq.Controls.Add(this.cmbFiltro);
            this.panelIzq.Controls.Add(this.btnMostrarTodos);
            this.panelIzq.Controls.Add(this.btnBuscar);
            this.panelIzq.Controls.Add(this.txtBuscar);
            this.panelIzq.Controls.Add(this.lblSecLista);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(700, 680);
            this.panelIzq.TabIndex = 0;
            // 
            // lblSecLista
            // 
            this.lblSecLista.BackColor = System.Drawing.Color.Transparent;
            this.lblSecLista.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecLista.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecLista.Location = new System.Drawing.Point(0, 0);
            this.lblSecLista.Name = "lblSecLista";
            this.lblSecLista.Size = new System.Drawing.Size(700, 22);
            this.lblSecLista.TabIndex = 0;
            this.lblSecLista.Text = "STOCK DE PRODUCTOS";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.txtBuscar.Location = new System.Drawing.Point(0, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(360, 34);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar producto...";
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 79 ) ) ) ), ( (int)( ( (byte)( 82 ) ) ) ), ( (int)( ( (byte)( 221 ) ) ) ));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 119 ) ) ) ), ( (int)( ( (byte)( 122 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(368, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.cmbFiltro.Items.AddRange(new object[] { "Todos", "Nuevo", "Usado" });
            this.cmbFiltro.Location = new System.Drawing.Point(486, 28);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(100, 28);
            this.cmbFiltro.TabIndex = 3;
            this.cmbFiltro.SelectedIndex = 0;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnMostrarTodos.FlatAppearance.BorderSize = 1;
            this.btnMostrarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnMostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 37 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 68 ) ) ) ));
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.btnMostrarTodos.Location = new System.Drawing.Point(594, 26);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(106, 38);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 19 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ));
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.dgvProductos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.dgvProductos.ColumnHeadersHeight = 34;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID,
                this.colNombre,
                this.colCondicion,
                this.colAlmacenamiento,
                this.colStock,
                this.colPrecioCosto,
                this.colPrecioVenta});
            this.dgvProductos.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.dgvProductos.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvProductos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 43 ) ) ) ), ( (int)( ( (byte)( 85 ) ) ) ));
            this.dgvProductos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 52 ) ) ) ));
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.dgvProductos.Location = new System.Drawing.Point(0, 74);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowTemplate.Height = 38;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(700, 606);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProductos_RowPrePaint);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 50;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colCondicion
            // 
            this.colCondicion.HeaderText = "Condicion";
            this.colCondicion.Name = "colCondicion";
            this.colCondicion.Width = 80;
            // 
            // colAlmacenamiento
            // 
            this.colAlmacenamiento.HeaderText = "Almac.";
            this.colAlmacenamiento.Name = "colAlmacenamiento";
            this.colAlmacenamiento.Width = 70;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Width = 60;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.HeaderText = "Costo";
            this.colPrecioCosto.Name = "colPrecioCosto";
            this.colPrecioCosto.Width = 90;
            // 
            // colPrecioVenta
            // 
            this.colPrecioVenta.HeaderText = "Venta";
            this.colPrecioVenta.Name = "colPrecioVenta";
            this.colPrecioVenta.Width = 90;
            // 
            // panelVSep
            // 
            this.panelVSep.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelVSep.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVSep.Name = "panelVSep";
            this.panelVSep.Size = new System.Drawing.Size(1, 680);
            this.panelVSep.TabIndex = 1;
            // 
            // panelDer
            // 
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.panelDer.AutoScroll = true;
            this.panelDer.Controls.Add(this.panelBotones);
            this.panelDer.Controls.Add(this.txtDescripcion);
            this.panelDer.Controls.Add(this.lblDescripcion);
            this.panelDer.Controls.Add(this.txtEmailProv);
            this.panelDer.Controls.Add(this.lblEmailProv);
            this.panelDer.Controls.Add(this.txtPrecioVenta);
            this.panelDer.Controls.Add(this.lblPrecioVenta);
            this.panelDer.Controls.Add(this.txtPrecioCosto);
            this.panelDer.Controls.Add(this.lblPrecioCosto);
            this.panelDer.Controls.Add(this.nudStock);
            this.panelDer.Controls.Add(this.lblStock);
            this.panelDer.Controls.Add(this.txtBateria);
            this.panelDer.Controls.Add(this.lblBateria);
            this.panelDer.Controls.Add(this.txtAlmacenamiento);
            this.panelDer.Controls.Add(this.lblAlmacenamiento);
            this.panelDer.Controls.Add(this.cmbCondicion);
            this.panelDer.Controls.Add(this.lblCondicion);
            this.panelDer.Controls.Add(this.txtNombre);
            this.panelDer.Controls.Add(this.lblNombre);
            this.panelDer.Controls.Add(this.panelSepForm);
            this.panelDer.Controls.Add(this.lblSecForm);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Name = "panelDer";
            this.panelDer.Padding = new System.Windows.Forms.Padding(24, 0, 12, 0);
            this.panelDer.TabIndex = 2;
            // 
            // lblSecForm
            // 
            this.lblSecForm.BackColor = System.Drawing.Color.Transparent;
            this.lblSecForm.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblSecForm.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 100 ) ) ) ), ( (int)( ( (byte)( 116 ) ) ) ), ( (int)( ( (byte)( 139 ) ) ) ));
            this.lblSecForm.Location = new System.Drawing.Point(24, 0);
            this.lblSecForm.Name = "lblSecForm";
            this.lblSecForm.Size = new System.Drawing.Size(360, 22);
            this.lblSecForm.TabIndex = 0;
            this.lblSecForm.Text = "DATOS DEL PRODUCTO";
            // 
            // panelSepForm
            // 
            this.panelSepForm.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.panelSepForm.Location = new System.Drawing.Point(24, 28);
            this.panelSepForm.Name = "panelSepForm";
            this.panelSepForm.Size = new System.Drawing.Size(360, 1);
            this.panelSepForm.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblNombre.Location = new System.Drawing.Point(24, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(360, 18);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtNombre.Location = new System.Drawing.Point(24, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 34);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCondicion
            // 
            this.lblCondicion.BackColor = System.Drawing.Color.Transparent;
            this.lblCondicion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblCondicion.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblCondicion.Location = new System.Drawing.Point(24, 104);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(360, 18);
            this.lblCondicion.TabIndex = 4;
            this.lblCondicion.Text = "Condicion";
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.cmbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCondicion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.cmbCondicion.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.cmbCondicion.Items.AddRange(new object[] { "Nuevo", "Usado" });
            this.cmbCondicion.Location = new System.Drawing.Point(24, 124);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(360, 34);
            this.cmbCondicion.TabIndex = 5;
            this.cmbCondicion.SelectedIndex = 0;
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblAlmacenamiento.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(24, 170);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(360, 18);
            this.lblAlmacenamiento.TabIndex = 6;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtAlmacenamiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlmacenamiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtAlmacenamiento.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtAlmacenamiento.Location = new System.Drawing.Point(24, 190);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(360, 34);
            this.txtAlmacenamiento.TabIndex = 7;
            // 
            // lblBateria
            // 
            this.lblBateria.BackColor = System.Drawing.Color.Transparent;
            this.lblBateria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblBateria.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblBateria.Location = new System.Drawing.Point(24, 236);
            this.lblBateria.Name = "lblBateria";
            this.lblBateria.Size = new System.Drawing.Size(360, 18);
            this.lblBateria.TabIndex = 8;
            this.lblBateria.Text = "Bateria";
            // 
            // txtBateria
            // 
            this.txtBateria.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtBateria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBateria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtBateria.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtBateria.Location = new System.Drawing.Point(24, 256);
            this.txtBateria.Name = "txtBateria";
            this.txtBateria.Size = new System.Drawing.Size(360, 34);
            this.txtBateria.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.BackColor = System.Drawing.Color.Transparent;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblStock.Location = new System.Drawing.Point(24, 302);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(360, 18);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // nudStock
            // 
            this.nudStock.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.nudStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.nudStock.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.nudStock.Location = new System.Drawing.Point(24, 322);
            this.nudStock.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(360, 34);
            this.nudStock.TabIndex = 11;
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioCosto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrecioCosto.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblPrecioCosto.Location = new System.Drawing.Point(24, 368);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(172, 18);
            this.lblPrecioCosto.TabIndex = 12;
            this.lblPrecioCosto.Text = "Precio Costo";
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtPrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCosto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtPrecioCosto.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtPrecioCosto.Location = new System.Drawing.Point(24, 388);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(172, 34);
            this.txtPrecioCosto.TabIndex = 13;
            this.txtPrecioCosto.Text = "0";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblPrecioVenta.Location = new System.Drawing.Point(212, 368);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(172, 18);
            this.lblPrecioVenta.TabIndex = 14;
            this.lblPrecioVenta.Text = "Precio Venta";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtPrecioVenta.Location = new System.Drawing.Point(212, 388);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(172, 34);
            this.txtPrecioVenta.TabIndex = 15;
            this.txtPrecioVenta.Text = "0";
            // 
            // lblEmailProv
            // 
            this.lblEmailProv.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailProv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblEmailProv.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblEmailProv.Location = new System.Drawing.Point(24, 434);
            this.lblEmailProv.Name = "lblEmailProv";
            this.lblEmailProv.Size = new System.Drawing.Size(360, 18);
            this.lblEmailProv.TabIndex = 16;
            this.lblEmailProv.Text = "Email Proveedor (opcional)";
            // 
            // txtEmailProv
            // 
            this.txtEmailProv.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtEmailProv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailProv.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtEmailProv.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtEmailProv.Location = new System.Drawing.Point(24, 454);
            this.txtEmailProv.Name = "txtEmailProv";
            this.txtEmailProv.Size = new System.Drawing.Size(360, 34);
            this.txtEmailProv.TabIndex = 17;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.lblDescripcion.Location = new System.Drawing.Point(24, 500);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(360, 18);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ), ( (int)( ( (byte)( 46 ) ) ) ));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 232 ) ) ) ), ( (int)( ( (byte)( 240 ) ) ) ));
            this.txtDescripcion.Location = new System.Drawing.Point(24, 520);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(360, 70);
            this.txtDescripcion.TabIndex = 19;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Location = new System.Drawing.Point(24, 604);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(360, 100);
            this.panelBotones.TabIndex = 20;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnNuevo.FlatAppearance.BorderSize = 1;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 37 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 68 ) ) ) ));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(172, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 99 ) ) ) ), ( (int)( ( (byte)( 102 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 79 ) ) ) ), ( (int)( ( (byte)( 82 ) ) ) ), ( (int)( ( (byte)( 221 ) ) ) ));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 119 ) ) ) ), ( (int)( ( (byte)( 122 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(188, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(172, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnEliminar.FlatAppearance.BorderSize = 1;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 185 ) ) ) ), ( (int)( ( (byte)( 28 ) ) ) ), ( (int)( ( (byte)( 28 ) ) ) ));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 220 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ), ( (int)( ( (byte)( 38 ) ) ) ));
            this.btnEliminar.Location = new System.Drawing.Point(0, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 42 ) ) ) ), ( (int)( ( (byte)( 74 ) ) ) ));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 37 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 68 ) ) ) ));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 148 ) ) ) ), ( (int)( ( (byte)( 163 ) ) ) ), ( (int)( ( (byte)( 184 ) ) ) ));
            this.btnLimpiar.Location = new System.Drawing.Point(188, 52);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(172, 42);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.ClientSize = new System.Drawing.Size(1090, 680);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelVSep);
            this.Controls.Add(this.panelIzq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStock";
            this.Text = "Stock";
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvProductos ) ).EndInit();
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.nudStock ) ).EndInit();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Label lblSecLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlmacenamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioVenta;
        private System.Windows.Forms.Panel panelVSep;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Label lblSecForm;
        private System.Windows.Forms.Panel panelSepForm;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Label lblBateria;
        private System.Windows.Forms.TextBox txtBateria;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblEmailProv;
        private System.Windows.Forms.TextBox txtEmailProv;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}