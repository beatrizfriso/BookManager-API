using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookManager.Domain.Entities;

namespace BookManager.Application.Service.Interface
{
    public interface IGenreService
    {
        Task<Genre> CreateGenre(Genre genre);
        Task<Genre> Update(Genre genre);
        Task<Genre> GetGenreById(Guid id);
        Task<IEnumerable<Genre>> GetAllGenres();
        Task DeleteGenre(Guid id);
        
    }
}