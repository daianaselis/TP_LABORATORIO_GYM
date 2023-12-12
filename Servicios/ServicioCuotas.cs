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
    public class ServicioCuotas : IServicioCuotas
    {
        private Contexto contexto;
        public ServicioCuotas(Contexto _contexto)
        {
            contexto = _contexto;
        }
        public void PagarCuota(Cuota cuota)
        {
            if(cuota.IDCuota == Guid.Empty)
            {
                cuota.IDCuota = Guid.NewGuid();
            }
            if(cuota.Monto <= 0)
            {
                throw new Exception("La cuota no puede tener monto negativo o 0");
            }
            if(cuota.Monto > 100000)
            {
                throw new Exception("La cuota no puede exceder $100.000");
            }

            contexto.Cuotas.Add(cuota);
            contexto.SaveChanges();
        }

        public List<Cuota> TraerCuotas()
        {
            return contexto.Cuotas.ToList();
        }
    }
}
