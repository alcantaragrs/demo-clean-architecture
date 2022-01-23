using System.Collections.Generic;
using System.Threading.Tasks;
using demo_clean_arc.Domain.Entities;
using demo_clean_arc.Domain.Interfaces;
using demo_clean_arc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace demo_clean_arc.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Add(T item)
        {
            _context.Set<T>().Add(item);
            return item;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Update(T item)
        {
            throw new System.NotImplementedException();
        }
    }
}
