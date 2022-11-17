using AutoMapper;
using BookManager.Application.DTO.Response;
using BookManager.Domain.Entities;

namespace BookManager.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
        }
    }
}
