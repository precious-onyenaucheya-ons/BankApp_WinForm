using TrustBank.Models;

namespace TrustBankApp_Core.Interfaces
{
    public interface IRepository
    {
        Task<bool> CreateCustomer(CustomerAccount customer);

        Task<CustomerAccount> GetCustomerById(int customerId);

        Task<bool> RemoveCustomerByID(int customerId);

        Task<bool> CheckCustomerByEmail(string email);

        Task<CustomerAccount> GetCustomerByEmail(string email);

        Task<bool> CreateBankAccount(BankAccount account);

        Task<bool> UpdateDeposit(BankAccount account, decimal amount);

        Task<BankAccount> GetBankAccountByCustomerId(int customerId);

        Task<bool> UpdateWithdraw(BankAccount account, decimal amount);

        Task<BankAccount> GetBankAccountsByAccountNumber(string accountNumber);

        Task<List<BankAccount>> GetAllBankAccountsByCustomerId(int customerId);

        Task<BankTransaction> GetTransactionId(int accountNo);

        Task<List<BankTransaction>> GetAllTransactionByBankAccountId(int accountId);


        Task<bool> CreateTransaction(BankTransaction transaction);               
    }
}
