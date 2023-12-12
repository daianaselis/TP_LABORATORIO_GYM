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
            lbl_DNI = new Label();
            lbl_apellido = new Label();
            lbl_Nombre = new Label();
            label2 = new Label();
            dgv_clientes = new DataGridView();
            btn_aceptar = new MaterialSkin.Controls.MaterialButton();
            txt_nombre = new MaterialSkin.Controls.MaterialTextBox();
            txt_apellido = new MaterialSkin.Controls.MaterialTextBox();
            txt_dni = new MaterialSkin.Controls.MaterialTextBox();
            combo_genero = new MaterialSkin.Controls.MaterialComboBox();
            dtp_fechaNacimiento = new DateTimePicker();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 313);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 16;
            label1.Text = "Fecha Nacimiento:";
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(55, 253);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(30, 15);
            lbl_DNI.TabIndex = 12;
            lbl_DNI.Text = "DNI:";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(43, 186);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(54, 15);
            lbl_apellido.TabIndex = 11;
            lbl_apellido.Text = "Apellido:";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(43, 120);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(54, 15);
            lbl_Nombre.TabIndex = 10;
            lbl_Nombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 386);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 17;
            label2.Text = "Genero:";
            // 
            // dgv_clientes
            // 
            dgv_clientes.BackgroundColor = Color.SeaShell;
            dgv_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_clientes.Location = new Point(388, 85);
            dgv_clientes.Name = "dgv_clientes";
            dgv_clientes.RowTemplate.Height = 25;
            dgv_clientes.Size = new Size(735, 427);
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
            btn_aceptar.Location = new Point(233, 489);
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
            // txt_nombre
            // 
            txt_nombre.AnimateReadOnly = false;
            txt_nombre.BorderStyle = BorderStyle.None;
            txt_nombre.Depth = 0;
            txt_nombre.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_nombre.LeadingIcon = null;
            txt_nombre.Location = new Point(158, 102);
            txt_nombre.MaxLength = 50;
            txt_nombre.MouseState = MaterialSkin.MouseState.OUT;
            txt_nombre.Multiline = false;
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(205, 50);
            txt_nombre.TabIndex = 23;
            txt_nombre.Text = "";
            txt_nombre.TrailingIcon = null;
            // 
            // txt_apellido
            // 
            txt_apellido.AnimateReadOnly = false;
            txt_apellido.BorderStyle = BorderStyle.None;
            txt_apellido.Depth = 0;
            txt_apellido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_apellido.LeadingIcon = null;
            txt_apellido.Location = new Point(158, 172);
            txt_apellido.MaxLength = 50;
            txt_apellido.MouseState = MaterialSkin.MouseState.OUT;
            txt_apellido.Multiline = false;
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(205, 50);
            txt_apellido.TabIndex = 24;
            txt_apellido.Text = "";
            txt_apellido.TrailingIcon = null;
            // 
            // txt_dni
            // 
            txt_dni.AnimateReadOnly = false;
            txt_dni.BorderStyle = BorderStyle.None;
            txt_dni.Depth = 0;
            txt_dni.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txt_dni.LeadingIcon = null;
            txt_dni.Location = new Point(158, 237);
            txt_dni.MaxLength = 50;
            txt_dni.MouseState = MaterialSkin.MouseState.OUT;
            txt_dni.Multiline = false;
            txt_dni.Name = "txt_dni";
            txt_dni.Size = new Size(205, 50);
            txt_dni.TabIndex = 25;
            txt_dni.Text = "";
            txt_dni.TrailingIcon = null;
            // 
            // combo_genero
            // 
            combo_genero.AutoResize = false;
            combo_genero.BackColor = Color.FromArgb(255, 255, 255);
            combo_genero.Depth = 0;
            combo_genero.DrawMode = DrawMode.OwnerDrawVariable;
            combo_genero.DropDownHeight = 174;
            combo_genero.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_genero.DropDownWidth = 121;
            combo_genero.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            combo_genero.ForeColor = Color.FromArgb(222, 0, 0, 0);
            combo_genero.FormattingEnabled = true;
            combo_genero.IntegralHeight = false;
            combo_genero.ItemHeight = 43;
            combo_genero.Location = new Point(158, 352);
            combo_genero.MaxDropDownItems = 4;
            combo_genero.MouseState = MaterialSkin.MouseState.OUT;
            combo_genero.Name = "combo_genero";
            combo_genero.Size = new Size(205, 49);
            combo_genero.StartIndex = 0;
            combo_genero.TabIndex = 26;
            // 
            // dtp_fechaNacimiento
            // 
            dtp_fechaNacimiento.Location = new Point(158, 307);
            dtp_fechaNacimiento.Name = "dtp_fechaNacimiento";
            dtp_fechaNacimiento.Size = new Size(182, 23);
            dtp_fechaNacimiento.TabIndex = 27;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // ABMClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Clientes_potenciales_de_un_gimnasio_que_buscan_y_quienes_son_1280x720;
            ClientSize = new Size(1157, 609);
            Controls.Add(dtp_fechaNacimiento);
            Controls.Add(combo_genero);
            Controls.Add(txt_dni);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(btn_aceptar);
            Controls.Add(dgv_clientes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_DNI);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_Nombre);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "ABMClientes";
            Sizable = false;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgv_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_DNI;
        private Label lbl_apellido;
        private Label lbl_Nombre;
        private Label label2;
        private DataGridView dgv_clientes;
        private MaterialSkin.Controls.MaterialButton btn_aceptar;
        private MaterialSkin.Controls.MaterialTextBox txt_nombre;
        private MaterialSkin.Controls.MaterialTextBox txt_apellido;
        private MaterialSkin.Controls.MaterialTextBox txt_dni;
        private MaterialSkin.Controls.MaterialComboBox combo_genero;
        private DateTimePicker dtp_fechaNacimiento;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}