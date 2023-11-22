using Modelo.Interfaces;

namespace TP_LABORATORIO_GYM
{
    public partial class ABMClientes : Form
    {
        private IServicioCliente servicioCliente;
        public ABMClientes(IServicioCliente _servicioCliente)
        {
            InitializeComponent();
            servicioCliente = _servicioCliente;
        }


    }
}