using AutoMapper;
using Acme.BookStore.Books;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
         CreateMap<Book, BookDto>();
         CreateMap<CreateUpdateBookDto, Book>();
    }
}
