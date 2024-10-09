using CleanArchitectureGraphQl.Doamin.Entities;
using GraphQL.Types;


namespace CleanArchitectureGraphQl.Appplication.Common.GraphQl.Types
{
    public class BookType : ObjectGraphType<Doamin.Entities.Book>
    {
        public BookType()
        {
            Field(i => i.BookId, type: typeof(IdGraphType)).Description("Id Property For Book Object");
            Field(i => i.Price, type: typeof(DecimalGraphType)).Description("Price Property For Book Object");
            Field(i => i.Title, type: typeof(StringGraphType)).Description("Title Property For Book Object");
            Field(i => i.Description, type: typeof(StringGraphType)).Description("Description Property For Book Object");
            Field(i => i.ImageUrl, type: typeof(StringGraphType)).Description("ImageUrl Property For Book Object");
        }
    }
}
