using System;

namespace GraphQL.Therapy.Core.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
