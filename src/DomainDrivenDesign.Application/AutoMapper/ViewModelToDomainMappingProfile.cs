using AutoMapper;
using DomainDrivenDesign.Application.ViewModels;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Application.AutoMapper
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<SecurityViewModel, Security>();
        }   
    }
}
