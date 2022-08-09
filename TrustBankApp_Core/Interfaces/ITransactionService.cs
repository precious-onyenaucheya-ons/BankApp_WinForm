using TrustBank.Models;

namespace TrustBankApp_Core.Interfaces
{
    public interface ITransactionService
    {
        Task<bool> CreateTransaction(BankTransaction bankTransaction);

        Task<List<BankTransaction>>? GetAllTransactionByBankAccountId(int bankAccountId);

    }
}