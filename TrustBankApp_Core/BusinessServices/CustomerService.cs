using TrustBank.Models;
using TrustBankApp_Core.Interfaces;
using TrustBankCore.Helpers;
using TrustBankCore.Interfaces;

namespace TrustBank.BusinessLogic
{
    public class CustomerService : ICustomerService
    {

        public  IReadWriteToJson _databaseItem;

        public  IReadWriteToJson databaseItem
        {
            get => _databaseItem ??= new ReadWriteToJson();
        }

        private static IUtilities _utilities;

        public static IUtilities utilities
        {
            get => _utilities ??= new Utilities();
        }

        public  string CustomerFile = "Customer.json";

        public async Task<bool> Register(CustomerAccount customer)
        {
            try
            {
                return await databaseItem.WriteJson<CustomerAccount>(customer, CustomerFile);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<CustomerAccount> Login(string email, string password)
        {
            string hashPassword = utilities.computeSha256Hash(password);
            var customers = await databaseItem.ReadJson<CustomerAccount>(CustomerFile);

            foreach (var item in customers)
            {
                if (item.EmailAddress == email && item.Password == hashPassword)
                {
                    return item;
                }
            } 
            return null;
        }

        public IRepository _repository;

        public IRepository repository
        {
            get => _repository ??= new repository.Repository();
        }

        public async Task<bool> CreateCustomer(CustomerAccount customer)
        {
            try
            {
                bool isSuccessful = await repository.CreateCustomer(customer);
                return isSuccessful;
            }
            catch
            {
                throw;
            }
            
        }

        public async Task<bool> CheckCustomerByEmail(string email)
        {
            return await repository.CheckCustomerByEmail(email);

        }

        public async Task<CustomerAccount>? GetCustomerByEmail(string email)
        {
            return await repository.GetCustomerByEmail(email);
        }

        public async Task<CustomerAccount> GetCustomerById(int id)
        {
            return await repository.GetCustomerById(id);
        }
    }
}
