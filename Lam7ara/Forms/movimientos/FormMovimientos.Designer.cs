namespace Lam7ara.Forms.movimientos {
    partial class FormMovimientos {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null ))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEstadoCaja = new System.Windows.Forms.Panel();
            this.panelAccionesCaja = new System.Windows.Forms.Panel();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.txtMontoApertura = new System.Windows.Forms.TextBox();
            this.lblMontoAperturaLabel = new System.Windows.Forms.Label();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.lblResponsableLabel = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelCardEstado = new System.Windows.Forms.Panel();
            this.lblCardEstadoValor = new System.Windows.Forms.Label();
            this.lblCardEstadoTitulo = new System.Windows.Forms.Label();
            this.panelCardApertura = new System.Windows.Forms.Panel();
            this.lblCardAperturaValor = new System.Windows.Forms.Label();
            this.lblCardAperturaTitulo = new System.Windows.Forms.Label();
            this.panelCardSaldo = new System.Windows.Forms.Panel();
            this.lblCardSaldoValor = new System.Windows.Forms.Label();
            this.lblCardSaldoTitulo = new System.Windows.Forms.Label();
            this.panelCardVentas = new System.Windows.Forms.Panel();
            this.lblCardVentasValor = new System.Windows.Forms.Label();
            this.lblCardVentasTitulo = new System.Windows.Forms.Label();
            this.panelSepCaja = new System.Windows.Forms.Panel();
            this.lblSecCaja = new System.Windows.Forms.Label();
            this.panelSepMedio = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelDerMov = new System.Windows.Forms.Panel();
            this.btnRegistrarMov = new System.Windows.Forms.Button();
            this.txtRespMov = new System.Windows.Forms.TextBox();
            this.lblRespMovLabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcionLabel = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMontoLabel = new System.Windows.Forms.Label();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.lblTipoLabel = new System.Windows.Forms.Label();
            this.panelSepNuevoMov = new System.Windows.Forms.Panel();
            this.lblSecNuevoMov = new System.Windows.Forms.Label();
            this.panelVSepMov = new System.Windows.Forms.Panel();
            this.panelIzqMov = new System.Windows.Forms.Panel();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.colMovID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMovResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecMovimientos = new System.Windows.Forms.Label();
            this.panelSepHistorial = new System.Windows.Forms.Panel();
            this.panelHistorial = new System.Windows.Forms.Panel();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.colHisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisMontoApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisMontoCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHisResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSecHistorial = new System.Windows.Forms.Label();
            this.panelEstadoCaja.SuspendLayout();
            this.panelAccionesCaja.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelCardEstado.SuspendLayout();
            this.panelCardApertura.SuspendLayout();
            this.panelCardSaldo.SuspendLayout();
            this.panelCardVentas.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelDerMov.SuspendLayout();
            this.panelIzqMov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.panelHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEstadoCaja
            // 
            this.panelEstadoCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelEstadoCaja.Controls.Add(this.panelAccionesCaja);
            this.panelEstadoCaja.Controls.Add(this.panelCards);
            this.panelEstadoCaja.Controls.Add(this.panelSepCaja);
            this.panelEstadoCaja.Controls.Add(this.lblSecCaja);
            this.panelEstadoCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEstadoCaja.Location = new System.Drawing.Point(0, 0);
            this.panelEstadoCaja.Name = "panelEstadoCaja";
            this.panelEstadoCaja.Size = new System.Drawing.Size(934, 139);
            this.panelEstadoCaja.TabIndex = 0;
            // 
            // panelAccionesCaja
            // 
            this.panelAccionesCaja.BackColor = System.Drawing.Color.Transparent;
            this.panelAccionesCaja.Controls.Add(this.btnCerrarCaja);
            this.panelAccionesCaja.Controls.Add(this.btnAbrirCaja);
            this.panelAccionesCaja.Controls.Add(this.txtMontoApertura);
            this.panelAccionesCaja.Controls.Add(this.lblMontoAperturaLabel);
            this.panelAccionesCaja.Controls.Add(this.txtResponsable);
            this.panelAccionesCaja.Controls.Add(this.lblResponsableLabel);
            this.panelAccionesCaja.Location = new System.Drawing.Point(523, 26);
            this.panelAccionesCaja.Name = "panelAccionesCaja";
            this.panelAccionesCaja.Size = new System.Drawing.Size(408, 104);
            this.panelAccionesCaja.TabIndex = 3;
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarCaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCerrarCaja.Location = new System.Drawing.Point(168, 54);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(154, 36);
            this.btnCerrarCaja.TabIndex = 5;
            this.btnCerrarCaja.Text = "Cerrar caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnAbrirCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnAbrirCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCaja.Location = new System.Drawing.Point(0, 54);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(154, 36);
            this.btnAbrirCaja.TabIndex = 4;
            this.btnAbrirCaja.Text = "Abrir caja";
            this.btnAbrirCaja.UseVisualStyleBackColor = false;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // txtMontoApertura
            // 
            this.txtMontoApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoApertura.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoApertura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtMontoApertura.Location = new System.Drawing.Point(202, 17);
            this.txtMontoApertura.Name = "txtMontoApertura";
            this.txtMontoApertura.Size = new System.Drawing.Size(120, 25);
            this.txtMontoApertura.TabIndex = 3;
            this.txtMontoApertura.Text = "0";
            // 
            // lblMontoAperturaLabel
            // 
            this.lblMontoAperturaLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoAperturaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAperturaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblMontoAperturaLabel.Location = new System.Drawing.Point(202, 0);
            this.lblMontoAperturaLabel.Name = "lblMontoAperturaLabel";
            this.lblMontoAperturaLabel.Size = new System.Drawing.Size(120, 16);
            this.lblMontoAperturaLabel.TabIndex = 2;
            this.lblMontoAperturaLabel.Text = "Monto apertura";
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponsable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtResponsable.Location = new System.Drawing.Point(0, 17);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(189, 25);
            this.txtResponsable.TabIndex = 1;
            // 
            // lblResponsableLabel
            // 
            this.lblResponsableLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblResponsableLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblResponsableLabel.Location = new System.Drawing.Point(0, 0);
            this.lblResponsableLabel.Name = "lblResponsableLabel";
            this.lblResponsableLabel.Size = new System.Drawing.Size(189, 16);
            this.lblResponsableLabel.TabIndex = 0;
            this.lblResponsableLabel.Text = "Responsable";
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.panelCardEstado);
            this.panelCards.Controls.Add(this.panelCardApertura);
            this.panelCards.Controls.Add(this.panelCardSaldo);
            this.panelCards.Controls.Add(this.panelCardVentas);
            this.panelCards.Location = new System.Drawing.Point(0, 26);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(497, 104);
            this.panelCards.TabIndex = 2;
            // 
            // panelCardEstado
            // 
            this.panelCardEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelCardEstado.Controls.Add(this.lblCardEstadoValor);
            this.panelCardEstado.Controls.Add(this.lblCardEstadoTitulo);
            this.panelCardEstado.Location = new System.Drawing.Point(0, 0);
            this.panelCardEstado.Name = "panelCardEstado";
            this.panelCardEstado.Size = new System.Drawing.Size(115, 95);
            this.panelCardEstado.TabIndex = 0;
            // 
            // lblCardEstadoValor
            // 
            this.lblCardEstadoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardEstadoValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardEstadoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardEstadoValor.Location = new System.Drawing.Point(10, 31);
            this.lblCardEstadoValor.Name = "lblCardEstadoValor";
            this.lblCardEstadoValor.Size = new System.Drawing.Size(94, 52);
            this.lblCardEstadoValor.TabIndex = 1;
            this.lblCardEstadoValor.Text = "Cerrada";
            this.lblCardEstadoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardEstadoTitulo
            // 
            this.lblCardEstadoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardEstadoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardEstadoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardEstadoTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardEstadoTitulo.Name = "lblCardEstadoTitulo";
            this.lblCardEstadoTitulo.Size = new System.Drawing.Size(94, 14);
            this.lblCardEstadoTitulo.TabIndex = 0;
            this.lblCardEstadoTitulo.Text = "Estado";
            // 
            // panelCardApertura
            // 
            this.panelCardApertura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelCardApertura.Controls.Add(this.lblCardAperturaValor);
            this.panelCardApertura.Controls.Add(this.lblCardAperturaTitulo);
            this.panelCardApertura.Location = new System.Drawing.Point(127, 0);
            this.panelCardApertura.Name = "panelCardApertura";
            this.panelCardApertura.Size = new System.Drawing.Size(115, 95);
            this.panelCardApertura.TabIndex = 1;
            // 
            // lblCardAperturaValor
            // 
            this.lblCardAperturaValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAperturaValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardAperturaValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblCardAperturaValor.Location = new System.Drawing.Point(10, 31);
            this.lblCardAperturaValor.Name = "lblCardAperturaValor";
            this.lblCardAperturaValor.Size = new System.Drawing.Size(94, 52);
            this.lblCardAperturaValor.TabIndex = 1;
            this.lblCardAperturaValor.Text = "$0,00";
            this.lblCardAperturaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardAperturaTitulo
            // 
            this.lblCardAperturaTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardAperturaTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardAperturaTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardAperturaTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardAperturaTitulo.Name = "lblCardAperturaTitulo";
            this.lblCardAperturaTitulo.Size = new System.Drawing.Size(94, 14);
            this.lblCardAperturaTitulo.TabIndex = 0;
            this.lblCardAperturaTitulo.Text = "Monto apertura";
            // 
            // panelCardSaldo
            // 
            this.panelCardSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelCardSaldo.Controls.Add(this.lblCardSaldoValor);
            this.panelCardSaldo.Controls.Add(this.lblCardSaldoTitulo);
            this.panelCardSaldo.Location = new System.Drawing.Point(254, 0);
            this.panelCardSaldo.Name = "panelCardSaldo";
            this.panelCardSaldo.Size = new System.Drawing.Size(115, 95);
            this.panelCardSaldo.TabIndex = 2;
            // 
            // lblCardSaldoValor
            // 
            this.lblCardSaldoValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardSaldoValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardSaldoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblCardSaldoValor.Location = new System.Drawing.Point(10, 31);
            this.lblCardSaldoValor.Name = "lblCardSaldoValor";
            this.lblCardSaldoValor.Size = new System.Drawing.Size(94, 52);
            this.lblCardSaldoValor.TabIndex = 1;
            this.lblCardSaldoValor.Text = "$0,00";
            this.lblCardSaldoValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardSaldoTitulo
            // 
            this.lblCardSaldoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardSaldoTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardSaldoTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardSaldoTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardSaldoTitulo.Name = "lblCardSaldoTitulo";
            this.lblCardSaldoTitulo.Size = new System.Drawing.Size(94, 14);
            this.lblCardSaldoTitulo.TabIndex = 0;
            this.lblCardSaldoTitulo.Text = "Saldo actual";
            // 
            // panelCardVentas
            // 
            this.panelCardVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelCardVentas.Controls.Add(this.lblCardVentasValor);
            this.panelCardVentas.Controls.Add(this.lblCardVentasTitulo);
            this.panelCardVentas.Location = new System.Drawing.Point(381, 0);
            this.panelCardVentas.Name = "panelCardVentas";
            this.panelCardVentas.Size = new System.Drawing.Size(115, 95);
            this.panelCardVentas.TabIndex = 3;
            // 
            // lblCardVentasValor
            // 
            this.lblCardVentasValor.BackColor = System.Drawing.Color.Transparent;
            this.lblCardVentasValor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardVentasValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
            this.lblCardVentasValor.Location = new System.Drawing.Point(10, 31);
            this.lblCardVentasValor.Name = "lblCardVentasValor";
            this.lblCardVentasValor.Size = new System.Drawing.Size(94, 52);
            this.lblCardVentasValor.TabIndex = 1;
            this.lblCardVentasValor.Text = "$0,00";
            this.lblCardVentasValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardVentasTitulo
            // 
            this.lblCardVentasTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardVentasTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardVentasTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCardVentasTitulo.Location = new System.Drawing.Point(10, 10);
            this.lblCardVentasTitulo.Name = "lblCardVentasTitulo";
            this.lblCardVentasTitulo.Size = new System.Drawing.Size(94, 14);
            this.lblCardVentasTitulo.TabIndex = 0;
            this.lblCardVentasTitulo.Text = "Ventas del dia";
            // 
            // panelSepCaja
            // 
            this.panelSepCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepCaja.Location = new System.Drawing.Point(0, 19);
            this.panelSepCaja.Name = "panelSepCaja";
            this.panelSepCaja.Size = new System.Drawing.Size(934, 1);
            this.panelSepCaja.TabIndex = 1;
            // 
            // lblSecCaja
            // 
            this.lblSecCaja.BackColor = System.Drawing.Color.Transparent;
            this.lblSecCaja.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecCaja.Location = new System.Drawing.Point(0, 0);
            this.lblSecCaja.Name = "lblSecCaja";
            this.lblSecCaja.Size = new System.Drawing.Size(257, 19);
            this.lblSecCaja.TabIndex = 0;
            this.lblSecCaja.Text = "ESTADO DE CAJA";
            // 
            // panelSepMedio
            // 
            this.panelSepMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepMedio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSepMedio.Location = new System.Drawing.Point(0, 139);
            this.panelSepMedio.Name = "panelSepMedio";
            this.panelSepMedio.Size = new System.Drawing.Size(934, 1);
            this.panelSepMedio.TabIndex = 1;
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelContenido.Controls.Add(this.panelDerMov);
            this.panelContenido.Controls.Add(this.panelVSepMov);
            this.panelContenido.Controls.Add(this.panelIzqMov);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContenido.Location = new System.Drawing.Point(0, 140);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(934, 260);
            this.panelContenido.TabIndex = 2;
            // 
            // panelDerMov
            // 
            this.panelDerMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelDerMov.Controls.Add(this.btnRegistrarMov);
            this.panelDerMov.Controls.Add(this.txtRespMov);
            this.panelDerMov.Controls.Add(this.lblRespMovLabel);
            this.panelDerMov.Controls.Add(this.txtDescripcion);
            this.panelDerMov.Controls.Add(this.lblDescripcionLabel);
            this.panelDerMov.Controls.Add(this.txtMonto);
            this.panelDerMov.Controls.Add(this.lblMontoLabel);
            this.panelDerMov.Controls.Add(this.rbEgreso);
            this.panelDerMov.Controls.Add(this.rbIngreso);
            this.panelDerMov.Controls.Add(this.lblTipoLabel);
            this.panelDerMov.Controls.Add(this.panelSepNuevoMov);
            this.panelDerMov.Controls.Add(this.lblSecNuevoMov);
            this.panelDerMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDerMov.Location = new System.Drawing.Point(584, 0);
            this.panelDerMov.Name = "panelDerMov";
            this.panelDerMov.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.panelDerMov.Size = new System.Drawing.Size(350, 260);
            this.panelDerMov.TabIndex = 2;
            // 
            // btnRegistrarMov
            // 
            this.btnRegistrarMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnRegistrarMov.FlatAppearance.BorderSize = 0;
            this.btnRegistrarMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(82)))), ((int)(((byte)(221)))));
            this.btnRegistrarMov.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btnRegistrarMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarMov.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarMov.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarMov.Location = new System.Drawing.Point(21, 220);
            this.btnRegistrarMov.Name = "btnRegistrarMov";
            this.btnRegistrarMov.Size = new System.Drawing.Size(309, 36);
            this.btnRegistrarMov.TabIndex = 11;
            this.btnRegistrarMov.Text = "Registrar movimiento";
            this.btnRegistrarMov.UseVisualStyleBackColor = false;
            this.btnRegistrarMov.Click += new System.EventHandler(this.btnRegistrarMov_Click);
            // 
            // txtRespMov
            // 
            this.txtRespMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtRespMov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRespMov.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespMov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtRespMov.Location = new System.Drawing.Point(21, 187);
            this.txtRespMov.Name = "txtRespMov";
            this.txtRespMov.Size = new System.Drawing.Size(309, 27);
            this.txtRespMov.TabIndex = 10;
            // 
            // lblRespMovLabel
            // 
            this.lblRespMovLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblRespMovLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespMovLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblRespMovLabel.Location = new System.Drawing.Point(21, 170);
            this.lblRespMovLabel.Name = "lblRespMovLabel";
            this.lblRespMovLabel.Size = new System.Drawing.Size(309, 16);
            this.lblRespMovLabel.TabIndex = 9;
            this.lblRespMovLabel.Text = "Responsable";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtDescripcion.Location = new System.Drawing.Point(21, 139);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(309, 27);
            this.txtDescripcion.TabIndex = 8;
            // 
            // lblDescripcionLabel
            // 
            this.lblDescripcionLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDescripcionLabel.Location = new System.Drawing.Point(21, 121);
            this.lblDescripcionLabel.Name = "lblDescripcionLabel";
            this.lblDescripcionLabel.Size = new System.Drawing.Size(309, 16);
            this.lblDescripcionLabel.TabIndex = 7;
            this.lblDescripcionLabel.Text = "Descripcion";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtMonto.Location = new System.Drawing.Point(21, 90);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(309, 27);
            this.txtMonto.TabIndex = 6;
            this.txtMonto.Text = "0";
            // 
            // lblMontoLabel
            // 
            this.lblMontoLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblMontoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblMontoLabel.Location = new System.Drawing.Point(21, 72);
            this.lblMontoLabel.Name = "lblMontoLabel";
            this.lblMontoLabel.Size = new System.Drawing.Size(309, 16);
            this.lblMontoLabel.TabIndex = 5;
            this.lblMontoLabel.Text = "Monto";
            // 
            // rbEgreso
            // 
            this.rbEgreso.BackColor = System.Drawing.Color.Transparent;
            this.rbEgreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(165)))), ((int)(((byte)(165)))));
            this.rbEgreso.Location = new System.Drawing.Point(123, 50);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(94, 23);
            this.rbEgreso.TabIndex = 4;
            this.rbEgreso.Text = "Egreso";
            this.rbEgreso.UseVisualStyleBackColor = false;
            // 
            // rbIngreso
            // 
            this.rbIngreso.BackColor = System.Drawing.Color.Transparent;
            this.rbIngreso.Checked = true;
            this.rbIngreso.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIngreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(222)))), ((int)(((byte)(128)))));
            this.rbIngreso.Location = new System.Drawing.Point(21, 50);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(94, 23);
            this.rbIngreso.TabIndex = 3;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "Ingreso";
            this.rbIngreso.UseVisualStyleBackColor = false;
            // 
            // lblTipoLabel
            // 
            this.lblTipoLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTipoLabel.Location = new System.Drawing.Point(21, 33);
            this.lblTipoLabel.Name = "lblTipoLabel";
            this.lblTipoLabel.Size = new System.Drawing.Size(309, 16);
            this.lblTipoLabel.TabIndex = 2;
            this.lblTipoLabel.Text = "Tipo";
            // 
            // panelSepNuevoMov
            // 
            this.panelSepNuevoMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepNuevoMov.Location = new System.Drawing.Point(21, 24);
            this.panelSepNuevoMov.Name = "panelSepNuevoMov";
            this.panelSepNuevoMov.Size = new System.Drawing.Size(309, 1);
            this.panelSepNuevoMov.TabIndex = 1;
            // 
            // lblSecNuevoMov
            // 
            this.lblSecNuevoMov.BackColor = System.Drawing.Color.Transparent;
            this.lblSecNuevoMov.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecNuevoMov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecNuevoMov.Location = new System.Drawing.Point(21, 0);
            this.lblSecNuevoMov.Name = "lblSecNuevoMov";
            this.lblSecNuevoMov.Size = new System.Drawing.Size(309, 19);
            this.lblSecNuevoMov.TabIndex = 0;
            this.lblSecNuevoMov.Text = "REGISTRAR MOVIMIENTO";
            // 
            // panelVSepMov
            // 
            this.panelVSepMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelVSepMov.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVSepMov.Location = new System.Drawing.Point(583, 0);
            this.panelVSepMov.Name = "panelVSepMov";
            this.panelVSepMov.Size = new System.Drawing.Size(1, 260);
            this.panelVSepMov.TabIndex = 1;
            // 
            // panelIzqMov
            // 
            this.panelIzqMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelIzqMov.Controls.Add(this.dgvMovimientos);
            this.panelIzqMov.Controls.Add(this.lblSecMovimientos);
            this.panelIzqMov.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzqMov.Location = new System.Drawing.Point(0, 0);
            this.panelIzqMov.Name = "panelIzqMov";
            this.panelIzqMov.Size = new System.Drawing.Size(583, 260);
            this.panelIzqMov.TabIndex = 0;
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.AllowUserToAddRows = false;
            this.dgvMovimientos.AllowUserToDeleteRows = false;
            this.dgvMovimientos.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.dgvMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMovimientos.ColumnHeadersHeight = 34;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMovID,
            this.colMovFecha,
            this.colMovTipo,
            this.colMovMonto,
            this.colMovDescripcion,
            this.colMovResponsable});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMovimientos.EnableHeadersVisualStyles = false;
            this.dgvMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 24);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.RowTemplate.Height = 36;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(583, 236);
            this.dgvMovimientos.TabIndex = 1;
            // 
            // colMovID
            // 
            this.colMovID.HeaderText = "ID";
            this.colMovID.Name = "colMovID";
            this.colMovID.ReadOnly = true;
            this.colMovID.Visible = false;
            this.colMovID.Width = 40;
            // 
            // colMovFecha
            // 
            this.colMovFecha.HeaderText = "Fecha";
            this.colMovFecha.Name = "colMovFecha";
            this.colMovFecha.ReadOnly = true;
            this.colMovFecha.Width = 140;
            // 
            // colMovTipo
            // 
            this.colMovTipo.HeaderText = "Tipo";
            this.colMovTipo.Name = "colMovTipo";
            this.colMovTipo.ReadOnly = true;
            this.colMovTipo.Width = 80;
            // 
            // colMovMonto
            // 
            this.colMovMonto.HeaderText = "Monto";
            this.colMovMonto.Name = "colMovMonto";
            this.colMovMonto.ReadOnly = true;
            // 
            // colMovDescripcion
            // 
            this.colMovDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMovDescripcion.HeaderText = "Descripcion";
            this.colMovDescripcion.Name = "colMovDescripcion";
            this.colMovDescripcion.ReadOnly = true;
            // 
            // colMovResponsable
            // 
            this.colMovResponsable.HeaderText = "Responsable";
            this.colMovResponsable.Name = "colMovResponsable";
            this.colMovResponsable.ReadOnly = true;
            this.colMovResponsable.Width = 110;
            // 
            // lblSecMovimientos
            // 
            this.lblSecMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.lblSecMovimientos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecMovimientos.Location = new System.Drawing.Point(0, 0);
            this.lblSecMovimientos.Name = "lblSecMovimientos";
            this.lblSecMovimientos.Size = new System.Drawing.Size(583, 19);
            this.lblSecMovimientos.TabIndex = 0;
            this.lblSecMovimientos.Text = "MOVIMIENTOS DE CAJA ACTUAL";
            // 
            // panelSepHistorial
            // 
            this.panelSepHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepHistorial.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSepHistorial.Location = new System.Drawing.Point(0, 400);
            this.panelSepHistorial.Name = "panelSepHistorial";
            this.panelSepHistorial.Size = new System.Drawing.Size(934, 1);
            this.panelSepHistorial.TabIndex = 3;
            // 
            // panelHistorial
            // 
            this.panelHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelHistorial.Controls.Add(this.dgvHistorial);
            this.panelHistorial.Controls.Add(this.lblSecHistorial);
            this.panelHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHistorial.Location = new System.Drawing.Point(0, 401);
            this.panelHistorial.Name = "panelHistorial";
            this.panelHistorial.Size = new System.Drawing.Size(934, 265);
            this.panelHistorial.TabIndex = 4;
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(52)))));
            this.dgvHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvHistorial.ColumnHeadersHeight = 34;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHisID,
            this.colHisApertura,
            this.colHisMontoApertura,
            this.colHisCierre,
            this.colHisMontoCierre,
            this.colHisEstado,
            this.colHisResponsable});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHistorial.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistorial.EnableHeadersVisualStyles = false;
            this.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.dgvHistorial.Location = new System.Drawing.Point(0, 0);
            this.dgvHistorial.MultiSelect = false;
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowTemplate.Height = 36;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(934, 265);
            this.dgvHistorial.TabIndex = 1;
            // 
            // colHisID
            // 
            this.colHisID.HeaderText = "ID";
            this.colHisID.Name = "colHisID";
            this.colHisID.ReadOnly = true;
            this.colHisID.Visible = false;
            this.colHisID.Width = 40;
            // 
            // colHisApertura
            // 
            this.colHisApertura.HeaderText = "Apertura";
            this.colHisApertura.Name = "colHisApertura";
            this.colHisApertura.ReadOnly = true;
            this.colHisApertura.Width = 150;
            // 
            // colHisMontoApertura
            // 
            this.colHisMontoApertura.HeaderText = "Monto apertura";
            this.colHisMontoApertura.Name = "colHisMontoApertura";
            this.colHisMontoApertura.ReadOnly = true;
            this.colHisMontoApertura.Width = 120;
            // 
            // colHisCierre
            // 
            this.colHisCierre.HeaderText = "Cierre";
            this.colHisCierre.Name = "colHisCierre";
            this.colHisCierre.ReadOnly = true;
            this.colHisCierre.Width = 150;
            // 
            // colHisMontoCierre
            // 
            this.colHisMontoCierre.HeaderText = "Monto cierre";
            this.colHisMontoCierre.Name = "colHisMontoCierre";
            this.colHisMontoCierre.ReadOnly = true;
            this.colHisMontoCierre.Width = 120;
            // 
            // colHisEstado
            // 
            this.colHisEstado.HeaderText = "Estado";
            this.colHisEstado.Name = "colHisEstado";
            this.colHisEstado.ReadOnly = true;
            this.colHisEstado.Width = 90;
            // 
            // colHisResponsable
            // 
            this.colHisResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHisResponsable.HeaderText = "Responsable";
            this.colHisResponsable.Name = "colHisResponsable";
            this.colHisResponsable.ReadOnly = true;
            // 
            // lblSecHistorial
            // 
            this.lblSecHistorial.BackColor = System.Drawing.Color.Transparent;
            this.lblSecHistorial.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecHistorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSecHistorial.Location = new System.Drawing.Point(0, 0);
            this.lblSecHistorial.Name = "lblSecHistorial";
            this.lblSecHistorial.Size = new System.Drawing.Size(934, 19);
            this.lblSecHistorial.TabIndex = 0;
            this.lblSecHistorial.Text = "HISTORIAL DE CAJAS";
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(934, 666);
            this.Controls.Add(this.panelHistorial);
            this.Controls.Add(this.panelSepHistorial);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelSepMedio);
            this.Controls.Add(this.panelEstadoCaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientos";
            this.Text = "Movimientos";
            this.panelEstadoCaja.ResumeLayout(false);
            this.panelAccionesCaja.ResumeLayout(false);
            this.panelAccionesCaja.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelCardEstado.ResumeLayout(false);
            this.panelCardApertura.ResumeLayout(false);
            this.panelCardSaldo.ResumeLayout(false);
            this.panelCardVentas.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelDerMov.ResumeLayout(false);
            this.panelDerMov.PerformLayout();
            this.panelIzqMov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.panelHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEstadoCaja;
        private System.Windows.Forms.Label lblSecCaja;
        private System.Windows.Forms.Panel panelSepCaja;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelCardEstado;
        private System.Windows.Forms.Label lblCardEstadoTitulo;
        private System.Windows.Forms.Label lblCardEstadoValor;
        private System.Windows.Forms.Panel panelCardApertura;
        private System.Windows.Forms.Label lblCardAperturaTitulo;
        private System.Windows.Forms.Label lblCardAperturaValor;
        private System.Windows.Forms.Panel panelCardSaldo;
        private System.Windows.Forms.Label lblCardSaldoTitulo;
        private System.Windows.Forms.Label lblCardSaldoValor;
        private System.Windows.Forms.Panel panelCardVentas;
        private System.Windows.Forms.Label lblCardVentasTitulo;
        private System.Windows.Forms.Label lblCardVentasValor;
        private System.Windows.Forms.Panel panelAccionesCaja;
        private System.Windows.Forms.Label lblResponsableLabel;
        private System.Windows.Forms.TextBox txtResponsable;
        private System.Windows.Forms.Label lblMontoAperturaLabel;
        private System.Windows.Forms.TextBox txtMontoApertura;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Panel panelSepMedio;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelIzqMov;
        private System.Windows.Forms.Label lblSecMovimientos;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMovResponsable;
        private System.Windows.Forms.Panel panelVSepMov;
        private System.Windows.Forms.Panel panelDerMov;
        private System.Windows.Forms.Label lblSecNuevoMov;
        private System.Windows.Forms.Panel panelSepNuevoMov;
        private System.Windows.Forms.Label lblTipoLabel;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.Label lblMontoLabel;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblDescripcionLabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblRespMovLabel;
        private System.Windows.Forms.TextBox txtRespMov;
        private System.Windows.Forms.Button btnRegistrarMov;
        private System.Windows.Forms.Panel panelSepHistorial;
        private System.Windows.Forms.Panel panelHistorial;
        private System.Windows.Forms.Label lblSecHistorial;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisMontoApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisMontoCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHisResponsable;
    }
}