﻿using Library.Domain.Entities;
using System.Collections.Generic;

namespace Library.Domain.Interfaces.Services
{
    public interface IBookService : IServiceBase<Book>
    {
        IEnumerable<Book> GetByTitle(string title);
    }
}
