namespace WindowsForms.Pedido
{
    partial class PedidoDetalleCliente
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
            LblDescripcion = new WinFormsControlLibrary1.BasicLabel();
            LblSubtotal = new WinFormsControlLibrary1.BasicLabel();
            TxtBoxDescripcion = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxSubtotal = new WinFormsControlLibrary1.BasicTxtBox();
            BtnCancelar = new WinFormsControlLibrary1.RedButton();
            BtnAceptar = new WinFormsControlLibrary1.RedButton();
            cboxCliente = new ComboBox();
            clistboxProductos = new CheckedListBox();
            basicLabel2 = new WinFormsControlLibrary1.BasicLabel();
            lblCliente = new WinFormsControlLibrary1.BasicLabel();
            lblId = new WinFormsControlLibrary1.BasicLabel();
            TxtBoxId = new WinFormsControlLibrary1.BasicTxtBox();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(588, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(557, 0);
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.BackColor = Color.Transparent;
            LblDescripcion.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescripcion.ForeColor = Color.MistyRose;
            LblDescripcion.Location = new Point(256, 102);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(75, 27);
            LblDescripcion.TabIndex = 5;
            LblDescripcion.Text = "Descripcion";
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.BackColor = Color.Transparent;
            LblSubtotal.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtotal.ForeColor = Color.MistyRose;
            LblSubtotal.Location = new Point(256, 332);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(56, 27);
            LblSubtotal.TabIndex = 10;
            LblSubtotal.Text = "Subtotal";
            // 
            // TxtBoxDescripcion
            // 
            TxtBoxDescripcion.BackColor = Color.MistyRose;
            TxtBoxDescripcion.BorderStyle = BorderStyle.None;
            TxtBoxDescripcion.Location = new Point(57, 105);
            TxtBoxDescripcion.Name = "TxtBoxDescripcion";
            TxtBoxDescripcion.PlaceholderText = "Content";
            TxtBoxDescripcion.Size = new Size(176, 16);
            TxtBoxDescripcion.TabIndex = 11;
            // 
            // TxtBoxSubtotal
            // 
            TxtBoxSubtotal.BackColor = Color.MistyRose;
            TxtBoxSubtotal.BorderStyle = BorderStyle.None;
            TxtBoxSubtotal.Location = new Point(57, 335);
            TxtBoxSubtotal.Name = "TxtBoxSubtotal";
            TxtBoxSubtotal.PlaceholderText = "Content";
            TxtBoxSubtotal.Size = new Size(176, 16);
            TxtBoxSubtotal.TabIndex = 16;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = Color.MistyRose;
            BtnCancelar.Location = new Point(368, 359);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(75, 23);
            BtnCancelar.TabIndex = 17;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnAceptar
            // 
            BtnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            BtnAceptar.FlatAppearance.BorderSize = 0;
            BtnAceptar.FlatStyle = FlatStyle.Flat;
            BtnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAceptar.ForeColor = Color.MistyRose;
            BtnAceptar.Location = new Point(449, 359);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 18;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // cboxCliente
            // 
            cboxCliente.BackColor = Color.MistyRose;
            cboxCliente.FormattingEnabled = true;
            cboxCliente.Location = new Point(57, 272);
            cboxCliente.Name = "cboxCliente";
            cboxCliente.Size = new Size(176, 23);
            cboxCliente.TabIndex = 27;
            // 
            // clistboxProductos
            // 
            clistboxProductos.BackColor = Color.MistyRose;
            clistboxProductos.FormattingEnabled = true;
            clistboxProductos.Location = new Point(368, 105);
            clistboxProductos.Name = "clistboxProductos";
            clistboxProductos.Size = new Size(156, 202);
            clistboxProductos.TabIndex = 31;
            // 
            // basicLabel2
            // 
            basicLabel2.AutoSize = true;
            basicLabel2.BackColor = Color.Transparent;
            basicLabel2.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basicLabel2.ForeColor = Color.MistyRose;
            basicLabel2.Location = new Point(402, 66);
            basicLabel2.Name = "basicLabel2";
            basicLabel2.Size = new Size(85, 36);
            basicLabel2.TabIndex = 32;
            basicLabel2.Text = "Productos";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.MistyRose;
            lblCliente.Location = new Point(256, 272);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(49, 27);
            lblCliente.TabIndex = 33;
            lblCliente.Text = "Cliente";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(256, 66);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 34;
            lblId.Text = "Id";
            // 
            // TxtBoxId
            // 
            TxtBoxId.BackColor = Color.MistyRose;
            TxtBoxId.BorderStyle = BorderStyle.None;
            TxtBoxId.Location = new Point(178, 69);
            TxtBoxId.Name = "TxtBoxId";
            TxtBoxId.PlaceholderText = "Content";
            TxtBoxId.Size = new Size(55, 16);
            TxtBoxId.TabIndex = 35;
            // 
            // PedidoDetalleCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 435);
            Controls.Add(TxtBoxId);
            Controls.Add(lblId);
            Controls.Add(lblCliente);
            Controls.Add(basicLabel2);
            Controls.Add(clistboxProductos);
            Controls.Add(cboxCliente);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtBoxSubtotal);
            Controls.Add(TxtBoxDescripcion);
            Controls.Add(LblSubtotal);
            Controls.Add(LblDescripcion);
            Name = "PedidoDetalleCliente";
            Text = "PedidoDetalle";
            Load += OnLoad;
            Controls.SetChildIndex(LblDescripcion, 0);
            Controls.SetChildIndex(LblSubtotal, 0);
            Controls.SetChildIndex(TxtBoxDescripcion, 0);
            Controls.SetChildIndex(TxtBoxSubtotal, 0);
            Controls.SetChildIndex(BtnCancelar, 0);
            Controls.SetChildIndex(BtnAceptar, 0);
            Controls.SetChildIndex(cboxCliente, 0);
            Controls.SetChildIndex(clistboxProductos, 0);
            Controls.SetChildIndex(basicLabel2, 0);
            Controls.SetChildIndex(lblCliente, 0);
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(TxtBoxId, 0);
            topBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsControlLibrary1.BasicLabel LblDescripcion;
        private WinFormsControlLibrary1.BasicLabel LblSubtotal;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxDescripcion;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxSubtotal;
        private WinFormsControlLibrary1.RedButton BtnCancelar;
        private WinFormsControlLibrary1.RedButton BtnAceptar;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxClienteId;
        private WinFormsControlLibrary1.BasicLabel LblClienteId;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxEmpleadoId;
        private ComboBox cboxCliente;
        private CheckedListBox clistboxProductos;
        private WinFormsControlLibrary1.BasicLabel basicLabel2;
        private WinFormsControlLibrary1.BasicLabel lblCliente;
        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxId;
    }
}