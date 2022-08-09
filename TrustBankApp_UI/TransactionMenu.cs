using TrustBank.Models;

namespace TrustBankApp_WinForm
{
    public partial class TransactionMenu : Form
    {
        public CustomerAccount Customer { get; set; }

        public TransactionMenu(CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Welcome welcome = new Welcome ();
            welcome.Show();
        }

        private void btn_CreateBankAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateBankAccount bankAccount = new CreateBankAccount(Customer);
            bankAccount.Show();
        }

        private void TransactionMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            this.Hide ();
            Deposit deposit = new Deposit(Customer);
            deposit.Show();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw(Customer);
            withdraw.Show();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer(Customer);
            transfer.Show();
        }

        private void btn_CheckAccountBAlance_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountBalance accountBalance = new AccountBalance(Customer);
            accountBalance.Show();
        }

        private void btn_AccountDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountDetails accountDetails = new AccountDetails(Customer);
            accountDetails.Show();
        }

        private void btn_AccountStatement_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountStatement accountStatement = new AccountStatement(Customer);
            accountStatement.Show();
        }
    }
}
