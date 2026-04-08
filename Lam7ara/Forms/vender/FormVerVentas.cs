using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Lam7ara.Database.Models;
using Lam7ara.Database.Services;

namespace Lam7ara.Forms.vender {
    public partial class FormVerVentas : Form {
        private readonly VentaService _ventaService = new VentaService();
        private readonly ClienteService _clienteService = new ClienteService();
        private readonly CajaService _cajaService = new CajaService();
        private readonly ProductoService _productoService = new ProductoService();

        private int _ventaIDSeleccionada = -1;
        private Venta _ventaSeleccionada = null;

        public FormVerVentas() {
            InitializeComponent();
        }

        private void FormVerVentas_Load(object sender, EventArgs e) {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            CargarVentas();
            LimpiarDetalle();
        }

        // ── CARGA Y FILTROS ────────────────────────────────────────────

        private void CargarVentas() {
            dgvVentas.Rows.Clear();
            decimal totalAcumulado = 0m;
            int cantVentas = 0;

            try {
                string medioPago = cmbMedioPago.SelectedItem?.ToString()?.Trim() ?? "Todos";
                string filtroMP = medioPago.Equals("Todos", StringComparison.OrdinalIgnoreCase) ? "" : medioPago;

                string q = @"SELECT v.VentaID, v.Fecha, c.Nombre || ' ' || c.Apellido AS Cliente,
                             v.Total, v.MedioPago, v.Cuotas, v.Estado
                             FROM Ventas v
                             INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
                             WHERE DATE(REPLACE(v.Fecha, '/', '-')) >= DATE(@desde)
                               AND DATE(REPLACE(v.Fecha, '/', '-')) <= DATE(@hasta)
                               AND (IFNULL(@mp, '') = '' OR TRIM(v.MedioPago) = TRIM(@mp))
                             ORDER BY v.Fecha DESC;";

                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con)) {
                    cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.AddDays(1).ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@mp", filtroMP);

                    using (var r = cmd.ExecuteReader()) {
                        while (r.Read()) {
                            decimal total = Convert.ToDecimal(r["Total"]);
                            string estado = r["Estado"].ToString();
                            int idx = dgvVentas.Rows.Add(
                                r["VentaID"].ToString(),
                                r["Fecha"].ToString(),
                                r["Cliente"].ToString(),
                                "$" + total.ToString("N2"),
                                r["MedioPago"].ToString(),
                                r["Cuotas"].ToString(),
                                estado);

                            if (estado == "Anulada") {
                                dgvVentas.Rows[idx].DefaultCellStyle.ForeColor = Color.FromArgb(100, 116, 139);
                                dgvVentas.Rows[idx].DefaultCellStyle.SelectionForeColor = Color.FromArgb(148, 163, 184);
                            } else {
                                totalAcumulado += total;
                                cantVentas++;
                            }
                        }
                    }
                }
            } catch (Exception ex) { Console.WriteLine(ex.Message); }

            lblResumen.Text = string.Format("{0} ventas  |  Total: ${1}", cantVentas, totalAcumulado.ToString("N2"));
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            CargarVentas();
            LimpiarDetalle();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e) {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;
            cmbMedioPago.SelectedIndex = 0;
            CargarVentas();
            LimpiarDetalle();
        }

        // ── DETALLE DE VENTA ───────────────────────────────────────────

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            int id = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["colVID"].Value);
            _ventaIDSeleccionada = id;
            _ventaSeleccionada = _ventaService.BuscarPorID(id);
            CargarDetalle(_ventaSeleccionada);
        }

        private void CargarDetalle(Venta v) {
            dgvDetalle.Rows.Clear();
            if (v == null) return;

            foreach (var item in v.Detalle)
                dgvDetalle.Rows.Add(
                    item.NombreProducto,
                    item.Cantidad,
                    "$" + item.PrecioUnitario.ToString("N2"),
                    "$" + item.Subtotal.ToString("N2"));

            lblTotalValor.Text = "$" + v.Total.ToString("N2");

            bool activa = v.Estado == "Completada";
            btnImprimir.Enabled = true;
            btnAnular.Enabled = activa;
            btnAnular.ForeColor = activa
                ? Color.FromArgb(220, 38, 38)
                : Color.FromArgb(42, 42, 74);
            btnAnular.FlatAppearance.BorderColor = activa
                ? Color.FromArgb(220, 38, 38)
                : Color.FromArgb(42, 42, 74);
        }

        private void LimpiarDetalle() {
            _ventaIDSeleccionada = -1;
            _ventaSeleccionada = null;
            dgvDetalle.Rows.Clear();
            lblTotalValor.Text = "-";
            btnImprimir.Enabled = false;
            btnAnular.Enabled = false;
        }

        private void btnAnular_Click(object sender, EventArgs e) {
            if (_ventaIDSeleccionada < 0) return;

            var confirm = MessageBox.Show(
                "Confirma que desea anular esta venta? Esta accion no se puede deshacer.",
                "Confirmar anulacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            bool ok = _ventaService.Anular(_ventaIDSeleccionada);

            if (ok) {
                CargarVentas();
                LimpiarDetalle();
                
            } else {
                MessageBox.Show("Error al anular la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RetornarStock(int idProducto) {
            Producto prod = new Producto();

            prod = _productoService.BuscarPorID(idProducto);
            using(var con = Conectar.ObtenerConexion()) {
                using(var tx = con.BeginTransaction()) {
                    _productoService.ActualizarStock(idProducto, prod.Stock, con, tx); 
                        
                    
                }
            }
            
 
        }

            
        private void btnImprimir_Click(object sender, EventArgs e) {
            if (_ventaSeleccionada == null) return;

            using (var sfd = new SaveFileDialog()) {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.Title = "Guardar recibo";
                sfd.FileName = string.Format("Recibo_Venta_{0}.pdf", _ventaSeleccionada.VentaID);

                if (sfd.ShowDialog() != DialogResult.OK) return;

                bool ok = GenerarPDF(_ventaSeleccionada, sfd.FileName);
                if (ok) {
                    MessageBox.Show("Recibo guardado correctamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try { System.Diagnostics.Process.Start(sfd.FileName); } catch { }
                }
            }
        }

        private bool GenerarPDF(Venta venta, string filePath) {
            try {
                Cliente cliente = _clienteService.BuscarPorID(venta.ClienteID);
                string nombreCliente = cliente != null ? cliente.NombreCompleto : "Sin cliente";
                string emailCliente = cliente?.Email ?? string.Empty;

                // ── colores y fuentes ──────────────────────────────────
                BaseColor colPrimario = BaseColor.BLACK;
                BaseColor colFondo = new BaseColor(19, 19, 43);
                BaseColor colAccent = new BaseColor(99, 102, 241);
                BaseColor colMuted = new BaseColor(100, 116, 139);
                BaseColor colLinea = new BaseColor(42, 42, 74);
                BaseColor colBlanco = BaseColor.WHITE;

                iTextSharp.text.Font fTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 22f, colAccent);
                iTextSharp.text.Font fSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11f, colPrimario);
                iTextSharp.text.Font fNormal = FontFactory.GetFont(FontFactory.HELVETICA, 9f, colPrimario);
                iTextSharp.text.Font fBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 9f, colPrimario);
                iTextSharp.text.Font fMuted = FontFactory.GetFont(FontFactory.HELVETICA, 8f, colMuted);
                iTextSharp.text.Font fTotal = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f, colAccent);
                iTextSharp.text.Font fItalic = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9f, colMuted);
                iTextSharp.text.Font fHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8f, colMuted);

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // ── encabezado ─────────────────────────────────────────
                Paragraph pNombreApp = new Paragraph("Lam7ara", fTitulo);
                pNombreApp.Alignment = Element.ALIGN_CENTER;
                doc.Add(pNombreApp);

                Paragraph pSubApp = new Paragraph("Gestion Retail", FontFactory.GetFont(FontFactory.HELVETICA, 10f, colMuted));
                pSubApp.Alignment = Element.ALIGN_CENTER;
                pSubApp.SpacingAfter = 10f;
                doc.Add(pSubApp);

                // linea separadora accent
                PdfPTable lineaSep = new PdfPTable(1);
                lineaSep.WidthPercentage = 100;
                PdfPCell cLinea = new PdfPCell();
                cLinea.BorderWidthBottom = 2f;
                cLinea.BorderColorBottom = colAccent;
                cLinea.BorderWidthTop = 0;
                cLinea.BorderWidthLeft = 0;
                cLinea.BorderWidthRight = 0;
                cLinea.FixedHeight = 4f;
                lineaSep.AddCell(cLinea);
                doc.Add(lineaSep);

                Paragraph pTitulo = new Paragraph("COMPROBANTE DE VENTA",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 13f, colPrimario));
                pTitulo.Alignment = Element.ALIGN_CENTER;
                pTitulo.SpacingBefore = 10f;
                pTitulo.SpacingAfter = 4f;
                doc.Add(pTitulo);

                Paragraph pNumero = new Paragraph(
                    string.Format("N° {0:D6}  |  Fecha: {1}", venta.VentaID, venta.Fecha),
                    FontFactory.GetFont(FontFactory.HELVETICA, 9f, colMuted));
                pNumero.Alignment = Element.ALIGN_CENTER;
                pNumero.SpacingAfter = 16f;
                doc.Add(pNumero);

                // ── datos del cliente ──────────────────────────────────
                Paragraph pSecCliente = new Paragraph("DATOS DEL CLIENTE", fSubtitulo);
                pSecCliente.SpacingAfter = 6f;
                doc.Add(pSecCliente);

                PdfPTable tablaCliente = new PdfPTable(2);
                tablaCliente.WidthPercentage = 100;
                tablaCliente.SetWidths(new float[] { 30f, 70f });
                tablaCliente.SpacingAfter = 14f;

                AgregarFilaCliente(tablaCliente, "Cliente:", nombreCliente, fBold, fNormal);
                AgregarFilaCliente(tablaCliente, "Email:", emailCliente, fBold, fNormal);
                AgregarFilaCliente(tablaCliente, "Medio de pago:", venta.MedioPago, fBold, fNormal);
                if (venta.MedioPago == "Credito" && venta.Cuotas > 1) {
                    decimal valorCuota = venta.Total / venta.Cuotas;
                    AgregarFilaCliente(tablaCliente, "Cuotas:",
                        string.Format("{0}x de ${1}", venta.Cuotas, valorCuota.ToString("N2")),
                        fBold, fNormal);
                }
                doc.Add(tablaCliente);

                // ── detalle de productos ───────────────────────────────
                Paragraph pSecProductos = new Paragraph("DETALLE DE PRODUCTOS", fSubtitulo);
                pSecProductos.SpacingAfter = 6f;
                doc.Add(pSecProductos);

                PdfPTable tablaProductos = new PdfPTable(4);
                tablaProductos.WidthPercentage = 100;
                tablaProductos.SetWidths(new float[] { 45f, 15f, 20f, 20f });
                tablaProductos.SpacingAfter = 6f;

                string[] headers = { "Producto", "Cant.", "Precio Unit.", "Subtotal" };
                foreach (string h in headers) {
                    PdfPCell ch = new PdfPCell(new Phrase(h, fHeader));
                    ch.BackgroundColor = colFondo;
                    ch.BorderColor = colLinea;
                    ch.Padding = 7f;
                    ch.HorizontalAlignment = Element.ALIGN_CENTER;
                    tablaProductos.AddCell(ch);
                }

                foreach (var item in venta.Detalle) {
                    PdfPCell cProd = new PdfPCell(new Phrase(item.NombreProducto, fNormal));
                    cProd.BorderColor = colLinea;
                    cProd.Padding = 7f;
                    tablaProductos.AddCell(cProd);

                    PdfPCell cCant = new PdfPCell(new Phrase(item.Cantidad.ToString(), fNormal));
                    cCant.BorderColor = colLinea;
                    cCant.Padding = 7f;
                    cCant.HorizontalAlignment = Element.ALIGN_CENTER;
                    tablaProductos.AddCell(cCant);

                    PdfPCell cPrecio = new PdfPCell(new Phrase("$" + item.PrecioUnitario.ToString("N2"), fNormal));
                    cPrecio.BorderColor = colLinea;
                    cPrecio.Padding = 7f;
                    cPrecio.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaProductos.AddCell(cPrecio);

                    PdfPCell cSub = new PdfPCell(new Phrase("$" + item.Subtotal.ToString("N2"), fNormal));
                    cSub.BorderColor = colLinea;
                    cSub.Padding = 7f;
                    cSub.HorizontalAlignment = Element.ALIGN_RIGHT;
                    tablaProductos.AddCell(cSub);
                }
                doc.Add(tablaProductos);

                // ── total ──────────────────────────────────────────────
                PdfPTable tablaTotal = new PdfPTable(2);
                tablaTotal.WidthPercentage = 100;
                tablaTotal.SetWidths(new float[] { 75f, 25f });
                tablaTotal.SpacingBefore = 4f;
                tablaTotal.SpacingAfter = 20f;

                PdfPCell cTotalLabel = new PdfPCell(new Phrase("TOTAL", fTotal));
                cTotalLabel.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cTotalLabel.HorizontalAlignment = Element.ALIGN_RIGHT;
                cTotalLabel.Padding = 6f;
                tablaTotal.AddCell(cTotalLabel);

                PdfPCell cTotalValor = new PdfPCell(new Phrase("$" + venta.Total.ToString("N2"), fTotal));
                cTotalValor.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cTotalValor.HorizontalAlignment = Element.ALIGN_RIGHT;
                cTotalValor.Padding = 6f;
                tablaTotal.AddCell(cTotalValor);
                doc.Add(tablaTotal);

                // ── pie ────────────────────────────────────────────────
                PdfPTable lineaPie = new PdfPTable(1);
                lineaPie.WidthPercentage = 100;
                PdfPCell cPie = new PdfPCell();
                cPie.BorderWidthBottom = 1f;
                cPie.BorderColorBottom = colLinea;
                cPie.BorderWidthTop = 0;
                cPie.BorderWidthLeft = 0;
                cPie.BorderWidthRight = 0;
                cPie.FixedHeight = 4f;
                lineaPie.AddCell(cPie);
                doc.Add(lineaPie);

                Paragraph pGracias = new Paragraph("Gracias por tu compra. Lam7ara - Gestion Retail", fItalic);
                pGracias.Alignment = Element.ALIGN_CENTER;
                pGracias.SpacingBefore = 10f;
                doc.Add(pGracias);

                Paragraph pAviso = new Paragraph("Este comprobante no es valido como factura.", fMuted);
                pAviso.Alignment = Element.ALIGN_CENTER;
                doc.Add(pAviso);

                doc.Close();
                return true;
            } catch (Exception ex) {
                MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void AgregarFilaCliente(PdfPTable tabla, string etiqueta, string valor,
            iTextSharp.text.Font fBold, iTextSharp.text.Font fNormal) {
            PdfPCell cLabel = new PdfPCell(new Phrase(etiqueta, fBold));
            cLabel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cLabel.PaddingBottom = 5f;
            tabla.AddCell(cLabel);

            PdfPCell cVal = new PdfPCell(new Phrase(valor, fNormal));
            cVal.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cVal.PaddingBottom = 5f;
            tabla.AddCell(cVal);
        }
    }
}