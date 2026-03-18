using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services
{
    public class ProductoService
    {
        private Producto Map(SQLiteDataReader r)
        {
            return new Producto
            {
                ProductoID     = Convert.ToInt32(r["ProductoID"]),
                Nombre         = r["Nombre"].ToString(),
                Condicion      = r["Condicion"].ToString(),
                Almacenamiento = r["Almacenamiento"].ToString(),
                Bateria        = r["Bateria"].ToString(),
                Stock          = Convert.ToInt32(r["Stock"]),
                EmailProveedor = r["EmailProveedor"].ToString(),
                PrecioCosto    = Convert.ToDecimal(r["PrecioCosto"]),
                PrecioVenta    = Convert.ToDecimal(r["PrecioVenta"]),
                Descripcion    = r["Descripcion"].ToString(),
                FechaAlta      = r["FechaAlta"].ToString(),
                IsDeleted      = Convert.ToInt32(r["IsDeleted"])
            };
        }

        public List<Producto> Listar()
        {
            var lista = new List<Producto>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Productos WHERE IsDeleted = 0 ORDER BY Nombre;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) lista.Add(Map(r));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Producto BuscarPorID(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Productos WHERE ProductoID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) return Map(r);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Producto> Buscar(string texto)
        {
            var lista = new List<Producto>();
            try
            {
                string q = "SELECT * FROM Productos WHERE IsDeleted = 0 AND (Nombre LIKE @q OR Descripcion LIKE @q) ORDER BY Nombre;";
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

        public bool Agregar(Producto p)
        {
            try
            {
                string q = @"INSERT INTO Productos (Nombre, Condicion, Almacenamiento, Bateria, Stock, EmailProveedor, PrecioCosto, PrecioVenta, Descripcion)
                             VALUES (@n, @c, @al, @b, @s, @ep, @pc, @pv, @d);";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@n",  p.Nombre);
                    cmd.Parameters.AddWithValue("@c",  p.Condicion);
                    cmd.Parameters.AddWithValue("@al", p.Almacenamiento);
                    cmd.Parameters.AddWithValue("@b",  p.Bateria);
                    cmd.Parameters.AddWithValue("@s",  p.Stock);
                    cmd.Parameters.AddWithValue("@ep", p.EmailProveedor);
                    cmd.Parameters.AddWithValue("@pc", p.PrecioCosto);
                    cmd.Parameters.AddWithValue("@pv", p.PrecioVenta);
                    cmd.Parameters.AddWithValue("@d",  p.Descripcion);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Editar(Producto p)
        {
            try
            {
                string q = @"UPDATE Productos SET Nombre=@n, Condicion=@c, Almacenamiento=@al, Bateria=@b,
                             Stock=@s, EmailProveedor=@ep, PrecioCosto=@pc, PrecioVenta=@pv, Descripcion=@d
                             WHERE ProductoID=@id;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@n",  p.Nombre);
                    cmd.Parameters.AddWithValue("@c",  p.Condicion);
                    cmd.Parameters.AddWithValue("@al", p.Almacenamiento);
                    cmd.Parameters.AddWithValue("@b",  p.Bateria);
                    cmd.Parameters.AddWithValue("@s",  p.Stock);
                    cmd.Parameters.AddWithValue("@ep", p.EmailProveedor);
                    cmd.Parameters.AddWithValue("@pc", p.PrecioCosto);
                    cmd.Parameters.AddWithValue("@pv", p.PrecioVenta);
                    cmd.Parameters.AddWithValue("@d",  p.Descripcion);
                    cmd.Parameters.AddWithValue("@id", p.ProductoID);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Eliminar(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("UPDATE Productos SET IsDeleted = 1 WHERE ProductoID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool ActualizarStock(int id, int nuevoStock, SQLiteConnection con, SQLiteTransaction tx)
        {
            try
            {
                using (var cmd = new SQLiteCommand("UPDATE Productos SET Stock = @s WHERE ProductoID = @id;", con, tx))
                {
                    cmd.Parameters.AddWithValue("@s",  nuevoStock);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
    }
}
