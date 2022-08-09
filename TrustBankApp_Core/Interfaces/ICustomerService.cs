using TrustBank.Models;

namespace TrustBankCore.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerAccount> Login(string email, string password);

        Task<bool> Register(CustomerAccount customer);

        Task<bool> CreateCustomer(CustomerAccount customer);

        Task<CustomerAccount> GetCustomerByEmail(string email);

        Task<bool> CheckCustomerByEmail(string email);

        Task<CustomerAccount>? GetCustomerById(int id);

    }
}