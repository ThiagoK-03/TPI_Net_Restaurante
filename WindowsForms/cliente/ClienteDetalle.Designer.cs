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
            lblFechaAlta = new WinFormsControlLibrary1.BasicLabel();
            btnAceptar = new WinFormsControlLibrary1.RedButton();
            btnCancelar = new WinFormsControlLibrary1.RedButton();
            tbxFechaAlta = new WinFormsControlLibrary1.BasicTxtBox();
            tbxEmail = new WinFormsControlLibrary1.BasicTxtBox();
            tbxApellido = new WinFormsControlLibrary1.BasicTxtBox();
            tbxNombre = new WinFormsControlLibrary1.BasicTxtBox();
            tbxId = new WinFormsControlLibrary1.BasicTxtBox();
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
            lblId.Location = new Point(326, 42);
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
            lblNombre.Location = new Point(326, 69);
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
            lblApellido.Location = new Point(327, 101);
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
            lblEmail.Location = new Point(326, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 27);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email";
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.BackColor = Color.Transparent;
            lblFechaAlta.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaAlta.ForeColor = Color.MistyRose;
            lblFechaAlta.Location = new Point(326, 155);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(67, 27);
            lblFechaAlta.TabIndex = 16;
            lblFechaAlta.Text = "Fecha Alta";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
            btnAceptar.Location = new Point(326, 209);
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
            btnCancelar.Location = new Point(235, 209);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tbxFechaAlta
            // 
            tbxFechaAlta.BackColor = Color.MistyRose;
            tbxFechaAlta.BorderStyle = BorderStyle.None;
            tbxFechaAlta.Location = new Point(141, 160);
            tbxFechaAlta.Name = "tbxFechaAlta";
            tbxFechaAlta.PlaceholderText = "Content";
            tbxFechaAlta.Size = new Size(169, 16);
            tbxFechaAlta.TabIndex = 19;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.MistyRose;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Location = new Point(141, 131);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Content";
            tbxEmail.Size = new Size(169, 16);
            tbxEmail.TabIndex = 20;
            // 
            // tbxApellido
            // 
            tbxApellido.BackColor = Color.MistyRose;
            tbxApellido.BorderStyle = BorderStyle.None;
            tbxApellido.Location = new Point(141, 104);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.PlaceholderText = "Content";
            tbxApellido.Size = new Size(169, 16);
            tbxApellido.TabIndex = 21;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = Color.MistyRose;
            tbxNombre.BorderStyle = BorderStyle.None;
            tbxNombre.Location = new Point(141, 72);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "Content";
            tbxNombre.Size = new Size(169, 16);
            tbxNombre.TabIndex = 22;
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(210, 45);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(100, 16);
            tbxId.TabIndex = 23;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 250);
            Controls.Add(tbxId);
            Controls.Add(tbxNombre);
            Controls.Add(tbxApellido);
            Controls.Add(tbxEmail);
            Controls.Add(tbxFechaAlta);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblFechaAlta);
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
            Controls.SetChildIndex(lblFechaAlta, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(tbxFechaAlta, 0);
            Controls.SetChildIndex(tbxEmail, 0);
            Controls.SetChildIndex(tbxApellido, 0);
            Controls.SetChildIndex(tbxNombre, 0);
            Controls.SetChildIndex(tbxId, 0);
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
        private WinFormsControlLibrary1.BasicLabel lblFechaAlta;
        private WinFormsControlLibrary1.BasicLabel lblApellido;
        private WinFormsControlLibrary1.BasicLabel lblNombre;
        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicTxtBox tbxId;
        private WinFormsControlLibrary1.BasicTxtBox tbxNombre;
        private WinFormsControlLibrary1.BasicTxtBox tbxApellido;
        private WinFormsControlLibrary1.BasicTxtBox tbxEmail;
        private WinFormsControlLibrary1.BasicTxtBox tbxFechaAlta;
    }
}