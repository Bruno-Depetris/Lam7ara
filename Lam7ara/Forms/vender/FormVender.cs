using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.vender {
    public partial class FormVender : Form {
        private readonly ClienteService _clienteService = new ClienteService();
        private readonly ProductoService _productoService = new ProductoService();
        private readonly VentaService _ventaService = new VentaService();
        private readonly CajaService _cajaService = new CajaService();

        private Cliente _clienteSeleccionado = null;
        private Producto _productoSeleccionado = null;

        public FormVender() {
            InitializeComponent();
            cmbCuotas.SelectedIndex = 0;
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e) {
            string q = txtBuscarCliente.Text.Trim();
            if(string.IsNullOrEmpty(q)) return;

            List<Cliente> resultados = _clienteService.Buscar(q);

            if(resultados.Count == 1) {
                SetCliente(resultados [0]);
            } else if(resultados.Count > 1) {
                using(var selector = new FormSelectorCliente(resultados)) {
                    if(selector.ShowDialog() == DialogResult.OK)
                        SetCliente(selector.ClienteSeleccionado);
                }
            } else {
                _clienteSeleccionado = null;
                lblClienteNombre.Text = "Cliente no encontrado";
                lblClienteNombre.ForeColor = Color.FromArgb(220, 38, 38);
                lblClienteNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                lblClienteDNI.Text = "DNI: -";
            }
        }

        private void SetCliente(Cliente c) {
            _clienteSeleccionado = c;
            lblClienteNombre.Text = c.NombreCompleto;
            lblClienteNombre.ForeColor = Color.FromArgb(226, 232, 240);
            lblClienteNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClienteDNI.Text = "DNI: " + c.DNI;
        }


        private void btnBuscarProducto_Click(object sender, EventArgs e) {
            string q = txtBuscarProducto.Text.Trim();
            if(string.IsNullOrEmpty(q)) return;

            List<Producto> resultados = _productoService.Buscar(q);

            if(resultados.Count == 1) {
                SetProducto(resultados [0]);
            } else if(resultados.Count > 1) {
                using(var selector = new FormSelectorProducto(resultados)) {
                    if(selector.ShowDialog() == DialogResult.OK)
                        SetProducto(selector.ProductoSeleccionado);
                }
            } else {
                _productoSeleccionado = null;
                txtBuscarProducto.ForeColor = Color.FromArgb(220, 38, 38);
            }
        }

        private void SetProducto(Producto p) {
            _productoSeleccionado = p;
            txtBuscarProducto.Text = p.Nombre;
            txtBuscarProducto.ForeColor = Color.FromArgb(226, 232, 240);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e) {
            if(_productoSeleccionado == null) {
                MessageBox.Show("Seleccione un producto valido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cant = (int)nudCantidad.Value;
            decimal precio = _productoSeleccionado.PrecioVenta;
            decimal sub = precio * cant;
            int rowNum = dgvProductos.Rows.Count + 1;

            dgvProductos.Rows.Add(
                rowNum,
                _productoSeleccionado.Nombre,
                "$" + precio.ToString("N2"),
                cant,
                "$" + sub.ToString("N2"),
                _productoSeleccionado.ProductoID
            );

            ActualizarTotal();
            LimpiarBuscadorProducto();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == dgvProductos.Columns ["colQuitar"].Index && e.RowIndex >= 0) {
                dgvProductos.Rows.RemoveAt(e.RowIndex);
                for(int i = 0; i < dgvProductos.Rows.Count; i++)
                    dgvProductos.Rows [i].Cells ["colNum"].Value = i + 1;
                ActualizarTotal();
            }
        }

        private void ActualizarTotal() {
            decimal total = 0m;
            foreach(DataGridViewRow row in dgvProductos.Rows) {
                string raw = row.Cells ["colSubtotal"].Value?.ToString() ?? "0";
                raw = raw.Replace("$", "").Replace(".", "").Replace(",", ".");
                decimal sub;
                if(decimal.TryParse(raw, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out sub))
                    total += sub;
            }
            lblTotalValue.Text = "$" + total.ToString("N2");
        }


        private void rbCredito_CheckedChanged(object sender, EventArgs e) {
            lblCuotasLabel.Visible = rbCredito.Checked;
            cmbCuotas.Visible = rbCredito.Checked;
        }


        private void btnConcretar_Click(object sender, EventArgs e) {
            if(_clienteSeleccionado == null) {
                MessageBox.Show("Seleccione un cliente.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dgvProductos.Rows.Count == 0) {
                MessageBox.Show("Agregue al menos un producto.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Caja caja = _cajaService.ObtenerCajaAbierta();
            if(caja == null) {
                MessageBox.Show("No hay una caja abierta. Abra la caja antes de registrar ventas.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var venta = new Venta {
                ClienteID = _clienteSeleccionado.ClienteID,
                CajaID = caja.CajaID,
                MedioPago = rbEfectivo.Checked ? "Efectivo" : rbTransferencia.Checked ? "Transferencia" : "Credito",
                Cuotas = rbCredito.Checked ? int.Parse(cmbCuotas.Text.Split(' ') [0]) : 1,
                Total = ObtenerTotalDecimal(),
                Estado = "Completada"
            };

            foreach(DataGridViewRow row in dgvProductos.Rows) {
                int prodID = Convert.ToInt32(row.Cells ["colProductoID"].Value);
                int cantidad = Convert.ToInt32(row.Cells ["colCantidad"].Value);
                string rawPU = row.Cells ["colPrecio"].Value.ToString().Replace("$", "").Replace(".", "").Replace(",", ".");
                decimal precio = decimal.Parse(rawPU, System.Globalization.CultureInfo.InvariantCulture);

                venta.Detalle.Add(new VentaProducto {
                    ProductoID = prodID,
                    Cantidad = cantidad,
                    PrecioUnitario = precio,
                    Subtotal = precio * cantidad
                });
            }

            bool ok = _ventaService.Agregar(venta);

            if(ok) {
                MessageBox.Show("Venta registrada: " + lblTotalValue.Text, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancelar_Click(sender, e);
            } else {
                MessageBox.Show("Ocurrio un error al registrar la venta. Revise el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            dgvProductos.Rows.Clear();
            lblTotalValue.Text = "$0,00";
            lblClienteNombre.Text = "Ningun cliente seleccionado";
            lblClienteNombre.ForeColor = Color.FromArgb(148, 163, 184);
            lblClienteNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblClienteDNI.Text = "DNI: -";
            txtBuscarCliente.Text = "Buscar por nombre o DNI...";
            txtBuscarCliente.ForeColor = Color.FromArgb(148, 163, 184);
            rbEfectivo.Checked = true;
            cmbCuotas.SelectedIndex = 0;
            _clienteSeleccionado = null;
            LimpiarBuscadorProducto();
        }

        // ── HELPERS ────────────────────────────────────────────────────

        private void LimpiarBuscadorProducto() {
            _productoSeleccionado = null;
            txtBuscarProducto.Text = "Buscar producto...";
            txtBuscarProducto.ForeColor = Color.FromArgb(148, 163, 184);
            nudCantidad.Value = 1;
        }

        private decimal ObtenerTotalDecimal() {
            decimal total = 0m;
            foreach(DataGridViewRow row in dgvProductos.Rows) {
                string raw = row.Cells ["colSubtotal"].Value?.ToString() ?? "0";
                raw = raw.Replace("$", "").Replace(".", "").Replace(",", ".");
                decimal sub;
                if(decimal.TryParse(raw, System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out sub))
                    total += sub;
            }
            return total;
        }
    }
}