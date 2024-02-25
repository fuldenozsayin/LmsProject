using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        public void Create(Course course);
        public List<Course> GetAll();
        public void Update(Course course);
        public void Delete(Course course);
    }
}
