

using CleanArchitectureGraphQl.Doamin.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitectureGraphQl.Persistance.Configuration;

public class BookPriceOfferConfiguration : IEntityTypeConfiguration<BookPriceOffer>
{
    public void Configure(EntityTypeBuilder<BookPriceOffer> builder)
    {
        builder.Property(t => t.NewPrice).IsRequired();

        builder.Property(t => t.PromotionalText).HasMaxLength(200).IsRequired();

    }
}
