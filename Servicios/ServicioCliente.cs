using Datos;
using Modelo.Clases;
using Modelo.Interfaces;


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

        public void VerificarAccesoGym(string DNI)
        {
            var cliente = contexto.Clientes.Where(cliente => cliente.DNI == DNI).FirstOrDefault();
            if (cliente==null)
                throw new Exception($"No existe el cliente con el DNI: {DNI}");

            var cuotas = contexto.Cuotas.Where(cuota => cuota.Cliente.IDCliente == cliente.IDCliente).ToList();

            for (DateTime fechaActual = cliente.FechaDeInscripcion.AddMonths(1); fechaActual <= DateTime.Now.AddMonths(1); fechaActual = fechaActual.AddMonths(1))
            {
                var fechaAnterior = fechaActual.AddMonths(-1);
                if(!cuotas.Where(cuota => cuota.FechaDePago <= fechaActual && cuota.FechaDePago >= fechaAnterior).Any())
                {
                    throw new Exception($"Falta la cuota entre {fechaAnterior.ToShortDateString()} y {fechaActual.ToShortDateString()}");
                }
            }

        }
    }
}
