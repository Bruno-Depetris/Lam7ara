namespace Lam7ara.Database.Models
{
    public class Caja
    {
        public int     CajaID         { get; set; }
        public string  FechaApertura  { get; set; }
        public decimal MontoApertura  { get; set; }
        public string  FechaCierre    { get; set; }
        public decimal? MontoCierre   { get; set; }
        public string  Estado         { get; set; }
        public string  Responsable    { get; set; }
    }
}
