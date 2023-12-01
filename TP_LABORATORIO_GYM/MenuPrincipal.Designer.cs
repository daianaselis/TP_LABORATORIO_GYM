namespace TP_LABORATORIO_GYM
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_verificar = new Button();
            btn_clientes = new Button();
            btn_pagos = new Button();
            SuspendLayout();
            // 
            // btn_verificar
            // 
            btn_verificar.Location = new Point(425, 430);
            btn_verificar.Name = "btn_verificar";
            btn_verificar.Size = new Size(141, 23);
            btn_verificar.TabIndex = 0;
            btn_verificar.Text = "Ingreso al gimnasio";
            btn_verificar.UseVisualStyleBackColor = true;
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(24, 82);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(188, 23);
            btn_clientes.TabIndex = 1;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_pagos
            // 
            btn_pagos.Location = new Point(213, 251);
            btn_pagos.Name = "btn_pagos";
            btn_pagos.Size = new Size(183, 23);
            btn_pagos.TabIndex = 2;
            btn_pagos.Text = "Pagos";
            btn_pagos.UseVisualStyleBackColor = true;
            btn_pagos.Click += btn_pagos_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 502);
            Controls.Add(btn_pagos);
            Controls.Add(btn_clientes);
            Controls.Add(btn_verificar);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_verificar;
        private Button btn_clientes;
        private Button btn_pagos;
    }
}