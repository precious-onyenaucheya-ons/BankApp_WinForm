using TrustBank;
using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankCore.Helpers;
using TrustBankCore.Interfaces;

namespace TrustBankApp_WinForm
{
    public partial class Register : Form
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
            get =>  _utilities ??= new Utilities();
        }

        public Register()
        {
            InitializeComponent();
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txt_FirstName.Text;
                string lastName = txt_LastName.Text;
                string email = txt_Email.Text;
                string password = txt_Password.Text;

                if (!validate.IsValidName(firstName)) { MessageBox.Show("Invalid Name Format!Name must be capitalized"); }
                else if (!validate.IsValidName(lastName)) { MessageBox.Show("Invalid Name Format!Name must be capitalized"); }
                else if (!validate.IsValidMail(email)) { MessageBox.Show("Invalid Email Format!"); }
                else if (!validate.IsValidPassword(password)) { MessageBox.Show("Invalid Password! Password must contain minimum 6 alphanumeric and special characters!"); }
                else if (await Customer.CheckCustomerByEmail(email)) { MessageBox.Show("User Account Exists"); }
                else
                {
                    string fullname = firstName + " " + lastName;
                    string hashpassword = utilities.computeSha256Hash(password);


                    CustomerAccount customer = new CustomerAccount()
                    {
                        FullName = fullname,
                        EmailAddress = email,
                        Password = hashpassword
                    };


                    var isSuccessful = await Customer.CreateCustomer(customer);
                    if (isSuccessful)
                    {
                        MessageBox.Show("Registration Successful");
                        this.Hide();
                        TransactionMenu mainMenu = new TransactionMenu(customer);
                        mainMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration Unsuccessful");
                        this.Hide();
                        Register register = new Register();
                        register.Show();
                    }
                }
            }
            catch(Exception ex)
            {
            MessageBox.Show(ex.Message);
            }

        }

        private void btn_BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
