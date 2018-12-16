using GraphQL.Therapy.Core.Models.Types;
using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models
{
    public class BlogQuery : ObjectGraphType<object>
    {
        public BlogQuery(BlogData data)
        {
            Name = "Query";

            Field<AuthorType>(
                "author",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id of the author" }
                ),
                resolve: context => data.GetAuthorByIdAsync(context.GetArgument<int>("id"))
            );

            Field<ReaderType>(
                "reader",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "id of the reader" }
                ),
                resolve: context => data.GetReaderByIdAsync(context.GetArgument<int>("id"))
            );
        }
    }
}
