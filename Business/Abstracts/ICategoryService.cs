using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        public void Create(Category category);
        public List<Category> GetAll();
        public void Update(Category category);
        public void Delete(Category category);
    }
}
