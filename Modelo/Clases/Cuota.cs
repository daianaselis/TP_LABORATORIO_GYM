
using System.ComponentModel.DataAnnotations;


namespace Modelo.Clases
{
    public class Cuota
    {
        [Key]
        public Guid IDCuota { get; set; }
        public double Monto { get; set; }
        public DateTime FechaDePago { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
    }
}
