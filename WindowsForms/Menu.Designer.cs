namespace WindowsForms
{
    partial class Menu
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
            btnClientes = new Button();
            btnProveedores = new Button();
            btnSalir = new Button();
            btnIngredientes = new WinFormsControlLibrary1.RedButton();
            btnProductos = new WinFormsControlLibrary1.RedButton();
            btnPedidos = new WinFormsControlLibrary1.RedButton();
            btnEmpleados = new WinFormsControlLibrary1.RedButton();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(406, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(375, 0);
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(192, 0, 0);
            btnClientes.FlatAppearance.BorderColor = Color.DarkRed;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.MistyRose;
            btnClientes.Location = new Point(120, 64);
            btnClientes.Margin = new Padding(3, 2, 3, 2);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(155, 22);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CRUD Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(192, 0, 0);
            btnProveedores.FlatAppearance.BorderSize = 0;
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.ForeColor = Color.MistyRose;
            btnProveedores.Location = new Point(120, 98);
            btnProveedores.Margin = new Padding(3, 2, 3, 2);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(155, 22);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "CRUD Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 0, 0);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.MistyRose;
            btnSalir.Location = new Point(120, 311);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 22);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnIngredientes
            // 
            btnIngredientes.BackColor = Color.FromArgb(192, 0, 0);
            btnIngredientes.FlatAppearance.BorderSize = 0;
            btnIngredientes.FlatStyle = FlatStyle.Flat;
            btnIngredientes.Font = new Font("Segoe UI", 9F);
            btnIngredientes.ForeColor = Color.MistyRose;
            btnIngredientes.Location = new Point(120, 133);
            btnIngredientes.Margin = new Padding(3, 2, 3, 2);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(155, 22);
            btnIngredientes.TabIndex = 4;
            btnIngredientes.Text = "CRUD Ingredientes";
            btnIngredientes.UseVisualStyleBackColor = false;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(192, 0, 0);
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 9F);
            btnProductos.ForeColor = Color.MistyRose;
            btnProductos.Location = new Point(120, 167);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(155, 22);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "CRUD Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = Color.FromArgb(192, 0, 0);
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.ForeColor = Color.MistyRose;
            btnPedidos.Location = new Point(120, 244);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(155, 23);
            btnPedidos.TabIndex = 6;
            btnPedidos.Text = "CRUD Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(192, 0, 0);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.MistyRose;
            btnEmpleados.Location = new Point(120, 203);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(155, 23);
            btnEmpleados.TabIndex = 7;
            btnEmpleados.Text = "CRUD Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(406, 357);
            Controls.Add(btnEmpleados);
            Controls.Add(btnPedidos);
            Controls.Add(btnProductos);
            Controls.Add(btnIngredientes);
            Controls.Add(btnSalir);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Restaurant";
            Controls.SetChildIndex(btnClientes, 0);
            Controls.SetChildIndex(btnProveedores, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(btnIngredientes, 0);
            Controls.SetChildIndex(btnProductos, 0);
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(btnPedidos, 0);
            Controls.SetChildIndex(btnEmpleados, 0);
            topBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProveedores;
        private Button btnSalir;
        private WinFormsControlLibrary1.RedButton btnIngredientes;
        private WinFormsControlLibrary1.RedButton btnProductos;
        private WinFormsControlLibrary1.RedButton btnPedidos;
        private WinFormsControlLibrary1.RedButton btnEmpleados;
    }
}