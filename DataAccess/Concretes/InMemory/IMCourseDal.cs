using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

// public olunca projeler arasında ulaım oluyor ama internal olursa sadece proje içinde oluyor. private olursa sadece class içinde erişiliri dosyalar arasında vs. erişilmez
namespace DataAccess.Concretes.InMemory
{
    public class IMCourseDal : ICourseDal
    {
        List<Course> courses;
        public IMCourseDal()
        {
            //veritabanımızı simüle etmek için liste oluşturacağız. Ama ef de çalışıyor olsaydık zaten veritabanımız olacağı için simüle etmemize gerek yoktu :)
            courses = new List<Course> { new Course { Id = 1, Name = "C#", Description = "EFMEKMERM", Instructor1=new Instructor{Id=1,Name="Fulden"},Category=new Category{Id=1,Name="Programming"} },
            new Course { Id = 2, Name = "C++", Description = "EFMEKMERgergergM",Instructor1=new Instructor{Id=2,Name="Fulden2"},Category=new Category{Id=2,Name="Programming2"}},
            new Course { Id = 3, Name = "Java", Description = "EeokrgepkrgpkregRM",Instructor1=new Instructor{Id=3,Name="Fulden3"},Category=new Category{Id=3,Name="Programming3"}}};
        }
        public void Create(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            foreach (var course1 in courses)
            {
                if (course.Id==course1.Id)
                {
                    courses.Remove(course1);
                }
            }
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Update(Course course)
        {
            foreach (var course1 in courses)
            {
                if (course.Id == course1.Id)
                {
                    course1.Name = course.Name;
                    course1.Description = course.Description;
                    course1.Instructor1 = course.Instructor1;
                    course1.Category = course.Category;
                }
            }
        }
        
    }
}
