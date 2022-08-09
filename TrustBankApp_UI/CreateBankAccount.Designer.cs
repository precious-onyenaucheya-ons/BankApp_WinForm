namespace TrustBankApp_WinForm
{
    partial class CreateBankAccount
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
            this.lbl_CreateBankAccountMenu = new System.Windows.Forms.Label();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.btnCreateBankAccount = new System.Windows.Forms.Button();
            this.lbl_AccountTypeSelection = new System.Windows.Forms.Label();
            this.rbSavings = new System.Windows.Forms.RadioButton();
            this.rbCurrent = new System.Windows.Forms.RadioButton();
            this.lblInitialDeposit = new System.Windows.Forms.Label();
            this.txtInitialDeposit = new System.Windows.Forms.TextBox();
            this.lblAccountCreated = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CreateBankAccountMenu
            // 
            this.lbl_CreateBankAccountMenu.AutoSize = true;
            this.lbl_CreateBankAccountMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_CreateBankAccountMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_CreateBankAccountMenu.Location = new System.Drawing.Point(233, 9);
            this.lbl_CreateBankAccountMenu.Name = "lbl_CreateBankAccountMenu";
            this.lbl_CreateBankAccountMenu.Size = new System.Drawing.Size(283, 37);
            this.lbl_CreateBankAccountMenu.TabIndex = 0;
            this.lbl_CreateBankAccountMenu.Text = "Create Bank Account";
            this.lbl_CreateBankAccountMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(96, 258);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(223, 39);
            this.btn_BackToTransactionMenu.TabIndex = 13;
            this.btn_BackToTransactionMenu.Text = "Back To Transaction Menu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // btnCreateBankAccount
            // 
            this.btnCreateBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCreateBankAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateBankAccount.Location = new System.Drawing.Point(544, 258);
            this.btnCreateBankAccount.Name = "btnCreateBankAccount";
            this.btnCreateBankAccount.Size = new System.Drawing.Size(147, 39);
            this.btnCreateBankAccount.TabIndex = 12;
            this.btnCreateBankAccount.Text = "Create Account";
            this.btnCreateBankAccount.UseVisualStyleBackColor = false;
            this.btnCreateBankAccount.Click += new System.EventHandler(this.btnCreateBankAccount_Click);
            // 
            // lbl_AccountTypeSelection
            // 
            this.lbl_AccountTypeSelection.AutoSize = true;
            this.lbl_AccountTypeSelection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountTypeSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_AccountTypeSelection.Location = new System.Drawing.Point(96, 65);
            this.lbl_AccountTypeSelection.Name = "lbl_AccountTypeSelection";
            this.lbl_AccountTypeSelection.Size = new System.Drawing.Size(218, 21);
            this.lbl_AccountTypeSelection.TabIndex = 14;
            this.lbl_AccountTypeSelection.Text = "Select Account Type below:";
            // 
            // rbSavings
            // 
            this.rbSavings.AutoSize = true;
            this.rbSavings.Location = new System.Drawing.Point(117, 89);
            this.rbSavings.Name = "rbSavings";
            this.rbSavings.Size = new System.Drawing.Size(113, 19);
            this.rbSavings.TabIndex = 15;
            this.rbSavings.TabStop = true;
            this.rbSavings.Text = "Savings Account";
            this.rbSavings.UseVisualStyleBackColor = true;
            this.rbSavings.CheckedChanged += new System.EventHandler(this.rbSavings_CheckedChanged);
            // 
            // rbCurrent
            // 
            this.rbCurrent.AutoSize = true;
            this.rbCurrent.Location = new System.Drawing.Point(117, 115);
            this.rbCurrent.Name = "rbCurrent";
            this.rbCurrent.Size = new System.Drawing.Size(113, 19);
            this.rbCurrent.TabIndex = 16;
            this.rbCurrent.TabStop = true;
            this.rbCurrent.Text = "Current Account";
            this.rbCurrent.UseVisualStyleBackColor = true;
            // 
            // lblInitialDeposit
            // 
            this.lblInitialDeposit.AutoSize = true;
            this.lblInitialDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInitialDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblInitialDeposit.Location = new System.Drawing.Point(96, 151);
            this.lblInitialDeposit.Name = "lblInitialDeposit";
            this.lblInitialDeposit.Size = new System.Drawing.Size(232, 21);
            this.lblInitialDeposit.TabIndex = 17;
            this.lblInitialDeposit.Text = "Enter Initial Deposit Amount:";
            // 
            // txtInitialDeposit
            // 
            this.txtInitialDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtInitialDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtInitialDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtInitialDeposit.Location = new System.Drawing.Point(334, 151);
            this.txtInitialDeposit.Name = "txtInitialDeposit";
            this.txtInitialDeposit.Size = new System.Drawing.Size(138, 27);
            this.txtInitialDeposit.TabIndex = 18;
            // 
            // lblAccountCreated
            // 
            this.lblAccountCreated.AutoSize = true;
            this.lblAccountCreated.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAccountCreated.Location = new System.Drawing.Point(571, 80);
            this.lblAccountCreated.Name = "lblAccountCreated";
            this.lblAccountCreated.Size = new System.Drawing.Size(178, 20);
            this.lblAccountCreated.TabIndex = 20;
            this.lblAccountCreated.Text = "Your account Number is ";
            // 
            // CreateBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccountCreated);
            this.Controls.Add(this.txtInitialDeposit);
            this.Controls.Add(this.lblInitialDeposit);
            this.Controls.Add(this.rbCurrent);
            this.Controls.Add(this.rbSavings);
            this.Controls.Add(this.lbl_AccountTypeSelection);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.btnCreateBankAccount);
            this.Controls.Add(this.lbl_CreateBankAccountMenu);
            this.Name = "CreateBankAccount";
            this.Text = "CreateBankAccount";
            this.Load += new System.EventHandler(this.CreateBankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_CreateBankAccountMenu;
        private CheckBox cb_AccountTypeS;
        private CheckBox cb_AccountTypeC;
        private Button btn_BackToTransactionMenu;
        private Button btnCreateBankAccount;
        private Label lbl_AccountTypeSelection;
        private RadioButton rbSavings;
        private RadioButton rbCurrent;
        private Label lblInitialDeposit;
        private TextBox txtInitialDeposit;
        private Label label1;
        private Label lblAccountCreated;
    }
}