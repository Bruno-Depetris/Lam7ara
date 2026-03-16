namespace Lam7ara {
    partial class FormMAIN {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelSidebarHeader = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogoChar = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppSubtitle = new System.Windows.Forms.Label();
            this.panelSep1 = new System.Windows.Forms.Panel();
            this.lblNavSection = new System.Windows.Forms.Label();
            this.btnNavInicio = new System.Windows.Forms.Button();
            this.btnNavVender = new System.Windows.Forms.Button();
            this.btnNavClientes = new System.Windows.Forms.Button();
            this.btnNavStock = new System.Windows.Forms.Button();
            this.btnNavTecnico = new System.Windows.Forms.Button();
            this.panelSidebarFooter = new System.Windows.Forms.Panel();
            this.panelSepFooter = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panelActiveIndicator = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMainContent = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnWinMinimize = new System.Windows.Forms.Button();
            this.btnWinClose = new System.Windows.Forms.Button();
            this.panelTopBarSep = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panelSidebarHeader.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelSidebarFooter.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelSidebar.Controls.Add(this.panelSidebarHeader);
            this.panelSidebar.Controls.Add(this.panelSep1);
            this.panelSidebar.Controls.Add(this.lblNavSection);
            this.panelSidebar.Controls.Add(this.btnNavInicio);
            this.panelSidebar.Controls.Add(this.btnNavVender);
            this.panelSidebar.Controls.Add(this.btnNavClientes);
            this.panelSidebar.Controls.Add(this.btnNavStock);
            this.panelSidebar.Controls.Add(this.btnNavTecnico);
            this.panelSidebar.Controls.Add(this.panelSidebarFooter);
            this.panelSidebar.Controls.Add(this.panelActiveIndicator);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(189, 666);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelSidebarHeader
            // 
            this.panelSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panelSidebarHeader.Controls.Add(this.panelLogo);
            this.panelSidebarHeader.Controls.Add(this.lblAppName);
            this.panelSidebarHeader.Controls.Add(this.lblAppSubtitle);
            this.panelSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarHeader.Name = "panelSidebarHeader";
            this.panelSidebarHeader.Size = new System.Drawing.Size(189, 78);
            this.panelSidebarHeader.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.panelLogo.Controls.Add(this.lblLogoChar);
            this.panelLogo.Location = new System.Drawing.Point(14, 21);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(36, 36);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogoChar
            // 
            this.lblLogoChar.BackColor = System.Drawing.Color.Transparent;
            this.lblLogoChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoChar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoChar.ForeColor = System.Drawing.Color.White;
            this.lblLogoChar.Location = new System.Drawing.Point(0, 0);
            this.lblLogoChar.Name = "lblLogoChar";
            this.lblLogoChar.Size = new System.Drawing.Size(36, 36);
            this.lblLogoChar.TabIndex = 0;
            this.lblLogoChar.Text = "L";
            this.lblLogoChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblAppName.Location = new System.Drawing.Point(58, 19);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(120, 23);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "Lam7ara";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppSubtitle
            // 
            this.lblAppSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAppSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblAppSubtitle.Location = new System.Drawing.Point(58, 43);
            this.lblAppSubtitle.Name = "lblAppSubtitle";
            this.lblAppSubtitle.Size = new System.Drawing.Size(120, 16);
            this.lblAppSubtitle.TabIndex = 2;
            this.lblAppSubtitle.Text = "Gestión Retail";
            this.lblAppSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelSep1
            // 
            this.panelSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSep1.Location = new System.Drawing.Point(0, 78);
            this.panelSep1.Name = "panelSep1";
            this.panelSep1.Size = new System.Drawing.Size(189, 1);
            this.panelSep1.TabIndex = 1;
            // 
            // lblNavSection
            // 
            this.lblNavSection.BackColor = System.Drawing.Color.Transparent;
            this.lblNavSection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNavSection.Location = new System.Drawing.Point(14, 87);
            this.lblNavSection.Name = "lblNavSection";
            this.lblNavSection.Size = new System.Drawing.Size(161, 23);
            this.lblNavSection.TabIndex = 2;
            this.lblNavSection.Text = "NAVEGACIÓN";
            this.lblNavSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNavInicio
            // 
            this.btnNavInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(43)))), ((int)(((byte)(85)))));
            this.btnNavInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavInicio.FlatAppearance.BorderSize = 0;
            this.btnNavInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(63)))), ((int)(((byte)(115)))));
            this.btnNavInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnNavInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavInicio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnNavInicio.Location = new System.Drawing.Point(0, 114);
            this.btnNavInicio.Name = "btnNavInicio";
            this.btnNavInicio.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnNavInicio.Size = new System.Drawing.Size(189, 43);
            this.btnNavInicio.TabIndex = 3;
            this.btnNavInicio.Text = "Inicio";
            this.btnNavInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavInicio.UseVisualStyleBackColor = false;
            this.btnNavInicio.Click += new System.EventHandler(this.btnNavInicio_Click);
            // 
            // btnNavVender
            // 
            this.btnNavVender.BackColor = System.Drawing.Color.Transparent;
            this.btnNavVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavVender.FlatAppearance.BorderSize = 0;
            this.btnNavVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnNavVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnNavVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVender.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavVender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavVender.Location = new System.Drawing.Point(0, 158);
            this.btnNavVender.Name = "btnNavVender";
            this.btnNavVender.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnNavVender.Size = new System.Drawing.Size(189, 43);
            this.btnNavVender.TabIndex = 4;
            this.btnNavVender.Text = "Vender";
            this.btnNavVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavVender.UseVisualStyleBackColor = false;
            this.btnNavVender.Click += new System.EventHandler(this.btnNavVender_Click);
            // 
            // btnNavClientes
            // 
            this.btnNavClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnNavClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavClientes.FlatAppearance.BorderSize = 0;
            this.btnNavClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnNavClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnNavClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavClientes.Location = new System.Drawing.Point(0, 201);
            this.btnNavClientes.Name = "btnNavClientes";
            this.btnNavClientes.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnNavClientes.Size = new System.Drawing.Size(189, 43);
            this.btnNavClientes.TabIndex = 5;
            this.btnNavClientes.Text = "Clientes";
            this.btnNavClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavClientes.UseVisualStyleBackColor = false;
            this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);
            // 
            // btnNavStock
            // 
            this.btnNavStock.BackColor = System.Drawing.Color.Transparent;
            this.btnNavStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStock.FlatAppearance.BorderSize = 0;
            this.btnNavStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnNavStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnNavStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavStock.Location = new System.Drawing.Point(0, 244);
            this.btnNavStock.Name = "btnNavStock";
            this.btnNavStock.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnNavStock.Size = new System.Drawing.Size(189, 43);
            this.btnNavStock.TabIndex = 6;
            this.btnNavStock.Text = "Stock";
            this.btnNavStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStock.UseVisualStyleBackColor = false;
            this.btnNavStock.Click += new System.EventHandler(this.btnNavStock_Click);
            // 
            // btnNavTecnico
            // 
            this.btnNavTecnico.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTecnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavTecnico.FlatAppearance.BorderSize = 0;
            this.btnNavTecnico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnNavTecnico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnNavTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTecnico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavTecnico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnNavTecnico.Location = new System.Drawing.Point(0, 288);
            this.btnNavTecnico.Name = "btnNavTecnico";
            this.btnNavTecnico.Padding = new System.Windows.Forms.Padding(21, 0, 0, 0);
            this.btnNavTecnico.Size = new System.Drawing.Size(189, 43);
            this.btnNavTecnico.TabIndex = 7;
            this.btnNavTecnico.Text = "Técnico";
            this.btnNavTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTecnico.UseVisualStyleBackColor = false;
            this.btnNavTecnico.Click += new System.EventHandler(this.btnNavTecnico_Click);
            // 
            // panelSidebarFooter
            // 
            this.panelSidebarFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panelSidebarFooter.Controls.Add(this.panelSepFooter);
            this.panelSidebarFooter.Controls.Add(this.lblDateTime);
            this.panelSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSidebarFooter.Location = new System.Drawing.Point(0, 607);
            this.panelSidebarFooter.Name = "panelSidebarFooter";
            this.panelSidebarFooter.Size = new System.Drawing.Size(189, 59);
            this.panelSidebarFooter.TabIndex = 9;
            // 
            // panelSepFooter
            // 
            this.panelSepFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelSepFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSepFooter.Location = new System.Drawing.Point(0, 0);
            this.panelSepFooter.Name = "panelSepFooter";
            this.panelSepFooter.Size = new System.Drawing.Size(189, 1);
            this.panelSepFooter.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDateTime.Location = new System.Drawing.Point(0, 1);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(189, 58);
            this.lblDateTime.TabIndex = 1;
            this.lblDateTime.Text = "00/00/0000\r\n00:00:00";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelActiveIndicator
            // 
            this.panelActiveIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.panelActiveIndicator.Location = new System.Drawing.Point(0, 114);
            this.panelActiveIndicator.Name = "panelActiveIndicator";
            this.panelActiveIndicator.Size = new System.Drawing.Size(3, 43);
            this.panelActiveIndicator.TabIndex = 8;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelContent.Controls.Add(this.panelMainContent);
            this.panelContent.Controls.Add(this.panelTopBar);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(189, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(982, 666);
            this.panelContent.TabIndex = 1;
            // 
            // panelMainContent
            // 
            this.panelMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.panelMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainContent.Location = new System.Drawing.Point(0, 57);
            this.panelMainContent.Name = "panelMainContent";
            this.panelMainContent.Padding = new System.Windows.Forms.Padding(24, 24, 24, 24);
            this.panelMainContent.Size = new System.Drawing.Size(982, 609);
            this.panelMainContent.TabIndex = 1;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.panelTopBar.Controls.Add(this.lblPageTitle);
            this.panelTopBar.Controls.Add(this.btnWinMinimize);
            this.panelTopBar.Controls.Add(this.btnWinClose);
            this.panelTopBar.Controls.Add(this.panelTopBarSep);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(982, 57);
            this.panelTopBar.TabIndex = 0;
            this.panelTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTopBar_Paint);
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblPageTitle.Location = new System.Drawing.Point(21, 0);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(514, 52);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Inicio";
            this.lblPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnWinMinimize
            // 
            this.btnWinMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnWinMinimize.FlatAppearance.BorderSize = 0;
            this.btnWinMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(53)))), ((int)(((byte)(100)))));
            this.btnWinMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.btnWinMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMinimize.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnWinMinimize.Location = new System.Drawing.Point(897, 0);
            this.btnWinMinimize.Name = "btnWinMinimize";
            this.btnWinMinimize.Size = new System.Drawing.Size(43, 52);
            this.btnWinMinimize.TabIndex = 1;
            this.btnWinMinimize.Text = "‒";
            this.btnWinMinimize.UseVisualStyleBackColor = false;
            this.btnWinMinimize.Click += new System.EventHandler(this.btnWinMinimize_Click);
            // 
            // btnWinClose
            // 
            this.btnWinClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWinClose.BackColor = System.Drawing.Color.Transparent;
            this.btnWinClose.FlatAppearance.BorderSize = 0;
            this.btnWinClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnWinClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnWinClose.Location = new System.Drawing.Point(939, 0);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(43, 52);
            this.btnWinClose.TabIndex = 2;
            this.btnWinClose.Text = "✕";
            this.btnWinClose.UseVisualStyleBackColor = false;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // panelTopBarSep
            // 
            this.panelTopBarSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(74)))));
            this.panelTopBarSep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTopBarSep.Location = new System.Drawing.Point(0, 56);
            this.panelTopBarSep.Name = "panelTopBarSep";
            this.panelTopBarSep.Size = new System.Drawing.Size(982, 1);
            this.panelTopBarSep.TabIndex = 3;
            // 
            // FormMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1171, 666);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1171, 666);
            this.Name = "FormMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lam7ara";
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebarHeader.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelSidebarFooter.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelSidebarHeader;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblLogoChar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppSubtitle;
        private System.Windows.Forms.Panel panelSep1;
        private System.Windows.Forms.Label lblNavSection;
        private System.Windows.Forms.Button btnNavInicio;
        private System.Windows.Forms.Button btnNavVender;
        private System.Windows.Forms.Button btnNavClientes;
        private System.Windows.Forms.Button btnNavStock;
        private System.Windows.Forms.Button btnNavTecnico;
        private System.Windows.Forms.Panel panelActiveIndicator;
        private System.Windows.Forms.Panel panelSidebarFooter;
        private System.Windows.Forms.Panel panelSepFooter;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Button btnWinMinimize;
        private System.Windows.Forms.Button btnWinClose;
        private System.Windows.Forms.Panel panelTopBarSep;
        private System.Windows.Forms.Panel panelMainContent;
    }
}