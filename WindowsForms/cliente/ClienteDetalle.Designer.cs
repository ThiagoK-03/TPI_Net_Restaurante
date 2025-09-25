using WinFormsControlLibrary1;

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
            btnAceptar = new RedButton();
            btnCancelar = new RedButton();
            lblId = new BasicLabel();
            tbxId = new BasicTxtBox();
            tbxNombre = new BasicTxtBox();
            lblNombre = new BasicLabel();
            tbxApellido = new BasicTxtBox();
            lblApellido = new BasicLabel();
            tbxFechaAlta = new BasicTxtBox();
            lblFechaAlta = new BasicLabel();
            tbxEmail = new BasicTxtBox();
            lblEmail = new BasicLabel();
            errorProvider = new ErrorProvider(components);
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Margin = new Padding(3, 2, 3, 2);
            topBar.Size = new Size(409, 23);
            // 
            // label_tittle
            // 
            label_tittle.Size = new Size(81, 23);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(382, 0);
            btn_salir.Margin = new Padding(3, 2, 3, 2);
            btn_salir.Size = new Size(27, 23);
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
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
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MistyRose;
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
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(10, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 2;
            lblId.Text = "Id";
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(115, 32);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(110, 16);
            tbxId.TabIndex = 3;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = Color.MistyRose;
            tbxNombre.BorderStyle = BorderStyle.None;
            tbxNombre.Location = new Point(115, 56);
            tbxNombre.Margin = new Padding(3, 2, 3, 2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "Content";
            tbxNombre.Size = new Size(196, 16);
            tbxNombre.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MistyRose;
            lblNombre.Location = new Point(10, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 27);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre";
            // 
            // tbxApellido
            // 
            tbxApellido.BackColor = Color.MistyRose;
            tbxApellido.BorderStyle = BorderStyle.None;
            tbxApellido.Location = new Point(115, 81);
            tbxApellido.Margin = new Padding(3, 2, 3, 2);
            tbxApellido.Name = "tbxApellido";
            tbxApellido.PlaceholderText = "Content";
            tbxApellido.Size = new Size(196, 16);
            tbxApellido.TabIndex = 7;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = Color.MistyRose;
            lblApellido.Location = new Point(10, 83);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 27);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // tbxFechaAlta
            // 
            tbxFechaAlta.BackColor = Color.MistyRose;
            tbxFechaAlta.BorderStyle = BorderStyle.None;
            tbxFechaAlta.Location = new Point(115, 130);
            tbxFechaAlta.Margin = new Padding(3, 2, 3, 2);
            tbxFechaAlta.Name = "tbxFechaAlta";
            tbxFechaAlta.PlaceholderText = "Content";
            tbxFechaAlta.Size = new Size(110, 16);
            tbxFechaAlta.TabIndex = 9;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.BackColor = Color.Transparent;
            lblFechaAlta.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaAlta.ForeColor = Color.MistyRose;
            lblFechaAlta.Location = new Point(10, 133);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(67, 27);
            lblFechaAlta.TabIndex = 8;
            lblFechaAlta.Text = "Fecha Alta";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.MistyRose;
            tbxEmail.BorderStyle = BorderStyle.None;
            tbxEmail.Location = new Point(115, 106);
            tbxEmail.Margin = new Padding(3, 2, 3, 2);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.PlaceholderText = "Content";
            tbxEmail.Size = new Size(196, 16);
            tbxEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.MistyRose;
            lblEmail.Location = new Point(10, 108);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 27);
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
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(tbxNombre, 0);
            Controls.SetChildIndex(lblApellido, 0);
            Controls.SetChildIndex(tbxApellido, 0);
            Controls.SetChildIndex(lblFechaAlta, 0);
            Controls.SetChildIndex(tbxFechaAlta, 0);
            Controls.SetChildIndex(lblEmail, 0);
            Controls.SetChildIndex(tbxEmail, 0);
            Controls.SetChildIndex(topBar, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RedButton btnAceptar;
        private RedButton btnCancelar;
        private BasicLabel lblId;
        private BasicTxtBox tbxId;
        private BasicTxtBox tbxNombre;
        private BasicLabel lblNombre;
        private BasicTxtBox tbxApellido;
        private BasicLabel lblApellido;
        private BasicTxtBox tbxFechaAlta;
        private BasicLabel lblFechaAlta;
        private BasicTxtBox tbxEmail;
        private BasicLabel lblEmail;
        private ErrorProvider errorProvider;
    }
}