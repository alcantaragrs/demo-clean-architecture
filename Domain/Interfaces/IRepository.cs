
using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;

namespace demo_clean_arc.Domain.Interfaces {
    public interface IRepository<T> where T : class
    {
       IEnumerable<T> GetAll();
       T GetById(int id);
       T Add(T item);
       T Update(T item);
       void Delete(int id);
    }
}
