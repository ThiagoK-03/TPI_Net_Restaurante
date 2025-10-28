namespace WindowsForms.Pedido
{
    partial class PedidoDetalleEmpleado
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
            LblEstado = new WinFormsControlLibrary1.BasicLabel();
            LblFechaHoraInicio = new WinFormsControlLibrary1.BasicLabel();
            LblSubtotal = new WinFormsControlLibrary1.BasicLabel();
            LblFechaHoraFinEstimada = new WinFormsControlLibrary1.BasicLabel();
            LblFechaHoraFin = new WinFormsControlLibrary1.BasicLabel();
            TxtBoxDescripcion = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxEstado = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxFechaHoraInicio = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxSubtotal = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxFechaHoraFinEstimada = new WinFormsControlLibrary1.BasicTxtBox();
            TxtBoxFechaHoraFin = new WinFormsControlLibrary1.BasicTxtBox();
            BtnCancelar = new WinFormsControlLibrary1.RedButton();
            BtnAceptar = new WinFormsControlLibrary1.RedButton();
            TxtBoxId = new WinFormsControlLibrary1.BasicTxtBox();
            LblId = new WinFormsControlLibrary1.BasicLabel();
            TxtBoxClienteId = new WinFormsControlLibrary1.BasicTxtBox();
            LblClienteId = new WinFormsControlLibrary1.BasicLabel();
            TxtBoxEmpleadoId = new WinFormsControlLibrary1.BasicTxtBox();
            LblEmpleadoId = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(681, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(650, 0);
            // 
            // LblDescripcion
            // 
            LblDescripcion.AutoSize = true;
            LblDescripcion.BackColor = Color.Transparent;
            LblDescripcion.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblDescripcion.ForeColor = Color.MistyRose;
            LblDescripcion.Location = new Point(375, 103);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(75, 27);
            LblDescripcion.TabIndex = 5;
            LblDescripcion.Text = "Descripcion";
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.BackColor = Color.Transparent;
            LblEstado.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEstado.ForeColor = Color.MistyRose;
            LblEstado.Location = new Point(378, 146);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(48, 27);
            LblEstado.TabIndex = 6;
            LblEstado.Text = "Estado";
            // 
            // LblFechaHoraInicio
            // 
            LblFechaHoraInicio.AutoSize = true;
            LblFechaHoraInicio.BackColor = Color.Transparent;
            LblFechaHoraInicio.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFechaHoraInicio.ForeColor = Color.MistyRose;
            LblFechaHoraInicio.Location = new Point(379, 184);
            LblFechaHoraInicio.Name = "LblFechaHoraInicio";
            LblFechaHoraInicio.Size = new Size(105, 27);
            LblFechaHoraInicio.TabIndex = 7;
            LblFechaHoraInicio.Text = "Fecha/Hora Inicio";
            // 
            // LblSubtotal
            // 
            LblSubtotal.AutoSize = true;
            LblSubtotal.BackColor = Color.Transparent;
            LblSubtotal.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblSubtotal.ForeColor = Color.MistyRose;
            LblSubtotal.Location = new Point(375, 307);
            LblSubtotal.Name = "LblSubtotal";
            LblSubtotal.Size = new Size(56, 27);
            LblSubtotal.TabIndex = 10;
            LblSubtotal.Text = "Subtotal";
            // 
            // LblFechaHoraFinEstimada
            // 
            LblFechaHoraFinEstimada.AutoSize = true;
            LblFechaHoraFinEstimada.BackColor = Color.Transparent;
            LblFechaHoraFinEstimada.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFechaHoraFinEstimada.ForeColor = Color.MistyRose;
            LblFechaHoraFinEstimada.Location = new Point(379, 265);
            LblFechaHoraFinEstimada.Name = "LblFechaHoraFinEstimada";
            LblFechaHoraFinEstimada.Size = new Size(145, 27);
            LblFechaHoraFinEstimada.TabIndex = 9;
            LblFechaHoraFinEstimada.Text = "Fecha/Hora Fin Estimada";
            // 
            // LblFechaHoraFin
            // 
            LblFechaHoraFin.AutoSize = true;
            LblFechaHoraFin.BackColor = Color.Transparent;
            LblFechaHoraFin.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblFechaHoraFin.ForeColor = Color.MistyRose;
            LblFechaHoraFin.Location = new Point(378, 224);
            LblFechaHoraFin.Name = "LblFechaHoraFin";
            LblFechaHoraFin.Size = new Size(93, 27);
            LblFechaHoraFin.TabIndex = 8;
            LblFechaHoraFin.Text = "Fecha/Hora Fin";
            // 
            // TxtBoxDescripcion
            // 
            TxtBoxDescripcion.BackColor = Color.MistyRose;
            TxtBoxDescripcion.BorderStyle = BorderStyle.None;
            TxtBoxDescripcion.Location = new Point(176, 106);
            TxtBoxDescripcion.Name = "TxtBoxDescripcion";
            TxtBoxDescripcion.PlaceholderText = "Content";
            TxtBoxDescripcion.Size = new Size(176, 16);
            TxtBoxDescripcion.TabIndex = 11;
            // 
            // TxtBoxEstado
            // 
            TxtBoxEstado.BackColor = Color.MistyRose;
            TxtBoxEstado.BorderStyle = BorderStyle.None;
            TxtBoxEstado.Location = new Point(176, 149);
            TxtBoxEstado.Name = "TxtBoxEstado";
            TxtBoxEstado.PlaceholderText = "Content";
            TxtBoxEstado.Size = new Size(176, 16);
            TxtBoxEstado.TabIndex = 12;
            // 
            // TxtBoxFechaHoraInicio
            // 
            TxtBoxFechaHoraInicio.BackColor = Color.MistyRose;
            TxtBoxFechaHoraInicio.BorderStyle = BorderStyle.None;
            TxtBoxFechaHoraInicio.Location = new Point(176, 187);
            TxtBoxFechaHoraInicio.Name = "TxtBoxFechaHoraInicio";
            TxtBoxFechaHoraInicio.PlaceholderText = "Content";
            TxtBoxFechaHoraInicio.Size = new Size(176, 16);
            TxtBoxFechaHoraInicio.TabIndex = 13;
            // 
            // TxtBoxSubtotal
            // 
            TxtBoxSubtotal.BackColor = Color.MistyRose;
            TxtBoxSubtotal.BorderStyle = BorderStyle.None;
            TxtBoxSubtotal.Location = new Point(176, 310);
            TxtBoxSubtotal.Name = "TxtBoxSubtotal";
            TxtBoxSubtotal.PlaceholderText = "Content";
            TxtBoxSubtotal.Size = new Size(176, 16);
            TxtBoxSubtotal.TabIndex = 16;
            // 
            // TxtBoxFechaHoraFinEstimada
            // 
            TxtBoxFechaHoraFinEstimada.BackColor = Color.MistyRose;
            TxtBoxFechaHoraFinEstimada.BorderStyle = BorderStyle.None;
            TxtBoxFechaHoraFinEstimada.Location = new Point(176, 268);
            TxtBoxFechaHoraFinEstimada.Name = "TxtBoxFechaHoraFinEstimada";
            TxtBoxFechaHoraFinEstimada.PlaceholderText = "Content";
            TxtBoxFechaHoraFinEstimada.Size = new Size(176, 16);
            TxtBoxFechaHoraFinEstimada.TabIndex = 15;
            // 
            // TxtBoxFechaHoraFin
            // 
            TxtBoxFechaHoraFin.BackColor = Color.MistyRose;
            TxtBoxFechaHoraFin.BorderStyle = BorderStyle.None;
            TxtBoxFechaHoraFin.Location = new Point(176, 227);
            TxtBoxFechaHoraFin.Name = "TxtBoxFechaHoraFin";
            TxtBoxFechaHoraFin.PlaceholderText = "Content";
            TxtBoxFechaHoraFin.Size = new Size(176, 16);
            TxtBoxFechaHoraFin.TabIndex = 14;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnCancelar.ForeColor = Color.MistyRose;
            BtnCancelar.Location = new Point(449, 488);
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
            BtnAceptar.Location = new Point(530, 488);
            BtnAceptar.Name = "BtnAceptar";
            BtnAceptar.Size = new Size(75, 23);
            BtnAceptar.TabIndex = 18;
            BtnAceptar.Text = "Aceptar";
            BtnAceptar.UseVisualStyleBackColor = false;
            BtnAceptar.Click += BtnAceptar_Click;
            // 
            // TxtBoxId
            // 
            TxtBoxId.BackColor = Color.MistyRose;
            TxtBoxId.BorderStyle = BorderStyle.None;
            TxtBoxId.Location = new Point(176, 64);
            TxtBoxId.Name = "TxtBoxId";
            TxtBoxId.PlaceholderText = "Content";
            TxtBoxId.Size = new Size(176, 16);
            TxtBoxId.TabIndex = 19;
            // 
            // LblId
            // 
            LblId.AutoSize = true;
            LblId.BackColor = Color.Transparent;
            LblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblId.ForeColor = Color.MistyRose;
            LblId.Location = new Point(375, 64);
            LblId.Name = "LblId";
            LblId.Size = new Size(23, 27);
            LblId.TabIndex = 20;
            LblId.Text = "Id";
            // 
            // TxtBoxClienteId
            // 
            TxtBoxClienteId.BackColor = Color.MistyRose;
            TxtBoxClienteId.BorderStyle = BorderStyle.None;
            TxtBoxClienteId.Location = new Point(176, 355);
            TxtBoxClienteId.Name = "TxtBoxClienteId";
            TxtBoxClienteId.PlaceholderText = "Content";
            TxtBoxClienteId.Size = new Size(176, 16);
            TxtBoxClienteId.TabIndex = 21;
            // 
            // LblClienteId
            // 
            LblClienteId.AutoSize = true;
            LblClienteId.BackColor = Color.Transparent;
            LblClienteId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblClienteId.ForeColor = Color.MistyRose;
            LblClienteId.Location = new Point(375, 352);
            LblClienteId.Name = "LblClienteId";
            LblClienteId.Size = new Size(65, 27);
            LblClienteId.TabIndex = 22;
            LblClienteId.Text = "ID Cliente";
            // 
            // TxtBoxEmpleadoId
            // 
            TxtBoxEmpleadoId.BackColor = Color.MistyRose;
            TxtBoxEmpleadoId.BorderStyle = BorderStyle.None;
            TxtBoxEmpleadoId.Location = new Point(176, 401);
            TxtBoxEmpleadoId.Name = "TxtBoxEmpleadoId";
            TxtBoxEmpleadoId.PlaceholderText = "Content";
            TxtBoxEmpleadoId.Size = new Size(176, 16);
            TxtBoxEmpleadoId.TabIndex = 23;
            // 
            // LblEmpleadoId
            // 
            LblEmpleadoId.AutoSize = true;
            LblEmpleadoId.BackColor = Color.Transparent;
            LblEmpleadoId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblEmpleadoId.ForeColor = Color.MistyRose;
            LblEmpleadoId.Location = new Point(375, 398);
            LblEmpleadoId.Name = "LblEmpleadoId";
            LblEmpleadoId.Size = new Size(81, 27);
            LblEmpleadoId.TabIndex = 24;
            LblEmpleadoId.Text = "ID Empleado";
            // 
            // PedidoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 566);
            Controls.Add(LblEmpleadoId);
            Controls.Add(TxtBoxEmpleadoId);
            Controls.Add(LblClienteId);
            Controls.Add(TxtBoxClienteId);
            Controls.Add(LblId);
            Controls.Add(TxtBoxId);
            Controls.Add(BtnAceptar);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtBoxSubtotal);
            Controls.Add(TxtBoxFechaHoraFinEstimada);
            Controls.Add(TxtBoxFechaHoraFin);
            Controls.Add(TxtBoxFechaHoraInicio);
            Controls.Add(TxtBoxEstado);
            Controls.Add(TxtBoxDescripcion);
            Controls.Add(LblSubtotal);
            Controls.Add(LblFechaHoraFinEstimada);
            Controls.Add(LblFechaHoraFin);
            Controls.Add(LblFechaHoraInicio);
            Controls.Add(LblEstado);
            Controls.Add(LblDescripcion);
            Name = "PedidoDetalle";
            Text = "PedidoDetalle";
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(LblDescripcion, 0);
            Controls.SetChildIndex(LblEstado, 0);
            Controls.SetChildIndex(LblFechaHoraInicio, 0);
            Controls.SetChildIndex(LblFechaHoraFin, 0);
            Controls.SetChildIndex(LblFechaHoraFinEstimada, 0);
            Controls.SetChildIndex(LblSubtotal, 0);
            Controls.SetChildIndex(TxtBoxDescripcion, 0);
            Controls.SetChildIndex(TxtBoxEstado, 0);
            Controls.SetChildIndex(TxtBoxFechaHoraInicio, 0);
            Controls.SetChildIndex(TxtBoxFechaHoraFin, 0);
            Controls.SetChildIndex(TxtBoxFechaHoraFinEstimada, 0);
            Controls.SetChildIndex(TxtBoxSubtotal, 0);
            Controls.SetChildIndex(BtnCancelar, 0);
            Controls.SetChildIndex(BtnAceptar, 0);
            Controls.SetChildIndex(TxtBoxId, 0);
            Controls.SetChildIndex(LblId, 0);
            Controls.SetChildIndex(TxtBoxClienteId, 0);
            Controls.SetChildIndex(LblClienteId, 0);
            Controls.SetChildIndex(TxtBoxEmpleadoId, 0);
            Controls.SetChildIndex(LblEmpleadoId, 0);
            topBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsControlLibrary1.BasicLabel LblDescripcion;
        private WinFormsControlLibrary1.BasicLabel LblEstado;
        private WinFormsControlLibrary1.BasicLabel LblFechaHoraInicio;
        private WinFormsControlLibrary1.BasicLabel LblSubtotal;
        private WinFormsControlLibrary1.BasicLabel LblFechaHoraFinEstimada;
        private WinFormsControlLibrary1.BasicLabel LblFechaHoraFin;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxDescripcion;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxEstado;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxFechaHoraInicio;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxSubtotal;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxFechaHoraFinEstimada;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxFechaHoraFin;
        private WinFormsControlLibrary1.RedButton BtnCancelar;
        private WinFormsControlLibrary1.RedButton BtnAceptar;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxId;
        private WinFormsControlLibrary1.BasicLabel LblId;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxClienteId;
        private WinFormsControlLibrary1.BasicLabel LblClienteId;
        private WinFormsControlLibrary1.BasicTxtBox TxtBoxEmpleadoId;
        private WinFormsControlLibrary1.BasicLabel LblEmpleadoId;
    }
}