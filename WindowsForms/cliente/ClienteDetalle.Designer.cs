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
            btnAceptar.Location = new Point(361, 220);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(12, 45);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 20);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(131, 42);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(126, 27);
            tbxId.TabIndex = 3;
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(131, 75);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(224, 27);
            tbxNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 78);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // tbxApellido
            // 
            tbxApellido.Location = new Point(131, 108);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.Size = new Size(224, 27);
            tbxApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(12, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // tbxFechaAlta
            // 
            tbxFechaAlta.Location = new Point(131, 174);
            tbxFechaAlta.Name = "tbxFechaAlta";
            tbxFechaAlta.Size = new Size(126, 27);
            tbxFechaAlta.TabIndex = 9;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Location = new Point(12, 177);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(78, 20);
            lblFechaAlta.TabIndex = 8;
            lblFechaAlta.Text = "Fecha Alta";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(131, 141);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(224, 27);
            tbxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 262);
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