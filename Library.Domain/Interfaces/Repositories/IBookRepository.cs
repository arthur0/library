using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Interfaces.Repositories
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IEnumerable<Book> findByTitle(string title);

    }
}
