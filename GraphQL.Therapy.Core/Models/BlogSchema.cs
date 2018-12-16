using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models
{
    public class BlogSchema : Schema
    {
        public BlogSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<BlogQuery>();
        }
    }
}
