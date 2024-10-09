namespace CleanArchitectureGraphQl.Doamin.Entities;
public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PublishedOn { get; set; }
    public string Publisher { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public bool SoftDeleted { get; set; }
    public BookPriceOffer Promotion { get; set; }
    public ICollection<Author> Authors { get; set; }
}
