using System;

namespace Library.Domain.Entities
{
    public class Book 
    {
        public int BookID { get; set; }

        public string Title { get; set; }

        public bool Active { get; set; }

        public DateTime RegistrationDate { get; set; }

        public int CustomerID { get; set; }

        public virtual Customer Customer { get; set; }

    }
}
