using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrustBank.Models;
using TrustBank.repository;
using TrustBankCore.Interfaces;
using Moq;
using TrustBankApp_Core.Interfaces;

namespace TrustBank.Tests
{
    public class RepositoryTests
    {
        private Mock<IReadWriteToJson> dbFile;
        private readonly Repository repo;
        BankAccount account = new BankAccount(1, "1003467589", AccountType.SavingsAccount);
        CustomerAccount customer = new CustomerAccount("Precious Uche", "precious@gmail.com", "Precious22!");
        BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
        public RepositoryTests()
        {
            repo = new Repository();
            dbFile = new Mock<IReadWriteToJson>();
        }

        [Fact]
        public async void CreateCustomerTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>("Customer.json")).ReturnsAsync(new List<CustomerAccount> { customer });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.CreateCustomer(customer);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetCustomerByIDTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>("Customer.json")).ReturnsAsync(new List<CustomerAccount> { customer });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetCustomerById(1);
            //Assert
            Assert.IsType<CustomerAccount>(expected);
        }
        [Fact]
        public async void RemoveCustomerByIDTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>("Customer.json")).ReturnsAsync(new List<CustomerAccount> { customer });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.RemoveCustomerByID(1);
            //Assert
            Assert.True(expected);
        }

        [Fact]
        public async void CheckCustomerByEmailTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>("Customer.json")).ReturnsAsync(new List<CustomerAccount> { customer });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.CheckCustomerByEmail("precious@gmail.com");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetCustomerByEmailTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>("Customer.json")).ReturnsAsync(new List<CustomerAccount> { customer });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetCustomerByEmail("precious@gmail.com");
            //Assert
            Assert.NotNull(expected);
            Assert.IsType<CustomerAccount>(expected);
        }
        [Fact]
        public async void CreateBankAccountTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankAccount>("Account.json")).ReturnsAsync(new List<BankAccount> { account });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.CreateBankAccount(account);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void UpdateDepositTest()
        {
            //Arrange
            dbFile.Setup(x => x.UpdateJson<BankAccount>( new List<BankAccount> {account},"Account.json")).ReturnsAsync(true);
            repo._dBConnect = dbFile.Object;
            var expected = await repo.UpdateDeposit(account, 5000);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void UpdateWithdrawTest()
        {
            //Arrange
            dbFile.Setup(x => x.UpdateJson<BankAccount>(new List<BankAccount> { account }, "Account.json")).ReturnsAsync(true);

            repo._dBConnect = dbFile.Object;
            var expected = await repo.UpdateWithdraw(account, 5000);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetbankAccountByCustomerIdTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankAccount>("Account.json")).ReturnsAsync(new List<BankAccount> { account });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetBankAccountByCustomerId(1);
            //Assert
            Assert.IsType<BankAccount>(expected);
        }
        [Fact]
        public async void GetbankAccountsByAccountNumberTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankAccount>("Account.json")).ReturnsAsync(new List<BankAccount> { account });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetBankAccountsByAccountNumber("1003467589");
            //Assert
            Assert.IsType<BankAccount>(expected);
        }
        [Fact]
        public async void GetAllbankAccountByCustomerIdTest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankAccount>("Account.json")).ReturnsAsync(new List<BankAccount> { account });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetAllBankAccountsByCustomerId(1);
            //Assert
            Assert.IsType<List<BankAccount>>(expected);
        }
        [Fact]
        public async void GetAllTransactionByAccountIdTest()
        {
            //Act
            BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankTransaction>("Transaction.json")).ReturnsAsync(new List<BankTransaction> { transaction });
            repo._dBConnect = dbFile.Object;
            var expected = await repo.GetAllTransactionByBankAccountId(transaction.Id);
            //Assert
            Assert.IsType<List<BankTransaction>>(expected);
        }
        [Fact]
        public async void CreateTransactionTest()
        {
            //Act
            BankTransaction transaction = new BankTransaction(1, 10000, DateTime.Now, "Transaction Done", 25000);
            //Arrange
            dbFile.Setup(x => x.ReadJson<BankTransaction>("Transaction.json")).ReturnsAsync(new List<BankTransaction> { transaction});
            repo._dBConnect = dbFile.Object;
            var expected = await repo.CreateTransaction(transaction);
            //Assert
            Assert.True(expected);
        }
    }
}
