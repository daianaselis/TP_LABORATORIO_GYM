using MaterialSkin.Controls;
using Modelo.Clases;
using Modelo.Interfaces;
using System.ComponentModel;
using System.Reflection;

namespace TP_LABORATORIO_GYM
{
    public partial class Pagos : MaterialForm
    {
        Empleado empleadoActual;
        IServicioCliente servicioCliente;
        IServicioCuotas servicioCuotas;
        BindingList<Cuota> bindingPagos;
        MenuPrincipal principal;
        public Pagos(IServicioCliente servicioCliente, IServicioCuotas servicioCuotas)
        {
            InitializeComponent();
            this.servicioCliente = servicioCliente;
            this.servicioCuotas = servicioCuotas;
            bindingPagos = new BindingList<Cuota>(servicioCuotas.TraerCuotas());
            this.FormClosing += Pagos_FormClosing;
            StateManager.MaterialSkinManager.AddFormToManage(this);
        }

        public void CargarDatos(Empleado empleado, MenuPrincipal menuPrincipal)
        {
            empleadoActual = empleado;
            principal = menuPrincipal;
            combo_clientes.DataSource = null;
            combo_clientes.DataSource = servicioCliente.TraerClientes();
            combo_clientes.DisplayMember = "DNI";
            dgv_pagos.DataSource = null;
            dgv_pagos.DataSource = bindingPagos;
            dgv_pagos.Columns[3].ValueType = typeof(string);
            dgv_pagos.Columns[3].DataPropertyName = "Cliente.DNI";
            dgv_pagos.Columns[3].HeaderText = "Cliente";
            dgv_pagos.Columns[4].ValueType = typeof(string);
            dgv_pagos.Columns[4].DataPropertyName = "Empleado.Legajo";
            dgv_pagos.Columns[4].HeaderText = "Empleado";
        }

        private void btn_Pagos_Click(object sender, EventArgs e)
        {
            try
            {
                Cuota cuota = new Cuota()
                {
                    Empleado = empleadoActual,
                    IDCuota = Guid.NewGuid(),
                    FechaDePago = DateTime.Now,
                    Monto = double.Parse(txt_monto.Text),
                    Cliente = (Cliente)combo_clientes.SelectedItem
                };
                servicioCuotas.PagarCuota(cuota);
                bindingPagos.Add(cuota);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_pagos_formatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_pagos.Rows[e.RowIndex].DataBoundItem != null &&
                dgv_pagos.Columns[e.ColumnIndex].DataPropertyName.Contains("."))
            {
                e.Value = BindProperty(dgv_pagos.Rows[e.RowIndex].DataBoundItem,
                    dgv_pagos.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";

            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;

                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();

                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(propertyInfo.GetValue(property, null),
                        propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;

                if (property != null)
                {
                    propertyType = property.GetType();
                    propertyInfo = propertyType.GetProperty(propertyName);
                    retValue = propertyInfo.GetValue(property, null).ToString();
                }
            }

            return retValue;
        }



        private void Pagos_FormClosing(object? sender, FormClosingEventArgs e)
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
