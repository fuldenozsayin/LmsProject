using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        public void Create(Instructor instructor);
        public List<Instructor> GetAll();
        public void Update(Instructor instructor);
        public void Delete(Instructor instructor);


    }
}
