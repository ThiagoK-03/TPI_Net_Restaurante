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
            SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(113, 86);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(177, 29);
            btnClientes.TabIndex = 0;
            btnClientes.Text = "CRUD Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(113, 130);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(177, 29);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "CRUD Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(113, 176);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(177, 29);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 302);
            Controls.Add(btnSalir);
            Controls.Add(btnProveedores);
            Controls.Add(btnClientes);
            Name = "Menu";
            Text = "Restaurant";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClientes;
        private Button btnProveedores;
        private Button btnSalir;
    }
}