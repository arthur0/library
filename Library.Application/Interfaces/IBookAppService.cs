using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Application.Interfaces
{
    public interface IBookAppService : IAppServicesBase<Book>
    {
        IEnumerable<Book> GetByTitle(string title);
    }
}
