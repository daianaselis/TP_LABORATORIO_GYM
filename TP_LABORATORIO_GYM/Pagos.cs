using MaterialSkin.Controls;
using Modelo.Clases;
using Modelo.Interfaces;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TP_LABORATORIO_GYM
{
    public partial class Pagos : MaterialForm
    {
        Empleado empleadoActual;
        IServicioCliente servicioCliente;
        IServicioCuotas servicioCuotas;
        BindingList<Cuota> bindingPagos;
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
        public Pagos(IServicioCliente servicioCliente, IServicioCuotas servicioCuotas)
        {
            InitializeComponent();            
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.servicioCliente = servicioCliente;
            this.servicioCuotas = servicioCuotas;
            bindingPagos = new BindingList<Cuota>(servicioCuotas.TraerCuotas());
            this.FormClosing += Pagos_FormClosing;
            dgv_pagos.AutoGenerateColumns = false;
            StateManager.MaterialSkinManager.AddFormToManage(this);

            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.DataPropertyName = "IDCuota";
            col1.HeaderText = "ID Cuota";
            dgv_pagos.Columns.Add(col1);

            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.DataPropertyName = "Monto";
            col2.HeaderText = "Monto";
            dgv_pagos.Columns.Add(col2);

            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.DataPropertyName = "FechaDePago";
            col3.HeaderText = "Fecha De Pago";
            dgv_pagos.Columns.Add(col3);

            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.DataPropertyName = "Cliente.DNI";
            col4.HeaderText = "DNI Cliente";
            dgv_pagos.Columns.Add(col4);

            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.DataPropertyName = "Empleado.Legajo";
            col5.HeaderText = "Legajo Empleado";
            dgv_pagos.Columns.Add(col5);
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
                    Monto = double.Parse(pagos_txt.Text),
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
