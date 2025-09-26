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
            tbxId = new TextBox();
            tbxDescripcion = new TextBox();
            lblId = new Label();
            lblNombre = new Label();
            tbxNombre = new TextBox();
            lblDescripcion = new Label();
            lblUnidadMedida = new Label();
            tbxUnidadMedida = new TextBox();
            lblStock = new Label();
            tbxStock = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tbxOrigen = new TextBox();
            lblOrigen = new Label();
            lblLimiteBajoStock = new Label();
            tbxLimiteBajoStock = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // tbxId
            // 
            tbxId.Location = new Point(142, 31);
            tbxId.Margin = new Padding(3, 2, 3, 2);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(111, 23);
            tbxId.TabIndex = 4;
            // 
            // tbxDescripcion
            // 
            tbxDescripcion.Location = new Point(142, 80);
            tbxDescripcion.Margin = new Padding(3, 2, 3, 2);
            tbxDescripcion.Name = "tbxDescripcion";
            tbxDescripcion.Size = new Size(196, 23);
            tbxDescripcion.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(10, 34);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 12;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre";
            // 
            // tbxNombre
            // 
            tbxNombre.Location = new Point(142, 55);
            tbxNombre.Margin = new Padding(3, 2, 3, 2);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(196, 23);
            tbxNombre.TabIndex = 14;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(10, 83);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 15;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblUnidadMedida
            // 
            lblUnidadMedida.AutoSize = true;
            lblUnidadMedida.Location = new Point(10, 133);
            lblUnidadMedida.Name = "lblUnidadMedida";
            lblUnidadMedida.Size = new Size(104, 15);
            lblUnidadMedida.TabIndex = 17;
            lblUnidadMedida.Text = "Unidad de Medida";
            // 
            // tbxUnidadMedida
            // 
            tbxUnidadMedida.Location = new Point(142, 129);
            tbxUnidadMedida.Margin = new Padding(3, 2, 3, 2);
            tbxUnidadMedida.Name = "tbxUnidadMedida";
            tbxUnidadMedida.Size = new Size(111, 23);
            tbxUnidadMedida.TabIndex = 18;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(10, 108);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 19;
            lblStock.Text = "Stock";
            // 
            // tbxStock
            // 
            tbxStock.Location = new Point(142, 105);
            tbxStock.Margin = new Padding(3, 2, 3, 2);
            tbxStock.Name = "tbxStock";
            tbxStock.Size = new Size(111, 23);
            tbxStock.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(315, 285);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 12;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(229, 285);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbxOrigen
            // 
            tbxOrigen.Location = new Point(142, 154);
            tbxOrigen.Margin = new Padding(3, 2, 3, 2);
            tbxOrigen.Name = "tbxOrigen";
            tbxOrigen.Size = new Size(196, 23);
            tbxOrigen.TabIndex = 21;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(10, 157);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 22;
            lblOrigen.Text = "Origen";
            // 
            // lblLimiteBajoStock
            // 
            lblLimiteBajoStock.AutoSize = true;
            lblLimiteBajoStock.Location = new Point(10, 181);
            lblLimiteBajoStock.Name = "lblLimiteBajoStock";
            lblLimiteBajoStock.Size = new Size(114, 15);
            lblLimiteBajoStock.TabIndex = 23;
            lblLimiteBajoStock.Text = "Limite de Bajo Stock";
            // 
            // tbxLimiteBajoStock
            // 
            tbxLimiteBajoStock.Location = new Point(142, 178);
            tbxLimiteBajoStock.Margin = new Padding(3, 2, 3, 2);
            tbxLimiteBajoStock.Name = "tbxLimiteBajoStock";
            tbxLimiteBajoStock.Size = new Size(111, 23);
            tbxLimiteBajoStock.TabIndex = 24;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // IngredienteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 318);
            Controls.Add(tbxLimiteBajoStock);
            Controls.Add(lblLimiteBajoStock);
            Controls.Add(lblOrigen);
            Controls.Add(tbxOrigen);
            Controls.Add(button2);
            Controls.Add(tbxStock);
            Controls.Add(button1);
            Controls.Add(tbxId);
            Controls.Add(lblStock);
            Controls.Add(tbxDescripcion);
            Controls.Add(tbxUnidadMedida);
            Controls.Add(lblId);
            Controls.Add(lblUnidadMedida);
            Controls.Add(lblNombre);
            Controls.Add(tbxNombre);
            Controls.Add(lblDescripcion);
            Name = "IngredienteDetalle";
            Text = "Ingrediente";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxId;
        private TextBox tbxDescripcion;
        private Label lblId;
        private Label lblNombre;
        private TextBox tbxNombre;
        private Label lblDescripcion;
        private Label lblUnidadMedida;
        private TextBox tbxUnidadMedida;
        private Label lblStock;
        private TextBox tbxStock;
        private Button button1;
        private Button button2;
        private TextBox tbxOrigen;
        private Label lblOrigen;
        private Label lblLimiteBajoStock;
        private TextBox tbxLimiteBajoStock;
        private ErrorProvider errorProvider;
    }
}