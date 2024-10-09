using CleanArchitectureGraphQl.Appplication.Common.GraphQl.Types;
using CleanArchitectureGraphQl.Infrastructure.AppDbContext;
using GraphQL;
using GraphQL.Types;


namespace CleanArchitectureGraphQl.Appplication.Common.GraphQl.Queries
{
    public class BookQuery : ObjectGraphType
    {
        public BookQuery(ApplicationDbContext _data)
        {
            Field<ListGraphType<BookType>>("books", "Returning All Books", resolve: context => _data.Books.ToList());
            Field<BookType>("book",
                "Returning Single Books"
                ,new QueryArguments( new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id For Book" })
                , resolve: context => _data.Books.FirstOrDefault(i=>i.BookId == context.GetArgument("id",int.MinValue)));
        }
    }
}
