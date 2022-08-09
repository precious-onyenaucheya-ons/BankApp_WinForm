using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class Deposit : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer;

        public Deposit(CustomerAccount customer)
        {
            InitializeComponent();
            Customer = customer;
        }

        private void txt_DepositAccountNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            
        }

        private async void btnDeposit_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_DepositAccountNumber.Text;
            string note = txt_DepositDescription.Text;

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
                    if (txt_DepositAmount.Text == "")
                    {
                        MessageBox.Show("Invalid Deposit Amount! ");
                    }
                    else
                    {
                        decimal amountToDeposit = decimal.Parse(txt_DepositAmount.Text);
                        if (amountToDeposit <= 0)
                        {
                            MessageBox.Show("Deposit Amount must be positive! ");
                        }
                        else
                        {
                            bool isSuccessful = await bankAccountService.Deposit(amountToDeposit, bankAccount, note);
                            if (!isSuccessful)
                            {
                                MessageBox.Show("Transaction Failed, Try Again");
                                this.Hide();
                                Deposit deposit = new Deposit(Customer);
                                deposit.Show();
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

        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }
    }
}
