using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lam7ara {
    public partial class FormMAIN : Form {
        // ─── Estado de arrastre (FormBorderStyle.None) ──────────────────
        private bool _isDragging = false;
        private Point _dragStart;

        public FormMAIN() {
            InitializeComponent();
            // Mostrar hora actual de inmediato sin esperar el primer Tick
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy") + "\r\n" + DateTime.Now.ToString("HH:mm:ss");
            // Asegurar que el indicador quede encima de los botones al iniciar
            panelActiveIndicator.BringToFront();
        }

        // ═══════════════════════════════════════════════════════════════
        //  RELOJ EN TIEMPO REAL
        // ═══════════════════════════════════════════════════════════════
        private void timerClock_Tick(object sender, EventArgs e) {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy") + "\r\n" + DateTime.Now.ToString("HH:mm:ss");
        }

        // ═══════════════════════════════════════════════════════════════
        //  ARRASTRE DE VENTANA (FormBorderStyle.None)
        // ═══════════════════════════════════════════════════════════════
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

        // ═══════════════════════════════════════════════════════════════
        //  BOTONES DE VENTANA
        // ═══════════════════════════════════════════════════════════════
        private void btnWinClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnWinMinimize_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        // ═══════════════════════════════════════════════════════════════
        //  NAVEGACIÓN — activar ítem seleccionado
        // ═══════════════════════════════════════════════════════════════
        private void SetActiveNavItem(Button activeButton) {
            // Colores de la paleta (sin lambdas, sin helpers)
            Color colorInactiveText = Color.FromArgb(148, 163, 184);
            Color colorActiveText = Color.FromArgb(99, 102, 241);
            Color colorActiveBg = Color.FromArgb(45, 43, 85);

            // Resetear todos los botones al estado inactivo
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

            // Aplicar estado activo al botón seleccionado
            activeButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            activeButton.ForeColor = colorActiveText;
            activeButton.BackColor = colorActiveBg;

            // Mover el indicador de 4px al botón activo
            panelActiveIndicator.Location = new Point(0, activeButton.Top);
            panelActiveIndicator.Height = activeButton.Height;
            panelActiveIndicator.BringToFront();

            // Actualizar título del área de contenido
            lblPageTitle.Text = activeButton.Text;
        }

        // ═══════════════════════════════════════════════════════════════
        //  HANDLERS DE CADA ÍTEM DE NAVEGACIÓN
        //  → Reemplazar los comentarios TODO por tu UserControl o Panel
        // ═══════════════════════════════════════════════════════════════
        private void btnNavInicio_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavInicio);
            // TODO: cargar contenido de Inicio en panelMainContent
        }

        private void btnNavVender_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavVender);
            // TODO: cargar contenido de Vender en panelMainContent
        }

        private void btnNavClientes_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavClientes);
            // TODO: cargar contenido de Clientes en panelMainContent
        }

        private void btnNavStock_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavStock);
            // TODO: cargar contenido de Stock en panelMainContent
        }

        private void btnNavTecnico_Click(object sender, EventArgs e) {
            SetActiveNavItem(btnNavTecnico);
            // TODO: cargar contenido de Técnico en panelMainContent
        }

        private void panelTopBar_Paint(object sender, PaintEventArgs e) {

        }
    }
}