using CleanArchitectureGraphQl.Appplication.Book.Commands.CreateBook.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureGraphQl.Appplication.Book.Commands.CreateBook
{
    public class CreateBookCommand : IRequest<CreateBookCommandDto>
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool SoftDeleted { get; set; }
        public ICollection<AuthorDto> Authors { get; set; }
    }
}
