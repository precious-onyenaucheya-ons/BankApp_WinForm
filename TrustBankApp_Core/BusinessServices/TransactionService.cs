using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBank.BusinessLogic
{
    public class TransactionService : ITransactionService
    {
        public IRepository _repository;

        public IRepository repository
        {
            get => _repository ??= new repository.Repository();
        }

        public async Task<bool> CreateTransaction(BankTransaction bankTransaction)
        {
            return await repository.CreateTransaction(bankTransaction);
        }

        public async Task<List<BankTransaction>> GetAllTransactionByBankAccountId(int bankAccountId)
        {
            return await repository.GetAllTransactionByBankAccountId(bankAccountId);
        }
    }
}
