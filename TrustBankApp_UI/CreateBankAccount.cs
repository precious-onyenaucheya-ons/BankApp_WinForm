using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class CreateBankAccount : Form
    {

        private static IBankAccountService _bankAccountService;
        public static IBankAccountService bankAccountService
        {
            get => _bankAccountService ??= new BankAccountService();
        }

        public CustomerAccount Customer { get; set; }

        public CreateBankAccount(CustomerAccount customer)
        {
            Customer = customer;
            InitializeComponent();
        }

        private void Cb_AccountTypeS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSavings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateBankAccount_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string accountNum = Convert.ToString(random.Next(1011111111, 1099999999));
            BankAccount bankAcc = new BankAccount(Customer.Id, accountNum, rbSavings.Checked == true ? AccountType.SavingsAccount : AccountType.CurrentAccount);

            bool isValid = true;
            if (rbSavings.Checked != true && rbCurrent.Checked != true)
            {
                MessageBox.Show("Please select account type! ");
                isValid = false;
            }
            if (txtInitialDeposit.Text == "")
            {
                MessageBox.Show("Please enter a valid amount! ");
                isValid = false;
            }

            if (isValid == true)
            {
                decimal amountToDeposit = decimal.Parse(txtInitialDeposit.Text);



                if (amountToDeposit < 1000)
                {
                    MessageBox.Show("Please deposit a minimum value of 1000!.How much do you wish to deposit? ");

                }
                else
                {
                    bankAccountService.CreateBankAccount(bankAcc);
                    bankAccountService.Deposit(amountToDeposit, bankAcc, "Initial Deposit");
                    MessageBox.Show("Account Created Successfully!");
                    MessageBox.Show($"Dear {Customer.FullName},\n {lblAccountCreated.Text} \n is {accountNum}");
                    /*lblAccountCreated.Text = $"Dear {Customer.FullName},\n {lblAccountCreated.Text} \n is {accountNum}";
                    lblAccountCreated.Show();*/
                    this.Hide();
                    TransactionMenu transactionMenu = new TransactionMenu(Customer);
                    transactionMenu.Show();
                }
            }

        }

        private void CreateBankAccount_Load(object sender, EventArgs e)
        {
            lblAccountCreated.Hide();
        }

        private void btn_BackToTransactionMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionMenu transactionMenu = new TransactionMenu(Customer);
            transactionMenu.Show();
        }
    }
}
