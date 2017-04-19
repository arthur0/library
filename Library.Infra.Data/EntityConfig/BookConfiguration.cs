using Library.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Library.Infra.Data.EntityConfig
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            HasKey(b => b.BookID);

            Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(250);

            HasRequired(b => b.Customer)
                .WithMany()
                .HasForeignKey(b => b.CustomerID);
        }
    }
}
