using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class AccountBalance : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer;

        public AccountBalance(CustomerAccount customer)
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

        private async void btnAccountBalance_Click(object sender, EventArgs e)
        {
            string accountNumber = txt_AccountBalance.Text;

            BankAccount? bankAccount = await bankAccountService.GetBankAccountsByAccountNumber(accountNumber);
            if (bankAccount == null)
            {

                MessageBox.Show("Account number doesnt exist");
            }
            else
                // bankAccountService.CheckBalance(accountNumber);
            lblGetBalance.Text = "";
            lblGetBalance.Text = $"Dear {Customer.FullName}, Your Account Balance is {bankAccount.AccountBalance}." ;
            lblGetBalance.Show();
        }

        private void AccountBalance_Load(object sender, EventArgs e)
        {
            lblGetBalance.Hide();
        }
    }
}
