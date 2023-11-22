using Modelo.Interfaces;
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
    public partial class Login : Form
    {
        IServicioEmpleado servicioEmpleado;
        MenuPrincipal menuPrincipal;
        public Login(IServicioEmpleado _servicioEmpleado, MenuPrincipal _menuPrincipal)
        {
            InitializeComponent();
            servicioEmpleado = _servicioEmpleado;
            menuPrincipal = _menuPrincipal;
        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            var empleado = servicioEmpleado.IniciarSesion(
                txt_Legajo.Text,
                txt_Password.Text
            );
            if(empleado != null )
            {

            }
        }
    }
}
