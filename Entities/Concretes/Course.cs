using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

       
        public virtual Instructor Instructor1 { get; set; }

        public Category Category { get; set; }
    }
}
