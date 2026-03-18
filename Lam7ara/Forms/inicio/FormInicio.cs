using Lam7ara.APIs.Logicas;
using Lam7ara.APIs.Modelos;
using Lam7ara.Database.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lam7ara.Forms.inicio {
    public partial class FormInicio : Form {
        private readonly CajaService _cajaService = new CajaService();

        public FormInicio() {
            InitializeComponent();
        }

        private async void FormInicio_Load(object sender, EventArgs e) {
            CargarDatosNegocio();
            await CargarCotizaciones();
        }

        // ── DATOS DEL NEGOCIO ──────────────────────────────────────────

        private void CargarDatosNegocio() {
            CargarVentasDelDia();
            CargarTotalClientes();
            CargarEstadoCaja();
            CargarStockBajo();
            CargarUltimasVentas();
        }

        private void CargarVentasDelDia() {
            try {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(
                    "SELECT COUNT(*), COALESCE(SUM(Total), 0) FROM Ventas WHERE DATE(Fecha) = DATE('now') AND Estado = 'Completada';", con))
                using (var r = cmd.ExecuteReader()) {
                    if (r.Read()) {
                        int cantidad = r.IsDBNull(0) ? 0 : Convert.ToInt32(r[0]);
                        decimal total = r.IsDBNull(1) ? 0m : Convert.ToDecimal(r[1]);
                        lblCardVValor.Text = "$" + total.ToString("N2");
                        lblCardCVValor.Text = cantidad.ToString();
                    }
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void CargarTotalClientes() {
            try {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Clientes WHERE IsDeleted = 0;", con)) {
                    var result = cmd.ExecuteScalar();
                    lblCardCLValor.Text = result != null ? result.ToString() : "0";
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void CargarEstadoCaja() {
            var caja = _cajaService.ObtenerCajaAbierta();
            if (caja != null) {
                lblCardCJValor.Text = "Abierta";
                lblCardCJValor.ForeColor = Color.FromArgb(74, 222, 128);
                decimal saldo = CalcularSaldoCaja(caja.CajaID, caja.MontoApertura);
                lblCardCJSub.Text = "Saldo: $" + saldo.ToString("N2");
            } else {
                lblCardCJValor.Text = "Cerrada";
                lblCardCJValor.ForeColor = Color.FromArgb(100, 116, 139);
                lblCardCJSub.Text = "Saldo: $0,00";
            }
        }

        private decimal CalcularSaldoCaja(int cajaID, decimal montoApertura) {
            decimal saldo = montoApertura;
            try {
                using (var con = Conectar.ObtenerConexion()) {
                    using (var cmd = new SQLiteCommand(
                        "SELECT Tipo, COALESCE(SUM(Monto),0) FROM Movimientos WHERE CajaID=@id GROUP BY Tipo;", con)) {
                        cmd.Parameters.AddWithValue("@id", cajaID);
                        using (var r = cmd.ExecuteReader())
                            while (r.Read())
                                saldo += r["Tipo"].ToString() == "Ingreso"
                                    ? Convert.ToDecimal(r[1])
                                    : -Convert.ToDecimal(r[1]);
                    }
                    using (var cmd = new SQLiteCommand(
                        "SELECT COALESCE(SUM(Total),0) FROM Ventas WHERE CajaID=@id AND Estado='Completada';", con)) {
                        cmd.Parameters.AddWithValue("@id", cajaID);
                        var v = cmd.ExecuteScalar();
                        if (v != null && v != DBNull.Value) saldo += Convert.ToDecimal(v);
                    }
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
            return saldo;
        }

        private void CargarStockBajo() {
            dgvStockBajo.Rows.Clear();
            try {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(
                    "SELECT Nombre, Condicion, Stock FROM Productos WHERE IsDeleted=0 AND Stock<=3 ORDER BY Stock ASC;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        dgvStockBajo.Rows.Add(r["Nombre"].ToString(), r["Condicion"].ToString(), r["Stock"].ToString());
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void CargarUltimasVentas() {
            dgvUltimasVentas.Rows.Clear();
            try {
                string q = @"SELECT v.Fecha, c.Nombre || ' ' || c.Apellido AS Cliente,
                             '$' || ROUND(v.Total, 2) AS Total, v.MedioPago, v.Estado
                             FROM Ventas v
                             INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
                             ORDER BY v.Fecha DESC LIMIT 10;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                using (var r = cmd.ExecuteReader()) {
                    while (r.Read()) {
                        int idx = dgvUltimasVentas.Rows.Add(
                            r["Fecha"].ToString(),
                            r["Cliente"].ToString(),
                            r["Total"].ToString(),
                            r["MedioPago"].ToString(),
                            r["Estado"].ToString());

                        dgvUltimasVentas.Rows[idx].DefaultCellStyle.ForeColor =
                            r["Estado"].ToString() == "Anulada"
                                ? Color.FromArgb(252, 165, 165)
                                : Color.FromArgb(226, 232, 240);
                    }
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        // ── COTIZACIONES ───────────────────────────────────────────────

        private async Task CargarCotizaciones() {
            btnActualizar.Enabled = false;
            lblEstadoCot.Text = "Cargando cotizaciones...";
            lblEstadoCot.ForeColor = Color.FromArgb(148, 163, 184);

            try {
                using (var api = new ApiCotizacion("https://dolarapi.com/v1/dolares")) {
                    string resp = await api.GetAsync("https://dolarapi.com/v1/dolares");
                    var cot = JsonConvert.DeserializeObject<List<ModeloApiCotizacion>>(resp);

                    var oficial = cot.Find(c => c.Casa == "oficial");
                    var blue = cot.Find(c => c.Casa == "blue");
                    var tarjeta = cot.Find(c => c.Casa == "tarjeta");

                    if (oficial != null) {
                        lblDOVenta.Text = $"${oficial.Venta:N0}";
                        lblDOCompra.Text = $"Compra: ${oficial.Compra:N0}";
                    }
                    if (blue != null) {
                        lblDBVenta.Text = $"${blue.Venta:N0}";
                        lblDBCompra.Text = $"Compra: ${blue.Compra:N0}";
                    }
                    if (tarjeta != null) {
                        lblDTVenta.Text = $"${tarjeta.Venta:N0}";
                        lblDTCompra.Text = $"Compra: ${tarjeta.Compra:N0}";
                    }

                    lblEstadoCot.Text = "Actualizado: " + DateTime.Now.ToString("HH:mm:ss");
                    lblEstadoCot.ForeColor = Color.FromArgb(74, 222, 128);
                }
            } catch (Exception) {
                lblEstadoCot.Text = "Sin conexion. Verifique su red e intente nuevamente.";
                lblEstadoCot.ForeColor = Color.FromArgb(252, 165, 165);
            } finally {
                btnActualizar.Enabled = true;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e) {
            CargarDatosNegocio();
            await CargarCotizaciones();
        }
    }
}