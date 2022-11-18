using System;
using BookManager.Domain.Entities;

namespace BookManager.Application.DTO.Response
{
    public class BookDto
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
    }
}