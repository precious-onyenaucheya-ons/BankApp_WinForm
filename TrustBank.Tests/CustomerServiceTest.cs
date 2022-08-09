using TrustBank.BusinessLogic;
using TrustBank.Models;
using TrustBankApp_Core.Interfaces;
using TrustBankCore.Interfaces;
using Moq;

namespace TrustBank.Tests
{
    public class CustomerServiceTest
    {
        private Mock<IReadWriteToJson> dbFile;
        private Mock<IRepository> DataBase;
        private CustomerService customerService;
        CustomerAccount customer = new CustomerAccount("Precious Uche", "precious@gmail.com", "Precious22!");
        CustomerAccount Hashcustomer = new CustomerAccount("Precious Uche", "precious@gmail.com", "e8b75477eb7c7be448992063950ad227bde731c869534a9a4522dbcd27f1e98f");
        public CustomerServiceTest()
        {
            dbFile = new Mock<IReadWriteToJson>();
            DataBase = new Mock<IRepository>();
            customerService = new CustomerService();
        }
        [Fact]
        public async void Registertest()
        {
            // Arrange
            dbFile.Setup(x => x.WriteJson<CustomerAccount>(customer,customerService.CustomerFile)).ReturnsAsync(true);
            customerService._databaseItem = dbFile.Object;
            //Act
            var expected = await customerService.Register(customer);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void Logintest()
        {
            //Arrange
            dbFile.Setup(x => x.ReadJson<CustomerAccount>(customerService.CustomerFile)).ReturnsAsync(new List<CustomerAccount> { Hashcustomer });
            customerService._databaseItem = dbFile.Object;
            var expected = await customerService.Login("precious@gmail.com", "Precious22!");
            //Assert
            Assert.IsType<CustomerAccount>(expected);
        }
        [Fact]
        public async void CreateCustomerTest()
        {
            //Arrange
            DataBase.Setup(x => x.CreateCustomer(customer)).ReturnsAsync(true);
            customerService._repository = DataBase.Object;
            var expected = await customerService.CreateCustomer(customer);
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetCustomerByIDTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetCustomerById(customer.Id)).ReturnsAsync(customer);
            customerService._repository = DataBase.Object;
            var expected = await customerService.GetCustomerById(1);
            //Assert
            Assert.IsType<CustomerAccount>(expected);
        }
        [Fact]
        public async void CheckCustomerByEmailTest()
        {
            //Arrange
            DataBase.Setup(x => x.CheckCustomerByEmail(customer.EmailAddress)).ReturnsAsync(true);
            customerService._repository = DataBase.Object;
            var expected = await customerService.CheckCustomerByEmail("precious@gmail.com");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public async void GetCustomerByEmailTest()
        {
            //Arrange
            DataBase.Setup(x => x.GetCustomerByEmail(customer.EmailAddress)).ReturnsAsync(customer);
            customerService._repository = DataBase.Object;
            var expected = await customerService.GetCustomerByEmail("precious@gmail.com");
            //Assert
            Assert.IsType<CustomerAccount>(expected);
        }
    }
}
