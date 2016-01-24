using AutoMapper;

namespace DomainDrivenDesign.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(mapp =>
            {
                mapp.AddProfile<DomainToViewModelMappingProfile>();
                mapp.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}
