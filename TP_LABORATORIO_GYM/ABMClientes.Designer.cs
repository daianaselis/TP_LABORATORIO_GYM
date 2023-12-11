namespace TP_LABORATORIO_GYM
{
    partial class ABMClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_DNIcliente = new TextBox();
            txt_ApellidoCliente = new TextBox();
            txt_NombCliente = new TextBox();
            lbl_DNI = new Label();
            lbl_apellido = new Label();
            lbl_Nombre = new Label();
            label2 = new Label();
            DTP_cliente = new DateTimePicker();
            combo_genero = new ComboBox();
            dgv_clientes = new DataGridView();
            btn_aceptar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 288);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 16;
            label1.Text = "Fecha Nacimiento:";
            // 
            // txt_DNIcliente
            // 
            txt_DNIcliente.Location = new Point(184, 229);
            txt_DNIcliente.Name = "txt_DNIcliente";
            txt_DNIcliente.Size = new Size(238, 23);
            txt_DNIcliente.TabIndex = 15;
            // 
            // txt_ApellidoCliente
            // 
            txt_ApellidoCliente.Location = new Point(184, 169);
            txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            txt_ApellidoCliente.Size = new Size(238, 23);
            txt_ApellidoCliente.TabIndex = 14;
            // 
            // txt_NombCliente
            // 
            txt_NombCliente.Location = new Point(184, 106);
            txt_NombCliente.Name = "txt_NombCliente";
            txt_NombCliente.Size = new Size(238, 23);
            txt_NombCliente.TabIndex = 13;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(82, 237);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(30, 15);
            lbl_DNI.TabIndex = 12;
            lbl_DNI.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(58, 172);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(54, 15);
            lbl_apellido.TabIndex = 11;
            lbl_apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(58, 114);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(54, 15);
            lbl_Nombre.TabIndex = 10;
            lbl_Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 334);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 17;
            label2.Text = "Genero:";
            // 
            // DTP_cliente
            // 
            DTP_cliente.Location = new Point(222, 282);
            DTP_cliente.Name = "DTP_cliente";
            DTP_cliente.Size = new Size(200, 23);
            DTP_cliente.TabIndex = 18;
            // 
            // combo_genero
            // 
            combo_genero.FormattingEnabled = true;
            combo_genero.Location = new Point(184, 331);
            combo_genero.Name = "combo_genero";
            combo_genero.Size = new Size(238, 23);
            combo_genero.TabIndex = 19;
            // 
            // dgv_clientes
            // 
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(507, 106);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(802, 423);
            dgv_clientes.TabIndex = 21;
            dgv_clientes.KeyDown += dgv_clientes_KeyDown;
            // 
            // btn_aceptar
            // 
            btn_aceptar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_aceptar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_aceptar.Depth = 0;
            btn_aceptar.HighEmphasis = true;
            btn_aceptar.Icon = null;
            btn_aceptar.Location = new Point(331, 387);
            btn_aceptar.Margin = new Padding(4, 6, 4, 6);
            btn_aceptar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.NoAccentTextColor = Color.Empty;
            btn_aceptar.Size = new Size(91, 36);
            btn_aceptar.TabIndex = 22;
            btn_aceptar.Text = "Ingresar";
            btn_aceptar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_aceptar.UseAccentColor = false;
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // ABMClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clientes_potenciales_de_un_gimnasio_que_buscan_y_quienes_son_1280x720;
            ClientSize = new Size(1329, 591);
            Controls.Add(btn_aceptar);
            Controls.Add(dgv_clientes);
            Controls.Add(combo_genero);
            Controls.Add(DTP_cliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_DNIcliente);
            Controls.Add(txt_ApellidoCliente);
            Controls.Add(txt_NombCliente);
            Controls.Add(lbl_DNI);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_Nombre);
            Name = "ABMClientes";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_DNIcliente;
        private TextBox txt_ApellidoCliente;
        private TextBox txt_NombCliente;
        private Label lbl_DNI;
        private Label lbl_apellido;
        private Label lbl_Nombre;
        private Label label2;
        private DateTimePicker DTP_cliente;
        private ComboBox combo_genero;
        private DataGridView dgv_clientes;
        private MaterialSkin.Controls.MaterialButton btn_aceptar;
    }
}