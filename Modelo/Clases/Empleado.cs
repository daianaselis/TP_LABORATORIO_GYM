
using System.ComponentModel.DataAnnotations;

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
