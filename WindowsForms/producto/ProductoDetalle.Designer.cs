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
            tbxNombre = new TextBox();
            lblId = new Label();
            tbxId = new TextBox();
            lblNombre = new Label();
            lblDescripcion = new Label();
            tbxDescripcion = new TextBox();
            lblCalificacion = new Label();
            tbxCalificacion = new TextBox();
            lblImagen = new Label();
            tbxImagen = new TextBox();
            lblPrecio = new Label();
            tbxPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(119, 59);
            tbxNombre.Margin = new Padding(3, 2, 3, 2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(196, 23);
            tbxNombre.TabIndex = 15;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(14, 37);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(119, 35);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(111, 23);
            tbxId.TabIndex = 13;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(14, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(14, 86);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 16;
            lblDescripcion.Text = "Descripcion";
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(119, 84);
            tbxDescripcion.Margin = new Padding(3, 2, 3, 2);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(196, 23);
            tbxDescripcion.TabIndex = 17;
            // 
            // lblCalificacion
            // 
            lblCalificacion.AutoSize = true;
            lblCalificacion.Location = new Point(14, 136);
            lblCalificacion.Name = "lblCalificacion";
            lblCalificacion.Size = new Size(69, 15);
            lblCalificacion.TabIndex = 18;
            lblCalificacion.Text = "Calificacion";
            // 
            // tbxCalificacion
            // 
            tbxCalificacion.Location = new Point(119, 133);
            tbxCalificacion.Margin = new Padding(3, 2, 3, 2);
            tbxCalificacion.Name = "tbxCalificacion";
            tbxCalificacion.Size = new Size(111, 23);
            tbxCalificacion.TabIndex = 19;
            // 
            // lblImagen
            // 
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(14, 111);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(47, 15);
            lblImagen.TabIndex = 20;
            lblImagen.Text = "Imagen";
            // 
            // tbxImagen
            // 
            tbxImagen.Location = new Point(119, 109);
            tbxImagen.Margin = new Padding(3, 2, 3, 2);
            tbxImagen.Name = "tbxImagen";
            tbxImagen.Size = new Size(196, 23);
            tbxImagen.TabIndex = 21;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(14, 161);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 22;
            lblPrecio.Text = "Precio";
            // 
            // tbxPrecio
            // 
            tbxPrecio.Location = new Point(119, 158);
            tbxPrecio.Margin = new Padding(3, 2, 3, 2);
            tbxPrecio.Name = "tbxPrecio";
            tbxPrecio.Size = new Size(111, 23);
            tbxPrecio.TabIndex = 23;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(361, 204);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(82, 22);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(273, 204);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 237);
            Controls.Add(btnCancelar);
            Controls.Add(tbxPrecio);
            Controls.Add(btnAceptar);
            Controls.Add(lblPrecio);
            Controls.Add(tbxImagen);
            Controls.Add(tbxNombre);
            Controls.Add(lblImagen);
            Controls.Add(lblId);
            Controls.Add(tbxCalificacion);
            Controls.Add(tbxId);
            Controls.Add(lblCalificacion);
            Controls.Add(lblNombre);
            Controls.Add(tbxDescripcion);
            Controls.Add(lblDescripcion);
            Name = "ProductoDetalle";
            Text = "ProductoDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNombre;
        private Label lblId;
        private TextBox tbxId;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox tbxDescripcion;
        private Label lblCalificacion;
        private TextBox tbxCalificacion;
        private Label lblImagen;
        private TextBox tbxImagen;
        private Label lblPrecio;
        private TextBox tbxPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}