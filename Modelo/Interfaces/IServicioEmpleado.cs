using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IServicioEmpleado
    {
        void CrearEmplado(Empleado empleado);
        Empleado TraerEmpleado(Guid id);
        Empleado IniciarSesion(string legajo, string password);
  
    }
}
