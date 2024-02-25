using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        Course course = new Course
        {
            Id = 4,
            Name = "Python",
            Description = "nwıfejnfjenr",
            Instructor1 = new Instructor { Id = 4, Name = "Fulden4" },
            Category = new Category { Id = 4, Name = "Software" }
        };
        

        CourseManager courseManager = new CourseManager(new IMCourseDal());
        foreach (var item in courseManager.GetAll())
        {
            Console.WriteLine(item.Name+" "+item.Category.Name+" "+item.Instructor1.Name);


        }
        Console.WriteLine();
        courseManager.Create(course);
        foreach (var item in courseManager.GetAll())
        {
            Console.WriteLine(item.Name + " " + item.Category.Name + " " + item.Instructor1.Name);
        }




        Console.WriteLine("\ndeneme");
        Category category = new Category
        {
            Id = 5,
            Name = "hardware"
        };
 
        CategoryManager categoryManager=new CategoryManager(new IMCategoryDal());
        categoryManager.Create(category);

        foreach (var item in categoryManager.GetAll())
        {
            Console.WriteLine(item.Id + " " + item.Name);
        }

       



        Console.WriteLine("\ndeneme2");
        Instructor instructor = new Instructor
        {
            Id = 5,
            Name = "Fulden5"
        };
    
        InstructorManager instructorManager = new InstructorManager(new IMInstructorDal());
        instructorManager.Create(instructor);

        foreach(var item in instructorManager.GetAll())
        {
            Console.WriteLine(item.Id + " " + item.Name);
        }
        
    }
}