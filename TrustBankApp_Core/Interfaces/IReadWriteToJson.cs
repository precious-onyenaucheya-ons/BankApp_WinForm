namespace TrustBankCore.Interfaces
{
    public interface IReadWriteToJson
    {
        Task<List<T>> ReadJson<T>(string jsonitem);

        Task<bool> WriteJson<T>(T model, string jsonitem);

        Task<bool> UpdateJson<T>(List<T> models, string fileName);
    }
}