
using System.ComponentModel.DataAnnotations;


namespace Modelo.Clases
{
    public class Cliente : Persona
    {
        [Key]
        public Guid IDCliente { get; set; }
        public DateTime FechaDeInscripcion { get; set; }
        public Generos Genero { get; set; }
        public List<Cuota> Cuotas { get; set; }
    }
}
