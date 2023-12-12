namespace TP_LABORATORIO_GYM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btn_iniciarSesion = new MaterialSkin.Controls.MaterialButton();
            txt_Legajo = new MaterialSkin.Controls.MaterialTextBox();
            txt_Password = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_iniciarSesion
            // 
            btn_iniciarSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_iniciarSesion.BackColor = Color.White;
            btn_iniciarSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_iniciarSesion.Depth = 0;
            btn_iniciarSesion.HighEmphasis = true;
            btn_iniciarSesion.Icon = null;
            btn_iniciarSesion.Location = new Point(542, 521);
            btn_iniciarSesion.Margin = new Padding(4, 6, 4, 6);
            btn_iniciarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            btn_iniciarSesion.Name = "btn_iniciarSesion";
            btn_iniciarSesion.NoAccentTextColor = Color.Empty;
            btn_iniciarSesion.Size = new Size(91, 36);
            btn_iniciarSesion.TabIndex = 4;
            btn_iniciarSesion.Text = "INGRESAR";
            btn_iniciarSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_iniciarSesion.UseAccentColor = false;
            btn_iniciarSesion.UseVisualStyleBackColor = false;
            btn_iniciarSesion.Click += btn_iniciarSesion_Click;
            // 
            // txt_Legajo
            // 
            txt_Legajo.AnimateReadOnly = false;
            txt_Legajo.BackColor = SystemColors.InactiveBorder;
            txt_Legajo.BorderStyle = BorderStyle.None;
            txt_Legajo.Depth = 0;
            txt_Legajo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Legajo.LeadingIcon = null;
            txt_Legajo.Location = new Point(432, 266);
            txt_Legajo.MaxLength = 50;
            txt_Legajo.MouseState = MaterialSkin.MouseState.OUT;
            txt_Legajo.Multiline = false;
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.Size = new Size(326, 50);
            txt_Legajo.TabIndex = 5;
            txt_Legajo.Text = "";
            txt_Legajo.TrailingIcon = null;
            // 
            // txt_Password
            // 
            txt_Password.AnimateReadOnly = false;
            txt_Password.BorderStyle = BorderStyle.None;
            txt_Password.Depth = 0;
            txt_Password.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_Password.LeadingIcon = null;
            txt_Password.Location = new Point(432, 353);
            txt_Password.MaxLength = 50;
            txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            txt_Password.Multiline = false;
            txt_Password.Name = "txt_Password";
            txt_Password.Password = true;
            txt_Password.Size = new Size(326, 50);
            txt_Password.TabIndex = 6;
            txt_Password.Text = "";
            txt_Password.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(432, 228);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(49, 19);
            materialLabel1.TabIndex = 7;
            materialLabel1.Text = "Legajo";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(432, 331);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(82, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 656);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Location = new Point(411, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 139);
            panel2.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(779, 725);
            Controls.Add(panel1);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txt_Password);
            Controls.Add(txt_Legajo);
            Controls.Add(btn_iniciarSesion);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Login";
            Sizable = false;
            Text = "Iniciar Sesion";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private MaterialSkin.Controls.MaterialButton btn_iniciarSesion;
        private MaterialSkin.Controls.MaterialTextBox txt_Legajo;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        #endregion

        private Panel panel1;
        private Panel panel2;
    }
}