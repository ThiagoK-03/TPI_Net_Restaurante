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
            topBar = new Panel();
            label1 = new Label();
            btn_salir = new Button();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.FromArgb(192, 0, 0);
            btnClientes.FlatAppearance.BorderColor = Color.DarkRed;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.ForeColor = Color.MistyRose;
            btnClientes.Location = new Point(99, 64);
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
            btnProveedores.Location = new Point(99, 98);
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
            btnSalir.Location = new Point(99, 132);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(155, 22);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(192, 0, 0);
            topBar.Controls.Add(label1);
            topBar.Controls.Add(btn_salir);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(354, 28);
            topBar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(10, 5);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 5;
            label1.Text = "Restaurante";
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.FromArgb(192, 0, 0);
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Georgia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.MistyRose;
            btn_salir.Location = new Point(328, -5);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(23, 30);
            btn_salir.TabIndex = 4;
            btn_salir.Text = "x";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btnSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(354, 226);
            Controls.Add(topBar);
            Controls.Add(btnSalir);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu";
            Text = "Restaurant";
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProveedores;
        private Button btnSalir;
        private Panel topBar;
        private Button btn_salir;
        private Label label1;
    }
}