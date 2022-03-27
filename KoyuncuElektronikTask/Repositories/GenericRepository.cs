using KoyuncuElektronikTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace KoyuncuElektronikTask.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        KoyuncuContext c = new KoyuncuContext();
        public List<T> ListData()
        {
            return c.Set<T>().ToList();
        }
        public void AddData(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();
        }
        public void DeleteT(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }
        public void UpdateT(T t)
        {
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
        public T GetT(int id)
        {
            return c.Set<T>().Find(id);

        }
    }
}
