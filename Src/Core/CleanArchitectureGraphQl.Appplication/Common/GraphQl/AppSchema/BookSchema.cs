using CleanArchitectureGraphQl.Appplication.Common.GraphQl.Queries;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureGraphQl.Appplication.Common.GraphQl.AppSchema
{
    public class BookSchema:Schema
    {
        public BookSchema(BookQuery query)
        {
            Query = query;
        }
    }
}
