using System.Collections.Generic;
using System.Threading.Tasks;
using BookManager.Application.DTO.Response;

namespace BookManager.Application.Service.Interface
{
    public interface IAuthorService
    {
        Task <AuthorDto> GetAuthorById(int id);
        Task <AuthorDto> GetAuthorByName(string name);
        Task <List<AuthorDto>> GetAllAuthors();
        Task<AuthorDto> CreateAuthor(AuthorDto author);
        Task<AuthorDto> UpdateAuthor(AuthorDto author);
        Task<AuthorDto> DeleteAuthor(int id);
    }
}