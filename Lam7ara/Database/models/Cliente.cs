namespace Lam7ara.Database.Models
{
    public class Cliente
    {
        public int    ClienteID  { get; set; }
        public string Nombre     { get; set; }
        public string Apellido   { get; set; }
        public string DNI        { get; set; }
        public string Telefono   { get; set; }
        public string Email      { get; set; }
        public string FechaAlta  { get; set; }
        public int    IsDeleted  { get; set; }

        public string NombreCompleto => $"{Apellido}, {Nombre}";
    }
}
