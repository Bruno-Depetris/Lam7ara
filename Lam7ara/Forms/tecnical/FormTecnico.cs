using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.tecnical {
    public partial class FormTecnico : Form {
        private readonly ReparacionService _service = new ReparacionService();
        private readonly CajaService _cajaService = new CajaService();
        private readonly MovimientoService _movService = new MovimientoService();

        private int _reparacionIDEditando = -1;
        private string _estadoAnterior = string.Empty;

        public FormTecnico() {
            InitializeComponent();
            CargarGrilla(_service.Listar());
            SetModoNuevo();
        }

        // ── GRILLA ─────────────────────────────────────────────────────

        private void CargarGrilla(List<Reparacion> lista) {
            dgvReparaciones.Rows.Clear();
            foreach(var r in lista)
                dgvReparaciones.Rows.Add(
                    r.ReparacionID,
                    r.NombreEquipo,
                    r.NombreCompletodueno,
                    r.TelefonoDueno,
                    r.FechaIngreso,
                    string.IsNullOrEmpty(r.FechaEstimadaEntrega) ? "-" : r.FechaEstimadaEntrega,
                    "$" + r.Presupuesto.ToString("N2"),
                    r.Estado);
        }

        private void dgvReparaciones_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            if(e.RowIndex < 0 || e.RowIndex >= dgvReparaciones.Rows.Count) return;
            string estado = dgvReparaciones.Rows [e.RowIndex].Cells ["colEstado"].Value?.ToString();
            Color fg, sel;
            switch(estado) {
                case "Ingresado":
                    fg = Color.FromArgb(148, 163, 184);
                    sel = Color.FromArgb(45, 43, 85);
                    break;
                case "En proceso":
                    fg = Color.FromArgb(251, 191, 36);
                    sel = Color.FromArgb(60, 50, 20);
                    break;
                case "Listo":
                    fg = Color.FromArgb(74, 222, 128);
                    sel = Color.FromArgb(20, 50, 30);
                    break;
                case "Entregado":
                    fg = Color.FromArgb(100, 116, 139);
                    sel = Color.FromArgb(30, 30, 50);
                    break;
                default:
                    fg = Color.FromArgb(226, 232, 240);
                    sel = Color.FromArgb(45, 43, 85);
                    break;
            }
            dgvReparaciones.Rows [e.RowIndex].DefaultCellStyle.ForeColor = fg;
            dgvReparaciones.Rows [e.RowIndex].DefaultCellStyle.SelectionBackColor = sel;
        }

        private void dgvReparaciones_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvReparaciones.Rows [e.RowIndex].Cells ["colID"].Value);
            Reparacion rep = _service.BuscarPorID(id);
            if(rep == null) return;
            SetModoEdicion(rep);
        }

        // ── BUSQUEDA Y FILTRO ──────────────────────────────────────────

        private void btnBuscar_Click(object sender, EventArgs e) {
            string q = txtBuscar.Text.Trim();
            if(string.IsNullOrEmpty(q)) return;
            CargarGrilla(AplicarFiltroEstado(_service.Buscar(q)));
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) btnBuscar_Click(sender, e);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e) {
            txtBuscar.Text = string.Empty;
            cmbFiltroEstado.SelectedIndex = 0;
            CargarGrilla(_service.Listar());
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) {
            CargarGrilla(AplicarFiltroEstado(_service.Listar()));
        }

        private List<Reparacion> AplicarFiltroEstado(List<Reparacion> lista) {
            string filtro = cmbFiltroEstado.SelectedItem?.ToString();
            if(filtro != "Todos" && !string.IsNullOrEmpty(filtro))
                return lista.FindAll(r => r.Estado == filtro);
            return lista;
        }

        // ── CRUD ────────────────────────────────────────────────────────

        private void btnNuevo_Click(object sender, EventArgs e) {
            SetModoNuevo();
            txtNombreEquipo.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace(txtNombreEquipo.Text) ||
                string.IsNullOrWhiteSpace(txtNombreDueno.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoDueno.Text)) {
                MessageBox.Show("Nombre del equipo, nombre y apellido del dueno son obligatorios.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal presupuesto;
            if(!decimal.TryParse(txtPresupuesto.Text.Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture, out presupuesto))
                presupuesto = 0m;

            string nuevoEstado = cmbEstado.SelectedItem?.ToString() ?? "Ingresado";

            // ── VALIDACION CAJA SI SE MARCA COMO ENTREGADO ─────────────
            if(nuevoEstado == "Entregado" && _estadoAnterior != "Entregado") {
                Caja caja = _cajaService.ObtenerCajaAbierta();
                if(caja == null) {
                    MessageBox.Show(
                        "No hay una caja abierta. Abra la caja antes de marcar una reparacion como Entregada.",
                        "Caja cerrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbEstado.SelectedItem = _estadoAnterior;
                    return;
                }

                if(presupuesto > 0) {
                    var mov = new Movimiento {
                        CajaID = caja.CajaID,
                        Tipo = "Ingreso",
                        Monto = presupuesto,
                        Descripcion = "Reparacion: " + txtNombreEquipo.Text.Trim() +
                                      " — " + txtApellidoDueno.Text.Trim() + ", " + txtNombreDueno.Text.Trim(),
                        Responsable = string.Empty
                    };
                    _movService.Agregar(mov);
                }
            }

            var rep = new Reparacion {
                NombreEquipo = txtNombreEquipo.Text.Trim(),
                NombreDueno = txtNombreDueno.Text.Trim(),
                ApellidoDueno = txtApellidoDueno.Text.Trim(),
                TelefonoDueno = txtTelefono.Text.Trim(),
                DescripcionProblema = txtDescripcion.Text.Trim(),
                Presupuesto = presupuesto,
                FechaIngreso = dtpFechaIngreso.Value.ToString("yyyy-MM-dd"),
                FechaEstimadaEntrega = dtpFechaEntrega.Value.ToString("yyyy-MM-dd"),
                Observaciones = txtObservaciones.Text.Trim(),
                Estado = nuevoEstado
            };

            bool ok;
            if(_reparacionIDEditando == -1) {
                ok = _service.Agregar(rep);
            } else {
                rep.ReparacionID = _reparacionIDEditando;
                ok = _service.Editar(rep);
            }

            if(ok) {
                CargarGrilla(AplicarFiltroEstado(_service.Listar()));
                SetModoNuevo();
            } else {
                MessageBox.Show("Ocurrio un error al guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e) {
            if(_reparacionIDEditando == -1) {
                MessageBox.Show("Seleccione una reparacion de la lista para eliminar.",
                    "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Confirma que desea eliminar esta reparacion?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirm != DialogResult.Yes) return;

            bool ok = _service.Eliminar(_reparacionIDEditando);
            if(ok) {
                CargarGrilla(AplicarFiltroEstado(_service.Listar()));
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
            _reparacionIDEditando = -1;
            _estadoAnterior = string.Empty;
            txtNombreEquipo.Text = string.Empty;
            txtNombreDueno.Text = string.Empty;
            txtApellidoDueno.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtPresupuesto.Text = "0";
            dtpFechaIngreso.Value = DateTime.Today;
            dtpFechaEntrega.Value = DateTime.Today.AddDays(7);
            txtObservaciones.Text = string.Empty;
            cmbEstado.SelectedIndex = 0;
            lblSecForm.Text = "DATOS DE REPARACION";
            btnEliminar.Enabled = false;
            btnEliminar.ForeColor = Color.FromArgb(42, 42, 74);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 74);
        }

        private void SetModoEdicion(Reparacion rep) {
            _reparacionIDEditando = rep.ReparacionID;
            _estadoAnterior = rep.Estado;
            txtNombreEquipo.Text = rep.NombreEquipo;
            txtNombreDueno.Text = rep.NombreDueno;
            txtApellidoDueno.Text = rep.ApellidoDueno;
            txtTelefono.Text = rep.TelefonoDueno;
            txtDescripcion.Text = rep.DescripcionProblema;
            txtPresupuesto.Text = rep.Presupuesto.ToString("N2");
            txtObservaciones.Text = rep.Observaciones;
            cmbEstado.SelectedItem = rep.Estado;

            DateTime fi;
            if(DateTime.TryParse(rep.FechaIngreso, out fi))
                dtpFechaIngreso.Value = fi;

            DateTime fe;
            if(!string.IsNullOrEmpty(rep.FechaEstimadaEntrega) &&
                DateTime.TryParse(rep.FechaEstimadaEntrega, out fe))
                dtpFechaEntrega.Value = fe;

            lblSecForm.Text = "EDITANDO: " + rep.NombreEquipo + " — " + rep.NombreCompletodueno;
            btnEliminar.Enabled = true;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
        }
    }
}