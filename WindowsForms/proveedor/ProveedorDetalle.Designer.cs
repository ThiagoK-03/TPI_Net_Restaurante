using WinFormsControlLibrary1;

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
            btnAceptar = new RedButton();
            btnCancelar = new RedButton();
            lblId = new BasicLabel();
            tbxId = new BasicTxtBox();
            tbxRazonSocial = new BasicTxtBox();
            lblRazonSocial = new BasicLabel();
            tbxCuit = new BasicTxtBox();
            lblCuit = new BasicLabel();
            tbxTelefono = new BasicTxtBox();
            lblTelefono = new BasicLabel();
            tbxEmail = new BasicTxtBox();
            lblEmail = new BasicLabel();
            tbxTipoIng = new BasicTxtBox();
            lblTipoIng = new BasicLabel();
            tbxCompania = new BasicTxtBox();
            lblCompania = new BasicLabel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
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
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MistyRose;
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
            lblId.Location = new Point(29, 56);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(134, 54);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(111, 23);
            tbxId.TabIndex = 3;
            // 
            // tbxRazonSocial
            // 
            tbxRazonSocial.Location = new Point(134, 78);
            tbxRazonSocial.Margin = new Padding(3, 2, 3, 2);
            tbxRazonSocial.Name = "tbxRazonSocial";
            tbxRazonSocial.Size = new Size(196, 23);
            tbxRazonSocial.TabIndex = 5;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.AutoSize = true;
            lblRazonSocial.Location = new Point(29, 80);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Size = new Size(70, 15);
            lblRazonSocial.TabIndex = 4;
            lblRazonSocial.Text = "RazonSocial";
            // 
            // tbxCuit
            // 
            tbxCuit.Location = new Point(134, 103);
            tbxCuit.Margin = new Padding(3, 2, 3, 2);
            tbxCuit.Name = "tbxCuit";
            tbxCuit.Size = new Size(196, 23);
            tbxCuit.TabIndex = 7;
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.Location = new Point(29, 105);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(29, 15);
            lblCuit.TabIndex = 6;
            lblCuit.Text = "Cuit";
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(134, 152);
            tbxTelefono.Margin = new Padding(3, 2, 3, 2);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(111, 23);
            tbxTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(29, 155);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(52, 15);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Telefono";
            // 
            // tbxEmail
            // 
            tbxEmail.Location = new Point(134, 128);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(196, 23);
            tbxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(29, 130);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
            // 
            // tbxTipoIng
            // 
            tbxTipoIng.Location = new Point(134, 177);
            tbxTipoIng.Name = "tbxTipoIng";
            tbxTipoIng.Size = new Size(196, 23);
            tbxTipoIng.TabIndex = 13;
            // 
            // lblTipoIng
            // 
            lblTipoIng.AutoSize = true;
            lblTipoIng.Location = new Point(29, 180);
            lblTipoIng.Name = "lblTipoIng";
            lblTipoIng.Size = new Size(93, 15);
            lblTipoIng.TabIndex = 12;
            lblTipoIng.Text = "Tipo Ingrediente";
            // 
            // tbxCompania
            // 
            tbxCompania.Location = new Point(134, 201);
            tbxCompania.Name = "tbxCompania";
            tbxCompania.Size = new Size(196, 23);
            tbxCompania.TabIndex = 15;
            // 
            // lblCompania
            // 
            lblCompania.AutoSize = true;
            lblCompania.Location = new Point(29, 204);
            lblCompania.Name = "lblCompania";
            lblCompania.Size = new Size(62, 15);
            lblCompania.TabIndex = 14;
            lblCompania.Text = "Compañia";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
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
            Text = "Proveedor";
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblTelefono, 0);
            Controls.SetChildIndex(tbxTelefono, 0);
            Controls.SetChildIndex(lblCuit, 0);
            Controls.SetChildIndex(tbxCuit, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(lblRazonSocial, 0);
            Controls.SetChildIndex(tbxRazonSocial, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(tbxEmail, 0);
            Controls.SetChildIndex(lblTipoIng, 0);
            Controls.SetChildIndex(tbxTipoIng, 0);
            Controls.SetChildIndex(lblCompania, 0);
            Controls.SetChildIndex(tbxCompania, 0);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RedButton btnAceptar;
        private RedButton btnCancelar;
        private BasicLabel lblId;
        private BasicTxtBox tbxId;
        private BasicTxtBox tbxRazonSocial;
        private BasicLabel lblRazonSocial;
        private BasicTxtBox tbxCuit;
        private BasicLabel lblCuit;
        private BasicTxtBox tbxTelefono;
        private BasicLabel lblTelefono;
        private BasicTxtBox tbxEmail;
        private BasicLabel lblEmail;
        private ErrorProvider errorProvider;
        private BasicLabel lblTipoIng;
        private BasicTxtBox tbxCompania;
        private BasicLabel lblCompania;
        private BasicTxtBox tbxTipoIng;
    }
}