namespace Lam7ara.Forms.tecnical {
    partial class FormTecnico {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null))
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
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.dgvReparaciones = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelVSep = new System.Windows.Forms.Panel();
            this.panelDer = new System.Windows.Forms.Panel();
            this.lblSecForm = new System.Windows.Forms.Label();
            this.panelSepForm = new System.Windows.Forms.Panel();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.lblNombreDueno = new System.Windows.Forms.Label();
            this.txtNombreDueno = new System.Windows.Forms.TextBox();
            this.lblApellidoDueno = new System.Windows.Forms.Label();
            this.txtApellidoDueno = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.txtPresupuesto = new System.Windows.Forms.TextBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblEstadoLabel = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelIzq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).BeginInit();
            this.panelDer.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzq
            // 
            this.panelIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelIzq.Controls.Add(this.dgvReparaciones);
            this.panelIzq.Controls.Add(this.cmbFiltroEstado);
            this.panelIzq.Controls.Add(this.btnMostrarTodos);
            this.panelIzq.Controls.Add(this.btnBuscar);
            this.panelIzq.Controls.Add(this.txtBuscar);
            this.panelIzq.Controls.Add(this.lblSecLista);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(670, 680);
            this.panelIzq.TabIndex = 0;
            // 
            // lblSecLista
            // 
            this.lblSecLista.BackColor = System.Drawing.Color.Transparent;
            this.lblSecLista.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecLista.Location = new System.Drawing.Point(0, 0);
            this.lblSecLista.Name = "lblSecLista";
            this.lblSecLista.Size = new System.Drawing.Size(670, 22);
            this.lblSecLista.TabIndex = 0;
            this.lblSecLista.Text = "REPARACIONES";
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.txtBuscar.Location = new System.Drawing.Point(0, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(300, 34);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "Buscar equipo, dueno o telefono...";
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(308, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltroEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmbFiltroEstado.Items.AddRange(new object [ ] { "Todos", "Ingresado", "En proceso", "Listo", "Entregado" });
            this.cmbFiltroEstado.Location = new System.Drawing.Point(416, 28);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.SelectedIndex = 0;
            this.cmbFiltroEstado.Size = new System.Drawing.Size(130, 28);
            this.cmbFiltroEstado.TabIndex = 3;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnMostrarTodos.FlatAppearance.BorderSize = 1;
            this.btnMostrarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnMostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnMostrarTodos.Location = new System.Drawing.Point(554, 26);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(116, 38);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // dgvReparaciones
            // 
            this.dgvReparaciones.AllowUserToAddRows = false;
            this.dgvReparaciones.AllowUserToDeleteRows = false;
            this.dgvReparaciones.AllowUserToResizeRows = false;
            this.dgvReparaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.dgvReparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReparaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReparaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.dgvReparaciones.ColumnHeadersHeight = 34;
            this.dgvReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn [ ] {
                this.colID, this.colEquipo, this.colDueno, this.colTelefono,
                this.colFechaIngreso, this.colFechaEntrega, this.colPresupuesto, this.colEstado });
            this.dgvReparaciones.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.dgvReparaciones.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvReparaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            this.dgvReparaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvReparaciones.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.dgvReparaciones.EnableHeadersVisualStyles = false;
            this.dgvReparaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.dgvReparaciones.Location = new System.Drawing.Point(0, 74);
            this.dgvReparaciones.MultiSelect = false;
            this.dgvReparaciones.Name = "dgvReparaciones";
            this.dgvReparaciones.ReadOnly = true;
            this.dgvReparaciones.RowHeadersVisible = false;
            this.dgvReparaciones.RowTemplate.Height = 38;
            this.dgvReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReparaciones.Size = new System.Drawing.Size(670, 606);
            this.dgvReparaciones.TabIndex = 5;
            this.dgvReparaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReparaciones_CellClick);
            this.dgvReparaciones.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvReparaciones_RowPrePaint);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            this.colID.Width = 40;
            // 
            // colEquipo
            // 
            this.colEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEquipo.HeaderText = "Equipo";
            this.colEquipo.Name = "colEquipo";
            // 
            // colDueno
            // 
            this.colDueno.HeaderText = "Dueno";
            this.colDueno.Name = "colDueno";
            this.colDueno.Width = 130;
            // 
            // colTelefono
            // 
            this.colTelefono.HeaderText = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Width = 100;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.HeaderText = "Ingreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Width = 86;
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.HeaderText = "Est. Entrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            this.colFechaEntrega.Width = 86;
            // 
            // colPresupuesto
            // 
            this.colPresupuesto.HeaderText = "Presupuesto";
            this.colPresupuesto.Name = "colPresupuesto";
            this.colPresupuesto.Width = 90;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 90;
            // 
            // panelVSep
            // 
            this.panelVSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelVSep.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVSep.Name = "panelVSep";
            this.panelVSep.Size = new System.Drawing.Size(1, 680);
            this.panelVSep.TabIndex = 1;
            // 
            // panelDer
            // 
            this.panelDer.AutoScroll = true;
            this.panelDer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelDer.Controls.Add(this.panelBotones);
            this.panelDer.Controls.Add(this.cmbEstado);
            this.panelDer.Controls.Add(this.lblEstadoLabel);
            this.panelDer.Controls.Add(this.txtObservaciones);
            this.panelDer.Controls.Add(this.lblObservaciones);
            this.panelDer.Controls.Add(this.dtpFechaEntrega);
            this.panelDer.Controls.Add(this.lblFechaEntrega);
            this.panelDer.Controls.Add(this.dtpFechaIngreso);
            this.panelDer.Controls.Add(this.lblFechaIngreso);
            this.panelDer.Controls.Add(this.txtPresupuesto);
            this.panelDer.Controls.Add(this.lblPresupuesto);
            this.panelDer.Controls.Add(this.txtDescripcion);
            this.panelDer.Controls.Add(this.lblDescripcion);
            this.panelDer.Controls.Add(this.txtTelefono);
            this.panelDer.Controls.Add(this.lblTelefono);
            this.panelDer.Controls.Add(this.txtApellidoDueno);
            this.panelDer.Controls.Add(this.lblApellidoDueno);
            this.panelDer.Controls.Add(this.txtNombreDueno);
            this.panelDer.Controls.Add(this.lblNombreDueno);
            this.panelDer.Controls.Add(this.txtNombreEquipo);
            this.panelDer.Controls.Add(this.lblNombreEquipo);
            this.panelDer.Controls.Add(this.panelSepForm);
            this.panelDer.Controls.Add(this.lblSecForm);
            this.panelDer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDer.Name = "panelDer";
            this.panelDer.Padding = new System.Windows.Forms.Padding(20, 0, 12, 0);
            this.panelDer.TabIndex = 2;
            // 
            // lblSecForm
            // 
            this.lblSecForm.BackColor = System.Drawing.Color.Transparent;
            this.lblSecForm.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecForm.Location = new System.Drawing.Point(20, 0);
            this.lblSecForm.Name = "lblSecForm";
            this.lblSecForm.Size = new System.Drawing.Size(380, 22);
            this.lblSecForm.TabIndex = 0;
            this.lblSecForm.Text = "DATOS DE REPARACION";
            // 
            // panelSepForm
            // 
            this.panelSepForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepForm.Location = new System.Drawing.Point(20, 26);
            this.panelSepForm.Name = "panelSepForm";
            this.panelSepForm.Size = new System.Drawing.Size(380, 1);
            this.panelSepForm.TabIndex = 1;
            // 
            // lblNombreEquipo
            // 
            this.lblNombreEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEquipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNombreEquipo.Location = new System.Drawing.Point(20, 36);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(380, 18);
            this.lblNombreEquipo.TabIndex = 2;
            this.lblNombreEquipo.Text = "Nombre del equipo";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtNombreEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEquipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEquipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNombreEquipo.Location = new System.Drawing.Point(20, 56);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(380, 34);
            this.txtNombreEquipo.TabIndex = 3;
            // 
            // lblNombreDueno
            // 
            this.lblNombreDueno.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreDueno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNombreDueno.Location = new System.Drawing.Point(20, 104);
            this.lblNombreDueno.Name = "lblNombreDueno";
            this.lblNombreDueno.Size = new System.Drawing.Size(185, 18);
            this.lblNombreDueno.TabIndex = 4;
            this.lblNombreDueno.Text = "Nombre";
            // 
            // txtNombreDueno
            // 
            this.txtNombreDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtNombreDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDueno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtNombreDueno.Location = new System.Drawing.Point(20, 124);
            this.txtNombreDueno.Name = "txtNombreDueno";
            this.txtNombreDueno.Size = new System.Drawing.Size(185, 34);
            this.txtNombreDueno.TabIndex = 5;
            // 
            // lblApellidoDueno
            // 
            this.lblApellidoDueno.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoDueno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblApellidoDueno.Location = new System.Drawing.Point(215, 104);
            this.lblApellidoDueno.Name = "lblApellidoDueno";
            this.lblApellidoDueno.Size = new System.Drawing.Size(185, 18);
            this.lblApellidoDueno.TabIndex = 6;
            this.lblApellidoDueno.Text = "Apellido";
            // 
            // txtApellidoDueno
            // 
            this.txtApellidoDueno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtApellidoDueno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoDueno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoDueno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtApellidoDueno.Location = new System.Drawing.Point(215, 124);
            this.txtApellidoDueno.Name = "txtApellidoDueno";
            this.txtApellidoDueno.Size = new System.Drawing.Size(185, 34);
            this.txtApellidoDueno.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTelefono.Location = new System.Drawing.Point(20, 172);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(380, 18);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtTelefono.Location = new System.Drawing.Point(20, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(380, 34);
            this.txtTelefono.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDescripcion.Location = new System.Drawing.Point(20, 240);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(380, 18);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion del problema";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtDescripcion.Location = new System.Drawing.Point(20, 260);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(380, 58);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPresupuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPresupuesto.Location = new System.Drawing.Point(20, 332);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(380, 18);
            this.lblPresupuesto.TabIndex = 12;
            this.lblPresupuesto.Text = "Presupuesto ($)";
            // 
            // txtPresupuesto
            // 
            this.txtPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPresupuesto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresupuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtPresupuesto.Location = new System.Drawing.Point(20, 352);
            this.txtPresupuesto.Name = "txtPresupuesto";
            this.txtPresupuesto.Size = new System.Drawing.Size(380, 34);
            this.txtPresupuesto.TabIndex = 13;
            this.txtPresupuesto.Text = "0";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFechaIngreso.Location = new System.Drawing.Point(20, 400);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(185, 18);
            this.lblFechaIngreso.TabIndex = 14;
            this.lblFechaIngreso.Text = "Fecha de ingreso";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(20, 420);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(185, 23);
            this.dtpFechaIngreso.TabIndex = 15;
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaEntrega.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFechaEntrega.Location = new System.Drawing.Point(215, 400);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(185, 18);
            this.lblFechaEntrega.TabIndex = 16;
            this.lblFechaEntrega.Text = "Fecha estimada entrega";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(215, 420);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(185, 23);
            this.dtpFechaEntrega.TabIndex = 17;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblObservaciones.Location = new System.Drawing.Point(20, 458);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(380, 18);
            this.lblObservaciones.TabIndex = 18;
            this.lblObservaciones.Text = "Observaciones internas";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtObservaciones.Location = new System.Drawing.Point(20, 478);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(380, 52);
            this.txtObservaciones.TabIndex = 19;
            // 
            // lblEstadoLabel
            // 
            this.lblEstadoLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblEstadoLabel.Location = new System.Drawing.Point(20, 544);
            this.lblEstadoLabel.Name = "lblEstadoLabel";
            this.lblEstadoLabel.Size = new System.Drawing.Size(380, 18);
            this.lblEstadoLabel.TabIndex = 20;
            this.lblEstadoLabel.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmbEstado.Items.AddRange(new object [ ] { "Ingresado", "En proceso", "Listo", "Entregado" });
            this.cmbEstado.Location = new System.Drawing.Point(20, 564);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.SelectedIndex = 0;
            this.cmbEstado.Size = new System.Drawing.Size(380, 34);
            this.cmbEstado.TabIndex = 21;
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Transparent;
            this.panelBotones.Controls.Add(this.btnNuevo);
            this.panelBotones.Controls.Add(this.btnGuardar);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnLimpiar);
            this.panelBotones.Location = new System.Drawing.Point(20, 612);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(380, 100);
            this.panelBotones.TabIndex = 22;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnNuevo.FlatAppearance.BorderSize = 1;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNuevo.Location = new System.Drawing.Point(0, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(183, 42);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo ingreso";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(193, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 42);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.FlatAppearance.BorderSize = 1;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnEliminar.Location = new System.Drawing.Point(0, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 42);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 1;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnLimpiar.Location = new System.Drawing.Point(193, 52);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 42);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1090, 720);
            this.Controls.Add(this.panelDer);
            this.Controls.Add(this.panelVSep);
            this.Controls.Add(this.panelIzq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTecnico";
            this.Text = "Tecnico";
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReparaciones)).EndInit();
            this.panelDer.ResumeLayout(false);
            this.panelDer.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Label lblSecLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.DataGridView dgvReparaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Panel panelVSep;
        private System.Windows.Forms.Panel panelDer;
        private System.Windows.Forms.Label lblSecForm;
        private System.Windows.Forms.Panel panelSepForm;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label lblNombreDueno;
        private System.Windows.Forms.TextBox txtNombreDueno;
        private System.Windows.Forms.Label lblApellidoDueno;
        private System.Windows.Forms.TextBox txtApellidoDueno;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.TextBox txtPresupuesto;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblEstadoLabel;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}