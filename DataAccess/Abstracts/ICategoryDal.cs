using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        public void Create(Category category);
        public List<Category> GetAll();
        public void Update(Category category);
        public void Delete(Category category);
    }
}
