using AppSumm1._0.Interface;
using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using AppSumm1._0.Model;

namespace AppSumm1._0
{
    public class Repository : IRepository
    {
        public DbModel LoadHistory()
        {
            if (File.Exists("test.json"))
            {
                return JsonConvert.DeserializeObject<DbModel>(File.ReadAllText("test.json"));
            }
            else { return new DbModel(); }
        }

        public void SaveHistory(DbModel dbModel)
        {
            File.WriteAllText("test.json", JsonConvert.SerializeObject(dbModel));
        }
    }
}
