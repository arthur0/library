using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Interfaces.Services
{
    public interface IBookService : IBaseService<Book>
    {
        IEnumerable<Book> findByTitle(string title);
    }
}
