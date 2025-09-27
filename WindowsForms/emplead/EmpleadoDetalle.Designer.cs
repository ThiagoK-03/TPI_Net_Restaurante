namespace WindowsForms.emplead
{
    partial class EmpleadoDetalle
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
            lblId = new WinFormsControlLibrary1.BasicLabel();
            lblNombre = new WinFormsControlLibrary1.BasicLabel();
            lblCuit = new WinFormsControlLibrary1.BasicLabel();
            lblTurno = new WinFormsControlLibrary1.BasicLabel();
            lblHorasTrabajadas = new WinFormsControlLibrary1.BasicLabel();
            lblPrecioXHora = new WinFormsControlLibrary1.BasicLabel();
            lblSueldo = new WinFormsControlLibrary1.BasicLabel();
            tbxId = new WinFormsControlLibrary1.BasicTxtBox();
            txbNombre = new WinFormsControlLibrary1.BasicTxtBox();
            txbCuit = new WinFormsControlLibrary1.BasicTxtBox();
            txbTurno = new WinFormsControlLibrary1.BasicTxtBox();
            txbHorasTrabajadas = new WinFormsControlLibrary1.BasicTxtBox();
            txbPrecioPorHora = new WinFormsControlLibrary1.BasicTxtBox();
            txbSueldo = new WinFormsControlLibrary1.BasicTxtBox();
            btnCancelar = new WinFormsControlLibrary1.RedButton();
            btnAceptar = new WinFormsControlLibrary1.RedButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorProvider = new ErrorProvider(components);
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(495, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(464, 0);
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(59, 58);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MistyRose;
            lblNombre.Location = new Point(59, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 27);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblCuit
            // 
            lblCuit.AutoSize = true;
            lblCuit.BackColor = Color.Transparent;
            lblCuit.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuit.ForeColor = Color.MistyRose;
            lblCuit.Location = new Point(60, 112);
            lblCuit.Name = "lblCuit";
            lblCuit.Size = new Size(34, 27);
            lblCuit.TabIndex = 7;
            lblCuit.Text = "Cuit";
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.BackColor = Color.Transparent;
            lblTurno.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTurno.ForeColor = Color.MistyRose;
            lblTurno.Location = new Point(59, 139);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(44, 27);
            lblTurno.TabIndex = 8;
            lblTurno.Text = "Turno";
            // 
            // lblHorasTrabajadas
            // 
            lblHorasTrabajadas.AutoSize = true;
            lblHorasTrabajadas.BackColor = Color.Transparent;
            lblHorasTrabajadas.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHorasTrabajadas.ForeColor = Color.MistyRose;
            lblHorasTrabajadas.Location = new Point(59, 166);
            lblHorasTrabajadas.Name = "lblHorasTrabajadas";
            lblHorasTrabajadas.Size = new Size(104, 27);
            lblHorasTrabajadas.TabIndex = 9;
            lblHorasTrabajadas.Text = "Horas Trabajadas";
            // 
            // lblPrecioXHora
            // 
            lblPrecioXHora.AutoSize = true;
            lblPrecioXHora.BackColor = Color.Transparent;
            lblPrecioXHora.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioXHora.ForeColor = Color.MistyRose;
            lblPrecioXHora.Location = new Point(59, 193);
            lblPrecioXHora.Name = "lblPrecioXHora";
            lblPrecioXHora.Size = new Size(95, 27);
            lblPrecioXHora.TabIndex = 10;
            lblPrecioXHora.Text = "Precio por Hora";
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.Transparent;
            lblSueldo.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSueldo.ForeColor = Color.MistyRose;
            lblSueldo.Location = new Point(59, 220);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(48, 27);
            lblSueldo.TabIndex = 11;
            lblSueldo.Text = "Sueldo";
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(191, 61);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(158, 16);
            tbxId.TabIndex = 12;
            // 
            // txbNombre
            // 
            txbNombre.BackColor = Color.MistyRose;
            txbNombre.BorderStyle = BorderStyle.None;
            txbNombre.Location = new Point(191, 88);
            txbNombre.Name = "txbNombre";
            txbNombre.PlaceholderText = "Content";
            txbNombre.Size = new Size(158, 16);
            txbNombre.TabIndex = 13;
            // 
            // txbCuit
            // 
            txbCuit.BackColor = Color.MistyRose;
            txbCuit.BorderStyle = BorderStyle.None;
            txbCuit.Location = new Point(191, 115);
            txbCuit.Name = "txbCuit";
            txbCuit.PlaceholderText = "Content";
            txbCuit.Size = new Size(158, 16);
            txbCuit.TabIndex = 14;
            // 
            // txbTurno
            // 
            txbTurno.BackColor = Color.MistyRose;
            txbTurno.BorderStyle = BorderStyle.None;
            txbTurno.Location = new Point(191, 142);
            txbTurno.Name = "txbTurno";
            txbTurno.PlaceholderText = "Content";
            txbTurno.Size = new Size(158, 16);
            txbTurno.TabIndex = 15;
            // 
            // txbHorasTrabajadas
            // 
            txbHorasTrabajadas.BackColor = Color.MistyRose;
            txbHorasTrabajadas.BorderStyle = BorderStyle.None;
            txbHorasTrabajadas.Location = new Point(191, 169);
            txbHorasTrabajadas.Name = "txbHorasTrabajadas";
            txbHorasTrabajadas.PlaceholderText = "Content";
            txbHorasTrabajadas.Size = new Size(158, 16);
            txbHorasTrabajadas.TabIndex = 16;
            // 
            // txbPrecioPorHora
            // 
            txbPrecioPorHora.BackColor = Color.MistyRose;
            txbPrecioPorHora.BorderStyle = BorderStyle.None;
            txbPrecioPorHora.Location = new Point(191, 196);
            txbPrecioPorHora.Name = "txbPrecioPorHora";
            txbPrecioPorHora.PlaceholderText = "Content";
            txbPrecioPorHora.Size = new Size(158, 16);
            txbPrecioPorHora.TabIndex = 17;
            // 
            // txbSueldo
            // 
            txbSueldo.BackColor = Color.MistyRose;
            txbSueldo.BorderStyle = BorderStyle.None;
            txbSueldo.Location = new Point(191, 223);
            txbSueldo.Name = "txbSueldo";
            txbSueldo.PlaceholderText = "Content";
            txbSueldo.Size = new Size(158, 16);
            txbSueldo.TabIndex = 18;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MistyRose;
            btnCancelar.Location = new Point(317, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
            btnAceptar.Location = new Point(398, 263);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EmpleadoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 314);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(txbSueldo);
            Controls.Add(txbPrecioPorHora);
            Controls.Add(txbHorasTrabajadas);
            Controls.Add(txbTurno);
            Controls.Add(txbCuit);
            Controls.Add(txbNombre);
            Controls.Add(tbxId);
            Controls.Add(lblSueldo);
            Controls.Add(lblPrecioXHora);
            Controls.Add(lblHorasTrabajadas);
            Controls.Add(lblTurno);
            Controls.Add(lblCuit);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "EmpleadoDetalle";
            Text = "EmpleadoDetalle";
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblCuit, 0);
            Controls.SetChildIndex(lblTurno, 0);
            Controls.SetChildIndex(lblHorasTrabajadas, 0);
            Controls.SetChildIndex(lblPrecioXHora, 0);
            Controls.SetChildIndex(lblSueldo, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(txbNombre, 0);
            Controls.SetChildIndex(txbCuit, 0);
            Controls.SetChildIndex(txbTurno, 0);
            Controls.SetChildIndex(txbHorasTrabajadas, 0);
            Controls.SetChildIndex(txbPrecioPorHora, 0);
            Controls.SetChildIndex(txbSueldo, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicLabel lblNombre;
        private WinFormsControlLibrary1.BasicLabel lblCuit;
        private WinFormsControlLibrary1.BasicLabel lblTurno;
        private WinFormsControlLibrary1.BasicLabel lblHorasTrabajadas;
        private WinFormsControlLibrary1.BasicLabel lblPrecioXHora;
        private WinFormsControlLibrary1.BasicLabel lblSueldo;
        private WinFormsControlLibrary1.BasicTxtBox tbxId;
        private WinFormsControlLibrary1.BasicTxtBox txbNombre;
        private WinFormsControlLibrary1.BasicTxtBox txbCuit;
        private WinFormsControlLibrary1.BasicTxtBox txbTurno;
        private WinFormsControlLibrary1.BasicTxtBox txbHorasTrabajadas;
        private WinFormsControlLibrary1.BasicTxtBox txbPrecioPorHora;
        private WinFormsControlLibrary1.BasicTxtBox txbSueldo;
        private WinFormsControlLibrary1.RedButton btnCancelar;
        private WinFormsControlLibrary1.RedButton btnAceptar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ErrorProvider errorProvider;
    }
}