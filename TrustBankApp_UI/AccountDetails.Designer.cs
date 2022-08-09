namespace TrustBankApp_WinForm
{
    partial class AccountDetails
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
            this.lbl_AccountDetails = new System.Windows.Forms.Label();
            this.btn_BackToTransactionMenu = new System.Windows.Forms.Button();
            this.dvAccountDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvAccountDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AccountDetails
            // 
            this.lbl_AccountDetails.AutoSize = true;
            this.lbl_AccountDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AccountDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_AccountDetails.Location = new System.Drawing.Point(0, 9);
            this.lbl_AccountDetails.Name = "lbl_AccountDetails";
            this.lbl_AccountDetails.Size = new System.Drawing.Size(150, 25);
            this.lbl_AccountDetails.TabIndex = 2;
            this.lbl_AccountDetails.Text = "Account Details";
            // 
            // btn_BackToTransactionMenu
            // 
            this.btn_BackToTransactionMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_BackToTransactionMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_BackToTransactionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToTransactionMenu.Location = new System.Drawing.Point(23, 365);
            this.btn_BackToTransactionMenu.Name = "btn_BackToTransactionMenu";
            this.btn_BackToTransactionMenu.Size = new System.Drawing.Size(226, 41);
            this.btn_BackToTransactionMenu.TabIndex = 5;
            this.btn_BackToTransactionMenu.Text = "Back To TransactionMenu";
            this.btn_BackToTransactionMenu.UseVisualStyleBackColor = false;
            this.btn_BackToTransactionMenu.Click += new System.EventHandler(this.btn_BackToTransactionMenu_Click);
            // 
            // dvAccountDetails
            // 
            this.dvAccountDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAccountDetails.Location = new System.Drawing.Point(0, 57);
            this.dvAccountDetails.Name = "dvAccountDetails";
            this.dvAccountDetails.RowTemplate.Height = 25;
            this.dvAccountDetails.Size = new System.Drawing.Size(789, 283);
            this.dvAccountDetails.TabIndex = 6;
            // 
            // AccountDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.dvAccountDetails);
            this.Controls.Add(this.btn_BackToTransactionMenu);
            this.Controls.Add(this.lbl_AccountDetails);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "AccountDetails";
            this.Text = "AccountDetails";
            this.Load += new System.EventHandler(this.AccountDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvAccountDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_AccountDetails;
        private Button btn_BackToTransactionMenu;
        private DataGridView dvAccountDetails;
    }
}