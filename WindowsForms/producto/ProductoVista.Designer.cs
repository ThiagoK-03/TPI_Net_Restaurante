namespace WindowsForms.producto
{
    partial class ProductoVista
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
            dgvProductos = new WinFormsControlLibrary1.BasicDataGridView();
            btnMenu = new WinFormsControlLibrary1.RedButton();
            btnEliminar = new WinFormsControlLibrary1.RedButton();
            btnModificar = new WinFormsControlLibrary1.RedButton();
            btnAgregar = new WinFormsControlLibrary1.RedButton();
            tittleLabel = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(666, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(635, 0);
            // 
            // dgvProductos
            // 
            dgvProductos.BackgroundColor = Color.MistyRose;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(70, 75);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(513, 179);
            dgvProductos.TabIndex = 9;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 0, 0);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.MistyRose;
            btnMenu.Location = new Point(265, 289);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += this.btnMenu_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.MistyRose;
            btnEliminar.Location = new Point(346, 289);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 11;
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
            btnModificar.Location = new Point(427, 289);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 12;
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
            btnAgregar.Location = new Point(508, 289);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // tittleLabel
            // 
            tittleLabel.AutoSize = true;
            tittleLabel.BackColor = Color.Transparent;
            tittleLabel.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tittleLabel.ForeColor = Color.MistyRose;
            tittleLabel.Location = new Point(291, 36);
            tittleLabel.Name = "tittleLabel";
            tittleLabel.Size = new Size(85, 36);
            tittleLabel.TabIndex = 14;
            tittleLabel.Text = "Productos";
            tittleLabel.Click += tittleLabel_Click;
            // 
            // ProductoVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 338);
            Controls.Add(tittleLabel);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnMenu);
            Controls.Add(dgvProductos);
            Name = "ProductoVista";
            Text = "Productos";
            Load += Productos_Load;
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(dgvProductos, 0);
            Controls.SetChildIndex(btnMenu, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            Controls.SetChildIndex(tittleLabel, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //private Button btnMenu;
        private WinFormsControlLibrary1.BasicDataGridView dgvProductos;
        private WinFormsControlLibrary1.RedButton btnMenu;
        private WinFormsControlLibrary1.RedButton btnEliminar;
        private WinFormsControlLibrary1.RedButton btnModificar;
        private WinFormsControlLibrary1.RedButton btnAgregar;
        private WinFormsControlLibrary1.BasicLabel tittleLabel;
    }
}