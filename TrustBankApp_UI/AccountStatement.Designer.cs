namespace TrustBankApp_WinForm
{
    partial class AccountStatement
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
            this.lbl_AccountStatement = new System.Windows.Forms.Label();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.btnAccountStatment = new System.Windows.Forms.Button();
            this.dvAccountStatement = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvAccountStatement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AccountStatement
            // 
            this.lbl_AccountStatement.AutoSize = true;
            this.lbl_AccountStatement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountStatement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_AccountStatement.Location = new System.Drawing.Point(12, 17);
            this.lbl_AccountStatement.Name = "lbl_AccountStatement";
            this.lbl_AccountStatement.Size = new System.Drawing.Size(182, 25);
            this.lbl_AccountStatement.TabIndex = 1;
            this.lbl_AccountStatement.Text = "Account Statement";
            this.lbl_AccountStatement.Click += new System.EventHandler(this.lbl_AccountStatement_Click);
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(21, 395);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(226, 41);
            this.btn_BackToTransactionMenu.TabIndex = 8;
            this.btn_BackToTransactionMenu.Text = "Back To TransactionMenu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtAccountNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtAccountNumber.Location = new System.Drawing.Point(281, 59);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(204, 29);
            this.txtAccountNumber.TabIndex = 10;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAccountNumber.Location = new System.Drawing.Point(38, 62);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(193, 21);
            this.lblAccountNumber.TabIndex = 9;
            this.lblAccountNumber.Text = "Enter Account Number: ";
            // 
            // btnAccountStatment
            // 
            this.btnAccountStatment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccountStatment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccountStatment.ForeColor = System.Drawing.Color.White;
            this.btnAccountStatment.Location = new System.Drawing.Point(572, 50);
            this.btnAccountStatment.Name = "btnAccountStatment";
            this.btnAccountStatment.Size = new System.Drawing.Size(145, 45);
            this.btnAccountStatment.TabIndex = 11;
            this.btnAccountStatment.Text = "Print Statement";
            this.btnAccountStatment.UseVisualStyleBackColor = false;
            this.btnAccountStatment.Click += new System.EventHandler(this.btnAccountStatment_Click);
            // 
            // dvAccountStatement
            // 
            this.dvAccountStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAccountStatement.Location = new System.Drawing.Point(6, 112);
            this.dvAccountStatement.Name = "dvAccountStatement";
            this.dvAccountStatement.RowTemplate.Height = 25;
            this.dvAccountStatement.Size = new System.Drawing.Size(782, 277);
            this.dvAccountStatement.TabIndex = 12;
            // 
            // AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvAccountStatement);
            this.Controls.Add(this.btnAccountStatment);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.lbl_AccountStatement);
            this.Name = "AccountStatement";
            this.Text = "AccountStatement";
            this.Load += new System.EventHandler(this.AccountStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvAccountStatement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_AccountStatement;
        private Button btn_BackToTransactionMenu;
        private TextBox txtAccountNumber;
        private Label lblAccountNumber;
        private Button btnAccountStatment;
        private DataGridView dvAccountStatement;
    }
}