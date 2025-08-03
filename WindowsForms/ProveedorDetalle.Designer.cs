namespace WindowsForms
{
    partial class ProveedorDetalle
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            tbxId = new TextBox();
            tbxRazonSocial = new TextBox();
            lblRazonSocial = new Label();
            tbxCuit = new TextBox();
            lblCuit = new Label();
            tbxTelefono = new TextBox();
            lblTelefono = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            tbxTipoIng = new TextBox();
            lblTipoIng = new Label();
            tbxCompania = new TextBox();
            lblCompania = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(317, 249);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(229, 249);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(10, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(115, 32);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(111, 23);
            tbxId.TabIndex = 3;
            // 
            // tbxRazonSocial
            // 
            tbxRazonSocial.Location = new Point(115, 56);
            tbxRazonSocial.Margin = new Padding(3, 2, 3, 2);
            tbxRazonSocial.Name = "tbxRazonSocial";
            tbxRazonSocial.Size = new Size(196, 23);
            tbxRazonSocial.TabIndex = 5;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(10, 58);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(70, 15);
            lblRazonSocial.TabIndex = 4;
            lblRazonSocial.Text = "RazonSocial";
            // 
            // tbxCuit
            // 
            tbxCuit.Location = new Point(115, 81);
            tbxCuit.Margin = new Padding(3, 2, 3, 2);
            tbxCuit.Name = "tbxCuit";
            tbxCuit.Size = new Size(196, 23);
            tbxCuit.TabIndex = 7;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(10, 83);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(29, 15);
            lblCuit.TabIndex = 6;
            lblCuit.Text = "Cuit";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(115, 130);
            tbxTelefono.Margin = new Padding(3, 2, 3, 2);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(111, 23);
            tbxTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(10, 133);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(115, 106);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(196, 23);
            tbxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(10, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // lblTipoIng
            // 
            lblTipoIng.AutoSize = true;
            lblTipoIng.Location = new Point(10, 158);
            lblTipoIng.Name = "lblTipoIng";
            lblTipoIng.Size = new Size(93, 15);
            lblTipoIng.TabIndex = 12;
            lblTipoIng.Text = "Tipo Ingrediente";
            // 
            // tbxTipoIng
            // 
            tbxTipoIng.Location = new Point(115, 155);
            tbxTipoIng.Name = "txtTipoIng";
            tbxTipoIng.Size = new Size(196, 23);
            tbxTipoIng.TabIndex = 13;
            // 
            // tbxCompania
            // 
            tbxCompania.Location = new Point(115, 179);
            tbxCompania.Name = "txtCompania";
            tbxCompania.Size = new Size(196, 23);
            tbxCompania.TabIndex = 15;
            // 
            // lblCompania
            // 
            lblCompania.AutoSize = true;
            lblCompania.Location = new Point(10, 182);
            lblCompania.Name = "lblCompania";
            lblCompania.Size = new Size(62, 15);
            lblCompania.TabIndex = 14;
            lblCompania.Text = "Compañia";
            // 
            // ProveedorDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 313);
            Controls.Add(tbxCompania);
            Controls.Add(lblCompania);
            Controls.Add(tbxTipoIng);
            Controls.Add(lblTipoIng);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxRazonSocial);
            Controls.Add(lblRazonSocial);
            Controls.Add(tbxId);
            Controls.Add(lblId);
            Controls.Add(tbxCuit);
            Controls.Add(lblCuit);
            Controls.Add(tbxTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveedorDetalle";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblId;
        private TextBox tbxId;
        private TextBox tbxRazonSocial;
        private Label lblRazonSocial;
        private TextBox tbxCuit;
        private Label lblCuit;
        private TextBox tbxTelefono;
        private Label lblTelefono;
        private TextBox tbxEmail;
        private Label lblEmail;
        private ErrorProvider errorProvider;
        private Label lblTipoIng;
        private TextBox tbxCompania;
        private Label lblCompania;
        private TextBox tbxTipoIng;
    }
}