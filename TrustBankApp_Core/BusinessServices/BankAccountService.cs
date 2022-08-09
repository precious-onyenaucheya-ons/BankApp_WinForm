using TrustBank.Models;
using TrustBankApp_Core.Interfaces;

namespace TrustBank.BusinessLogic
{
    public class BankAccountService : IBankAccountService
    {
        public IRepository _repository;
        public IRepository repository
        {
            get => _repository ??= new repository.Repository();
        }

        public async Task<bool> CreateBankAccount(BankAccount bankAccount)
        {
            return await repository.CreateBankAccount(bankAccount);
        }

        public async Task<BankAccount>? GetBankAccountByCustomerId(int id)
        {
            return await repository.GetBankAccountByCustomerId(id);
        }
        
        public async Task<List<BankAccount>>? GetAllAccountsByCustomerId(int customerId)
        {
            return await repository.GetAllBankAccountsByCustomerId(customerId);
        }

        public async Task<BankAccount>? GetBankAccountsByAccountNumber(string accountNumber)
        {
            return await repository.GetBankAccountsByAccountNumber(accountNumber);
        }

        public async Task CheckBalance(string accountNumber)
        {
            BankAccount? Account =  await GetBankAccountsByAccountNumber(accountNumber);
            Console.WriteLine("Your Account balance is {0:N}.", Account.AccountBalance);
        }

        public async Task<bool> Deposit(decimal amount, BankAccount bankAccount, string note)
        {
            await repository.UpdateDeposit(bankAccount, amount);
            BankTransaction bankTransaction = new BankTransaction(bankAccount.Id, amount, DateTime.Now, note, bankAccount.AccountBalance);
            await repository.CreateTransaction(bankTransaction);
            return bankTransaction != null;
        }

        public async Task<bool> Withdraw(decimal amount, BankAccount bankAccount, string note)
        {
            await repository.UpdateWithdraw(bankAccount,amount);
            BankTransaction bankTransaction = new BankTransaction(bankAccount.Id, amount, DateTime.Now, note, bankAccount.AccountBalance);
            await repository.CreateTransaction(bankTransaction);
            return bankTransaction != null;
        }

        public async Task<bool> Transfer(decimal amount, BankAccount bankAccount, string note, string DestinationAccount)
        {
            await repository.UpdateWithdraw(bankAccount,amount);
            BankTransaction bankTransaction = new BankTransaction(bankAccount.Id, amount, DateTime.Now, note, bankAccount.AccountBalance);
            repository.CreateTransaction(bankTransaction);

            BankAccount receivingAccount = await repository.GetBankAccountsByAccountNumber(DestinationAccount);
            await repository.UpdateDeposit(receivingAccount,amount);
            BankTransaction ReceivingBankTransaction = new BankTransaction(receivingAccount.Id, amount, DateTime.Now, note, receivingAccount.AccountBalance);
            await repository.CreateTransaction(ReceivingBankTransaction);


            return bankTransaction != null;
        }
    }
}

