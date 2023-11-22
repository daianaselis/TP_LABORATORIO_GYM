using Datos;
using Modelo.Clases;
using Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServicioEmpleado : IServicioEmpleado
    {
        Contexto contexto;
        public ServicioEmpleado(Contexto _contexto) { 
            contexto = _contexto;    
        }
        public void CrearEmplado(Empleado empleado)
        {
            contexto.Empleados.Add(empleado);
            contexto.SaveChanges(); 
        }

        public Empleado IniciarSesion(string legajo, string password)
        {
            var empleado = contexto.Empleados.Where(empleado => empleado.Legajo == legajo).FirstOrDefault();
            if(empleado != null)
            {
                if (password==empleado.Password)
                {
                    return empleado;
                }
            }

            return null;
        }

        public Empleado TraerEmpleado(Guid id)
        {
            var empleado = contexto.Empleados.Find(id);
            return empleado;
        }
    }
}
