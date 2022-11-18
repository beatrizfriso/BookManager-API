using System;
using System.Collections.Generic;
using BookManager.Domain.Entities.Base;

namespace BookManager.Domain.Entities
{
    public class Author : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; }
    }
}