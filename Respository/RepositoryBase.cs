using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Respository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public RepositoryContext RespositoryContext { get; set; }
        public RepositoryBase(RepositoryContext respositoryContext)
        {
            RespositoryContext = respositoryContext;
        }

        public IQueryable<T> FindAll()
        {
            return RespositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return RespositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            RespositoryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            RespositoryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            RespositoryContext.Set<T>().Remove(entity);
        }
    }
}
