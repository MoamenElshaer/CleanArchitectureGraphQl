using CleanArchitectureGraphQl.Doamin.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CleanArchitectureGraphQl.Persistance.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(t => t.Price).IsRequired();

        builder.Property(t => t.Title).HasMaxLength(200).IsRequired();

        builder.HasOne(e => e.Promotion).WithOne(ed => ed.Book).HasForeignKey<BookPriceOffer>(ed => ed.BookId);
    }
}
