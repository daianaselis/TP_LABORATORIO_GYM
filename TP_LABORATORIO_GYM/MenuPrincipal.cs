using Modelo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LABORATORIO_GYM
{
    public partial class MenuPrincipal : Form
    {
        Empleado empleadoActual;
        ABMClientes ABMClientes;
        Pagos pagosForm;

        public MenuPrincipal(ABMClientes _ABMClientes, Pagos pagosForm)
        {
            InitializeComponent();
            ABMClientes = _ABMClientes;
            this.pagosForm = pagosForm;
        }

        public void CargarDatos(Empleado empleadoActual)
        {
            this.empleadoActual = empleadoActual;
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            //ABMClientes.CargarDatos(empleado);
            ABMClientes.Show();
            this.Hide();
            ABMClientes.FormClosed += ShowForm;
        }

        private void ShowForm(object? sender, EventArgs e)
        {
            this.Show();
        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            pagosForm.CargarDatos(empleadoActual);
            pagosForm.Show();
            this.Hide();
            pagosForm.FormClosed += ShowForm;
        }
    }
}
