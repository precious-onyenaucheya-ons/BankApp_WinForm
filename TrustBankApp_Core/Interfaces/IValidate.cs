namespace TrustBankCore.Interfaces
{
    public interface IValidate
    {
        bool IsValidName(string item);


        bool IsValidMail(string item);


        bool IsValidPassword(string item);
       
    }
}
