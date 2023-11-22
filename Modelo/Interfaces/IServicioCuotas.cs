using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Interfaces
{
   public interface IServicioCuotas
    {
        void PagarCuota(Cuota cuota);
        List<Cuota> TraerCuotas();
    }
}
