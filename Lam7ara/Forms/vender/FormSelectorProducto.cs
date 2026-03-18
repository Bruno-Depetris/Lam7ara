using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;

namespace Lam7ara.Forms.vender {
    public partial class FormSelectorProducto : Form {
        public Producto ProductoSeleccionado { get; private set; }

        private readonly List<Producto> _productos;

        public FormSelectorProducto(List<Producto> productos) {
            InitializeComponent();
            _productos = productos;
            CargarLista();
        }

        private void CargarLista() {
            dgvProductos.Rows.Clear();
            foreach(var p in _productos)
                dgvProductos.Rows.Add(p.ProductoID, p.Nombre, p.Condicion, p.Stock, "$" + p.PrecioVenta.ToString("N2"));
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Seleccionar(e.RowIndex);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            if(dgvProductos.CurrentRow == null) return;
            Seleccionar(dgvProductos.CurrentRow.Index);
        }

        private void Seleccionar(int rowIndex) {
            if(rowIndex < 0) return;
            int id = Convert.ToInt32(dgvProductos.Rows [rowIndex].Cells ["colProdID"].Value);
            ProductoSeleccionado = _productos.Find(p => p.ProductoID == id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}