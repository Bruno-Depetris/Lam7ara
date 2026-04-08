using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services
{
    public class VentaService
    {
        private readonly ProductoService _productoService = new ProductoService();

        private Venta Map(SQLiteDataReader r)
        {
            return new Venta
            {
                VentaID   = Convert.ToInt32(r["VentaID"]),
                ClienteID = Convert.ToInt32(r["ClienteID"]),
                CajaID    = Convert.ToInt32(r["CajaID"]),
                Fecha     = r["Fecha"].ToString(),
                MedioPago = r["MedioPago"].ToString(),
                Cuotas    = Convert.ToInt32(r["Cuotas"]),
                Total     = Convert.ToDecimal(r["Total"]),
                Estado    = r["Estado"].ToString()
            };
        }

        public List<Venta> Listar()
        {
            var lista = new List<Venta>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Ventas ORDER BY Fecha DESC;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) lista.Add(Map(r));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Venta BuscarPorID(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Ventas WHERE VentaID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                    {
                        if (!r.Read()) return null;
                        var venta = Map(r);
                        r.Close();
                        venta.Detalle = ObtenerDetalle(id, con);
                        return venta;
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Venta> Buscar(string texto)
        {
            var lista = new List<Venta>();
            try
            {
                string q = @"SELECT v.* FROM Ventas v
                             INNER JOIN Clientes c ON v.ClienteID = c.ClienteID
                             WHERE (c.Nombre LIKE @q OR c.Apellido LIKE @q OR c.DNI LIKE @q)
                             ORDER BY v.Fecha DESC;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@q", $"%{texto}%");
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) lista.Add(Map(r));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        private List<VentaProducto> ObtenerDetalle(int ventaID, SQLiteConnection con)
        {
            var lista = new List<VentaProducto>();
            string q = @"SELECT vp.*, p.Nombre AS NombreProducto FROM Venta_Productos vp
                         INNER JOIN Productos p ON vp.ProductoID = p.ProductoID
                         WHERE vp.VentaID = @id;";
            using (var cmd = new SQLiteCommand(q, con))
            {
                cmd.Parameters.AddWithValue("@id", ventaID);
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        lista.Add(new VentaProducto
                        {
                            VentaProductoID = Convert.ToInt32(r["VentaProductoID"]),
                            VentaID         = ventaID,
                            ProductoID      = Convert.ToInt32(r["ProductoID"]),
                            Cantidad        = Convert.ToInt32(r["Cantidad"]),
                            PrecioUnitario  = Convert.ToDecimal(r["PrecioUnitario"]),
                            Subtotal        = Convert.ToDecimal(r["Subtotal"]),
                            NombreProducto  = r["NombreProducto"].ToString()
                        });
            }
            return lista;
        }

        public bool Agregar(Venta venta)
        {
            using (var con = Conectar.ObtenerConexion())
            using (var tx = con.BeginTransaction())
            {
                try
                {
                    string qVenta = @"INSERT INTO Ventas (ClienteID, CajaID, MedioPago, Cuotas, Total)
                                      VALUES (@ci, @ca, @mp, @cu, @to);
                                      SELECT last_insert_rowid();";
                    int ventaID;
                    using (var cmd = new SQLiteCommand(qVenta, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@ci", venta.ClienteID);
                        cmd.Parameters.AddWithValue("@ca", venta.CajaID);
                        cmd.Parameters.AddWithValue("@mp", venta.MedioPago);
                        cmd.Parameters.AddWithValue("@cu", venta.Cuotas);
                        cmd.Parameters.AddWithValue("@to", venta.Total);
                        ventaID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach (var item in venta.Detalle)
                    {
                        string qDetalle = @"INSERT INTO Venta_Productos (VentaID, ProductoID, Cantidad, PrecioUnitario, Subtotal)
                                            VALUES (@vi, @pi, @ca, @pu, @su);";
                        using (var cmd = new SQLiteCommand(qDetalle, con, tx))
                        {
                            cmd.Parameters.AddWithValue("@vi", ventaID);
                            cmd.Parameters.AddWithValue("@pi", item.ProductoID);
                            cmd.Parameters.AddWithValue("@ca", item.Cantidad);
                            cmd.Parameters.AddWithValue("@pu", item.PrecioUnitario);
                            cmd.Parameters.AddWithValue("@su", item.Subtotal);
                            cmd.ExecuteNonQuery();
                        }

                        var prod = _productoService.BuscarPorID(item.ProductoID);
                        if (prod == null) throw new Exception($"Producto {item.ProductoID} no encontrado.");
                        int nuevoStock = prod.Stock - item.Cantidad;
                        if (nuevoStock < 0) throw new Exception($"Stock insuficiente para '{prod.Nombre}'.");
                        _productoService.ActualizarStock(item.ProductoID, nuevoStock, con, tx);
                    }

                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool Anular(int id) {
            using(var con = Conectar.ObtenerConexion())
            using(var tx = con.BeginTransaction()) {
                try {
                    List<VentaProducto> detalle = ObtenerDetalle(id, con);

                    foreach(var item in detalle) {
                        var prod = _productoService.BuscarPorID(item.ProductoID);
                        if(prod != null) {
                            int stockRestaurado = prod.Stock + item.Cantidad;
                            _productoService.ActualizarStock(item.ProductoID, stockRestaurado, con, tx);
                        }
                    }

                    using(var cmd = new SQLiteCommand(
                        "UPDATE Ventas SET Estado = 'Anulada' WHERE VentaID = @id;", con, tx)) {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;
                } catch(Exception ex) {
                    tx.Rollback();
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
