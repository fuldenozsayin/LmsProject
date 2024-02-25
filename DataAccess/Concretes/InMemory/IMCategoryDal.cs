using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class IMCategoryDal : ICategoryDal
    {
        List<Category> categories;
        public IMCategoryDal()
        {
            categories = new List<Category>();
        }
        public void Create(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            foreach (var item in categories)
            {
                if (item.Id == category.Id)
                {
                    categories.Remove(category);
                }
            }
            
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public void Update(Category category)
        {
            foreach (var item in categories)
            {
                if (item.Id == category.Id)
                {
                    item.Name= category.Name;
                }
            }
        }
    }
}
