using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.movimientos {
    public partial class FormMovimientos : Form {
        private readonly CajaService _cajaService = new CajaService();
        private readonly MovimientoService _movService = new MovimientoService();
        private Caja _cajaActual = null;

        public FormMovimientos() {
            InitializeComponent();
            Actualizar();
        }

        // ── CARGA GENERAL ──────────────────────────────────────────────

        private void Actualizar() {
            _cajaActual = _cajaService.ObtenerCajaAbierta();
            ActualizarCards();
            ActualizarMovimientos();
            ActualizarHistorial();
            ActualizarEstadoBotones();
        }

        // ── CARDS DE ESTADO ────────────────────────────────────────────

        private void ActualizarCards() {
            if (_cajaActual != null) {
                lblCardEstadoValor.Text = "Abierta";
                lblCardEstadoValor.ForeColor = Color.FromArgb(74, 222, 128);
                lblCardAperturaValor.Text = "$" + _cajaActual.MontoApertura.ToString("N2");

                decimal saldo = CalcularSaldo();
                decimal ventas = CalcularTotalVentas();

                lblCardSaldoValor.Text = "$" + saldo.ToString("N2");
                lblCardVentasValor.Text = "$" + ventas.ToString("N2");
            } else {
                lblCardEstadoValor.Text = "Cerrada";
                lblCardEstadoValor.ForeColor = Color.FromArgb(100, 116, 139);
                lblCardAperturaValor.Text = "$0,00";
                lblCardSaldoValor.Text = "$0,00";
                lblCardVentasValor.Text = "$0,00";
            }
        }

        private decimal CalcularSaldo() {
            if (_cajaActual == null) return 0m;
            decimal saldo = _cajaActual.MontoApertura;
            var movs = _movService.ListarPorCaja(_cajaActual.CajaID);
            foreach (var m in movs)
                saldo += m.Tipo == "Ingreso" ? m.Monto : -m.Monto;
            saldo += CalcularTotalVentas();
            return saldo;
        }

        private decimal CalcularTotalVentas() {
            if (_cajaActual == null) return 0m;
            decimal total = 0m;
            try {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(
                    "SELECT COALESCE(SUM(Total), 0) FROM Ventas WHERE CajaID = @id AND Estado = 'Completada';", con)) {
                    cmd.Parameters.AddWithValue("@id", _cajaActual.CajaID);
                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                        total = Convert.ToDecimal(result);
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            return total;
        }

        // ── MOVIMIENTOS ────────────────────────────────────────────────

        private void ActualizarMovimientos() {
            dgvMovimientos.Rows.Clear();
            if (_cajaActual == null) return;

            var lista = _movService.ListarPorCaja(_cajaActual.CajaID);
            foreach (var m in lista) {
                int idx = dgvMovimientos.Rows.Add(
                    m.MovimientoID,
                    m.Fecha,
                    m.Tipo,
                    "$" + m.Monto.ToString("N2"),
                    m.Descripcion,
                    m.Responsable);

                dgvMovimientos.Rows[idx].DefaultCellStyle.ForeColor = m.Tipo == "Ingreso"
                    ? Color.FromArgb(74, 222, 128)
                    : Color.FromArgb(252, 165, 165);
            }
        }

        private void btnRegistrarMov_Click(object sender, EventArgs e) {
            if (_cajaActual == null) {
                MessageBox.Show("No hay una caja abierta.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto;
            if (!decimal.TryParse(txtMonto.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out monto) || monto <= 0) {
                MessageBox.Show("Ingrese un monto valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mov = new Movimiento {
                CajaID = _cajaActual.CajaID,
                Tipo = rbIngreso.Checked ? "Ingreso" : "Egreso",
                Monto = monto,
                Descripcion = txtDescripcion.Text.Trim(),
                Responsable = txtRespMov.Text.Trim()
            };

            bool ok = _movService.Agregar(mov);
            if (ok) {
                LimpiarFormMovimiento();
                Actualizar();
            } else {
                MessageBox.Show("Error al registrar el movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormMovimiento() {
            txtMonto.Text = "0";
            txtDescripcion.Text = string.Empty;
            txtRespMov.Text = string.Empty;
            rbIngreso.Checked = true;
        }

        // ── CAJA ───────────────────────────────────────────────────────

        private void btnAbrirCaja_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtResponsable.Text)) {
                MessageBox.Show("Ingrese el nombre del responsable.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monto;
            if (!decimal.TryParse(txtMontoApertura.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out monto)) {
                MessageBox.Show("Ingrese un monto de apertura valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = _cajaService.Abrir(monto, txtResponsable.Text.Trim());
            if (ok) {
                txtResponsable.Text = string.Empty;
                txtMontoApertura.Text = "0";
                Actualizar();
            } else {
                MessageBox.Show("No se pudo abrir la caja. Verifique que no haya una caja ya abierta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e) {
            if (_cajaActual == null) {
                MessageBox.Show("No hay una caja abierta para cerrar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal saldo = CalcularSaldo();

            var confirm = MessageBox.Show(
                string.Format("Cerrar caja con saldo calculado de ${0}?", saldo.ToString("N2")),
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            bool ok = _cajaService.Cerrar(_cajaActual.CajaID, saldo);
            if (ok)
                Actualizar();
            else
                MessageBox.Show("Error al cerrar la caja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // ── HISTORIAL ──────────────────────────────────────────────────

        private void ActualizarHistorial() {
            dgvHistorial.Rows.Clear();
            var lista = _cajaService.Listar();
            foreach (var c in lista) {
                int idx = dgvHistorial.Rows.Add(
                    c.CajaID,
                    c.FechaApertura,
                    "$" + c.MontoApertura.ToString("N2"),
                    c.FechaCierre ?? "-",
                    c.MontoCierre.HasValue ? "$" + c.MontoCierre.Value.ToString("N2") : "-",
                    c.Estado,
                    c.Responsable);

                dgvHistorial.Rows[idx].DefaultCellStyle.ForeColor = c.Estado == "Abierta"
                    ? Color.FromArgb(74, 222, 128)
                    : Color.FromArgb(226, 232, 240);
            }
        }

        // ── HELPERS ────────────────────────────────────────────────────

        private void ActualizarEstadoBotones() {
            bool hayAbierta = _cajaActual != null;

            btnAbrirCaja.Enabled = !hayAbierta;
            btnCerrarCaja.Enabled = hayAbierta;
            panelContenido.Enabled = hayAbierta;

            btnAbrirCaja.BackColor = hayAbierta
                ? Color.FromArgb(30, 30, 52)
                : Color.FromArgb(5, 150, 105);
            btnAbrirCaja.ForeColor = hayAbierta
                ? Color.FromArgb(100, 116, 139)
                : Color.White;
        }
    }
}