namespace WindowsForms.ingrediente
{
    partial class IngredienteDetalle
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
            btnCancelar = new WinFormsControlLibrary1.RedButton();
            btnAceptar = new WinFormsControlLibrary1.RedButton();
            tbxId = new WinFormsControlLibrary1.BasicTxtBox();
            tbxNombre = new WinFormsControlLibrary1.BasicTxtBox();
            tbxDescripcion = new WinFormsControlLibrary1.BasicTxtBox();
            tbxStock = new WinFormsControlLibrary1.BasicTxtBox();
            tbxUnidadMedida = new WinFormsControlLibrary1.BasicTxtBox();
            tbxOrigen = new WinFormsControlLibrary1.BasicTxtBox();
            tbxLimiteBajoStock = new WinFormsControlLibrary1.BasicTxtBox();
            lblId = new WinFormsControlLibrary1.BasicLabel();
            lblNombre = new WinFormsControlLibrary1.BasicLabel();
            lblDescripcion = new WinFormsControlLibrary1.BasicLabel();
            lblStock = new WinFormsControlLibrary1.BasicLabel();
            lblUnidadDeMedida = new WinFormsControlLibrary1.BasicLabel();
            lblOrigen = new WinFormsControlLibrary1.BasicLabel();
            lblLimiteBajoStock = new WinFormsControlLibrary1.BasicLabel();
            cboxProveedores = new ComboBox();
            lblProveedores = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(438, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(407, 0);
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.MistyRose;
            btnCancelar.Location = new Point(213, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(192, 0, 0);
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.MistyRose;
            btnAceptar.Location = new Point(294, 275);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 26;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_click;
            // 
            // tbxId
            // 
            tbxId.BackColor = Color.MistyRose;
            tbxId.BorderStyle = BorderStyle.None;
            tbxId.Location = new Point(159, 49);
            tbxId.Name = "tbxId";
            tbxId.PlaceholderText = "Content";
            tbxId.Size = new Size(100, 16);
            tbxId.TabIndex = 27;
            // 
            // tbxNombre
            // 
            tbxNombre.BackColor = Color.MistyRose;
            tbxNombre.BorderStyle = BorderStyle.None;
            tbxNombre.Location = new Point(159, 76);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.PlaceholderText = "Content";
            tbxNombre.Size = new Size(100, 16);
            tbxNombre.TabIndex = 28;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.BackColor = Color.MistyRose;
            tbxDescripcion.BorderStyle = BorderStyle.None;
            tbxDescripcion.Location = new Point(103, 104);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.PlaceholderText = "Content";
            tbxDescripcion.Size = new Size(156, 16);
            tbxDescripcion.TabIndex = 29;
            // 
            // tbxStock
            // 
            tbxStock.BackColor = Color.MistyRose;
            tbxStock.BorderStyle = BorderStyle.None;
            tbxStock.Location = new Point(159, 131);
            tbxStock.Name = "tbxStock";
            tbxStock.PlaceholderText = "Content";
            tbxStock.Size = new Size(100, 16);
            tbxStock.TabIndex = 30;
            // 
            // tbxUnidadMedida
            // 
            tbxUnidadMedida.BackColor = Color.MistyRose;
            tbxUnidadMedida.BorderStyle = BorderStyle.None;
            tbxUnidadMedida.Location = new Point(159, 158);
            tbxUnidadMedida.Name = "tbxUnidadMedida";
            tbxUnidadMedida.PlaceholderText = "Content";
            tbxUnidadMedida.Size = new Size(100, 16);
            tbxUnidadMedida.TabIndex = 31;
            // 
            // tbxOrigen
            // 
            tbxOrigen.BackColor = Color.MistyRose;
            tbxOrigen.BorderStyle = BorderStyle.None;
            tbxOrigen.Location = new Point(119, 185);
            tbxOrigen.Name = "tbxOrigen";
            tbxOrigen.PlaceholderText = "Content";
            tbxOrigen.Size = new Size(140, 16);
            tbxOrigen.TabIndex = 32;
            // 
            // tbxLimiteBajoStock
            // 
            tbxLimiteBajoStock.BackColor = Color.MistyRose;
            tbxLimiteBajoStock.BorderStyle = BorderStyle.None;
            tbxLimiteBajoStock.Location = new Point(159, 212);
            tbxLimiteBajoStock.Name = "tbxLimiteBajoStock";
            tbxLimiteBajoStock.PlaceholderText = "Content";
            tbxLimiteBajoStock.Size = new Size(100, 16);
            tbxLimiteBajoStock.TabIndex = 33;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.MistyRose;
            lblId.Location = new Point(265, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 27);
            lblId.TabIndex = 34;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.MistyRose;
            lblNombre.Location = new Point(265, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(55, 27);
            lblNombre.TabIndex = 35;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.MistyRose;
            lblDescripcion.Location = new Point(265, 101);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(75, 27);
            lblDescripcion.TabIndex = 36;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.MistyRose;
            lblStock.Location = new Point(265, 128);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 27);
            lblStock.TabIndex = 37;
            lblStock.Text = "Stock";
            // 
            // lblUnidadDeMedida
            // 
            lblUnidadDeMedida.AutoSize = true;
            lblUnidadDeMedida.BackColor = Color.Transparent;
            lblUnidadDeMedida.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidadDeMedida.ForeColor = Color.MistyRose;
            lblUnidadDeMedida.Location = new Point(265, 155);
            lblUnidadDeMedida.Name = "lblUnidadDeMedida";
            lblUnidadDeMedida.Size = new Size(110, 27);
            lblUnidadDeMedida.TabIndex = 38;
            lblUnidadDeMedida.Text = "Unidad de Medida";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.BackColor = Color.Transparent;
            lblOrigen.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrigen.ForeColor = Color.MistyRose;
            lblOrigen.Location = new Point(265, 182);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(48, 27);
            lblOrigen.TabIndex = 39;
            lblOrigen.Text = "Origen";
            // 
            // lblLimiteBajoStock
            // 
            lblLimiteBajoStock.AutoSize = true;
            lblLimiteBajoStock.BackColor = Color.Transparent;
            lblLimiteBajoStock.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLimiteBajoStock.ForeColor = Color.MistyRose;
            lblLimiteBajoStock.Location = new Point(265, 209);
            lblLimiteBajoStock.Name = "lblLimiteBajoStock";
            lblLimiteBajoStock.Size = new Size(104, 27);
            lblLimiteBajoStock.TabIndex = 40;
            lblLimiteBajoStock.Text = "Limite Bajo Stock";
            // 
            // cboxProveedores
            // 
            cboxProveedores.BackColor = Color.MistyRose;
            cboxProveedores.FormattingEnabled = true;
            cboxProveedores.Location = new Point(138, 239);
            cboxProveedores.Name = "cboxProveedores";
            cboxProveedores.Size = new Size(121, 23);
            cboxProveedores.TabIndex = 41;
            // 
            // lblProveedores
            // 
            lblProveedores.AutoSize = true;
            lblProveedores.BackColor = Color.Transparent;
            lblProveedores.Font = new Font("Javanese Text", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedores.ForeColor = Color.MistyRose;
            lblProveedores.Location = new Point(265, 239);
            lblProveedores.Name = "lblProveedores";
            lblProveedores.Size = new Size(77, 27);
            lblProveedores.TabIndex = 42;
            lblProveedores.Text = "Proveedores";
            // 
            // IngredienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 335);
            Controls.Add(lblProveedores);
            Controls.Add(cboxProveedores);
            Controls.Add(lblLimiteBajoStock);
            Controls.Add(lblOrigen);
            Controls.Add(lblUnidadDeMedida);
            Controls.Add(lblStock);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Controls.Add(tbxLimiteBajoStock);
            Controls.Add(tbxOrigen);
            Controls.Add(tbxUnidadMedida);
            Controls.Add(tbxStock);
            Controls.Add(tbxDescripcion);
            Controls.Add(tbxNombre);
            Controls.Add(tbxId);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Name = "IngredienteDetalle";
            Text = "Ingrediente";
            Load += onLoad;
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(btnAceptar, 0);
            Controls.SetChildIndex(tbxId, 0);
            Controls.SetChildIndex(tbxNombre, 0);
            Controls.SetChildIndex(tbxDescripcion, 0);
            Controls.SetChildIndex(tbxStock, 0);
            Controls.SetChildIndex(tbxUnidadMedida, 0);
            Controls.SetChildIndex(tbxOrigen, 0);
            Controls.SetChildIndex(tbxLimiteBajoStock, 0);
            Controls.SetChildIndex(lblId, 0);
            Controls.SetChildIndex(lblNombre, 0);
            Controls.SetChildIndex(lblDescripcion, 0);
            Controls.SetChildIndex(lblStock, 0);
            Controls.SetChildIndex(lblUnidadDeMedida, 0);
            Controls.SetChildIndex(lblOrigen, 0);
            Controls.SetChildIndex(lblLimiteBajoStock, 0);
            Controls.SetChildIndex(cboxProveedores, 0);
            Controls.SetChildIndex(lblProveedores, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider;
        private WinFormsControlLibrary1.RedButton btnAceptar;
        private WinFormsControlLibrary1.RedButton btnCancelar;
        private WinFormsControlLibrary1.BasicLabel lblLimiteBajoStock;
        private WinFormsControlLibrary1.BasicLabel lblOrigen;
        private WinFormsControlLibrary1.BasicLabel lblUnidadDeMedida;
        private WinFormsControlLibrary1.BasicLabel lblStock;
        private WinFormsControlLibrary1.BasicLabel lblDescripcion;
        private WinFormsControlLibrary1.BasicLabel lblNombre;
        private WinFormsControlLibrary1.BasicLabel lblId;
        private WinFormsControlLibrary1.BasicTxtBox tbxLimiteBajoStock;
        private WinFormsControlLibrary1.BasicTxtBox tbxOrigen;
        private WinFormsControlLibrary1.BasicTxtBox tbxUnidadMedida;
        private WinFormsControlLibrary1.BasicTxtBox tbxStock;
        private WinFormsControlLibrary1.BasicTxtBox tbxDescripcion;
        private WinFormsControlLibrary1.BasicTxtBox tbxNombre;
        private WinFormsControlLibrary1.BasicTxtBox tbxId;
        private WinFormsControlLibrary1.BasicLabel lblProveedores;
        private ComboBox cboxProveedores;
    }
}