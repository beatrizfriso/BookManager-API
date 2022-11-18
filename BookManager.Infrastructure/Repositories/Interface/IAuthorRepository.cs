using System.Collections.Generic;
using System.Threading.Tasks;
using BookManager.Application.DTO.Response;

namespace BookManager.Infrastructure.Repositories.Interface
{
    public interface IAuthorRepository
    {
        Task <AuthorDto> GetAuthorByName(string name);
        Task <List<AuthorDto>> GetAllAuthors();
        Task<AuthorDto> CreateAuthor(AuthorDto author);
        Task<AuthorDto> UpdateAuthor(AuthorDto author);
        Task<AuthorDto> DeleteAuthor(int id);
    }
}