using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services {
    public class ReparacionService {
        private Reparacion Map(SQLiteDataReader r) {
            return new Reparacion {
                ReparacionID = Convert.ToInt32(r ["ReparacionID"]),
                NombreEquipo = r ["NombreEquipo"].ToString(),
                NombreDueno = r ["NombreDueno"].ToString(),
                ApellidoDueno = r ["ApellidoDueno"].ToString(),
                TelefonoDueno = r ["TelefonoDueno"].ToString(),
                DescripcionProblema = r ["DescripcionProblema"].ToString(),
                Presupuesto = Convert.ToDecimal(r ["Presupuesto"]),
                FechaIngreso = r ["FechaIngreso"].ToString(),
                FechaEstimadaEntrega = r ["FechaEstimadaEntrega"].ToString(),
                Observaciones = r ["Observaciones"].ToString(),
                Estado = r ["Estado"].ToString(),
                IsDeleted = Convert.ToInt32(r ["IsDeleted"])
            };
        }

        public List<Reparacion> Listar() {
            var lista = new List<Reparacion>();
            try {
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(
                    "SELECT * FROM Reparaciones WHERE IsDeleted = 0 ORDER BY FechaIngreso DESC;", con))
                using(var r = cmd.ExecuteReader())
                    while(r.Read()) lista.Add(Map(r));
            } catch(Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public List<Reparacion> ListarPorEstado(string estado) {
            var lista = new List<Reparacion>();
            try {
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(
                    "SELECT * FROM Reparaciones WHERE IsDeleted = 0 AND Estado = @e ORDER BY FechaIngreso DESC;", con)) {
                    cmd.Parameters.AddWithValue("@e", estado);
                    using(var r = cmd.ExecuteReader())
                        while(r.Read()) lista.Add(Map(r));
                }
            } catch(Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Reparacion BuscarPorID(int id) {
            try {
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(
                    "SELECT * FROM Reparaciones WHERE ReparacionID = @id;", con)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(var r = cmd.ExecuteReader())
                        if(r.Read()) return Map(r);
                }
            } catch(Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Reparacion> Buscar(string texto) {
            var lista = new List<Reparacion>();
            try {
                string q = @"SELECT * FROM Reparaciones
                             WHERE IsDeleted = 0
                               AND (NombreEquipo LIKE @q OR NombreDueno LIKE @q
                                    OR ApellidoDueno LIKE @q OR TelefonoDueno LIKE @q)
                             ORDER BY FechaIngreso DESC;";
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(q, con)) {
                    cmd.Parameters.AddWithValue("@q", $"%{texto}%");
                    using(var r = cmd.ExecuteReader())
                        while(r.Read()) lista.Add(Map(r));
                }
            } catch(Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public bool Agregar(Reparacion rep) {
            try {
                string q = @"INSERT INTO Reparaciones
                             (NombreEquipo, NombreDueno, ApellidoDueno, TelefonoDueno,
                              DescripcionProblema, Presupuesto, FechaIngreso,
                              FechaEstimadaEntrega, Observaciones)
                             VALUES (@ne, @nd, @ad, @td, @dp, @pr, @fi, @fe, @ob);";
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(q, con)) {
                    cmd.Parameters.AddWithValue("@ne", rep.NombreEquipo);
                    cmd.Parameters.AddWithValue("@nd", rep.NombreDueno);
                    cmd.Parameters.AddWithValue("@ad", rep.ApellidoDueno);
                    cmd.Parameters.AddWithValue("@td", rep.TelefonoDueno);
                    cmd.Parameters.AddWithValue("@dp", rep.DescripcionProblema);
                    cmd.Parameters.AddWithValue("@pr", rep.Presupuesto);
                    cmd.Parameters.AddWithValue("@fi", rep.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fe", rep.FechaEstimadaEntrega);
                    cmd.Parameters.AddWithValue("@ob", rep.Observaciones);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } catch(Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Editar(Reparacion rep) {
            try {
                string q = @"UPDATE Reparaciones SET
                             NombreEquipo=@ne, NombreDueno=@nd, ApellidoDueno=@ad,
                             TelefonoDueno=@td, DescripcionProblema=@dp, Presupuesto=@pr,
                             FechaIngreso=@fi, FechaEstimadaEntrega=@fe, Observaciones=@ob,
                             Estado=@es
                             WHERE ReparacionID=@id;";
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(q, con)) {
                    cmd.Parameters.AddWithValue("@ne", rep.NombreEquipo);
                    cmd.Parameters.AddWithValue("@nd", rep.NombreDueno);
                    cmd.Parameters.AddWithValue("@ad", rep.ApellidoDueno);
                    cmd.Parameters.AddWithValue("@td", rep.TelefonoDueno);
                    cmd.Parameters.AddWithValue("@dp", rep.DescripcionProblema);
                    cmd.Parameters.AddWithValue("@pr", rep.Presupuesto);
                    cmd.Parameters.AddWithValue("@fi", rep.FechaIngreso);
                    cmd.Parameters.AddWithValue("@fe", rep.FechaEstimadaEntrega);
                    cmd.Parameters.AddWithValue("@ob", rep.Observaciones);
                    cmd.Parameters.AddWithValue("@es", rep.Estado);
                    cmd.Parameters.AddWithValue("@id", rep.ReparacionID);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } catch(Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool CambiarEstado(int id, string nuevoEstado) {
            try {
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(
                    "UPDATE Reparaciones SET Estado = @e WHERE ReparacionID = @id;", con)) {
                    cmd.Parameters.AddWithValue("@e", nuevoEstado);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } catch(Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Eliminar(int id) {
            try {
                using(var con = Conectar.ObtenerConexion())
                using(var cmd = new SQLiteCommand(
                    "UPDATE Reparaciones SET IsDeleted = 1 WHERE ReparacionID = @id;", con)) {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return true;
            } catch(Exception ex) { Console.WriteLine(ex.Message); return false; }
        }
    }
}