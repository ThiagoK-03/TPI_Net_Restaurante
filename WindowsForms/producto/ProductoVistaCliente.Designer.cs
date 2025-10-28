namespace WindowsForms.producto;
using DTOs;
using API;

partial class ProductoVistaCliente
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
        dgvProductos = new WinFormsControlLibrary1.BasicDataGridView();
        btnMenu = new WinFormsControlLibrary1.RedButton();
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
        dgvProductos.AllowUserToResizeRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 245, 245);
        dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvProductos.BackgroundColor = Color.MistyRose;
        dgvProductos.BorderStyle = BorderStyle.None;
        dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(180, 40, 40);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        dataGridViewCellStyle2.ForeColor = Color.White;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 235, 235);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = Color.FromArgb(60, 0, 0);
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 60, 60);
        dataGridViewCellStyle3.SelectionForeColor = Color.White;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
        dgvProductos.EnableHeadersVisualStyles = false;
        dgvProductos.GridColor = Color.FromArgb(220, 120, 120);
        dgvProductos.Location = new Point(70, 75);
        dgvProductos.Name = "dgvProductos";
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(160, 50, 50);
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle4.ForeColor = Color.White;
        dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
        dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
        btnMenu.Location = new Point(508, 282);
        btnMenu.Name = "btnMenu";
        btnMenu.Size = new Size(75, 23);
        btnMenu.TabIndex = 10;
        btnMenu.Text = "Menu";
        btnMenu.UseVisualStyleBackColor = false;
        btnMenu.Click += btnMenu_Click;
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
        // ProductoVistaCliente
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(666, 338);
        Controls.Add(tittleLabel);
        Controls.Add(btnMenu);
        Controls.Add(dgvProductos);
        Name = "ProductoVistaCliente";
        Text = "Productos";
        Load += Productos_Load;
        Controls.SetChildIndex(topBar, 0);
        Controls.SetChildIndex(dgvProductos, 0);
        Controls.SetChildIndex(btnMenu, 0);
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
    private WinFormsControlLibrary1.BasicLabel tittleLabel;
}