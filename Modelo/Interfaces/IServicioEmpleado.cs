using Modelo.Clases;

namespace Modelo.Interfaces
{
    public interface IServicioEmpleado
    {
        void CrearEmplado(Empleado empleado);
        Empleado TraerEmpleado(Guid id);
        Empleado IniciarSesion(string legajo, string password);
 
    }
}
