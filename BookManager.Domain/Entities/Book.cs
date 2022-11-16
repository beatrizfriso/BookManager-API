using System;
using BookManager.Domain.Entities.Base;

namespace BookManager.Domain.Entities
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Isbn { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
        public DateTime PublishDate { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        
        //acrescentar aqui uma lista de atributos para estudar as relações many-to-many no banco (dica do Matheus)
    }
}