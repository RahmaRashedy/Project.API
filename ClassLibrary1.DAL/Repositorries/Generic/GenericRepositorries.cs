using ClassLibrary1.DAL.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAL.Repositorries.Generic
{
    public class GenericRepositorries<TEntity> : IGenericRepositorries<TEntity> where TEntity : class
    {
        protected readonly ProjectContext _context;
        public GenericRepositorries(ProjectContext context) {
             _context=context;
                }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public TEntity? GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
             _context.Set<TEntity>().Update(entity);

        }
    }
}
