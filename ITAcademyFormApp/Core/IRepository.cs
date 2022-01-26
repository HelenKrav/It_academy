using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ITAcademyFormApp
{
    internal interface IRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Remove(T item);
        IEnumerable<T> GetAll(); 
    }
}
