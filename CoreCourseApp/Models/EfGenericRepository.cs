using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public class EfGenericRepository<Tentity> : IGenericRepository<Tentity> where Tentity : class
    {
        private DataContext db;
        public EfGenericRepository(DataContext _db)
        {
            db = _db;
        }
        public virtual void Delete(int id)
        {
            db.Remove<Tentity>(Get(id));
            db.SaveChanges();
        }

        public virtual Tentity Get(int id)
        {
            return db.Set<Tentity>().Find(id);
        }

        public virtual IEnumerable<Tentity> GetAll()
        {
            return db.Set<Tentity>();
        }

        public virtual void Insert(Tentity entity)
        {
            db.Add<Tentity>(entity);
            db.SaveChanges();
        }

        public virtual void Update(Tentity entity)
        {
            db.Update<Tentity>(entity);
            db.SaveChanges();
        }
    }
}
