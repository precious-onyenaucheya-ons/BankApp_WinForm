using Newtonsoft.Json;
using TrustBankCore.Interfaces;

namespace TrustBankCore.Helpers
{
    public class ReadWriteToJson : IReadWriteToJson
    {
        public static string parentPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

        public static string filePath = Path.Combine(parentPath,  @"Database\");

        //public static string filePath = @"C:\Users\hp\Desktop\WEEK 4 WinForm- Submitted\TrustBankApp_UI\Database\";
        
        public async Task<bool> WriteJson<T>(T model, string jsonitem)
        {
            try
            {
                string json = JsonConvert.SerializeObject(model) + Environment.NewLine;
                await File.AppendAllTextAsync(filePath + jsonitem, json);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        public async Task<List<T>> ReadJson<T>(string jsonitem)
        {
            var readText = await File.ReadAllTextAsync(filePath + jsonitem);
            var objects = new List<T>();
            var serializer = new JsonSerializer();  

            using (var stringReader = new StringReader(readText))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;
                while (jsonReader.Read())
                {
                    T? json = serializer.Deserialize<T>(jsonReader);
                    objects.Add(json);
                }
            }
            return objects;
        }

        public async Task<bool> UpdateJson<T>(List<T> models, string fileName)
        {

            try
            {
                string json = "";
                string jsonPath = filePath + fileName;
                foreach (T model in models)
                {
                    json += JsonConvert.SerializeObject(model) + Environment.NewLine;
                }
                await File.WriteAllTextAsync(jsonPath, json);
                return true;
            }
            catch (Exception)
            {
                throw;
            }

        }
       
        }
    }
