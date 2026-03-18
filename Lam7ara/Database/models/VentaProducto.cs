namespace Lam7ara.Database.Models
{
    public class VentaProducto
    {
        public int     VentaProductoID { get; set; }
        public int     VentaID         { get; set; }
        public int     ProductoID      { get; set; }
        public int     Cantidad        { get; set; }
        public decimal PrecioUnitario  { get; set; }
        public decimal Subtotal        { get; set; }

        public string NombreProducto   { get; set; }
    }
}
