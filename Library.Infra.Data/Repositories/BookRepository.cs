using Library.Domain.Entities;
using Library.Domain.Interfaces.Repositories;
using System.Linq;
using System.Collections.Generic;

namespace Library.Infra.Data.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public IEnumerable<Book> findByTitle(string title)
        {
            return Db.Books.Where(b => b.Title == title);
        }
    }
}
