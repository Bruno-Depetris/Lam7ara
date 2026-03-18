namespace Lam7ara.Database.Models
{
    public class Movimiento
    {
        public int    MovimientoID { get; set; }
        public int    CajaID       { get; set; }
        public string Tipo         { get; set; }
        public decimal Monto       { get; set; }
        public string Descripcion  { get; set; }
        public string Responsable  { get; set; }
        public string Fecha        { get; set; }
    }
}
