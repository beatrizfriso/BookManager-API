using System.Collections.Generic;
using BookManager.Domain.Entities.Base;

namespace BookManager.Domain.Entities
{
    public class Genre : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}