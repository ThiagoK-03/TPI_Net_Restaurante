namespace WindowsForms
{
    partial class LoginForm
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            labelUsuario = new WinFormsControlLibrary1.BasicLabel();
            labelContraseña = new WinFormsControlLibrary1.BasicLabel();
            btnLogin = new WinFormsControlLibrary1.RedButton();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.MistyRose;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Location = new Point(157, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "admin";
            txtUsuario.Size = new Size(139, 16);
            txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MistyRose;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Location = new Point(157, 96);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "1234";
            txtPassword.Size = new Size(139, 16);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.MistyRose;
            labelUsuario.Location = new Point(58, 53);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(78, 23);
            labelUsuario.TabIndex = 5;
            labelUsuario.Text = "Usuario";
            // 
            // labelContraseña
            // 
            labelContraseña.BackColor = Color.Transparent;
            labelContraseña.Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelContraseña.ForeColor = Color.MistyRose;
            labelContraseña.Location = new Point(58, 92);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(100, 23);
            labelContraseña.TabIndex = 6;
            labelContraseña.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 0, 0);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.MistyRose;
            btnLogin.Location = new Point(199, 151);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(97, 24);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 232);
            Controls.Add(btnLogin);
            Controls.Add(labelContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Name = "LoginForm";
            Text = "Form1";
            Controls.SetChildIndex(txtUsuario, 0);
            Controls.SetChildIndex(txtPassword, 0);
            Controls.SetChildIndex(labelUsuario, 0);
            Controls.SetChildIndex(labelContraseña, 0);
            Controls.SetChildIndex(btnLogin, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtPassword;
        //private Button btnLogin;
        private WinFormsControlLibrary1.BasicLabel labelUsuario;
        private WinFormsControlLibrary1.BasicLabel labelContraseña;
        private WinFormsControlLibrary1.RedButton btnLogin;
    }
}