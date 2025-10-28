namespace WindowsForms.Pedido
{
    partial class PedidoVistaEmpleado
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
            dgvPedidos = new WinFormsControlLibrary1.BasicDataGridView();
            btnMenu = new WinFormsControlLibrary1.RedButton();
            btnEliminar = new WinFormsControlLibrary1.RedButton();
            btnModificar = new WinFormsControlLibrary1.RedButton();
            btnAgregar = new WinFormsControlLibrary1.RedButton();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            // 
            // dgvPedidos
            // 
            dgvPedidos.BackgroundColor = Color.MistyRose;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(85, 72);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(608, 275);
            dgvPedidos.TabIndex = 5;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 0, 0);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.MistyRose;
            btnMenu.Location = new Point(375, 382);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 6;
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
            btnEliminar.Location = new Point(456, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
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
            btnModificar.Location = new Point(537, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 8;
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
            btnAgregar.Location = new Point(618, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // PedidoVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnMenu);
            Controls.Add(dgvPedidos);
            Name = "PedidoVista";
            Text = "PedidosVista";
            Load += PedidoVista_Load;
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(dgvPedidos, 0);
            Controls.SetChildIndex(btnMenu, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnModificar, 0);
            Controls.SetChildIndex(btnAgregar, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary1.BasicDataGridView dgvPedidos;
        private WinFormsControlLibrary1.RedButton btnMenu;
        private WinFormsControlLibrary1.RedButton btnEliminar;
        private WinFormsControlLibrary1.RedButton btnModificar;
        private WinFormsControlLibrary1.RedButton btnAgregar;
    }
}