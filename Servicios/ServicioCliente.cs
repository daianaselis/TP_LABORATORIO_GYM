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
    public class ServicioCliente : IServicioCliente
    {
        Contexto contexto;
      public ServicioCliente(Contexto _contexto) {
        contexto = _contexto;
        }  
        public void BorrarCliente(Guid id)
        {
            var cliente = contexto.Clientes.Find(id);
            if (cliente != null) {
                contexto.Clientes.Remove(cliente);
                contexto.SaveChanges();
            }
        }

        public void CrearCliente(Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void ModificarCliente(Cliente cliente)
        {
            var entry = contexto.Clientes.Find(cliente.IDCliente);
            if (entry != null)
            {
                entry.Nombre = cliente.Nombre;
                entry.Apellido = cliente.Apellido;
                entry.FechaDeNacimiento = cliente.FechaDeNacimiento;
                entry.FechaDeInscripcion = cliente.FechaDeInscripcion;
                entry.Genero = cliente.Genero;
                contexto.SaveChanges();
            }
        }

        public Cliente TraerCliente(Guid id)
        {
            var cliente = contexto.Clientes.Find(id);
            return cliente;
        }

        public List<Cliente> TraerClientes()
        {
            return contexto.Clientes.ToList();
        }
    }
}
