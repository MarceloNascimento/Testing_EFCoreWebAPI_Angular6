namespace Examples.Charge.Application.AutoMapper
{
    using AutoMapper;
    using Examples.Charge.Application.Dtos;
    using Examples.Charge.Domain.Aggregates.PersonAggregate;
    using global::AutoMapper;

    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>()
               .ForMember(dest => dest.Id,opt => opt.MapFrom(src => src.BusinessEntityID))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)
               ).ReverseMap();
        }
    }
}
