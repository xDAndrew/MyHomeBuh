using AppSumm1._0.Interface;
using System.IO;
using Newtonsoft.Json;
using AppSumm1._0.Models;
using System.Collections.Generic;

namespace AppSumm1._0
{
    public class Repository : IRepository
    {
        private const string path = "test.json";
        private const string pathDb = "categories.json";

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
        public void SaveCategories(List<Category> category)
        {
            File.WriteAllText(pathDb, JsonConvert.SerializeObject(category));
            
        }
        public IEnumerable<Category> LoadCategories()
        {
            if (File.Exists(pathDb))
            {
                return JsonConvert.DeserializeObject<IEnumerable<Category>>(File.ReadAllText(pathDb));
            }
            else
            {
                return new List<Category>();
            }
        }
    }
}
