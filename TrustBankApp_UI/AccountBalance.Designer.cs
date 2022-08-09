namespace TrustBankApp_WinForm
{
    partial class AccountBalance
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
            this.txt_AccountBalance = new System.Windows.Forms.TextBox();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.lbl_BalanceAccountNumber = new System.Windows.Forms.Label();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.lbl_BalanceMenu = new System.Windows.Forms.Label();
            this.lblGetBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_AccountBalance
            // 
            this.txt_AccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_AccountBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_AccountBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_AccountBalance.Location = new System.Drawing.Point(388, 123);
            this.txt_AccountBalance.Multiline = true;
            this.txt_AccountBalance.Name = "txt_AccountBalance";
            this.txt_AccountBalance.Size = new System.Drawing.Size(220, 35);
            this.txt_AccountBalance.TabIndex = 0;
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(78, 363);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(226, 41);
            this.btn_BackToTransactionMenu.TabIndex = 1;
            this.btn_BackToTransactionMenu.Text = "Back To TransactionMenu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // lbl_BalanceAccountNumber
            // 
            this.lbl_BalanceAccountNumber.AutoSize = true;
            this.lbl_BalanceAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BalanceAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_BalanceAccountNumber.Location = new System.Drawing.Point(175, 126);
            this.lbl_BalanceAccountNumber.Name = "lbl_BalanceAccountNumber";
            this.lbl_BalanceAccountNumber.Size = new System.Drawing.Size(192, 21);
            this.lbl_BalanceAccountNumber.TabIndex = 3;
            this.lbl_BalanceAccountNumber.Text = "Enter Account Number :";
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccountBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccountBalance.ForeColor = System.Drawing.Color.White;
            this.btnAccountBalance.Location = new System.Drawing.Point(515, 363);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(179, 41);
            this.btnAccountBalance.TabIndex = 4;
            this.btnAccountBalance.Text = "Get Balance";
            this.btnAccountBalance.UseVisualStyleBackColor = false;
            this.btnAccountBalance.Click += new System.EventHandler(this.btnAccountBalance_Click);
            // 
            // lbl_BalanceMenu
            // 
            this.lbl_BalanceMenu.AutoSize = true;
            this.lbl_BalanceMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BalanceMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_BalanceMenu.Location = new System.Drawing.Point(260, 25);
            this.lbl_BalanceMenu.Name = "lbl_BalanceMenu";
            this.lbl_BalanceMenu.Size = new System.Drawing.Size(280, 37);
            this.lbl_BalanceMenu.TabIndex = 5;
            this.lbl_BalanceMenu.Text = "Get Account Balance";
            // 
            // lblGetBalance
            // 
            this.lblGetBalance.AutoSize = true;
            this.lblGetBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGetBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGetBalance.Location = new System.Drawing.Point(315, 229);
            this.lblGetBalance.Name = "lblGetBalance";
            this.lblGetBalance.Size = new System.Drawing.Size(176, 20);
            this.lblGetBalance.TabIndex = 6;
            this.lblGetBalance.Text = "Your Account Balance is ";
            // 
            // AccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGetBalance);
            this.Controls.Add(this.lbl_BalanceMenu);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.lbl_BalanceAccountNumber);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.txt_AccountBalance);
            this.Name = "AccountBalance";
            this.Text = "AccountBalance";
            this.Load += new System.EventHandler(this.AccountBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_AccountBalance;
        private Button btn_BackToTransactionMenu;
        private Label lbl_BalanceAccountNumber;
        private Button btnAccountBalance;
        private Label lbl_BalanceMenu;
        private Label lblGetBalance;
    }
}