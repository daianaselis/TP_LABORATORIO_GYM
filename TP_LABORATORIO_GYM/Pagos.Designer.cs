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
            label1 = new Label();
            dgv_pagos = new DataGridView();
            label2 = new Label();
            btn_Pagos = new MaterialSkin.Controls.MaterialButton();
            combo_clientes = new MaterialSkin.Controls.MaterialComboBox();
            pagos_txt = new MaterialSkin.Controls.MaterialTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_pagos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 246);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Monto";
            // 
            // dgv_pagos
            // 
            dgv_pagos.AllowUserToAddRows = false;
            dgv_pagos.AllowUserToDeleteRows = false;
            dgv_pagos.BackgroundColor = Color.SeaShell;
            dgv_pagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_pagos.Location = new Point(351, 67);
            dgv_pagos.Name = "dgv_pagos";
            dgv_pagos.ReadOnly = true;
            dgv_pagos.RowTemplate.Height = 25;
            dgv_pagos.Size = new Size(562, 431);
            dgv_pagos.TabIndex = 3;
            dgv_pagos.CellFormatting += dgv_pagos_formatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 156);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // btn_Pagos
            // 
            btn_Pagos.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Pagos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Pagos.Depth = 0;
            btn_Pagos.HighEmphasis = true;
            btn_Pagos.Icon = null;
            btn_Pagos.Location = new Point(125, 373);
            btn_Pagos.Margin = new Padding(4, 6, 4, 6);
            btn_Pagos.MouseState = MaterialSkin.MouseState.HOVER;
            btn_Pagos.Name = "btn_Pagos";
            btn_Pagos.NoAccentTextColor = Color.Empty;
            btn_Pagos.Size = new Size(69, 36);
            btn_Pagos.TabIndex = 6;
            btn_Pagos.Text = "Pagar";
            btn_Pagos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Pagos.UseAccentColor = false;
            btn_Pagos.UseVisualStyleBackColor = true;
            btn_Pagos.Click += btn_Pagos_Click;
            // 
            // combo_clientes
            // 
            combo_clientes.AutoResize = false;
            combo_clientes.BackColor = Color.FromArgb(255, 255, 255);
            combo_clientes.Depth = 0;
            combo_clientes.DrawMode = DrawMode.OwnerDrawVariable;
            combo_clientes.DropDownHeight = 174;
            combo_clientes.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_clientes.DropDownWidth = 121;
            combo_clientes.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            combo_clientes.ForeColor = Color.FromArgb(222, 0, 0, 0);
            combo_clientes.FormattingEnabled = true;
            combo_clientes.IntegralHeight = false;
            combo_clientes.ItemHeight = 43;
            combo_clientes.Location = new Point(115, 141);
            combo_clientes.MaxDropDownItems = 4;
            combo_clientes.MouseState = MaterialSkin.MouseState.OUT;
            combo_clientes.Name = "combo_clientes";
            combo_clientes.Size = new Size(196, 49);
            combo_clientes.StartIndex = 0;
            combo_clientes.TabIndex = 7;
            // 
            // pagos_txt
            // 
            pagos_txt.AnimateReadOnly = false;
            pagos_txt.BorderStyle = BorderStyle.None;
            pagos_txt.Depth = 0;
            pagos_txt.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            pagos_txt.LeadingIcon = null;
            pagos_txt.Location = new Point(127, 211);
            pagos_txt.MaxLength = 50;
            pagos_txt.MouseState = MaterialSkin.MouseState.OUT;
            pagos_txt.Multiline = false;
            pagos_txt.Name = "pagos_txt";
            pagos_txt.Size = new Size(167, 50);
            pagos_txt.TabIndex = 8;
            pagos_txt.Text = "";
            pagos_txt.TrailingIcon = null;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 510);
            Controls.Add(pagos_txt);
            Controls.Add(combo_clientes);
            Controls.Add(btn_Pagos);
            Controls.Add(label2);
            Controls.Add(dgv_pagos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Pagos";
            Sizable = false;
            Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)dgv_pagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgv_pagos;
        private Label label2;
        private MaterialSkin.Controls.MaterialButton btn_Pagos;
        private MaterialSkin.Controls.MaterialComboBox combo_clientes;
        private MaterialSkin.Controls.MaterialTextBox pagos_txt;
    }
}