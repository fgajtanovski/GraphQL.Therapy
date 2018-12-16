using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models.Types
{
    public class ReaderType : ObjectGraphType<Reader>
    {
        public ReaderType()
        {
            Name = "Reader";
            Field(x => x.Id);
            Field(x => x.Name);
            //TODO: add two fields for favorite posts and authors following
        }
    }
}
