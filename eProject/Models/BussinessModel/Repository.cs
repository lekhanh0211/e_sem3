using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace eProject.Models.BussinessModel
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Check(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(object id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(object id)
        {
            throw new NotImplementedException();
        }
    }
}