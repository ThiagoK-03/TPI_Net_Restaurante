namespace WindowsForms
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblId = new Label();
            tbxId = new TextBox();
            tbxNombre = new TextBox();
            lblNombre = new Label();
            tbxApellido = new TextBox();
            lblApellido = new Label();
            tbxFechaAlta = new TextBox();
            lblFechaAlta = new Label();
            tbxEmail = new TextBox();
            lblEmail = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(316, 165);
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
            btnCancelar.Location = new Point(228, 165);
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
            // tbxNombre
            // 
            tbxNombre.Location = new Point(115, 56);
            tbxNombre.Margin = new Padding(3, 2, 3, 2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(196, 23);
            tbxNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(115, 81);
            tbxApellido.Margin = new Padding(3, 2, 3, 2);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(196, 23);
            tbxApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(10, 83);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // tbxFechaAlta
            // 
            tbxFechaAlta.Location = new Point(115, 130);
            tbxFechaAlta.Margin = new Padding(3, 2, 3, 2);
            tbxFechaAlta.Name = "tbxFechaAlta";
            tbxFechaAlta.Size = new Size(111, 23);
            tbxFechaAlta.TabIndex = 9;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(10, 133);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(62, 15);
            lblFechaAlta.TabIndex = 8;
            lblFechaAlta.Text = "Fecha Alta";
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
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 196);
            Controls.Add(tbxEmail);
            Controls.Add(lblEmail);
            Controls.Add(tbxFechaAlta);
            Controls.Add(lblFechaAlta);
            Controls.Add(tbxApellido);
            Controls.Add(lblApellido);
            Controls.Add(tbxNombre);
            Controls.Add(lblNombre);
            Controls.Add(tbxId);
            Controls.Add(lblId);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClienteDetalle";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblId;
        private TextBox tbxId;
        private TextBox tbxNombre;
        private Label lblNombre;
        private TextBox tbxApellido;
        private Label lblApellido;
        private TextBox tbxFechaAlta;
        private Label lblFechaAlta;
        private TextBox tbxEmail;
        private Label lblEmail;
        private ErrorProvider errorProvider;
    }
}