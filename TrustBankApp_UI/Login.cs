using TrustBank;
using TrustBank.BusinessLogic;
using TrustBankCore.Helpers;
using TrustBankCore.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class Login : Form
    {

        private static ICustomerService _Customer;
        public static ICustomerService Customer
        {
            get => _Customer ??= new CustomerService();
        }

        private static IValidate _validate;
        public static IValidate validate
        {
            get => _validate ??= new Validate();
        }

        private static IUtilities _utilities;
        public static IUtilities utilities
        {
            get => _utilities ??= new Utilities();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void lbl_BackToRegister_Click(object sender, EventArgs e)
        {
            
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            string email = txt_MailLogin.Text;
            string password = txt_PasswordLogin.Text;

            string hashpassword = utilities.computeSha256Hash(password);

            var customer = await Customer.GetCustomerByEmail(email);

            if(customer != null)
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                TransactionMenu mainMenu = new TransactionMenu(customer);
                mainMenu.Customer = customer;
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password");
                this.Close();
                Login login = new Login();
                login.Show();
            }

            
        }

        private void btn_BackToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
