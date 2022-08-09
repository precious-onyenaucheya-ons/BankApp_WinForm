namespace TrustBankApp_WinForm
{
    partial class Deposit
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
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lbl_DepositAccountNumber = new System.Windows.Forms.Label();
            this.lbl_DepositAmount = new System.Windows.Forms.Label();
            this.txt_DepositAmount = new System.Windows.Forms.TextBox();
            this.txt_DepositAccountNumber = new System.Windows.Forms.TextBox();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.lbl_DepositMenu = new System.Windows.Forms.Label();
            this.lbl_DepositDescription = new System.Windows.Forms.Label();
            this.txt_DepositDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.Location = new System.Drawing.Point(594, 296);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(121, 45);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lbl_DepositAccountNumber
            // 
            this.lbl_DepositAccountNumber.AutoSize = true;
            this.lbl_DepositAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DepositAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DepositAccountNumber.Location = new System.Drawing.Point(181, 89);
            this.lbl_DepositAccountNumber.Name = "lbl_DepositAccountNumber";
            this.lbl_DepositAccountNumber.Size = new System.Drawing.Size(193, 21);
            this.lbl_DepositAccountNumber.TabIndex = 1;
            this.lbl_DepositAccountNumber.Text = "Enter Account Number: ";
            // 
            // lbl_DepositAmount
            // 
            this.lbl_DepositAmount.AutoSize = true;
            this.lbl_DepositAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DepositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DepositAmount.Location = new System.Drawing.Point(182, 150);
            this.lbl_DepositAmount.Name = "lbl_DepositAmount";
            this.lbl_DepositAmount.Size = new System.Drawing.Size(80, 21);
            this.lbl_DepositAmount.TabIndex = 2;
            this.lbl_DepositAmount.Text = "Amount :";
            // 
            // txt_DepositAmount
            // 
            this.txt_DepositAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_DepositAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DepositAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_DepositAmount.Location = new System.Drawing.Point(412, 152);
            this.txt_DepositAmount.Name = "txt_DepositAmount";
            this.txt_DepositAmount.Size = new System.Drawing.Size(204, 29);
            this.txt_DepositAmount.TabIndex = 3;
            // 
            // txt_DepositAccountNumber
            // 
            this.txt_DepositAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_DepositAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DepositAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_DepositAccountNumber.Location = new System.Drawing.Point(412, 89);
            this.txt_DepositAccountNumber.Name = "txt_DepositAccountNumber";
            this.txt_DepositAccountNumber.Size = new System.Drawing.Size(204, 29);
            this.txt_DepositAccountNumber.TabIndex = 4;
            this.txt_DepositAccountNumber.TextChanged += new System.EventHandler(this.txt_DepositAccountNumber_TextChanged);
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(33, 296);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(241, 45);
            this.btn_BackToTransactionMenu.TabIndex = 5;
            this.btn_BackToTransactionMenu.Text = "Back To Transaction Menu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // lbl_DepositMenu
            // 
            this.lbl_DepositMenu.AutoSize = true;
            this.lbl_DepositMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DepositMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_DepositMenu.Location = new System.Drawing.Point(295, 9);
            this.lbl_DepositMenu.Name = "lbl_DepositMenu";
            this.lbl_DepositMenu.Size = new System.Drawing.Size(197, 37);
            this.lbl_DepositMenu.TabIndex = 6;
            this.lbl_DepositMenu.Text = "Deposit Menu";
            // 
            // lbl_DepositDescription
            // 
            this.lbl_DepositDescription.AutoSize = true;
            this.lbl_DepositDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DepositDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DepositDescription.Location = new System.Drawing.Point(182, 213);
            this.lbl_DepositDescription.Name = "lbl_DepositDescription";
            this.lbl_DepositDescription.Size = new System.Drawing.Size(106, 21);
            this.lbl_DepositDescription.TabIndex = 7;
            this.lbl_DepositDescription.Text = "Description :";
            // 
            // txt_DepositDescription
            // 
            this.txt_DepositDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_DepositDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DepositDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_DepositDescription.Location = new System.Drawing.Point(412, 215);
            this.txt_DepositDescription.Name = "txt_DepositDescription";
            this.txt_DepositDescription.Size = new System.Drawing.Size(204, 29);
            this.txt_DepositDescription.TabIndex = 8;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_DepositDescription);
            this.Controls.Add(this.lbl_DepositDescription);
            this.Controls.Add(this.lbl_DepositMenu);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.txt_DepositAccountNumber);
            this.Controls.Add(this.txt_DepositAmount);
            this.Controls.Add(this.lbl_DepositAmount);
            this.Controls.Add(this.lbl_DepositAccountNumber);
            this.Controls.Add(this.btnDeposit);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDeposit;
        private Label lbl_DepositAccountNumber;
        private Label lbl_DepositAmount;
        private TextBox txt_DepositAmount;
        private TextBox txt_DepositAccountNumber;
        private Button btn_BackToTransactionMenu;
        private Label lbl_DepositMenu;
        private Label lbl_DepositDescription;
        private TextBox txt_DepositDescription;
    }
}