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
            label1 = new Label();
            txt_Legajo = new TextBox();
            txt_Password = new TextBox();
            btn_iniciarSesion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(322, 77);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "INICIO DE SESION";
            // 
            // txt_Legajo
            // 
            txt_Legajo.BackColor = Color.White;
            txt_Legajo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Legajo.Location = new Point(257, 170);
            txt_Legajo.Name = "txt_Legajo";
            txt_Legajo.PlaceholderText = "Legajo";
            txt_Legajo.Size = new Size(341, 32);
            txt_Legajo.TabIndex = 1;
            // 
            // txt_Password
            // 
            txt_Password.BackColor = Color.White;
            txt_Password.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(257, 239);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.PlaceholderText = "Password";
            txt_Password.Size = new Size(341, 32);
            txt_Password.TabIndex = 2;
            // 
            // btn_iniciarSesion
            // 
            btn_iniciarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_iniciarSesion.Location = new Point(352, 337);
            btn_iniciarSesion.Name = "btn_iniciarSesion";
            btn_iniciarSesion.Size = new Size(143, 34);
            btn_iniciarSesion.TabIndex = 3;
            btn_iniciarSesion.Text = "INICIAR SESION";
            btn_iniciarSesion.UseVisualStyleBackColor = true;
            btn_iniciarSesion.Click += btn_iniciarSesion_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(857, 458);
            Controls.Add(btn_iniciarSesion);
            Controls.Add(txt_Password);
            Controls.Add(txt_Legajo);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Legajo;
        private TextBox txt_Password;
        private Button btn_iniciarSesion;
    }
}