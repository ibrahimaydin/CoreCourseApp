using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class SeedDatabase
    {
     public static void Seed(DbContext context)
        {
            if (!context.Database.GetPendingMigrations().Any())
            {
                if(context is DataContext)
                {
                    DataContext _context = context as DataContext;
                    if(!_context.Instructors.Any())
                    {
                        _context.Instructors.AddRange(Instructors);
                    }
                    if(!_context.Courses.Any())
                    {
                        _context.Courses.AddRange(Courses);
                    }
                }
            }
            context.SaveChanges();
        }

        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                {
                    new Course() {Name="Html",Price=100,isActive=true,Instructor=Instructors[0]},
                    new Course() {Name="Css",Price=200,isActive=true,Instructor=Instructors[1]},
                    new Course() {Name="Javascript",Price=300,isActive=true,Instructor=Instructors[2]},
                    new Course() {Name="Nodels",Price=400,isActive=true,Instructor=Instructors[3]},
                };

                return courses;

            }
        }

        private static Instructor[] Instructors =
        {
            new Instructor(){Name="İbrahim",Contact=new Contact(){Email="ibrahim@gmail.com",Phone="232131",Address=new Address{City="Konya",Country="T.C",Text="Esenler"}}},
            new Instructor(){Name="Alper",Contact=new Contact(){Email="alper@gmail.com",Phone="232454",Address=new Address{City="Kayseri",Country="T.C",Text="Davutpaşa"}}},
            new Instructor(){Name="Ali",Contact=new Contact(){Email="ali@gmail.com",Phone="232890",Address=new Address{City="Hatay",Country="T.C",Text="Kadıköy"}}},
            new Instructor(){Name="Emin",Contact=new Contact(){Email="emin@gmail.com",Phone="23490",Address=new Address{City="Ardahan",Country="T.C",Text="Merkez"}}},
        };
    }
}
