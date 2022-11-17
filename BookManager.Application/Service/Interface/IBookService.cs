using System.Collections.Generic;
using System.Threading.Tasks;
using BookManager.Application.DTO.Response;

namespace BookManager.Application.Service.Interface
{
    public interface IBookService
    {
        Task <BookDto> GetBookById(int id);
        Task <BookDto> GetBookByTitle(string title);
        Task <List<BookDto>> GetAllBooks();
        Task <BookDto> CreateBook(BookDto book);
        Task <BookDto> UpdateBook(BookDto book);
        Task <BookDto> DeleteBook(int id);
    }
}