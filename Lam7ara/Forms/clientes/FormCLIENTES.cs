using System;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.clientes {
    public partial class FormCLIENTES : Form {
        private readonly ClienteService _service = new ClienteService();
        private int _clienteIDEditando = -1;

        public FormCLIENTES() {
            InitializeComponent();
            CargarGrilla(_service.Listar());
            SetModoNuevo();
        }

        // ── GRILLA ─────────────────────────────────────────────────────

        private void CargarGrilla(System.Collections.Generic.List<Cliente> lista) {
            dgvClientes.Rows.Clear();
            foreach(var c in lista)
                dgvClientes.Rows.Add(c.ClienteID, c.Nombre, c.Apellido, c.DNI, c.Telefono, c.Email);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvClientes.Rows [e.RowIndex].Cells ["colID"].Value);
            Cliente c = _service.BuscarPorID(id);
            if(c == null) return;
            SetModoEdicion(c);
        }

        // ── BUSQUEDA ───────────────────────────────────────────────────

        private void btnBuscar_Click(object sender, EventArgs e) {
            string q = txtBuscar.Text.Trim();
            if(string.IsNullOrEmpty(q)) return;
            CargarGrilla(_service.Buscar(q));
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                btnBuscar_Click(sender, e);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e) {
            txtBuscar.Text = string.Empty;
            CargarGrilla(_service.Listar());
        }

        // ── CRUD ────────────────────────────────────────────────────────

        private void btnNuevo_Click(object sender, EventArgs e) {
            SetModoNuevo();
            txtNombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text)) {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var c = new Cliente {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                DNI = txtDNI.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            bool ok;
            if(_clienteIDEditando == -1) {
                ok = _service.Agregar(c);
            } else {
                c.ClienteID = _clienteIDEditando;
                ok = _service.Editar(c);
            }

            if(ok) {
                CargarGrilla(_service.Listar());
                SetModoNuevo();
            } else {
                MessageBox.Show("Ocurrio un error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if(_clienteIDEditando == -1) {
                MessageBox.Show("Seleccione un cliente de la lista para eliminar.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Confirma que desea eliminar este cliente?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(confirm != DialogResult.Yes) return;

            bool ok = _service.Eliminar(_clienteIDEditando);
            if(ok) {
                CargarGrilla(_service.Listar());
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
            _clienteIDEditando = -1;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            lblSecForm.Text = "DATOS DEL CLIENTE";
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.FromArgb(42, 42, 74);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 74);
        }

        private void SetModoEdicion(Cliente c) {
            _clienteIDEditando = c.ClienteID;
            txtNombre.Text = c.Nombre;
            txtApellido.Text = c.Apellido;
            txtDNI.Text = c.DNI;
            txtTelefono.Text = c.Telefono;
            txtEmail.Text = c.Email;
            lblSecForm.Text = "EDITANDO: " + c.NombreCompleto;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
        }
    }
}