using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Name = "Post";

            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Body);
            Field(x=>x.Author.Name).Name("Author");
            Field(x => x.DateCreated).Name("DateCreated");
        }
    }
}
