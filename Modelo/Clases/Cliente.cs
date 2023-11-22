using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Clases
{
    public class Cliente : Persona
    {
        [Key]
        public Guid IDCliente { get; set; }
        public DateTime FechaDeInscripcion { get; set; }
        public Generos Genero { get; set; }
    }
}
