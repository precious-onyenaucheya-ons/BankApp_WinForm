namespace TrustBank.Models
{
    public class CustomerAccount
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        private static int _id;

        public CustomerAccount(string fullname, string emailaddress, string password)
        {
            FullName = fullname;
            EmailAddress = emailaddress;
            Password = password;
            Id = ++Id;
        }

        public CustomerAccount()
        {
        }
    }
}
