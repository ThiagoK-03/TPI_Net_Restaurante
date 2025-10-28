namespace WindowsForms.ingrediente


{
    partial class IngredienteVistaCliente
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
            btnMenu = new WinFormsControlLibrary1.RedButton();
            btnEliminar = new WinFormsControlLibrary1.RedButton();
            btnModificar = new WinFormsControlLibrary1.RedButton();
            btnAgregar = new WinFormsControlLibrary1.RedButton();
            dgvIngredientes = new WinFormsControlLibrary1.BasicDataGridView();
            lblTitle = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(676, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(645, 0);
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 0, 0);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.MistyRose;
            btnMenu.Location = new Point(289, 317);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.MistyRose;
            btnEliminar.Location = new Point(370, 317);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(192, 0, 0);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.MistyRose;
            btnModificar.Location = new Point(451, 317);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(192, 0, 0);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.MistyRose;
            btnAgregar.Location = new Point(532, 317);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.BackgroundColor = Color.MistyRose;
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(79, 108);
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.Size = new Size(528, 187);
            dgvIngredientes.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MistyRose;
            lblTitle.Location = new Point(289, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 36);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Ingredientes";
            // 
            // IngredienteVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 374);
            Controls.Add(lblTitle);
            Controls.Add(dgvIngredientes);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnMenu);
            Name = "IngredienteVista";
            Text = "Ingredientes";
            Load += Ingredientes_Load;
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(btnMenu, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(dgvIngredientes, 0);
            Controls.SetChildIndex(lblTitle, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WinFormsControlLibrary1.RedButton btnMenu;
        private WinFormsControlLibrary1.RedButton btnModificar;
        private WinFormsControlLibrary1.RedButton btnEliminar;
        private WinFormsControlLibrary1.RedButton btnAgregar;
        private WinFormsControlLibrary1.BasicDataGridView dgvIngredientes;
        private WinFormsControlLibrary1.BasicLabel lblTitle;
    }
}