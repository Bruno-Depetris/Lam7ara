using System.Collections.Generic;

namespace Lam7ara.Database.Models
{
    public class Venta
    {
        public int    VentaID    { get; set; }
        public int    ClienteID  { get; set; }
        public int    CajaID     { get; set; }
        public string Fecha      { get; set; }
        public string MedioPago  { get; set; }
        public int    Cuotas     { get; set; }
        public decimal Total     { get; set; }
        public string Estado     { get; set; }

        public List<VentaProducto> Detalle { get; set; } = new List<VentaProducto>();
    }
}
