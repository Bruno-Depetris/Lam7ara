namespace Lam7ara.Database.Models {
    public class Reparacion {
        public int ReparacionID { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreDueno { get; set; }
        public string ApellidoDueno { get; set; }
        public string TelefonoDueno { get; set; }
        public string DescripcionProblema { get; set; }
        public decimal Presupuesto { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaEstimadaEntrega { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public int IsDeleted { get; set; }

        public string NombreCompletodueno => $"{ApellidoDueno}, {NombreDueno}";
    }
}