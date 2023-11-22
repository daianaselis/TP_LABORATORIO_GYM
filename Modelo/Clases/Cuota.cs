using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
