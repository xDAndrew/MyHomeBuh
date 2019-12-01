using AppSumm1._0.Interface;
using System.IO;
using Newtonsoft.Json;
using AppSumm1._0.Model;

namespace AppSumm1._0
{
    public class Repository : IRepository
    {
        private const string path = "test.json";

        public DbModel LoadHistory()
        {
            if (File.Exists(path))
            {
                return JsonConvert.DeserializeObject<DbModel>(File.ReadAllText(path));
            }
            else
            { 
                return new DbModel(); 
            }
        }

        public void SaveHistory(DbModel dbModel)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(dbModel));
        }
    }
}
