using GraphQL.Types;

namespace GraphQL.Therapy.Core.Models.Types
{
    public class UserInterface : InterfaceGraphType<User>
    {
        public UserInterface()
        {
            Name = "User";

            Field(x => x.Id).Description("This is the User ID");
            Field(x => x.Name, nullable: true).Description("Name of the User");
        }
    }
}
