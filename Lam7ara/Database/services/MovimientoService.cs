using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services
{
    public class MovimientoService
    {
        private Movimiento Map(SQLiteDataReader r)
        {
            return new Movimiento
            {
                MovimientoID = Convert.ToInt32(r["MovimientoID"]),
                CajaID       = Convert.ToInt32(r["CajaID"]),
                Tipo         = r["Tipo"].ToString(),
                Monto        = Convert.ToDecimal(r["Monto"]),
                Descripcion  = r["Descripcion"].ToString(),
                Responsable  = r["Responsable"].ToString(),
                Fecha        = r["Fecha"].ToString()
            };
        }

        public List<Movimiento> Listar()
        {
            var lista = new List<Movimiento>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Movimientos ORDER BY Fecha DESC;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) lista.Add(Map(r));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public List<Movimiento> ListarPorCaja(int cajaID)
        {
            var lista = new List<Movimiento>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Movimientos WHERE CajaID = @id ORDER BY Fecha DESC;", con))
                {
                    cmd.Parameters.AddWithValue("@id", cajaID);
                    using (var r = cmd.ExecuteReader())
                        while (r.Read()) lista.Add(Map(r));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Movimiento BuscarPorID(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Movimientos WHERE MovimientoID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) return Map(r);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Movimiento> Buscar(string texto)
        {
            var lista = new List<Movimiento>();
            try
            {
                string q = "SELECT * FROM Movimientos WHERE Descripcion LIKE @q OR Responsable LIKE @q ORDER BY Fecha DESC;";
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

        public bool Agregar(Movimiento m)
        {
            try
            {
                string q = "INSERT INTO Movimientos (CajaID, Tipo, Monto, Descripcion, Responsable) VALUES (@ca, @ti, @mo, @de, @re);";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@ca", m.CajaID);
                    cmd.Parameters.AddWithValue("@ti", m.Tipo);
                    cmd.Parameters.AddWithValue("@mo", m.Monto);
                    cmd.Parameters.AddWithValue("@de", m.Descripcion);
                    cmd.Parameters.AddWithValue("@re", m.Responsable);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Editar(Movimiento m)
        {
            try
            {
                string q = "UPDATE Movimientos SET Tipo=@ti, Monto=@mo, Descripcion=@de, Responsable=@re WHERE MovimientoID=@id;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@ti", m.Tipo);
                    cmd.Parameters.AddWithValue("@mo", m.Monto);
                    cmd.Parameters.AddWithValue("@de", m.Descripcion);
                    cmd.Parameters.AddWithValue("@re", m.Responsable);
                    cmd.Parameters.AddWithValue("@id", m.MovimientoID);
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
                using (var cmd = new SQLiteCommand("DELETE FROM Movimientos WHERE MovimientoID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
    }
}
