namespace Lam7ara.Database.Models
{
    public class Producto
    {
        public int     ProductoID      { get; set; }
        public string  Nombre          { get; set; }
        public string  Condicion       { get; set; }
        public string  Almacenamiento  { get; set; }
        public string  Bateria         { get; set; }
        public int     Stock           { get; set; }
        public string  EmailProveedor  { get; set; }
        public decimal PrecioCosto     { get; set; }
        public decimal PrecioVenta     { get; set; }
        public string  Descripcion     { get; set; }
        public string  FechaAlta       { get; set; }
        public int     IsDeleted       { get; set; }
    }
}
