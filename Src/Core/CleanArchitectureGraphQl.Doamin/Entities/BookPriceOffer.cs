

namespace CleanArchitectureGraphQl.Doamin.Entities;

public class BookPriceOffer
{
    public int BookPriceOfferId { get; set; }
    public decimal NewPrice { get; set; }
    public string PromotionalText { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}
