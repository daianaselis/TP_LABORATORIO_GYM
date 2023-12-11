using MaterialSkin.Controls;
using Modelo.Clases;
using System.Runtime.InteropServices;

namespace TP_LABORATORIO_GYM
{
    public partial class MenuPrincipal : MaterialForm
    {
        Empleado empleadoActual;
        ABMClientes ABMClientes;
        Pagos pagosForm;
        IngresoGym ingresoGym;

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

        public MenuPrincipal(ABMClientes _ABMClientes, Pagos pagosForm, IngresoGym ingresoGym)
        {
            InitializeComponent();
            ABMClientes = _ABMClientes;
            this.pagosForm = pagosForm;
            this.ingresoGym = ingresoGym;
            FormClosing += MenuPrincipal_FormClosing;
            StateManager.MaterialSkinManager.AddFormToManage(this);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public void CargarDatos(Empleado empleadoActual)
        {
            this.empleadoActual = empleadoActual;
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ABMClientes.CargarDatos(this);
            ABMClientes.Show();
            this.Hide();
        }
        private void btn_pagos_Click(object sender, EventArgs e)
        {
            pagosForm.CargarDatos(empleadoActual, this);
            pagosForm.Show();
            this.Hide();
        }

        private void MenuPrincipal_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
            else
            {
                Console.WriteLine(e.CloseReason);
            }
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            ingresoGym.CargarDatos(this);
            ingresoGym.Show();
            this.Hide();
        }


    }
}
