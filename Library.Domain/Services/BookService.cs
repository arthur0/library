﻿using System.Collections.Generic;
using Library.Domain.Entities;
using Library.Domain.Interfaces.Repositories;
using Library.Domain.Interfaces.Services;

namespace Library.Domain.Services
{
    public class BookService : ServiceBase<Book>, IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            return _repository.findByTitle(title);
        }
    }
}
