using System.Data;
using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class AccountStatement : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        private static ITransactionService _transactionService;
        public static ITransactionService transactionService
        {
            get => _transactionService ??= new TransactionService();
        }

        public CustomerAccount Customer;

        public AccountStatement(CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private void lbl_AccountStatement_Click(object sender, EventArgs e)
        {
            
                
        }

        private void AccountStatement_Load(object sender, EventArgs e)
        {
            dvAccountStatement.Hide();
        }

        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }

        private async void btnAccountStatment_Click(object sender, EventArgs e)
        {
            string AccountNumber = txtAccountNumber.Text;
            BankAccount? bankAccount = await bankAccountService.GetBankAccountsByAccountNumber(AccountNumber);
            if (bankAccount == null)
            {

                MessageBox.Show("Account number doesnt exist");
            }
            else
            {
                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("DATE", typeof(string));
                dataTable.Columns.Add("DESCRIPTION", typeof(string));
                dataTable.Columns.Add("AMOUNT", typeof(string));
                dataTable.Columns.Add("BALANCE", typeof(string));


                BankAccount account = await bankAccountService.GetBankAccountsByAccountNumber(AccountNumber);
                List<BankTransaction>? list = await transactionService.GetAllTransactionByBankAccountId(account.Id);

                foreach (var item in list)
                {
                    dataTable.Rows.Add(new object[] { item.Date.ToShortDateString(), item.Note, $"{item.Amount}", $"{item.Balance:N2}" });
                }
                dvAccountStatement.DataSource = dataTable;
                dvAccountStatement.Show();

            }
        }
    }
}
