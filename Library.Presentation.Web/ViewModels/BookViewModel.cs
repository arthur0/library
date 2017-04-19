using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Presentation.Web.ViewModels
{
    public class BookViewModel
    {
        [Key]
        public int BookID { get; set; }

        [Required(ErrorMessage = "Fill the title field")]
        [MaxLength(250, ErrorMessage = "Max {0} chars")]
        [MinLength(2, ErrorMessage = "Min {0} chars")]
        public string Title { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        public bool Active { get; set; }

        public int CustomerID { get; set; }

        public virtual CustomerViewModel Customer { get; set; }

    }
}