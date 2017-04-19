using System;
using System.Collections.Generic;
using Library.Application.Interfaces;
using Library.Domain.Entities;
using Library.Domain.Interfaces.Services;

namespace Library.Application.Services
{
    public class BookAppService : AppServiceBase<Book>, IBookAppService
    {
        private IBookService _bookService;

        public BookAppService(IBookService bookService) 
            : base(bookService)
        {
            _bookService = bookService;
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
           return  _bookService.GetByTitle(title);
        }
    }
}
