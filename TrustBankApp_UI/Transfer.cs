using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class Transfer : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer;

        public Transfer(CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private async void btnTransfer_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_TransferAccountNumber.Text;
            string description = txt_TransferDescription.Text;

            string? DestinationAccount = txt_DestinationAccountNumber.Text;
            BankAccount? DestinationBankAcc = await bankAccountService.GetBankAccountsByAccountNumber(DestinationAccount);

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
                    if (txt_TransferAmount.Text == "")
                    {
                        MessageBox.Show("Invalid Deposit Amount! ");
                    }

                    if (DestinationBankAcc == null)
                    {
                        MessageBox.Show("Account number doesnt exist, please input a valid destination account number? ");
                    }
                    else
                    {
                        decimal amountToTransfer = decimal.Parse(txt_TransferAmount.Text);
                        if (amountToTransfer <= 0)
                        {
                            MessageBox.Show("Deposit Amount must be positive! ");
                        }
                        else
                        {
                            if (bankAccount.AccountType == AccountType.CurrentAccount && bankAccount.AccountBalance < amountToTransfer)
                            {
                                MessageBox.Show("Insufficient Balance");
                            }
                            else if (bankAccount.AccountType == AccountType.SavingsAccount && bankAccount.AccountBalance - amountToTransfer < 1000)
                            {
                                MessageBox.Show("Insufficient Balance");
                            }
                            else
                            {
                                bool isSuccessful = await bankAccountService.Transfer(amountToTransfer, bankAccount, description, DestinationAccount);
                                if (!isSuccessful)
                                {
                                    MessageBox.Show("Transaction Failed, Try Again");
                                    this.Hide();
                                    Transfer transfer = new Transfer(Customer);
                                    transfer.Show();
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

        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }
    }
}

