using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrustBank.Models;
using TrustBankCore.Helpers;

namespace TrustBank.Tests
{
    public class ValidationTests
    {
        private readonly ReadWriteToJson jsonFile;
        private readonly Validate validate;
        private readonly Utilities utility;
        public ValidationTests()
        {
            jsonFile = new ReadWriteToJson();
            validate = new Validate();
            utility = new Utilities();
        }
        [Fact]
        public void ValidateName()
        {
            //Arrange
            var expected = validate.IsValidName("Precious");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public void ValidateMail()
        {
            //Arrange
            var expected = validate.IsValidMail("Precious@gmail.com");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public void ValidatePassword()
        {
            //Arrange
            var expected = validate.IsValidPassword("Precious22!");
            //Assert
            Assert.True(expected);
        }
        [Fact]
        public void PasswordHash()
        {
            //Arrange
            string HashPassword = "e8b75477eb7c7be448992063950ad227bde731c869534a9a4522dbcd27f1e98f";
            string actual = utility.computeSha256Hash("Precious22!");
            //Assert
            Assert.Equal(HashPassword, actual);
        }
    }
}
