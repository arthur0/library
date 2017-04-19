using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Library.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }


        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }


        public TEntity GetByID(int id)
        {
            return _repository.GetByID(id);
        }


        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }


        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }


        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
