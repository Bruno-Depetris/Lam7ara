using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services
{
    public class CajaService
    {
        private Caja Map(SQLiteDataReader r)
        {
            return new Caja
            {
                CajaID        = Convert.ToInt32(r["CajaID"]),
                FechaApertura = r["FechaApertura"].ToString(),
                MontoApertura = Convert.ToDecimal(r["MontoApertura"]),
                FechaCierre   = r["FechaCierre"]  == DBNull.Value ? null : r["FechaCierre"].ToString(),
                MontoCierre   = r["MontoCierre"]  == DBNull.Value ? (decimal?)null : Convert.ToDecimal(r["MontoCierre"]),
                Estado        = r["Estado"].ToString(),
                Responsable   = r["Responsable"].ToString()
            };
        }

        public List<Caja> Listar()
        {
            var lista = new List<Caja>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Cajas ORDER BY FechaApertura DESC;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) lista.Add(Map(r));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Caja BuscarPorID(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Cajas WHERE CajaID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) return Map(r);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public Caja ObtenerCajaAbierta()
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Cajas WHERE Estado = 'Abierta' LIMIT 1;", con))
                using (var r = cmd.ExecuteReader())
                    if (r.Read()) return Map(r);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Caja> Buscar(string texto)
        {
            var lista = new List<Caja>();
            try
            {
                string q = "SELECT * FROM Cajas WHERE Responsable LIKE @q OR Estado LIKE @q ORDER BY FechaApertura DESC;";
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

        public bool Abrir(decimal montoApertura, string responsable)
        {
            try
            {
                if (ObtenerCajaAbierta() != null)
                {
                    Console.WriteLine("Ya existe una caja abierta.");
                    return false;
                }
                string q = "INSERT INTO Cajas (MontoApertura, Responsable) VALUES (@m, @r);";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@m", montoApertura);
                    cmd.Parameters.AddWithValue("@r", responsable);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Cerrar(int cajaID, decimal montoCierre)
        {
            try
            {
                string q = "UPDATE Cajas SET FechaCierre = datetime('now'), MontoCierre = @m, Estado = 'Cerrada' WHERE CajaID = @id;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@m",  montoCierre);
                    cmd.Parameters.AddWithValue("@id", cajaID);
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
                using (var cmd = new SQLiteCommand("DELETE FROM Cajas WHERE CajaID = @id;", con))
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
