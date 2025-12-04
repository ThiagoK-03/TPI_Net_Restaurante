namespace WinFormsControlLibrary1
{
    public partial class MenuBase
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
            topBar = new Panel();
            btn_salir = new Button();
            label_tittle = new Label();
            topBar.SuspendLayout();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.FromArgb(192, 0, 0);
            topBar.Controls.Add(btn_salir);
            topBar.Controls.Add(label_tittle);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(800, 31);
            topBar.TabIndex = 4;
            // 
            // btn_salir
            // 
            btn_salir.Dock = DockStyle.Right;
            btn_salir.FlatAppearance.BorderSize = 0;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Leelawadee UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir.ForeColor = Color.MistyRose;
            btn_salir.Location = new Point(769, 0);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(31, 31);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "x";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // label_tittle
            // 
            label_tittle.BackColor = Color.FromArgb(192, 0, 0);
            label_tittle.Dock = DockStyle.Left;
            label_tittle.Font = new Font("Javanese Text", 12F);
            label_tittle.ForeColor = Color.MistyRose;
            label_tittle.Location = new Point(0, 0);
            label_tittle.Name = "label_tittle";
            label_tittle.Size = new Size(110, 31);
            label_tittle.TabIndex = 5;
            label_tittle.Text = "Restaurante";
            label_tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MenuBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            BackgroundImage = WForm.Controls.Properties.Resources.restaurantBG1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuBase";
            Text = "MenuBase";
            topBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel topBar;
        public Label label_tittle;
        public Button btn_salir;
    }
}