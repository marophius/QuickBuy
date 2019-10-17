using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Dominio.Interfaces;

namespace QuickBuy.Repositorio.Repos
{
    public class BaseRepos<TEntity> : IBaseRepos<TEntity> where TEntity : class
    {
        public BaseRepos()
        {

        }
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
