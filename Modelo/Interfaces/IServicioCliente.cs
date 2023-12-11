using Modelo.Clases;


namespace Modelo.Interfaces
{
    public interface IServicioCliente
    {
        void CrearCliente(Cliente cliente);
        Cliente TraerCliente(Guid id);
        void ModificarCliente(Cliente cliente);
        void BorrarCliente(Guid id);
        List<Cliente> TraerClientes();
        void VerificarAccesoGym(string DNI);
    }
}
