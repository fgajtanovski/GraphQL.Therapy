using GraphQL.Therapy.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Therapy.Core
{
    public class BlogData
    {
        private readonly List<Author> authors = new List<Author>();
        private readonly List<Reader> readers = new List<Reader>();

        public BlogData()
        {
            Post post = new Post()
            {
                Id = 1,
                Title = "Where does a thought go when it's forgotten?",
                Body = "This questions most of the time results in generating more questions so it serves as question factory..."
            };

            Reader reader = new Reader()
            {
                Id = 2,
                Name = "Lydia"
            };

            authors.Add(new Author
            {
                Id = 1,
                Name = "Filip",
                Posts = new List<Post>()
                {
                    post
                },
                Followers = new List<Reader>()
                {
                    reader
                }

            });
        }

        public Task<Author> GetAuthorByIdAsync(int id)
        {
            return Task.FromResult(authors.FirstOrDefault(x => x.Id == id));
        }

        public Task<List<Reader>> GetFollowersByAuthorsIdAsync(int id)
        //public string NamedQuery { get; set; }
        {
            return Task.FromResult(
                authors
                .Where(x => x.Id == id)
                .FirstOrDefault()
                .Followers
                );
        }

        public Task<Reader> GetReaderByIdAsync(int id)
        {
            return Task.FromResult(
                readers
                .FirstOrDefault(x => x.Id == id)
                );
        }

        public Task<List<Post>> GetPostsByAuthorIdAsync(int id)
        {
            return Task.FromResult(
                authors
                .FirstOrDefault(x => x.Id == id)
                .Posts);
        }
    }
}
