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
    public class BankServiceTest
    {
        private Mock<IReadWriteToJson> dbFile;
        private Mock<IRepository> DataBase;
        private readonly BankAccountService bankAccountService;
        CustomerAccount customer = new CustomerAccount("Precious Uche", "Precious22!", "precious@gmail.com");
        BankAccount DestinationAccount = new BankAccount(2, "1573466789", AccountType.CurrentAccount);
        BankAccount account = new BankAccount(1, "1003467589", AccountType.SavingsAccount);
        public BankServiceTest()
        {
            dbFile = new Mock<IReadWriteToJson>();
            DataBase = new Mock<IRepository>();
            bankAccountService = new BankAccountService();
        }
        [Fact]
        public async void CreateBankAccountTest()
        {
            // Arrange
            DataBase.Setup(x => x.CreateBankAccount(account)).ReturnsAsync(true);
            bankAccountService._repository = DataBase.Object;
            var expected = await bankAccountService.CreateBankAccount(account);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetbankAccountByCustomerIdTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetBankAccountByCustomerId(account.CustomerId)).ReturnsAsync(account);
            bankAccountService._repository = DataBase.Object;
            var expected = await bankAccountService.GetBankAccountByCustomerId(account.CustomerId);
            //Assert
            Assert.IsType<BankAccount>(expected);
        }
        [Fact]
        public async void GetbankAccountsByAccountNumberTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetBankAccountsByAccountNumber(account.AccountNumber)).ReturnsAsync(account);
            bankAccountService._repository = DataBase.Object;
            //Act
            var expected = await bankAccountService.GetBankAccountsByAccountNumber(account.AccountNumber);
            //Assert
            Assert.IsType<BankAccount>(expected);
        }
        [Fact]
        public async void GetAllbankAccountByCustomerIdTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetAllBankAccountsByCustomerId(account.CustomerId)).ReturnsAsync(new List<BankAccount>() { account });
            bankAccountService._repository = DataBase.Object;
            var expected = await bankAccountService.GetAllAccountsByCustomerId(account.CustomerId);
            //assert
            Assert.IsType<List<BankAccount>>(expected);
        }
        [Fact]
        public async void DepositTest()
        {
            //Arrange
            BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
            DataBase.Setup(x => x.CreateTransaction(transaction)).ReturnsAsync(true);
            //Act
            bankAccountService._repository = DataBase.Object;
            var expected = await bankAccountService.Deposit(5000, account, "Deposit");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void WithdrawTest()
        {
            //Arrange
            BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
            DataBase.Setup(x => x.CreateTransaction(transaction)).ReturnsAsync(true);
            bankAccountService._repository = DataBase.Object;
            var expected = await bankAccountService.Withdraw(5000, account, "Withdraw");
            //Assert
            Assert.True(expected);
        }
    }
}
