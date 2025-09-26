namespace WindowsForms.ingrediente
{
    partial class IngredienteVista
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
            dgvIngredientes = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(32, 23);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.RowHeadersWidth = 51;
            dgvIngredientes.Size = new Size(623, 223);
            dgvIngredientes.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(573, 268);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(82, 22);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(398, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(82, 22);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(486, 268);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(82, 22);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(311, 268);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(82, 22);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // IngredienteVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnMenu);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvIngredientes);
            Name = "IngredienteVista";
            Text = "Ingredientes";
            Load += Ingredientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvIngredientes;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnMenu;
    }
}