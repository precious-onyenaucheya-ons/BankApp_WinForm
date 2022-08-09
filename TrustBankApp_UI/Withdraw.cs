using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class Withdraw : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer;

        public Withdraw(CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }

        private async void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                string accountNumber = txt_WithdrawAccountNumber.Text;
                string description = txt_WithdrawDescription.Text;

                if (bankAccountService.GetBankAccountsByAccountNumber(accountNumber) == null)
                {
                    MessageBox.Show("Account number doesnt exist");
                }
                else
                {
                    BankAccount? bankAccount = await bankAccountService.GetBankAccountsByAccountNumber(accountNumber);
                    if (bankAccount == null)
                    {
                        MessageBox.Show("Account number doesnt exist");
                    }
                    else
                    {
                        bankAccount = await bankAccountService.GetBankAccountsByAccountNumber(accountNumber);
                        if (txt_WithdrawAmount.Text == "")
                        {
                            MessageBox.Show("Invalid Deposit Amount! ");
                        }
                        else
                        {
                            decimal amountToWithdraw = decimal.Parse(txt_WithdrawAmount.Text);
                            if (amountToWithdraw <= 0)
                            {
                                MessageBox.Show("Deposit Amount must be positive! ");
                            }
                            else
                            {
                                if (bankAccount.AccountType == AccountType.CurrentAccount && bankAccount.AccountBalance < amountToWithdraw)
                                {
                                    MessageBox.Show("Insufficient Balance");
                                }
                                else if (bankAccount.AccountType == AccountType.SavingsAccount && bankAccount.AccountBalance - amountToWithdraw < 1000)
                                {
                                    MessageBox.Show("Insufficient Balance");
                                }
                                else
                                {
                                    bool isSuccessful = await bankAccountService.Withdraw(amountToWithdraw, bankAccount, description);
                                    if (!isSuccessful)
                                    {
                                        MessageBox.Show("Transaction Failed, Try Again");
                                        this.Hide();
                                        Withdraw withdraw = new Withdraw(Customer);
                                        withdraw.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Transaction Successful");
                                        this.Hide();
                                        TransactionMenu transactionMenu = new TransactionMenu(Customer);
                                        transactionMenu.Show();
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Invalid Credentials! Try Again");
                this.Hide();
                Withdraw withdraw = new Withdraw(Customer);
                withdraw.Show();
            }
        
        


            

        }
    }
}
