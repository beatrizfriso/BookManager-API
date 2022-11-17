using System.Threading.Tasks;
using AutoMapper;
using BookManager.Application.DTO.Response;
using BookManager.Application.Service.Interface;

namespace BookManager.Application.Service
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorsRepository _repo;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorsRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        
        public async Task <AuthorDto> GetAuthorById(int id)
        {
            var author = await _repo.GetAuthorById(id);
            return _mapper.Map<AuthorDto>(author);
        }
    }
}