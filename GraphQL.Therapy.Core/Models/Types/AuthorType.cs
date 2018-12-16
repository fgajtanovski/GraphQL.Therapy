using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType(BlogData data)
        {
            Name = "Author";
            Field(x => x.Id)
                .Description("Author Id");
            Field(x => x.Name)
                .Description("Author Name");
            Field<ListGraphType<PostType>>(name: "posts", resolve: context => data.GetFollowersByAuthorsIdAsync(context.Source.Id))
                .Description = "Author Blog Posts";
            Field<ListGraphType<ReaderType>>(name: "follower", resolve: context => data.GetFollowersByAuthorsIdAsync(context.Source.Id))
                .Description = "Author Followers";
        }
    }
}
