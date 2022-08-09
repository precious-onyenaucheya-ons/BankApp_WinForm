using TrustBank.Models;
using TrustBankApp_Core.Interfaces;
using TrustBankCore.Helpers;
using TrustBankCore.Interfaces;

namespace TrustBank.repository
{
    public class Repository : IRepository
    {
        public IReadWriteToJson _dBConnect;
        public IReadWriteToJson dbConnect
        {
            get => _dBConnect ??= new ReadWriteToJson();
        }

        private static List<CustomerAccount> customerDB = new List<CustomerAccount>();
        private static List<BankAccount> bankAccountsDB = new List<BankAccount>();
        private static List<BankTransaction> transactionDB = new List<BankTransaction>();

        public async Task<bool> CreateCustomer(CustomerAccount customer)
        {
            try
            {
                if (customerDB.Count == 0)
                {
                    await dbConnect.WriteJson<CustomerAccount>(customer, "Customer.json");
                    customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                }
                else
                {
                    customer.Id = customerDB[customerDB.Count - 1].Id + 1;
                    await dbConnect.WriteJson<CustomerAccount>(customer, "Customer.json");
                    customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                }

                return customerDB.Any(x => x.EmailAddress == customer.EmailAddress);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<CustomerAccount> GetCustomerById(int customerId)
        {
            try
            {
                customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                return customerDB.FirstOrDefault(x => x.Id == customerId);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> RemoveCustomerByID(int customerId)
        {
            try
            {
                customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                CustomerAccount customer = await GetCustomerById(customerId);
                return customerDB.Remove(customer);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> CheckCustomerByEmail(string email)
        {
            try
            {
                customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                bool result = customerDB.Any(x => x.EmailAddress == email);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CustomerAccount> GetCustomerByEmail(string email)
        {
            try
            {
                customerDB = await dbConnect.ReadJson<CustomerAccount>("Customer.json");
                CustomerAccount? customer = customerDB.FirstOrDefault(x => x.EmailAddress == email);
                return customer;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> CreateBankAccount(BankAccount account)
        {
            try
            {
                if(bankAccountsDB.Count == 0)
                {
                    await dbConnect.WriteJson<BankAccount>(account, "Account.json");
                    bankAccountsDB = await dbConnect.ReadJson<BankAccount>("Account.json");
                }
                else 
                {
                    account.Id = bankAccountsDB[bankAccountsDB.Count - 1].Id + 1;
                    await dbConnect.WriteJson<BankAccount>(account, "Account.json");
                    bankAccountsDB = await dbConnect.ReadJson<BankAccount>("Account.json");
                }
                return bankAccountsDB.Contains(account);
            }
            catch (Exception)
            {
                throw;
                //Console.WriteLine(ex.StackTrace); 
            }
        }

        public async Task<bool> UpdateDeposit(BankAccount account, decimal amount)
        {

            try
            {
                if (bankAccountsDB.Contains(account))
                {
                    foreach (BankAccount bankAccount in bankAccountsDB)
                    {
                        if (bankAccount == account)
                        {
                            bankAccount.AccountBalance += amount;
                        }
                    }
                    await dbConnect.UpdateJson<BankAccount>(bankAccountsDB, "Account.json");
                }
                else
                {
                    bankAccountsDB.Add(account);
                    foreach (BankAccount bankAccount in bankAccountsDB)
                    {
                        if (bankAccount == account)
                        {
                            bankAccount.AccountBalance += amount;
                        }
                    }
                    await dbConnect.UpdateJson<BankAccount>(bankAccountsDB, "Account.json");
                };
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> UpdateWithdraw(BankAccount account, decimal amount)
        {

            try
            {
                if (bankAccountsDB.Contains(account))
                {
                    foreach (BankAccount bankAccount in bankAccountsDB)
                    {
                        if (bankAccount == account)
                        {
                            bankAccount.AccountBalance -= amount;
                        }
                    }
                    await dbConnect.UpdateJson<BankAccount>(bankAccountsDB, "Account.json");
                };
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BankAccount> GetBankAccountByCustomerId(int customerId)
        {
            bankAccountsDB = await dbConnect.ReadJson<BankAccount>("Account.json");
            return bankAccountsDB.FirstOrDefault(x => x.CustomerId == customerId);
        }

        public async Task<BankAccount> GetBankAccountsByAccountNumber(string accountNumber)
        {
            try
            {
                bankAccountsDB = await dbConnect.ReadJson<BankAccount>("Account.json");
                return bankAccountsDB.FirstOrDefault(x => x.AccountNumber == accountNumber);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<BankAccount>> GetAllBankAccountsByCustomerId(int customerId)
        {
            try
            {
                bankAccountsDB = await dbConnect.ReadJson<BankAccount>("Account.json");
                return bankAccountsDB.FindAll(x => x.CustomerId == customerId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<BankTransaction> GetTransactionId(int accountNo)
        {

            try
            {
                transactionDB = await dbConnect.ReadJson<BankTransaction>("Transaction.json");
                return transactionDB.FirstOrDefault(x => x.Id == accountNo);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<List<BankTransaction>> GetAllTransactionByBankAccountId(int accountId)
        {
            try
            {
                transactionDB = await dbConnect.ReadJson<BankTransaction>("Transaction.json");
                return transactionDB.FindAll(x => x.BankAccountId == accountId);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<bool> CreateTransaction(BankTransaction transaction)
        {
            try
            {
                if (transactionDB.Count == 0)
                {
                    await dbConnect.WriteJson<BankTransaction>(transaction, "Transaction.json");
                    transactionDB = await dbConnect.ReadJson<BankTransaction>("Transaction.json");
                }
                else
                {
                    transaction.Id = transactionDB[transactionDB.Count - 1].Id + 1;
                    await dbConnect.WriteJson<BankTransaction>(transaction, "Transaction.json");
                    transactionDB = await dbConnect.ReadJson<BankTransaction>("Transaction.json");
                }

                return transactionDB.Contains(transaction);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
