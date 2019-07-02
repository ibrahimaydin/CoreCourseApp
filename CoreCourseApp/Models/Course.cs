using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool isActive { get; set; }

        public int? InstructorId { get; set; }

        public Instructor Instructor { get; set; }
    }
}
