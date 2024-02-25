using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class IMInstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public IMInstructorDal()
        {
            instructors = new List<Instructor>();

        }
        public void Create(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            foreach (var item in instructors)
            {
                if (item.Id == instructor.Id)
                {
                    instructors.Remove(item);
                }
            }
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public void Update(Instructor instructor)
        {
            foreach (var item in instructors)
            {
                if (item.Id == instructor.Id)
                {
                    item.Name = instructor.Name;
                }
            }
        }
    }
}
