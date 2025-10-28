namespace WindowsForms.ingrediente

{
    partial class IngredienteVistaEmpleado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dgvIngredientes = new WinFormsControlLibrary1.BasicDataGridView();
            lblTitle = new WinFormsControlLibrary1.BasicLabel();
            btnMenu = new WinFormsControlLibrary1.RedButton();
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
            // dgvIngredientes
            // 
            dgvIngredientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 245, 245);
            dgvIngredientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIngredientes.BackgroundColor = Color.MistyRose;
            dgvIngredientes.BorderStyle = BorderStyle.None;
            dgvIngredientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(180, 40, 40);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 235, 235);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(60, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 60, 60);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvIngredientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvIngredientes.EnableHeadersVisualStyles = false;
            dgvIngredientes.GridColor = Color.FromArgb(220, 120, 120);
            dgvIngredientes.Location = new Point(79, 108);
            dgvIngredientes.Name = "dgvIngredientes";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(160, 50, 50);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(192, 0, 0);
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.MistyRose;
            btnMenu.Location = new Point(532, 318);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // IngredienteVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 374);
            Controls.Add(lblTitle);
            Controls.Add(dgvIngredientes);
            Controls.Add(btnMenu);
            Name = "IngredienteVista";
            Text = "Ingredientes";
            Load += Ingredientes_Load;
            Controls.SetChildIndex(btnMenu, 0);
            Controls.SetChildIndex(dgvIngredientes, 0);
            Controls.SetChildIndex(lblTitle, 0);
            Controls.SetChildIndex(topBar, 0);
            topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private WinFormsControlLibrary1.BasicDataGridView dgvIngredientes;
        private WinFormsControlLibrary1.BasicLabel lblTitle;
        private WinFormsControlLibrary1.RedButton btnMenu;
    }
}