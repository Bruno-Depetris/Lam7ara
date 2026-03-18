using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;

namespace Lam7ara.Forms.vender {
    public partial class FormSelectorCliente : Form {
        public Cliente ClienteSeleccionado { get; private set; }

        private readonly List<Cliente> _clientes;

        public FormSelectorCliente(List<Cliente> clientes) {
            InitializeComponent();
            _clientes = clientes;
            CargarLista();
        }

        private void CargarLista() {
            dgvClientes.Rows.Clear();
            foreach(var c in _clientes)
                dgvClientes.Rows.Add(c.ClienteID, c.NombreCompleto, c.DNI, c.Telefono);
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            Seleccionar(e.RowIndex);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            if(dgvClientes.CurrentRow == null) return;
            Seleccionar(dgvClientes.CurrentRow.Index);
        }

        private void Seleccionar(int rowIndex) {
            if(rowIndex < 0) return;
            int id = Convert.ToInt32(dgvClientes.Rows [rowIndex].Cells ["colCliID"].Value);
            ClienteSeleccionado = _clientes.Find(c => c.ClienteID == id);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}