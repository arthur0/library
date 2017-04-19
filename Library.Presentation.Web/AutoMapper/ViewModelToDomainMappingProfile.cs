using AutoMapper;
using Library.Domain.Entities;
using Library.Presentation.Web.ViewModels;

namespace Library.Presentation.Web.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            CreateMap<BookViewModel, Book>();
            CreateMap<CustomerViewModel, Customer>();
        }
    }
}