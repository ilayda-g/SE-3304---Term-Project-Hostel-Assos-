namespace Hostel_Assos_Application_V._2
{
    partial class FormAdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminLogin));
            LblUsername = new Label();
            LblPassword = new Label();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            BtnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.BackColor = Color.Transparent;
            LblUsername.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            LblUsername.Location = new Point(150, 139);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(123, 30);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "Username:";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.BackColor = Color.Transparent;
            LblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            LblPassword.Location = new Point(155, 191);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(118, 30);
            LblPassword.TabIndex = 1;
            LblPassword.Text = "Password:";
            // 
            // TxtUsername
            // 
            TxtUsername.BackColor = Color.MistyRose;
            TxtUsername.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtUsername.Location = new Point(279, 137);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(249, 34);
            TxtUsername.TabIndex = 2;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.MistyRose;
            TxtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            TxtPassword.Location = new Point(279, 191);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(249, 34);
            TxtPassword.TabIndex = 3;
            TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnLogin
            // 
            BtnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnLogin.Location = new Point(320, 244);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(165, 36);
            BtnLogin.TabIndex = 4;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Script", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 46);
            label1.TabIndex = 5;
            label1.Text = "Welcome Hostel Assos";
            // 
            // FormAdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(736, 429);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUsername);
            Controls.Add(LblPassword);
            Controls.Add(LblUsername);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdminLogin";
            Text = "FormAdminLogin";
            Load += FormAdminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUsername;
        private Label LblPassword;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Button BtnLogin;
        private Label label1;
    }
}