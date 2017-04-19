using AutoMapper;
using Library.Domain.Entities;
using Library.Presentation.Web.ViewModels;

namespace Library.Presentation.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        public DomainToViewModelMappingProfile()
        {
            CreateMap<Book, BookViewModel>();
            CreateMap<Customer, CustomerViewModel>();
        }
    }
}