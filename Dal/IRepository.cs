using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal interface IRepository<T>
    {
        T Get(int id);
        List<T> GetAll();   
        T Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
