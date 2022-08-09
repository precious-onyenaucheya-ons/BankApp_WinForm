namespace TrustBankApp_WinForm
{
    partial class TransactionMenu
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
            this.lbl_TransactionMenu = new System.Windows.Forms.Label();
            this.btn_CreateBankAccount = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_AccountDetails = new System.Windows.Forms.Button();
            this.btn_AccountStatement = new System.Windows.Forms.Button();
            this.btn_CheckAccountBAlance = new System.Windows.Forms.Button();
            this.btn_Transfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TransactionMenu
            // 
            this.lbl_TransactionMenu.AutoSize = true;
            this.lbl_TransactionMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TransactionMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_TransactionMenu.Location = new System.Drawing.Point(286, 18);
            this.lbl_TransactionMenu.Name = "lbl_TransactionMenu";
            this.lbl_TransactionMenu.Size = new System.Drawing.Size(177, 37);
            this.lbl_TransactionMenu.TabIndex = 0;
            this.lbl_TransactionMenu.Text = "Transactions";
            // 
            // btn_CreateBankAccount
            // 
            this.btn_CreateBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_CreateBankAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateBankAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_CreateBankAccount.Location = new System.Drawing.Point(102, 91);
            this.btn_CreateBankAccount.Name = "btn_CreateBankAccount";
            this.btn_CreateBankAccount.Size = new System.Drawing.Size(245, 37);
            this.btn_CreateBankAccount.TabIndex = 1;
            this.btn_CreateBankAccount.Text = "Create Bank Account";
            this.btn_CreateBankAccount.UseVisualStyleBackColor = false;
            this.btn_CreateBankAccount.Click += new System.EventHandler(this.btn_CreateBankAccount_Click);
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Deposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Deposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Deposit.Location = new System.Drawing.Point(102, 163);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(245, 37);
            this.btn_Deposit.TabIndex = 2;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = false;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Logout.Location = new System.Drawing.Point(440, 313);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(246, 37);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Withdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Withdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Withdraw.Location = new System.Drawing.Point(102, 239);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(245, 37);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = false;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_AccountDetails
            // 
            this.btn_AccountDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_AccountDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AccountDetails.Location = new System.Drawing.Point(440, 163);
            this.btn_AccountDetails.Name = "btn_AccountDetails";
            this.btn_AccountDetails.Size = new System.Drawing.Size(246, 37);
            this.btn_AccountDetails.TabIndex = 5;
            this.btn_AccountDetails.Text = "Account Details";
            this.btn_AccountDetails.UseVisualStyleBackColor = false;
            this.btn_AccountDetails.Click += new System.EventHandler(this.btn_AccountDetails_Click);
            // 
            // btn_AccountStatement
            // 
            this.btn_AccountStatement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_AccountStatement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AccountStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AccountStatement.Location = new System.Drawing.Point(440, 239);
            this.btn_AccountStatement.Name = "btn_AccountStatement";
            this.btn_AccountStatement.Size = new System.Drawing.Size(246, 37);
            this.btn_AccountStatement.TabIndex = 7;
            this.btn_AccountStatement.Text = "Account Statement";
            this.btn_AccountStatement.UseVisualStyleBackColor = false;
            this.btn_AccountStatement.Click += new System.EventHandler(this.btn_AccountStatement_Click);
            // 
            // btn_CheckAccountBAlance
            // 
            this.btn_CheckAccountBAlance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CheckAccountBAlance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CheckAccountBAlance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_CheckAccountBAlance.Location = new System.Drawing.Point(440, 91);
            this.btn_CheckAccountBAlance.Name = "btn_CheckAccountBAlance";
            this.btn_CheckAccountBAlance.Size = new System.Drawing.Size(246, 37);
            this.btn_CheckAccountBAlance.TabIndex = 8;
            this.btn_CheckAccountBAlance.Text = "Account Balance";
            this.btn_CheckAccountBAlance.UseVisualStyleBackColor = false;
            this.btn_CheckAccountBAlance.Click += new System.EventHandler(this.btn_CheckAccountBAlance_Click);
            // 
            // btn_Transfer
            // 
            this.btn_Transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Transfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Transfer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Transfer.Location = new System.Drawing.Point(102, 313);
            this.btn_Transfer.Name = "btn_Transfer";
            this.btn_Transfer.Size = new System.Drawing.Size(246, 37);
            this.btn_Transfer.TabIndex = 9;
            this.btn_Transfer.Text = "Transfer";
            this.btn_Transfer.UseVisualStyleBackColor = false;
            this.btn_Transfer.Click += new System.EventHandler(this.btn_Transfer_Click);
            // 
            // TransactionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Transfer);
            this.Controls.Add(this.btn_CheckAccountBAlance);
            this.Controls.Add(this.btn_AccountStatement);
            this.Controls.Add(this.btn_AccountDetails);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_CreateBankAccount);
            this.Controls.Add(this.lbl_TransactionMenu);
            this.Name = "TransactionMenu";
            this.Text = "TransactionMenu";
            this.Load += new System.EventHandler(this.TransactionMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_TransactionMenu;
        private Button btn_CreateBankAccount;
        private Button btn_Deposit;
        private Button btn_Logout;
        private Button btn_Withdraw;
        private Button btn_AccountDetails;
        private Button btn_AccountStatement;
        private Button btn_CheckAccountBAlance;
        private Button btn_Transfer;
    }
}