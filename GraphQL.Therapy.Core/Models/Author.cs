using System.Collections.Generic;

namespace GraphQL.Therapy.Core.Models
{
    public class Author:User
    {
        public List<Reader> Followers { get; set; }
        public List<Post> Posts { get; set; }
    }
}