namespace TrustBankApp_WinForm
{
    partial class Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_LoginMenu = new System.Windows.Forms.Label();
            this.txt_MailLogin = new System.Windows.Forms.TextBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.lbl_MailLogin = new System.Windows.Forms.Label();
            this.lbl_PasswordLogin = new System.Windows.Forms.Label();
            this.btn_BackToRegister = new System.Windows.Forms.Button();
            this.lbl_BackToRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(356, 300);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(103, 34);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_LoginMenu
            // 
            this.lbl_LoginMenu.AutoSize = true;
            this.lbl_LoginMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_LoginMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_LoginMenu.Location = new System.Drawing.Point(277, 25);
            this.lbl_LoginMenu.Name = "lbl_LoginMenu";
            this.lbl_LoginMenu.Size = new System.Drawing.Size(262, 37);
            this.lbl_LoginMenu.TabIndex = 1;
            this.lbl_LoginMenu.Text = "Existing User Login";
            // 
            // txt_MailLogin
            // 
            this.txt_MailLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_MailLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_MailLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_MailLogin.Location = new System.Drawing.Point(318, 137);
            this.txt_MailLogin.Name = "txt_MailLogin";
            this.txt_MailLogin.Size = new System.Drawing.Size(316, 29);
            this.txt_MailLogin.TabIndex = 2;
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_PasswordLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_PasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_PasswordLogin.Location = new System.Drawing.Point(318, 208);
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.Size = new System.Drawing.Size(316, 29);
            this.txt_PasswordLogin.TabIndex = 3;
            // 
            // lbl_MailLogin
            // 
            this.lbl_MailLogin.AutoSize = true;
            this.lbl_MailLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_MailLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_MailLogin.Location = new System.Drawing.Point(165, 138);
            this.lbl_MailLogin.Name = "lbl_MailLogin";
            this.lbl_MailLogin.Size = new System.Drawing.Size(125, 21);
            this.lbl_MailLogin.TabIndex = 4;
            this.lbl_MailLogin.Text = "Email Address :";
            // 
            // lbl_PasswordLogin
            // 
            this.lbl_PasswordLogin.AutoSize = true;
            this.lbl_PasswordLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_PasswordLogin.Location = new System.Drawing.Point(165, 209);
            this.lbl_PasswordLogin.Name = "lbl_PasswordLogin";
            this.lbl_PasswordLogin.Size = new System.Drawing.Size(90, 21);
            this.lbl_PasswordLogin.TabIndex = 5;
            this.lbl_PasswordLogin.Text = "Password :";
            // 
            // btn_BackToRegister
            // 
            this.btn_BackToRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToRegister.ForeColor = System.Drawing.Color.White;
            this.btn_BackToRegister.Location = new System.Drawing.Point(687, 346);
            this.btn_BackToRegister.Name = "btn_BackToRegister";
            this.btn_BackToRegister.Size = new System.Drawing.Size(103, 34);
            this.btn_BackToRegister.TabIndex = 6;
            this.btn_BackToRegister.Text = "Register";
            this.btn_BackToRegister.UseVisualStyleBackColor = false;
            this.btn_BackToRegister.Click += new System.EventHandler(this.btn_BackToRegister_Click);
            // 
            // lbl_BackToRegister
            // 
            this.lbl_BackToRegister.AutoSize = true;
            this.lbl_BackToRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_BackToRegister.Location = new System.Drawing.Point(589, 326);
            this.lbl_BackToRegister.Name = "lbl_BackToRegister";
            this.lbl_BackToRegister.Size = new System.Drawing.Size(234, 17);
            this.lbl_BackToRegister.TabIndex = 7;
            this.lbl_BackToRegister.Text = "Don\'t have an account, Register here!";
            this.lbl_BackToRegister.Click += new System.EventHandler(this.lbl_BackToRegister_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lbl_BackToRegister);
            this.Controls.Add(this.btn_BackToRegister);
            this.Controls.Add(this.lbl_PasswordLogin);
            this.Controls.Add(this.lbl_MailLogin);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.txt_MailLogin);
            this.Controls.Add(this.lbl_LoginMenu);
            this.Controls.Add(this.btn_Login);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Login;
        private Label lbl_LoginMenu;
        private TextBox txt_MailLogin;
        private TextBox txt_PasswordLogin;
        private Label lbl_MailLogin;
        private Label lbl_PasswordLogin;
        private Button btn_BackToRegister;
        private Label lbl_BackToRegister;
    }
}