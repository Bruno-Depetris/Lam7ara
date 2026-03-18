using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.stock {
    public partial class FormStock : Form {
        private readonly ProductoService _service = new ProductoService();
        private int _productoIDEditando = -1;
        private const int STOCK_BAJO = 3;

        public FormStock() {
            InitializeComponent();
            CargarGrilla(_service.Listar());
            SetModoNuevo();
        }

        // ── GRILLA ─────────────────────────────────────────────────────

        private void CargarGrilla(List<Producto> lista) {
            dgvProductos.Rows.Clear();
            foreach (var p in lista)
                dgvProductos.Rows.Add(
                    p.ProductoID,
                    p.Nombre,
                    p.Condicion,
                    p.Almacenamiento,
                    p.Stock,
                    "$" + p.PrecioCosto.ToString("N2"),
                    "$" + p.PrecioVenta.ToString("N2"));
        }

        private void dgvProductos_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            if (e.RowIndex < 0 || e.RowIndex >= dgvProductos.Rows.Count) return;
            var row = dgvProductos.Rows[e.RowIndex];
            int stock;
            if (int.TryParse(row.Cells["colStock"].Value?.ToString(), out stock) && stock <= STOCK_BAJO) {
                row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(66, 25, 25);
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(252, 165, 165);
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(90, 35, 35);
            } else {
                row.DefaultCellStyle.BackColor = e.RowIndex % 2 == 0
                    ? System.Drawing.Color.FromArgb(26, 26, 46)
                    : System.Drawing.Color.FromArgb(30, 30, 52);
                row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
                row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(45, 43, 85);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["colID"].Value);
            Producto p = _service.BuscarPorID(id);
            if (p == null) return;
            SetModoEdicion(p);
        }

        // ── BUSQUEDA Y FILTRO ──────────────────────────────────────────

        private void btnBuscar_Click(object sender, EventArgs e) {
            string q = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(q)) return;
            List<Producto> resultado = _service.Buscar(q);
            resultado = AplicarFiltroCondicion(resultado);
            CargarGrilla(resultado);
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, e);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e) {
            txtBuscar.Text = string.Empty;
            cmbFiltro.SelectedIndex = 0;
            CargarGrilla(_service.Listar());
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e) {
            CargarGrilla(AplicarFiltroCondicion(_service.Listar()));
        }

        private List<Producto> AplicarFiltroCondicion(List<Producto> lista) {
            string filtro = cmbFiltro.SelectedItem?.ToString();
            if (filtro == "Nuevo" || filtro == "Usado")
                return lista.FindAll(p => p.Condicion == filtro);
            return lista;
        }

        // ── CRUD ────────────────────────────────────────────────────────

        private void btnNuevo_Click(object sender, EventArgs e) {
            SetModoNuevo();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) {
                MessageBox.Show("El nombre del producto es obligatorio.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costo, venta;
            if (!decimal.TryParse(txtPrecioCosto.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out costo)) {
                MessageBox.Show("Precio Costo invalido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecioVenta.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out venta)) {
                MessageBox.Show("Precio Venta invalido.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = new Producto {
                Nombre = txtNombre.Text.Trim(),
                Condicion = cmbCondicion.SelectedItem.ToString(),
                Almacenamiento = txtAlmacenamiento.Text.Trim(),
                Bateria = txtBateria.Text.Trim(),
                Stock = (int)nudStock.Value,
                PrecioCosto = costo,
                PrecioVenta = venta,
                EmailProveedor = txtEmailProv.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim()
            };

            bool ok;
            if (_productoIDEditando == -1) {
                ok = _service.Agregar(p);
            } else {
                p.ProductoID = _productoIDEditando;
                ok = _service.Editar(p);
            }

            if (ok) {
                CargarGrilla(AplicarFiltroCondicion(_service.Listar()));
                SetModoNuevo();
            } else {
                MessageBox.Show("Ocurrio un error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if (_productoIDEditando == -1) {
                MessageBox.Show("Seleccione un producto de la lista para eliminar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Confirma que desea eliminar este producto?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            bool ok = _service.Eliminar(_productoIDEditando);
            if (ok) {
                CargarGrilla(AplicarFiltroCondicion(_service.Listar()));
                SetModoNuevo();
            } else {
                MessageBox.Show("Ocurrio un error al eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {
            SetModoNuevo();
        }

        // ── HELPERS ────────────────────────────────────────────────────

        private void SetModoNuevo() {
            _productoIDEditando = -1;
            txtNombre.Text = string.Empty;
            cmbCondicion.SelectedIndex = 0;
            txtAlmacenamiento.Text = string.Empty;
            txtBateria.Text = string.Empty;
            nudStock.Value = 0;
            txtPrecioCosto.Text = "0";
            txtPrecioVenta.Text = "0";
            txtEmailProv.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            lblSecForm.Text = "DATOS DEL PRODUCTO";
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.FromArgb(42, 42, 74);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 74);
        }

        private void SetModoEdicion(Producto p) {
            _productoIDEditando = p.ProductoID;
            txtNombre.Text = p.Nombre;
            cmbCondicion.SelectedItem = p.Condicion;
            txtAlmacenamiento.Text = p.Almacenamiento;
            txtBateria.Text = p.Bateria;
            nudStock.Value = p.Stock;
            txtPrecioCosto.Text = p.PrecioCosto.ToString("N2");
            txtPrecioVenta.Text = p.PrecioVenta.ToString("N2");
            txtEmailProv.Text = p.EmailProveedor;
            txtDescripcion.Text = p.Descripcion;
            lblSecForm.Text = "EDITANDO: " + p.Nombre;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
        }
    }
}