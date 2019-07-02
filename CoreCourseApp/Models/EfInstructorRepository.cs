using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class EfInstructorRepository : IInstructorRepository
    {
        private DataContext db;
        public EfInstructorRepository(DataContext _db)
        {
            db = _db;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Instructor Get(int id)
        {
            return db.Instructors.Find(id);
        }

        public IEnumerable<Instructor> GetAll()
        {
            return db.Instructors;
        }

        public void Insert(Instructor entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Instructor entity)
        {
            throw new NotImplementedException();
        }
    }
}
