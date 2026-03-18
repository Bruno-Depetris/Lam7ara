using System;
using System.Collections.Generic;
using System.Data.SQLite;
using Lam7ara.Database.Models;

namespace Lam7ara.Database.Services
{
    public class ClienteService
    {
        private Cliente Map(SQLiteDataReader r)
        {
            return new Cliente
            {
                ClienteID = Convert.ToInt32(r["ClienteID"]),
                Nombre    = r["Nombre"].ToString(),
                Apellido  = r["Apellido"].ToString(),
                DNI       = r["DNI"].ToString(),
                Telefono  = r["Telefono"].ToString(),
                Email     = r["Email"].ToString(),
                FechaAlta = r["FechaAlta"].ToString(),
                IsDeleted = Convert.ToInt32(r["IsDeleted"])
            };
        }

        public List<Cliente> Listar()
        {
            var lista = new List<Cliente>();
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Clientes WHERE IsDeleted = 0 ORDER BY Apellido, Nombre;", con))
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) lista.Add(Map(r));
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return lista;
        }

        public Cliente BuscarPorID(int id)
        {
            try
            {
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand("SELECT * FROM Clientes WHERE ClienteID = @id;", con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var r = cmd.ExecuteReader())
                        if (r.Read()) return Map(r);
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return null;
        }

        public List<Cliente> Buscar(string texto)
        {
            var lista = new List<Cliente>();
            try
            {
                string q = "SELECT * FROM Clientes WHERE IsDeleted = 0 AND (Nombre LIKE @q OR Apellido LIKE @q OR DNI LIKE @q) ORDER BY Apellido, Nombre;";
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

        public bool Agregar(Cliente c)
        {
            try
            {
                string q = "INSERT INTO Clientes (Nombre, Apellido, DNI, Telefono, Email) VALUES (@n, @a, @d, @t, @e);";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@n", c.Nombre);
                    cmd.Parameters.AddWithValue("@a", c.Apellido);
                    cmd.Parameters.AddWithValue("@d", c.DNI);
                    cmd.Parameters.AddWithValue("@t", c.Telefono);
                    cmd.Parameters.AddWithValue("@e", c.Email);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return false; }
        }

        public bool Editar(Cliente c)
        {
            try
            {
                string q = "UPDATE Clientes SET Nombre=@n, Apellido=@a, DNI=@d, Telefono=@t, Email=@e WHERE ClienteID=@id;";
                using (var con = Conectar.ObtenerConexion())
                using (var cmd = new SQLiteCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@n",  c.Nombre);
                    cmd.Parameters.AddWithValue("@a",  c.Apellido);
                    cmd.Parameters.AddWithValue("@d",  c.DNI);
                    cmd.Parameters.AddWithValue("@t",  c.Telefono);
                    cmd.Parameters.AddWithValue("@e",  c.Email);
                    cmd.Parameters.AddWithValue("@id", c.ClienteID);
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
                using (var cmd = new SQLiteCommand("UPDATE Clientes SET IsDeleted = 1 WHERE ClienteID = @id;", con))
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
