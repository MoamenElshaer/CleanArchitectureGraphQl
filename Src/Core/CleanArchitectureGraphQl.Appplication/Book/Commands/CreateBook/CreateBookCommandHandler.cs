using CleanArchitectureGraphQl.Appplication.Book.Commands.CreateBook.Dtos;
using CleanArchitectureGraphQl.Infrastructure.AppDbContext;
using MediatR;


namespace CleanArchitectureGraphQl.Appplication.Book.Commands.CreateBook
{
    public class CreateBookCommandHandler(ApplicationDbContext _context) : IRequestHandler<CreateBookCommand, CreateBookCommandDto>
    {
        public async Task<CreateBookCommandDto> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var book = _context.Books.FirstOrDefault(s => s.Title.Trim().Equals(request.Title.Trim()));

            var bookEntity = new Doamin.Entities.Book()
            {
                Title = request.Title,
                BookId = request.BookId,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Price = request.Price,
                PublishedOn = request.PublishedOn,
                Publisher = request.Publisher,
                SoftDeleted = false
            };

            _context.Add(bookEntity);

            return new CreateBookCommandDto
            {
                IsCreated = _context.SaveChanges() > 0
            };
        }
    }
}
