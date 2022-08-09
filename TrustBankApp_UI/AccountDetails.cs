using System.Data;
using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class AccountDetails : Form
    {
        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer;

        public AccountDetails( CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private async void AccountDetails_Load(object sender, EventArgs e)
        {
            List<BankAccount>? Account = await bankAccountService.GetAllAccountsByCustomerId(Customer.Id);
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("FULL NAME", typeof(string));
            dataTable.Columns.Add("ACCOUNT NUMBER", typeof(string));
            dataTable.Columns.Add("ACCOUNT TYPE", typeof(string));
            dataTable.Columns.Add("ACCOUNT BALANCE", typeof(string));

            foreach (var item in Account)
            {
                dataTable.Rows.Add(new object[] { Customer.FullName, item.AccountNumber, item.AccountType.ToString(), $"{item.AccountBalance:N2}" });
                
                
            }
            dvAccountDetails.DataSource = dataTable;
        }
      
        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }
    }
}
