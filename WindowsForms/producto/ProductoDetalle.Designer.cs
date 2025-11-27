namespace WindowsForms.producto
{
    partial class ProductoDetalle
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
            btnAceptar = new WinFormsControlLibrary1.RedButton();
            btnCancelar = new WinFormsControlLibrary1.RedButton();
            lblId = new WinFormsControlLibrary1.BasicLabel();
            lblNombre = new WinFormsControlLibrary1.BasicLabel();
            lblDescripcion = new WinFormsControlLibrary1.BasicLabel();
            lblImagen = new WinFormsControlLibrary1.BasicLabel();
            lblCalificacion = new WinFormsControlLibrary1.BasicLabel();
            lblPrecio = new WinFormsControlLibrary1.BasicLabel();
            tbxId = new WinFormsControlLibrary1.BasicTxtBox();
            tbxNombre = new WinFormsControlLibrary1.BasicTxtBox();
            tbxDescripcion = new WinFormsControlLibrary1.BasicTxtBox();
            tbxImagen = new WinFormsControlLibrary1.BasicTxtBox();
            tbxCalificacion = new WinFormsControlLibrary1.BasicTxtBox();
            tbxPrecio = new WinFormsControlLibrary1.BasicTxtBox();
            lblIngredientes = new WinFormsControlLibrary1.BasicLabel();
            cboxIngredientes = new CheckedListBox();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(540, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(509, 0);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
            btnAceptar.Location = new Point(453, 367);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 24;
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
            btnCancelar.Location = new Point(372, 367);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(328, 39);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 26;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MistyRose;
            lblNombre.Location = new Point(328, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 27);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.MistyRose;
            lblDescripcion.Location = new Point(328, 89);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 27);
            lblDescripcion.TabIndex = 28;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.BackColor = Color.Transparent;
            lblImagen.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImagen.ForeColor = Color.MistyRose;
            lblImagen.Location = new Point(328, 113);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(51, 27);
            lblImagen.TabIndex = 29;
            lblImagen.Text = "Imagen";
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.BackColor = Color.Transparent;
            lblCalificacion.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalificacion.ForeColor = Color.MistyRose;
            lblCalificacion.Location = new Point(328, 138);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(73, 27);
            lblCalificacion.TabIndex = 30;
            lblCalificacion.Text = "Calificacion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.MistyRose;
            lblPrecio.Location = new Point(328, 163);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(45, 27);
            lblPrecio.TabIndex = 31;
            lblPrecio.Text = "Precio";
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(222, 42);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(100, 16);
            tbxId.TabIndex = 32;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = Color.MistyRose;
            tbxNombre.BorderStyle = BorderStyle.None;
            tbxNombre.Location = new Point(139, 69);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "Content";
            tbxNombre.Size = new Size(183, 16);
            tbxNombre.TabIndex = 33;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.BackColor = Color.MistyRose;
            tbxDescripcion.BorderStyle = BorderStyle.None;
            tbxDescripcion.Location = new Point(139, 92);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.PlaceholderText = "Content";
            tbxDescripcion.Size = new Size(183, 16);
            tbxDescripcion.TabIndex = 34;
            // 
            // tbxImagen
            // 
            tbxImagen.BackColor = Color.MistyRose;
            tbxImagen.BorderStyle = BorderStyle.None;
            tbxImagen.Location = new Point(139, 116);
            tbxImagen.Name = "tbxImagen";
            tbxImagen.PlaceholderText = "Content";
            tbxImagen.Size = new Size(183, 16);
            tbxImagen.TabIndex = 35;
            // 
            // tbxCalificacion
            // 
            tbxCalificacion.BackColor = Color.MistyRose;
            tbxCalificacion.BorderStyle = BorderStyle.None;
            tbxCalificacion.Location = new Point(222, 141);
            tbxCalificacion.Name = "tbxCalificacion";
            tbxCalificacion.PlaceholderText = "Content";
            tbxCalificacion.Size = new Size(100, 16);
            tbxCalificacion.TabIndex = 36;
            // 
            // tbxPrecio
            // 
            tbxPrecio.BackColor = Color.MistyRose;
            tbxPrecio.BorderStyle = BorderStyle.None;
            tbxPrecio.Location = new Point(222, 166);
            tbxPrecio.Name = "tbxPrecio";
            tbxPrecio.PlaceholderText = "Content";
            tbxPrecio.Size = new Size(100, 16);
            tbxPrecio.TabIndex = 37;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.BackColor = Color.Transparent;
            lblIngredientes.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngredientes.ForeColor = Color.MistyRose;
            lblIngredientes.Location = new Point(328, 207);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(78, 27);
            lblIngredientes.TabIndex = 39;
            lblIngredientes.Text = "Ingredientes";
            // 
            // cboxIngredientes
            // 
            cboxIngredientes.BackColor = Color.MistyRose;
            cboxIngredientes.FormattingEnabled = true;
            cboxIngredientes.Location = new Point(181, 207);
            cboxIngredientes.Name = "cboxIngredientes";
            cboxIngredientes.Size = new Size(141, 130);
            cboxIngredientes.TabIndex = 40;
            // 
            // ProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 412);
            Controls.Add(cboxIngredientes);
            Controls.Add(lblIngredientes);
            Controls.Add(tbxPrecio);
            Controls.Add(tbxCalificacion);
            Controls.Add(tbxImagen);
            Controls.Add(tbxDescripcion);
            Controls.Add(tbxNombre);
            Controls.Add(tbxId);
            Controls.Add(lblPrecio);
            Controls.Add(lblCalificacion);
            Controls.Add(lblImagen);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "ProductoDetalle";
            Text = "ProductoDetalle";
            Load += onLoad;
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblDescripcion, 0);
            Controls.SetChildIndex(lblImagen, 0);
            Controls.SetChildIndex(lblCalificacion, 0);
            Controls.SetChildIndex(lblPrecio, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(tbxNombre, 0);
            Controls.SetChildIndex(tbxDescripcion, 0);
            Controls.SetChildIndex(tbxImagen, 0);
            Controls.SetChildIndex(tbxCalificacion, 0);
            Controls.SetChildIndex(tbxPrecio, 0);
            Controls.SetChildIndex(lblIngredientes, 0);
            Controls.SetChildIndex(cboxIngredientes, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider;
        private WinFormsControlLibrary1.RedButton btnCancelar;
        private WinFormsControlLibrary1.RedButton btnAceptar;
        private WinFormsControlLibrary1.BasicLabel lblPrecio;
        private WinFormsControlLibrary1.BasicLabel lblCalificacion;
        private WinFormsControlLibrary1.BasicLabel lblImagen;
        private WinFormsControlLibrary1.BasicLabel lblDescripcion;
        private WinFormsControlLibrary1.BasicLabel lblNombre;
        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicTxtBox tbxPrecio;
        private WinFormsControlLibrary1.BasicTxtBox tbxCalificacion;
        private WinFormsControlLibrary1.BasicTxtBox tbxImagen;
        private WinFormsControlLibrary1.BasicTxtBox tbxDescripcion;
        private WinFormsControlLibrary1.BasicTxtBox tbxNombre;
        private WinFormsControlLibrary1.BasicTxtBox tbxId;
        private WinFormsControlLibrary1.BasicLabel lblIngredientes;
        private CheckedListBox cboxIngredientes;
    }
}