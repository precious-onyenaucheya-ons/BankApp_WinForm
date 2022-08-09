using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrustBank.BusinessLogic;
using TrustBank.Models;
using Moq;
using TrustBankCore.Interfaces;
using TrustBankApp_Core.Interfaces;

namespace TrustBank.Tests
{
    public class TransactionServiceTest
    {
        private Mock<IReadWriteToJson> dbFile;
        private Mock<IRepository> DataBase;
        private readonly TransactionService transactionService;
        BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
        BankAccount account = new BankAccount(1, "1003467589", AccountType.SavingsAccount);
        public TransactionServiceTest()
        {
            dbFile = new Mock<IReadWriteToJson>();
            DataBase = new Mock<IRepository>();
            transactionService = new TransactionService();
        }
        [Fact]
        public async void GetAllTransactionByAccountIdTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetAllTransactionByBankAccountId(account.Id)).ReturnsAsync(new List<BankTransaction> {transaction});
            transactionService._repository = DataBase.Object;
            var expected = await transactionService.GetAllTransactionByBankAccountId(transaction.Id);
            //Assert
            Assert.IsType<List<BankTransaction>>(expected);
        }
        [Fact]
        public async void CreateTransactionTest()
        {
            //Arrange
            DataBase.Setup(x => x.CreateTransaction(transaction)).ReturnsAsync(true);
            transactionService._repository = DataBase.Object;
            var expected = await transactionService.CreateTransaction(transaction);
            //Assert
            Assert.True(expected);
        }
    }
}
