using System;
using System.Collections.Generic;

namespace Library.Domain.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public bool Active { get; set; }

        public DateTime RegistrationDate { get; set; }

        public virtual IEnumerable<Book> Books { get; set; }


    }
}
