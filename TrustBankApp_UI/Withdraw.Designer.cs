namespace TrustBankApp_WinForm
{
    partial class Withdraw
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
            this.lbl_WithdrawMenu = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.txt_WithdrawAccountNumber = new System.Windows.Forms.TextBox();
            this.txt_WithdrawAmount = new System.Windows.Forms.TextBox();
            this.txt_WithdrawDescription = new System.Windows.Forms.TextBox();
            this.lbl_WithdrawAccountNumber = new System.Windows.Forms.Label();
            this.lbl_WithdrawAmount = new System.Windows.Forms.Label();
            this.lbl_WithdrawDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_WithdrawMenu
            // 
            this.lbl_WithdrawMenu.AutoSize = true;
            this.lbl_WithdrawMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_WithdrawMenu.Location = new System.Drawing.Point(284, 9);
            this.lbl_WithdrawMenu.Name = "lbl_WithdrawMenu";
            this.lbl_WithdrawMenu.Size = new System.Drawing.Size(224, 37);
            this.lbl_WithdrawMenu.TabIndex = 0;
            this.lbl_WithdrawMenu.Text = "Withdraw Menu";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(555, 351);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(110, 39);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(88, 351);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(223, 39);
            this.btn_BackToTransactionMenu.TabIndex = 2;
            this.btn_BackToTransactionMenu.Text = "Back To Transaction Menu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // txt_WithdrawAccountNumber
            // 
            this.txt_WithdrawAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_WithdrawAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_WithdrawAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_WithdrawAccountNumber.Location = new System.Drawing.Point(361, 87);
            this.txt_WithdrawAccountNumber.Name = "txt_WithdrawAccountNumber";
            this.txt_WithdrawAccountNumber.Size = new System.Drawing.Size(291, 29);
            this.txt_WithdrawAccountNumber.TabIndex = 3;
            // 
            // txt_WithdrawAmount
            // 
            this.txt_WithdrawAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_WithdrawAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_WithdrawAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_WithdrawAmount.Location = new System.Drawing.Point(361, 146);
            this.txt_WithdrawAmount.Name = "txt_WithdrawAmount";
            this.txt_WithdrawAmount.Size = new System.Drawing.Size(291, 29);
            this.txt_WithdrawAmount.TabIndex = 4;
            // 
            // txt_WithdrawDescription
            // 
            this.txt_WithdrawDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_WithdrawDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_WithdrawDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_WithdrawDescription.Location = new System.Drawing.Point(361, 207);
            this.txt_WithdrawDescription.Name = "txt_WithdrawDescription";
            this.txt_WithdrawDescription.Size = new System.Drawing.Size(291, 29);
            this.txt_WithdrawDescription.TabIndex = 5;
            // 
            // lbl_WithdrawAccountNumber
            // 
            this.lbl_WithdrawAccountNumber.AutoSize = true;
            this.lbl_WithdrawAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawAccountNumber.Location = new System.Drawing.Point(147, 90);
            this.lbl_WithdrawAccountNumber.Name = "lbl_WithdrawAccountNumber";
            this.lbl_WithdrawAccountNumber.Size = new System.Drawing.Size(189, 21);
            this.lbl_WithdrawAccountNumber.TabIndex = 6;
            this.lbl_WithdrawAccountNumber.Text = "Enter Account Number:";
            // 
            // lbl_WithdrawAmount
            // 
            this.lbl_WithdrawAmount.AutoSize = true;
            this.lbl_WithdrawAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawAmount.Location = new System.Drawing.Point(147, 153);
            this.lbl_WithdrawAmount.Name = "lbl_WithdrawAmount";
            this.lbl_WithdrawAmount.Size = new System.Drawing.Size(76, 21);
            this.lbl_WithdrawAmount.TabIndex = 7;
            this.lbl_WithdrawAmount.Text = "Amount:";
            // 
            // lbl_WithdrawDescription
            // 
            this.lbl_WithdrawDescription.AutoSize = true;
            this.lbl_WithdrawDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawDescription.Location = new System.Drawing.Point(147, 215);
            this.lbl_WithdrawDescription.Name = "lbl_WithdrawDescription";
            this.lbl_WithdrawDescription.Size = new System.Drawing.Size(102, 21);
            this.lbl_WithdrawDescription.TabIndex = 8;
            this.lbl_WithdrawDescription.Text = "Description:";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_WithdrawDescription);
            this.Controls.Add(this.lbl_WithdrawAmount);
            this.Controls.Add(this.lbl_WithdrawAccountNumber);
            this.Controls.Add(this.txt_WithdrawDescription);
            this.Controls.Add(this.txt_WithdrawAmount);
            this.Controls.Add(this.txt_WithdrawAccountNumber);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lbl_WithdrawMenu);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_WithdrawMenu;
        private Button btnWithdraw;
        private Button btn_BackToTransactionMenu;
        private TextBox txt_WithdrawAccountNumber;
        private TextBox txt_WithdrawAmount;
        private TextBox txt_WithdrawDescription;
        private Label lbl_WithdrawAccountNumber;
        private Label lbl_WithdrawAmount;
        private Label lbl_WithdrawDescription;
    }
}