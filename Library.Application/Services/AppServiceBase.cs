using Library.Application.Interfaces;
using Library.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Library.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServicesBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }


        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }


        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }


        public TEntity GetByID(int id)
        {
            return _serviceBase.GetByID(id);
        }


        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }


        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
