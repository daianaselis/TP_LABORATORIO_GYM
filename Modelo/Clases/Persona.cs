
namespace Modelo.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; } = "P. Sherman, Wallaby Street 42, Sydney";
    }
}
