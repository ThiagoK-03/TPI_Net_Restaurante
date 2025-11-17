namespace WindowsForms.cliente
{
    partial class ClienteDetalle
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
            components = new System.ComponentModel.Container();
            errorProvider = new ErrorProvider(components);
            lblId = new WinFormsControlLibrary1.BasicLabel();
            lblNombre = new WinFormsControlLibrary1.BasicLabel();
            lblApellido = new WinFormsControlLibrary1.BasicLabel();
            lblEmail = new WinFormsControlLibrary1.BasicLabel();
            btnAceptar = new WinFormsControlLibrary1.RedButton();
            btnCancelar = new WinFormsControlLibrary1.RedButton();
            tbxEmail = new WinFormsControlLibrary1.BasicTxtBox();
            tbxApellido = new WinFormsControlLibrary1.BasicTxtBox();
            tbxNombre = new WinFormsControlLibrary1.BasicTxtBox();
            tbxId = new WinFormsControlLibrary1.BasicTxtBox();
            tbxUsername = new WinFormsControlLibrary1.BasicTxtBox();
            lblUsername = new WinFormsControlLibrary1.BasicLabel();
            tbxTelefono = new WinFormsControlLibrary1.BasicTxtBox();
            lblTelefono = new WinFormsControlLibrary1.BasicLabel();
            tbxPassword = new WinFormsControlLibrary1.BasicTxtBox();
            lblPassword = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(436, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(405, 0);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(325, 61);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MistyRose;
            lblNombre.Location = new Point(325, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 27);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.MistyRose;
            lblApellido.Location = new Point(326, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 27);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MistyRose;
            lblEmail.Location = new Point(325, 147);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 27);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
            btnAceptar.Location = new Point(336, 315);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MistyRose;
            btnCancelar.Location = new Point(245, 315);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.MistyRose;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Location = new Point(140, 150);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Content";
            tbxEmail.Size = new Size(169, 16);
            tbxEmail.TabIndex = 20;
            // 
            // tbxApellido
            // 
            tbxApellido.BackColor = Color.MistyRose;
            tbxApellido.BorderStyle = BorderStyle.None;
            tbxApellido.Location = new Point(140, 123);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.PlaceholderText = "Content";
            tbxApellido.Size = new Size(169, 16);
            tbxApellido.TabIndex = 21;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = Color.MistyRose;
            tbxNombre.BorderStyle = BorderStyle.None;
            tbxNombre.Location = new Point(140, 91);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "Content";
            tbxNombre.Size = new Size(169, 16);
            tbxNombre.TabIndex = 22;
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(209, 64);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(100, 16);
            tbxId.TabIndex = 23;
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.MistyRose;
            tbxUsername.BorderStyle = BorderStyle.None;
            tbxUsername.Location = new Point(140, 181);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PlaceholderText = "Content";
            tbxUsername.Size = new Size(169, 16);
            tbxUsername.TabIndex = 24;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MistyRose;
            lblUsername.Location = new Point(325, 178);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 27);
            lblUsername.TabIndex = 25;
            lblUsername.Text = "Username";
            // 
            // tbxTelefono
            // 
            tbxTelefono.BackColor = Color.MistyRose;
            tbxTelefono.BorderStyle = BorderStyle.None;
            tbxTelefono.Location = new Point(140, 246);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.PlaceholderText = "Content";
            tbxTelefono.Size = new Size(169, 16);
            tbxTelefono.TabIndex = 26;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = Color.MistyRose;
            lblTelefono.Location = new Point(325, 246);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(57, 27);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Telefono";
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.MistyRose;
            tbxPassword.BorderStyle = BorderStyle.None;
            tbxPassword.Location = new Point(140, 212);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PlaceholderText = "Content";
            tbxPassword.Size = new Size(169, 16);
            tbxPassword.TabIndex = 28;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MistyRose;
            lblPassword.Location = new Point(325, 212);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(62, 27);
            lblPassword.TabIndex = 29;
            lblPassword.Text = "Password";
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 364);
            Controls.Add(lblPassword);
            Controls.Add(tbxPassword);
            Controls.Add(lblTelefono);
            Controls.Add(tbxTelefono);
            Controls.Add(lblUsername);
            Controls.Add(tbxUsername);
            Controls.Add(tbxId);
            Controls.Add(tbxNombre);
            Controls.Add(tbxApellido);
            Controls.Add(tbxEmail);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblEmail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteDetalle";
            Text = "Cliente";
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(tbxEmail, 0);
            Controls.SetChildIndex(tbxApellido, 0);
            Controls.SetChildIndex(tbxNombre, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(tbxUsername, 0);
            Controls.SetChildIndex(lblUsername, 0);
            Controls.SetChildIndex(tbxTelefono, 0);
            Controls.SetChildIndex(lblTelefono, 0);
            Controls.SetChildIndex(tbxPassword, 0);
            Controls.SetChildIndex(lblPassword, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private WinFormsControlLibrary1.RedButton btnCancelar;
        private WinFormsControlLibrary1.RedButton btnAceptar;
        private WinFormsControlLibrary1.BasicLabel lblEmail;
        private WinFormsControlLibrary1.BasicLabel lblApellido;
        private WinFormsControlLibrary1.BasicLabel lblNombre;
        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicTxtBox tbxId;
        private WinFormsControlLibrary1.BasicTxtBox tbxNombre;
        private WinFormsControlLibrary1.BasicTxtBox tbxApellido;
        private WinFormsControlLibrary1.BasicTxtBox tbxEmail;
        private WinFormsControlLibrary1.BasicLabel lblUsername;
        private WinFormsControlLibrary1.BasicTxtBox tbxUsername;
        private WinFormsControlLibrary1.BasicLabel lblTelefono;
        private WinFormsControlLibrary1.BasicTxtBox tbxTelefono;
        private WinFormsControlLibrary1.BasicTxtBox tbxPassword;
        private WinFormsControlLibrary1.BasicLabel lblPassword;
    }
}