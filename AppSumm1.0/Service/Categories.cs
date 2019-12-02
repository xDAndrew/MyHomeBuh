using AppSumm1._0.Interface;
using AppSumm1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSumm1._0.Service
{
    public class Categories : ICategorie
    {
        private List<Categorie> categories;
        public List<Categorie> GetCategories()
        {
            return categories;
        }
        public void SetCategories(Categorie categorie)
        {
            categories.Add(new Categorie()
            {
                CategorieName = categorie.CategorieName
            });
        }
    }
}
