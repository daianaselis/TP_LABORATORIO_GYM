using Modelo.Clases;
using Modelo.Interfaces;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace TP_LABORATORIO_GYM
{
    public partial class ABMClientes : Form
    {
        private IServicioCliente servicioCliente;
        BindingList<Cliente> bindingClientes;
        Cliente clienteActual;
        public ABMClientes(IServicioCliente _servicioCliente)
        {
            InitializeComponent();
            servicioCliente = _servicioCliente;
            combo_genero.DataSource = Enum.GetNames(typeof(Generos));
            bindingClientes = new BindingList<Cliente>(servicioCliente.TraerClientes());
            dgv_clientes.DataSource = bindingClientes;
            dgv_clientes.ReadOnly = true;
            dgv_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_clientes.AllowUserToAddRows = false;
            dgv_clientes.AllowUserToDeleteRows = false;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if(btn_aceptar.Text == "Modificar")
            {
                clienteActual.Nombre = txt_NombCliente.Text;
                clienteActual.Apellido = txt_ApellidoCliente.Text;
                clienteActual.DNI = txt_DNIcliente.Text;
                clienteActual.FechaDeNacimiento = DTP_cliente.Value;
                clienteActual.Genero = (Generos)combo_genero.SelectedIndex;
                servicioCliente.ModificarCliente(clienteActual);
                bindingClientes[bindingClientes.IndexOf(clienteActual)] = clienteActual;
            }
            else
            {
                var cliente = new Cliente()
                {
                    Nombre = txt_NombCliente.Text,
                    Apellido = txt_ApellidoCliente.Text,
                    DNI = txt_DNIcliente.Text,
                    FechaDeNacimiento = DTP_cliente.Value,
                    Genero = (Generos)combo_genero.SelectedIndex,
                    FechaDeInscripcion = DateTime.Now,
                    IDCliente = Guid.NewGuid()
                };
                bindingClientes.Add(cliente);
                servicioCliente.CrearCliente(cliente);
            }
        }

        private void dgv_clientes_KeyDown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
            {
                if(dgv_clientes.SelectedRows.Count == 1)
                {
                    var cliente = (Cliente)dgv_clientes.SelectedRows[0].DataBoundItem;
                    btn_aceptar.Text = "Modificar";
                    clienteActual = cliente;
                    txt_NombCliente.Text = cliente.Nombre;
                    txt_ApellidoCliente.Text = cliente.Apellido;
                    txt_DNIcliente.Text = cliente.DNI;
                    DTP_cliente.Value = cliente.FechaDeNacimiento;
                    combo_genero.SelectedIndex = (int)cliente.Genero;
                }
                
            }
            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in dgv_clientes.SelectedRows)
                {
                    var cliente = (Cliente)r.DataBoundItem;
                    servicioCliente.BorrarCliente(cliente.IDCliente);
                    bindingClientes.Remove(cliente);
                }
            }
        }
    }
}