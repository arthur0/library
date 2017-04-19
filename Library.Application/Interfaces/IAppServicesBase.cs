using System.Collections.Generic;

namespace Library.Application.Interfaces
{
    public interface IAppServicesBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetByID(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
    }
}
