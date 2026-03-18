using Lam7ara.Forms.clientes;
using Lam7ara.Forms.movimientos;
using Lam7ara.Forms.stock;
using Lam7ara.Forms.inicio;
using Lam7ara.Forms.vender;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lam7ara {
    public partial class FormMAIN : Form {
        private bool _isDragging = false;
        private Point _dragStart;
        private Form FormActivo = null;
        public FormMAIN() {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy") + "\r\n" + DateTime.Now.ToString("HH:mm:ss");
            panelActiveIndicator.BringToFront();
            AbrirFormNuevo(new FormInicio());
        }

        private void timerClock_Tick(object sender, EventArgs e) {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy") + "\r\n" + DateTime.Now.ToString("HH:mm:ss");
        }


        private void panelTopBar_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                _isDragging = true;
                _dragStart = new Point(e.X, e.Y);
            }
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e) {
            if(_isDragging) {
                Location = new Point(
                    Location.X + (e.X - _dragStart.X),
                    Location.Y + (e.Y - _dragStart.Y)
                );
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e) {
            _isDragging = false;
        }


        private void btnWinClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnWinMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void SetActiveNavItem(Button activeButton) {
            Color colorInactiveText = Color.FromArgb(148, 163, 184);
            Color colorActiveText = Color.FromArgb(99, 102, 241);
            Color colorActiveBg = Color.FromArgb(45, 43, 85);

            btnNavInicio.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnNavInicio.ForeColor = colorInactiveText;
            btnNavInicio.BackColor = Color.Transparent;

            btnNavVender.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnNavVender.ForeColor = colorInactiveText;
            btnNavVender.BackColor = Color.Transparent;

            btnNavClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnNavClientes.ForeColor = colorInactiveText;
            btnNavClientes.BackColor = Color.Transparent;

            btnNavStock.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnNavStock.ForeColor = colorInactiveText;
            btnNavStock.BackColor = Color.Transparent;

            btnNavTecnico.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            btnNavTecnico.ForeColor = colorInactiveText;
            btnNavTecnico.BackColor = Color.Transparent;

            activeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            activeButton.ForeColor = colorActiveText;
            activeButton.BackColor = colorActiveBg;

            panelActiveIndicator.Location = new Point(0, activeButton.Top);
            panelActiveIndicator.Height = activeButton.Height;
            panelActiveIndicator.BringToFront();

            lblPageTitle.Text = activeButton.Text;
        }

        private void AbrirFormNuevo(Form FormHijo) {
            if(FormActivo != null) {
                FormActivo.Close();
            }

            FormActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelMainContent.Controls.Add(FormHijo);
            panelMainContent.Tag = FormHijo;
            FormHijo.Show();
        }


        private void btnNavInicio_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavInicio);
            AbrirFormNuevo(new FormInicio());

        }

        private void btnNavVender_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavVender);
            AbrirFormNuevo(new FormVender()); 
        }

        private void btnNavClientes_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavClientes);
            AbrirFormNuevo(new FormCLIENTES());

            // TODO: cargar contenido de Clientes en panelMainContent
        }

        private void btnNavStock_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavStock);
            AbrirFormNuevo(new FormStock());
            // TODO: cargar contenido de Stock en panelMainContent
        }

        private void btnNavTecnico_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavTecnico);
            // TODO: cargar contenido de Técnico en panelMainContent
        }

        private void panelTopBar_Paint(object sender, PaintEventArgs e) {

        }

        private void btnNavMovimiento_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavMovimiento);
            AbrirFormNuevo(new FormMovimientos());
        }
    }
}