using Newtonsoft.Json.Linq;

namespace GraphQL.Therapy.Models
{
    public class GraphQLQuery
    {
        public string Query { get; set; }
        public JObject Variables { get; set; }
    }
}
