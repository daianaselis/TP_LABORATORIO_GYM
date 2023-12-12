using MaterialSkin.Controls;
using Modelo.Clases;
using Modelo.Interfaces;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TP_LABORATORIO_GYM
{
    public partial class ABMClientes : MaterialForm
    {
        private IServicioCliente servicioCliente;
        BindingList<Cliente> bindingClientes;
        Cliente clienteActual;
        MenuPrincipal principal;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

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

            FormClosing += ABM_FormClosing;
            StateManager.MaterialSkinManager.AddFormToManage(this);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void CargarDatos(MenuPrincipal menuPrincipal)
        {
            principal = menuPrincipal;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (btn_aceptar.Text == "Modificar")
            {
                clienteActual.Nombre = txt_nombre.Text;
                clienteActual.Apellido = txt_apellido.Text;
                clienteActual.DNI = txt_dni.Text;
                clienteActual.FechaDeNacimiento = dtp_fechaNacimiento.Value;
                clienteActual.Genero = (Generos)combo_genero.SelectedIndex;
                servicioCliente.ModificarCliente(clienteActual);
                bindingClientes[bindingClientes.IndexOf(clienteActual)] = clienteActual;
                btn_aceptar.Text = "Ingresar";
                MessageBox.Show("Cliente modificado!");
            }
            else
            {
                var cliente = new Cliente()
                {
                    Nombre = txt_nombre.Text,
                    Apellido = txt_apellido.Text,
                    DNI = txt_dni.Text,
                    FechaDeNacimiento = dtp_fechaNacimiento.Value,
                    Genero = (Generos)combo_genero.SelectedIndex,
                    FechaDeInscripcion = DateTime.Now,
                    IDCliente = Guid.NewGuid()
                };
                bindingClientes.Add(cliente);
                servicioCliente.CrearCliente(cliente);
                MessageBox.Show("Cliente Agregado!");
            }
            ReiniciarTextboxes();
        }

        private void ReiniciarTextboxes()
        {
            txt_apellido.Clear();
            txt_nombre.Clear();
            txt_dni.Clear();
            dtp_fechaNacimiento.Value = DateTime.Now;
        }

        private void dgv_clientes_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (dgv_clientes.SelectedRows.Count == 1)
                {
                    var cliente = (Cliente)dgv_clientes.SelectedRows[0].DataBoundItem;
                    btn_aceptar.Text = "Modificar";
                    clienteActual = cliente;
                    txt_nombre.Text = cliente.Nombre;
                    txt_apellido.Text = cliente.Apellido;
                    txt_dni.Text = cliente.DNI;
                    dtp_fechaNacimiento.Value = cliente.FechaDeNacimiento;
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
                    MessageBox.Show("Cliente Borrado!");
                }
            }
        }

        private void ABM_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                principal.Show();
            }
        }
    }
}