using TrustBank.Models;

namespace TrustBankApp_Core.Interfaces
{
    public interface IBankAccountService
    {
        Task<bool> CreateBankAccount(BankAccount bankAccount);
        
        Task<BankAccount>? GetBankAccountByCustomerId(int id);
        
        Task<List<BankAccount>>? GetAllAccountsByCustomerId(int customerId);
        
        Task<BankAccount>? GetBankAccountsByAccountNumber(string accountNumber);

        Task CheckBalance(string accountNumber);

        Task<bool> Deposit(decimal amount, BankAccount bankAccount, string note);
       
        Task<bool> Withdraw(decimal amount, BankAccount bankAccount, string note);
       
        Task<bool> Transfer(decimal amount, BankAccount bankAccount, string note, string DestinationAccount);
  

    }
}