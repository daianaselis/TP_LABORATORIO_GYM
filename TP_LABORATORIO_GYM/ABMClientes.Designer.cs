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
            btn_aceptar = new Button();
            dgv_clientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 212);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 16;
            label1.Text = "Fecha Nacimiento";
            // 
            // txt_DNIcliente
            // 
            txt_DNIcliente.Location = new Point(177, 153);
            txt_DNIcliente.Name = "txt_DNIcliente";
            txt_DNIcliente.Size = new Size(238, 23);
            txt_DNIcliente.TabIndex = 15;
            // 
            // txt_ApellidoCliente
            // 
            txt_ApellidoCliente.Location = new Point(177, 93);
            txt_ApellidoCliente.Name = "txt_ApellidoCliente";
            txt_ApellidoCliente.Size = new Size(238, 23);
            txt_ApellidoCliente.TabIndex = 14;
            // 
            // txt_NombCliente
            // 
            txt_NombCliente.Location = new Point(177, 30);
            txt_NombCliente.Name = "txt_NombCliente";
            txt_NombCliente.Size = new Size(238, 23);
            txt_NombCliente.TabIndex = 13;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(60, 161);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(30, 15);
            lbl_DNI.TabIndex = 12;
            lbl_DNI.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(49, 101);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 11;
            lbl_apellido.Text = "Apellido";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(49, 38);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(54, 15);
            lbl_Nombre.TabIndex = 10;
            lbl_Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 255);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 17;
            label2.Text = "Genero";
            // 
            // DTP_cliente
            // 
            DTP_cliente.Location = new Point(215, 206);
            DTP_cliente.Name = "DTP_cliente";
            DTP_cliente.Size = new Size(200, 23);
            DTP_cliente.TabIndex = 18;
            // 
            // combo_genero
            // 
            combo_genero.FormattingEnabled = true;
            combo_genero.Location = new Point(177, 255);
            combo_genero.Name = "combo_genero";
            combo_genero.Size = new Size(238, 23);
            combo_genero.TabIndex = 19;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(340, 308);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 20;
            btn_aceptar.Text = "Ingresar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // dgv_clientes
            // 
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(477, 30);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(611, 423);
            dgv_clientes.TabIndex = 21;
            dgv_clientes.KeyDown += dgv_clientes_KeyDown;
            // 
            // ABMClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 465);
            Controls.Add(dgv_clientes);
            Controls.Add(btn_aceptar);
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
            Text = "ABM Clientes";
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
        private Button btn_aceptar;
        private DataGridView dgv_clientes;
    }
}