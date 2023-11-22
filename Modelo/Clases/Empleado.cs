using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Clases
{
    public class Empleado : Persona
    {
        [Key]
        public Guid IDEmpleado { get; set; }
        public string Legajo { get; set; }
        public string Password { get; set; }
    }
}
