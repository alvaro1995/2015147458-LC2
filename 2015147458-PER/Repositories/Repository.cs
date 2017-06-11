using _2015147458_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace _2015147458_PER.Repositories
{
    public class Repository<TEntities> : IRepository<TEntities> where TEntities : class
    {
        protected readonly DbContext _Context;

        public Repository(DbContext context)
        {
            _Context = context;
        }

        public void Delete(TEntities entity)
        {
            _Context.Set<TEntities>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<TEntities> entities)
        {
            _Context.Set<TEntities>().RemoveRange(entities);
        }

        public TEntities Get(int? id)
        {
            return _Context.Set<TEntities>().Find(id);
        }

        public IEnumerable<TEntities> GetAll()
        {
            return _Context.Set<TEntities>().ToList();
        }

        public IEnumerable<TEntities> Find(Expression<Func<TEntities, bool>> predicate)
        {
            return _Context.Set<TEntities>().Where(predicate);
        }

        public void Add(TEntities entity)
        {
            _Context.Set<TEntities>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntities> entities)
        {
            _Context.Set<TEntities>().AddRange(entities);
        }
    }
}
