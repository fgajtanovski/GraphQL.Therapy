using System.Collections.Generic;

namespace GraphQL.Therapy.Core.Models
{
    public class Reader : User
    {
        public List<Post> FavoritePosts { get; set; }
        public List<Author> Following { get; set; }
    }
}
