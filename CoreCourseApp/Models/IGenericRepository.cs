using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourseApp.Models
{
    public interface IGenericRepository<Tentity> where Tentity:class 
    {
        Tentity Get(int id);
        IEnumerable<Tentity> GetAll();
        void Delete(int id);
        void Update(Tentity entity);
        void Insert(Tentity entity);

    }
}
