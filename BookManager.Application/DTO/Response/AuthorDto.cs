using System;
using System.Collections.Generic;

namespace BookManager.Application.DTO.Response
{
    public class AuthorDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public string Biography { get; set; }
    }
}