using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
    public interface IServicioCliente
    {
        void CrearCliente(Cliente cliente);
        Cliente TraerCliente(Guid id);
        void ModificarCliente(Cliente cliente);
        void BorrarCliente(Guid id);
        List<Cliente> TraerClientes();
    }
}
