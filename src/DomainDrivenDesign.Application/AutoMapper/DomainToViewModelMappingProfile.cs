using AutoMapper;
using DomainDrivenDesign.Application.ViewModels;
using DomainDrivenDesign.Domain.Entities;

namespace DomainDrivenDesign.Application.AutoMapper
{
    internal class DomainToViewModelMappingProfile: Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Security, SecurityViewModel>();
        }
    }
}
