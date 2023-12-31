﻿using MaterialSkin.Controls;
using Modelo.Interfaces;
using System.Runtime.InteropServices;


namespace TP_LABORATORIO_GYM
{
    public partial class Login : MaterialForm
    {
        IServicioEmpleado servicioEmpleado;
        MenuPrincipal menuPrincipal;

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

        public Login(IServicioEmpleado _servicioEmpleado, MenuPrincipal _menuPrincipal)
        {
            InitializeComponent();
            servicioEmpleado = _servicioEmpleado;
            menuPrincipal = _menuPrincipal;
            StateManager.MaterialSkinManager.AddFormToManage(this);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            var empleado = servicioEmpleado.IniciarSesion(
                txt_Legajo.Text,
                txt_Password.Text
            );
            if (empleado != null)
            {
                menuPrincipal.CargarDatos(empleado);
                menuPrincipal.Show();
                this.Hide();
                menuPrincipal.FormClosed += ShowForm;
            }
            else
            {
                MessageBox.Show("Login incorrecto, intente denuevo");
            }
        }

        private void ShowForm(object? sender, EventArgs e)
        {
            this.Show();
        }

        private void Pagos_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }


    }
}
