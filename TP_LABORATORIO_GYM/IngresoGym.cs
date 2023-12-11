using MaterialSkin.Controls;
using Modelo.Interfaces;
using System.Runtime.InteropServices;

namespace TP_LABORATORIO_GYM
{
    public partial class IngresoGym : MaterialForm
    {
        IServicioCliente servicioCliente;
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

        public IngresoGym(IServicioCliente _servicioCliente)
        {
            InitializeComponent();
            servicioCliente = _servicioCliente;
            this.FormClosing += IngresoGym_FormClosing;
            StateManager.MaterialSkinManager.AddFormToManage(this);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void CargarDatos(MenuPrincipal menuPrincipal)
        {
            principal = menuPrincipal;
        }

        private void btnIngresoGym_Click(object sender, EventArgs e)
        {
            try
            {
                servicioCliente.VerificarAccesoGym(txt_dni.Text);
                MessageBox.Show("ACCESO CONCEDIDO");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

        }

        private void IngresoGym_FormClosing(object? sender, FormClosingEventArgs e)
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
