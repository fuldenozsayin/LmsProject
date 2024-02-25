using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        public void Create(Instructor instructor);
        public List<Instructor> GetAll();
        public void Update(Instructor instructor);
        public void Delete(Instructor instructor);
    }
}
