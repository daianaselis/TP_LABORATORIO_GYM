namespace TP_LABORATORIO_GYM
{
    partial class IngresoGym
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
            btnIngresoGym = new MaterialSkin.Controls.MaterialButton();
            txt_dni = new MaterialSkin.Controls.MaterialTextBox2();
            m_labelDni = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // btnIngresoGym
            // 
            btnIngresoGym.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIngresoGym.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIngresoGym.Depth = 0;
            btnIngresoGym.HighEmphasis = true;
            btnIngresoGym.Icon = null;
            btnIngresoGym.Location = new Point(207, 284);
            btnIngresoGym.Margin = new Padding(4, 6, 4, 6);
            btnIngresoGym.MouseState = MaterialSkin.MouseState.HOVER;
            btnIngresoGym.Name = "btnIngresoGym";
            btnIngresoGym.NoAccentTextColor = Color.Empty;
            btnIngresoGym.Size = new Size(93, 36);
            btnIngresoGym.TabIndex = 1;
            btnIngresoGym.Text = "Verificar ";
            btnIngresoGym.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIngresoGym.UseAccentColor = false;
            btnIngresoGym.UseVisualStyleBackColor = true;
            btnIngresoGym.Click += btnIngresoGym_Click;
            // 
            // txt_dni
            // 
            txt_dni.AnimateReadOnly = false;
            txt_dni.BackgroundImageLayout = ImageLayout.None;
            txt_dni.CharacterCasing = CharacterCasing.Normal;
            txt_dni.Depth = 0;
            txt_dni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_dni.HideSelection = true;
            txt_dni.LeadingIcon = null;
            txt_dni.Location = new Point(138, 183);
            txt_dni.MaxLength = 32767;
            txt_dni.MouseState = MaterialSkin.MouseState.OUT;
            txt_dni.Name = "txt_dni";
            txt_dni.PasswordChar = '\0';
            txt_dni.PrefixSuffixText = null;
            txt_dni.ReadOnly = false;
            txt_dni.RightToLeft = RightToLeft.No;
            txt_dni.SelectedText = "";
            txt_dni.SelectionLength = 0;
            txt_dni.SelectionStart = 0;
            txt_dni.ShortcutsEnabled = true;
            txt_dni.Size = new Size(250, 48);
            txt_dni.TabIndex = 2;
            txt_dni.TabStop = false;
            txt_dni.TextAlign = HorizontalAlignment.Left;
            txt_dni.TrailingIcon = null;
            txt_dni.UseSystemPasswordChar = false;
            // 
            // m_labelDni
            // 
            m_labelDni.AutoSize = true;
            m_labelDni.Depth = 0;
            m_labelDni.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            m_labelDni.Location = new Point(138, 161);
            m_labelDni.MouseState = MaterialSkin.MouseState.HOVER;
            m_labelDni.Name = "m_labelDni";
            m_labelDni.Size = new Size(31, 19);
            m_labelDni.TabIndex = 3;
            m_labelDni.Text = "DNI:";
            // 
            // IngresoGym
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 468);
            Controls.Add(m_labelDni);
            Controls.Add(txt_dni);
            Controls.Add(btnIngresoGym);
            Name = "IngresoGym";
            Text = "Ingreso al Gym";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnIngresoGym;
        private MaterialSkin.Controls.MaterialTextBox2 txt_dni;
        private MaterialSkin.Controls.MaterialLabel m_labelDni;
    }
}