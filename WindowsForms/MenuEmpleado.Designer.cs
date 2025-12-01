namespace WindowsForms
{
    partial class MenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleado));
            topBar = new WinFormsControlLibrary1.TopBar();
            label_tittle = new WinFormsControlLibrary1.BasicLabel();
            btn_salir = new WinFormsControlLibrary1.RedButton();
            btnSalir = new Button();
            btnIngredientes = new WinFormsControlLibrary1.RedButton();
            btnProductos = new WinFormsControlLibrary1.RedButton();
            btnPedidos = new WinFormsControlLibrary1.RedButton();
            basicLabel1 = new WinFormsControlLibrary1.BasicLabel();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(192, 0, 0);
            topBar.Controls.Add(label_tittle);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(406, 32);
            topBar.TabIndex = 0;
            // 
            // label_tittle
            // 
            label_tittle.BackColor = Color.FromArgb(192, 0, 0);
            label_tittle.Dock = DockStyle.Left;
            label_tittle.Font = new Font("Javanese Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_tittle.ForeColor = Color.MistyRose;
            label_tittle.Location = new Point(0, 0);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(110, 32);
            label_tittle.TabIndex = 1;
            label_tittle.Text = "Restaurante";
            label_tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.MistyRose;
            btn_salir.Location = new Point(375, 0);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 31);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "x";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btnSalir_Click;
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
            btnSalir.TabIndex = 3;
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
            btnIngredientes.Location = new Point(12, 169);
            btnIngredientes.Margin = new Padding(3, 2, 3, 2);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(107, 52);
            btnIngredientes.TabIndex = 5;
            btnIngredientes.Text = "Ver Ingredientes";
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
            btnProductos.Location = new Point(275, 169);
            btnProductos.Margin = new Padding(3, 2, 3, 2);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(107, 52);
            btnProductos.TabIndex = 6;
            btnProductos.Text = "Productos";
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
            btnPedidos.Location = new Point(145, 169);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(107, 52);
            btnPedidos.TabIndex = 7;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // basicLabel1
            // 
            basicLabel1.BackColor = Color.Transparent;
            basicLabel1.Font = new Font("Javanese Text", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basicLabel1.ForeColor = Color.MistyRose;
            basicLabel1.Location = new Point(100, 54);
            basicLabel1.Name = "basicLabel1";
            basicLabel1.Size = new Size(205, 47);
            basicLabel1.TabIndex = 8;
            basicLabel1.Text = "Menu Empleado";
            basicLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(406, 357);
            Controls.Add(basicLabel1);
            Controls.Add(btnPedidos);
            Controls.Add(btnProductos);
            Controls.Add(btnIngredientes);
            Controls.Add(btnSalir);
            Controls.Add(btn_salir);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuEmpleado";
            Text = "Restaurant";
            topBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary1.TopBar topBar;
        public WinFormsControlLibrary1.BasicLabel label_tittle;
        public WinFormsControlLibrary1.RedButton btn_salir;
        private Button btnSalir;
        private WinFormsControlLibrary1.RedButton btnIngredientes;
        private WinFormsControlLibrary1.RedButton btnProductos;
        private WinFormsControlLibrary1.RedButton btnPedidos;
        public WinFormsControlLibrary1.BasicLabel basicLabel1;
    }
}