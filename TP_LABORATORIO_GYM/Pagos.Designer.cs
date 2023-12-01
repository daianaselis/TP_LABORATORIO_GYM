namespace TP_LABORATORIO_GYM
{
    partial class Pagos
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
            btn_Pagos = new Button();
            label1 = new Label();
            txt_monto = new TextBox();
            dgv_pagos = new DataGridView();
            combo_clientes = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_pagos).BeginInit();
            SuspendLayout();
            // 
            // btn_Pagos
            // 
            btn_Pagos.Location = new Point(91, 272);
            btn_Pagos.Name = "btn_Pagos";
            btn_Pagos.Size = new Size(167, 40);
            btn_Pagos.TabIndex = 0;
            btn_Pagos.Text = "Realizar pago";
            btn_Pagos.UseVisualStyleBackColor = true;
            btn_Pagos.Click += btn_Pagos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 232);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Monto";
            // 
            // txt_monto
            // 
            txt_monto.Location = new Point(147, 229);
            txt_monto.Name = "txt_monto";
            txt_monto.Size = new Size(100, 23);
            txt_monto.TabIndex = 2;
            // 
            // dgv_pagos
            // 
            dgv_pagos.AllowUserToAddRows = false;
            dgv_pagos.AllowUserToDeleteRows = false;
            dgv_pagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pagos.Location = new Point(407, 40);
            dgv_pagos.Name = "dgv_pagos";
            dgv_pagos.ReadOnly = true;
            dgv_pagos.RowTemplate.Height = 25;
            dgv_pagos.Size = new Size(532, 449);
            dgv_pagos.TabIndex = 3;
            dgv_pagos.CellFormatting += dgv_pagos_formatting;
            // 
            // combo_clientes
            // 
            combo_clientes.FormattingEnabled = true;
            combo_clientes.Location = new Point(147, 153);
            combo_clientes.Name = "combo_clientes";
            combo_clientes.Size = new Size(121, 23);
            combo_clientes.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 156);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 510);
            Controls.Add(label2);
            Controls.Add(combo_clientes);
            Controls.Add(dgv_pagos);
            Controls.Add(txt_monto);
            Controls.Add(label1);
            Controls.Add(btn_Pagos);
            Name = "Pagos";
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)dgv_pagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pagos;
        private Label label1;
        private TextBox txt_monto;
        private DataGridView dgv_pagos;
        private ComboBox combo_clientes;
        private Label label2;
    }
}