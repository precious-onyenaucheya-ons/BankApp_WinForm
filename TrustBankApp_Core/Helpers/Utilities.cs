using System.Security.Cryptography;
using System.Text;
using TrustBankCore.Interfaces;

namespace TrustBankCore.Helpers
{
    public class Utilities : IUtilities
    {
        public string computeSha256Hash(string item)
        {
            using (var sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(item));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }
    }
}
