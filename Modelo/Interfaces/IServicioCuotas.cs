using Modelo.Clases;

namespace Modelo.Interfaces
{
   public interface IServicioCuotas
    {
        void PagarCuota(Cuota cuota);
        List<Cuota> TraerCuotas();
    }
}
