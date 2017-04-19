using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Presentation.Web.ViewModels
{
    public class CustomerViewModel
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Fill the name field")]
        [MaxLength(150, ErrorMessage = "Max {0} chars")]
        [MinLength(2, ErrorMessage = "Min {0} chars")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Fill the name field")]
        [MaxLength(100, ErrorMessage = "Max {0} chars")]
        [EmailAddress(ErrorMessage = "Fill with a valid e-mail")]
        public string Email { get; set; }

        public bool Active { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        public virtual IEnumerable<BookViewModel> Books { get; set; }

    }
}