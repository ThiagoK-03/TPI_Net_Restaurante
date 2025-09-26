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
            btnEmpleado = new WinFormsControlLibrary1.RedButton();
            btnPedido = new WinFormsControlLibrary1.RedButton();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.Size = new Size(414, 31);
            // 
            // btn_salir
            // 
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.Location = new Point(383, 0);
            btn_salir.Click += btnSalir_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(192, 0, 0);
            btnClientes.FlatAppearance.BorderColor = Color.DarkRed;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.MistyRose;
            btnClientes.Location = new Point(130, 53);
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
            btnProveedores.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.MistyRose;
            btnProveedores.Location = new Point(130, 87);
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
            btnSalir.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.MistyRose;
            btnSalir.Location = new Point(130, 213);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 22);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(192, 0, 0);
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEmpleado.ForeColor = Color.MistyRose;
            btnEmpleado.Location = new Point(130, 125);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(155, 23);
            btnEmpleado.TabIndex = 5;
            btnEmpleado.Text = "CRUD Empleado";
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnPedido
            // 
            btnPedido.BackColor = Color.FromArgb(192, 0, 0);
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = FlatStyle.Flat;
            btnPedido.Font = new Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedido.ForeColor = Color.MistyRose;
            btnPedido.Location = new Point(130, 166);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new Size(155, 23);
            btnPedido.TabIndex = 6;
            btnPedido.Text = "CRUD Pedido";
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += btnPedido_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(414, 256);
            Controls.Add(btnPedido);
            Controls.Add(btnEmpleado);
            Controls.Add(btnSalir);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Restaurant";
            Controls.SetChildIndex(btnClientes, 0);
            Controls.SetChildIndex(btnProveedores, 0);
            Controls.SetChildIndex(btnSalir, 0);
            Controls.SetChildIndex(topBar, 0);
            Controls.SetChildIndex(btnEmpleado, 0);
            Controls.SetChildIndex(btnPedido, 0);
            topBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProveedores;
        private Button btnSalir;
        private WinFormsControlLibrary1.RedButton btnEmpleado;
        private WinFormsControlLibrary1.RedButton btnPedido;
    }
}