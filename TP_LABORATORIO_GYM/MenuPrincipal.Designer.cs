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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            btn_clientes = new MaterialSkin.Controls.MaterialButton();
            btn_pagos = new MaterialSkin.Controls.MaterialButton();
            btn_verificar = new MaterialSkin.Controls.MaterialButton();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_clientes
            // 
            btn_clientes.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_clientes.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_clientes.Depth = 0;
            btn_clientes.HighEmphasis = true;
            btn_clientes.Icon = null;
            btn_clientes.Location = new Point(411, 26);
            btn_clientes.Margin = new Padding(4, 6, 4, 6);
            btn_clientes.MouseState = MaterialSkin.MouseState.HOVER;
            btn_clientes.Name = "btn_clientes";
            btn_clientes.NoAccentTextColor = Color.Empty;
            btn_clientes.Size = new Size(88, 36);
            btn_clientes.TabIndex = 3;
            btn_clientes.Text = "Clientes";
            btn_clientes.TextAlign = ContentAlignment.MiddleRight;
            btn_clientes.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_clientes.UseAccentColor = false;
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_pagos
            // 
            btn_pagos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_pagos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_pagos.Depth = 0;
            btn_pagos.HighEmphasis = true;
            btn_pagos.Icon = null;
            btn_pagos.Location = new Point(93, 273);
            btn_pagos.Margin = new Padding(4, 6, 4, 6);
            btn_pagos.MouseState = MaterialSkin.MouseState.HOVER;
            btn_pagos.Name = "btn_pagos";
            btn_pagos.NoAccentTextColor = Color.Empty;
            btn_pagos.Size = new Size(69, 36);
            btn_pagos.TabIndex = 4;
            btn_pagos.Text = "Pagos";
            btn_pagos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_pagos.UseAccentColor = false;
            btn_pagos.UseVisualStyleBackColor = true;
            btn_pagos.Click += btn_pagos_Click;
            // 
            // btn_verificar
            // 
            btn_verificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_verificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_verificar.Depth = 0;
            btn_verificar.HighEmphasis = true;
            btn_verificar.Icon = null;
            btn_verificar.Location = new Point(350, 365);
            btn_verificar.Margin = new Padding(4, 6, 4, 6);
            btn_verificar.MouseState = MaterialSkin.MouseState.HOVER;
            btn_verificar.Name = "btn_verificar";
            btn_verificar.NoAccentTextColor = Color.Empty;
            btn_verificar.Size = new Size(178, 36);
            btn_verificar.TabIndex = 5;
            btn_verificar.Text = "Ingreso al gimnasio";
            btn_verificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_verificar.UseAccentColor = false;
            btn_verificar.UseVisualStyleBackColor = true;
            btn_verificar.Click += btn_verificar_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._614b7f59f1c03cfebaa0d7ce09dc5c0c;
            panel1.Controls.Add(btn_clientes);
            panel1.Controls.Add(btn_pagos);
            panel1.Controls.Add(btn_verificar);
            panel1.Location = new Point(6, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 441);
            panel1.TabIndex = 6;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 514);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Sizable = false;
            Text = "MenuPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_clientes;
        private MaterialSkin.Controls.MaterialButton btn_pagos;
        private MaterialSkin.Controls.MaterialButton btn_verificar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
    }
}