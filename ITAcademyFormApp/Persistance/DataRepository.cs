using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ITAcademyFormApp
{
    internal class DataRepository<T> : IRepository<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("db.Add");
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("db.GetAll");
            return Enumerable.Empty<T>();
        }

        public void Remove(T item)
        {
            Console.WriteLine("db.Remove");
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
