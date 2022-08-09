namespace TrustBankApp_WinForm
{
    partial class Transfer
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
            this.lbl_WithdrawDescription = new System.Windows.Forms.Label();
            this.lbl_WithdrawAmount = new System.Windows.Forms.Label();
            this.lbl_WithdrawAccountNumber = new System.Windows.Forms.Label();
            this.txt_TransferDescription = new System.Windows.Forms.TextBox();
            this.txt_TransferAmount = new System.Windows.Forms.TextBox();
            this.txt_TransferAccountNumber = new System.Windows.Forms.TextBox();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.lbl_TransferMenu = new System.Windows.Forms.Label();
            this.lbl_DestinationAccountNumber = new System.Windows.Forms.Label();
            this.txt_DestinationAccountNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_WithdrawDescription
            // 
            this.lbl_WithdrawDescription.AutoSize = true;
            this.lbl_WithdrawDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawDescription.Location = new System.Drawing.Point(122, 278);
            this.lbl_WithdrawDescription.Name = "lbl_WithdrawDescription";
            this.lbl_WithdrawDescription.Size = new System.Drawing.Size(102, 21);
            this.lbl_WithdrawDescription.TabIndex = 17;
            this.lbl_WithdrawDescription.Text = "Description:";
            // 
            // lbl_WithdrawAmount
            // 
            this.lbl_WithdrawAmount.AutoSize = true;
            this.lbl_WithdrawAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawAmount.Location = new System.Drawing.Point(122, 225);
            this.lbl_WithdrawAmount.Name = "lbl_WithdrawAmount";
            this.lbl_WithdrawAmount.Size = new System.Drawing.Size(76, 21);
            this.lbl_WithdrawAmount.TabIndex = 16;
            this.lbl_WithdrawAmount.Text = "Amount:";
            // 
            // lbl_WithdrawAccountNumber
            // 
            this.lbl_WithdrawAccountNumber.AutoSize = true;
            this.lbl_WithdrawAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_WithdrawAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_WithdrawAccountNumber.Location = new System.Drawing.Point(122, 116);
            this.lbl_WithdrawAccountNumber.Name = "lbl_WithdrawAccountNumber";
            this.lbl_WithdrawAccountNumber.Size = new System.Drawing.Size(189, 21);
            this.lbl_WithdrawAccountNumber.TabIndex = 15;
            this.lbl_WithdrawAccountNumber.Text = "Enter Account Number:";
            // 
            // txt_TransferDescription
            // 
            this.txt_TransferDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_TransferDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TransferDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_TransferDescription.Location = new System.Drawing.Point(385, 270);
            this.txt_TransferDescription.Name = "txt_TransferDescription";
            this.txt_TransferDescription.Size = new System.Drawing.Size(291, 29);
            this.txt_TransferDescription.TabIndex = 14;
            // 
            // txt_TransferAmount
            // 
            this.txt_TransferAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_TransferAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TransferAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_TransferAmount.Location = new System.Drawing.Point(385, 216);
            this.txt_TransferAmount.Name = "txt_TransferAmount";
            this.txt_TransferAmount.Size = new System.Drawing.Size(291, 29);
            this.txt_TransferAmount.TabIndex = 13;
            // 
            // txt_TransferAccountNumber
            // 
            this.txt_TransferAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_TransferAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_TransferAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_TransferAccountNumber.Location = new System.Drawing.Point(385, 109);
            this.txt_TransferAccountNumber.Name = "txt_TransferAccountNumber";
            this.txt_TransferAccountNumber.Size = new System.Drawing.Size(291, 29);
            this.txt_TransferAccountNumber.TabIndex = 12;
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(112, 377);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(223, 39);
            this.btn_BackToTransactionMenu.TabIndex = 11;
            this.btn_BackToTransactionMenu.Text = "Back To Transaction Menu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(579, 377);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(110, 39);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // lbl_TransferMenu
            // 
            this.lbl_TransferMenu.AutoSize = true;
            this.lbl_TransferMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TransferMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_TransferMenu.Location = new System.Drawing.Point(308, 35);
            this.lbl_TransferMenu.Name = "lbl_TransferMenu";
            this.lbl_TransferMenu.Size = new System.Drawing.Size(201, 37);
            this.lbl_TransferMenu.TabIndex = 9;
            this.lbl_TransferMenu.Text = "Transfer Menu";
            // 
            // lbl_DestinationAccountNumber
            // 
            this.lbl_DestinationAccountNumber.AutoSize = true;
            this.lbl_DestinationAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DestinationAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_DestinationAccountNumber.Location = new System.Drawing.Point(122, 174);
            this.lbl_DestinationAccountNumber.Name = "lbl_DestinationAccountNumber";
            this.lbl_DestinationAccountNumber.Size = new System.Drawing.Size(238, 21);
            this.lbl_DestinationAccountNumber.TabIndex = 18;
            this.lbl_DestinationAccountNumber.Text = "Destination Account Number:";
            // 
            // txt_DestinationAccountNumber
            // 
            this.txt_DestinationAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_DestinationAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_DestinationAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txt_DestinationAccountNumber.Location = new System.Drawing.Point(385, 162);
            this.txt_DestinationAccountNumber.Name = "txt_DestinationAccountNumber";
            this.txt_DestinationAccountNumber.Size = new System.Drawing.Size(291, 29);
            this.txt_DestinationAccountNumber.TabIndex = 19;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_DestinationAccountNumber);
            this.Controls.Add(this.lbl_DestinationAccountNumber);
            this.Controls.Add(this.lbl_WithdrawDescription);
            this.Controls.Add(this.lbl_WithdrawAmount);
            this.Controls.Add(this.lbl_WithdrawAccountNumber);
            this.Controls.Add(this.txt_TransferDescription);
            this.Controls.Add(this.txt_TransferAmount);
            this.Controls.Add(this.txt_TransferAccountNumber);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lbl_TransferMenu);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_WithdrawDescription;
        private Label lbl_WithdrawAmount;
        private Label lbl_WithdrawAccountNumber;
        private TextBox txt_TransferDescription;
        private TextBox txt_TransferAmount;
        private TextBox txt_TransferAccountNumber;
        private Button btn_BackToTransactionMenu;
        private Button btnTransfer;
        private Label lbl_TransferMenu;
        private Label lbl_DestinationAccountNumber;
        private TextBox txt_DestinationAccountNumber;
    }
}