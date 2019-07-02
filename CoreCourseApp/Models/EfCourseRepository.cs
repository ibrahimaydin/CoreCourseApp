using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class EfCourseRepository : ICourseRepository
    {
        private DataContext db;
        public EfCourseRepository(DataContext _db)
        {
            db = _db;

        }
        public IQueryable<Course> Courses => db.Courses; //Hazırda tutuyor database e gitmiyor.

        public int CreateCourse(Course newCourse)
        {
            db.Courses.Add(newCourse);
            db.SaveChanges();

            return newCourse.Id;
        }

        public void DeleteCourse(int courseid)
        {
            var entity = GetById(courseid);
            db.Courses.Remove(entity);
            if(entity.Instructor!=null)
            {
                db.Remove(entity.Instructor);
            }
            db.SaveChanges();
        }

        public Course GetById(int courseid)
        {
            return db.Courses
                .Include(x => x.Instructor)
                .ThenInclude(x => x.Contact)
                .ThenInclude(x => x.Address)
                .FirstOrDefault(x => x.Id == courseid);
        }

        public IEnumerable<Course> GetCourse()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCourseByActive(bool isActive)
        {
            return db.Courses.Where(x => x.isActive == isActive).ToList();
        }

        public IEnumerable<Course> GetCourseByFilters(string name = null, decimal? price = null, string isActive = null)
        {
            IQueryable<Course> query = db.Courses;

            if(name!=null)
            {
                query = query.Where(x => x.Name.ToLower().Contains(name.ToLower()));
            }
            if(price!=null)
            {
                query = query.Where(x => x.Price >= price);
            }
            if(isActive=="on")
            {
                query = query.Where(x => x.isActive == true);
            }


            return query.ToList();

        }

        public void UpdateCourse(Course updatedCourse, Course originalCourse = null)
        {
           if(originalCourse==null)
            {
                originalCourse = db.Courses.Find(updatedCourse.Id);
            }
            else
            {
                db.Courses.Attach(originalCourse);
            }
            originalCourse.Name = updatedCourse.Name;
            originalCourse.Price = updatedCourse.Price;
            originalCourse.isActive = updatedCourse.isActive;

            EntityEntry entry = db.Entry(originalCourse);
            Console.WriteLine($"Entry State : {entry.State}");
            foreach (var property in new string[] {"Name","Price","isActive"})
            {
                Console.WriteLine($"{property} - old :{entry.OriginalValues[property]} new :{entry.CurrentValues[property]}");
            }
            db.SaveChanges();   

        }
    }
}
