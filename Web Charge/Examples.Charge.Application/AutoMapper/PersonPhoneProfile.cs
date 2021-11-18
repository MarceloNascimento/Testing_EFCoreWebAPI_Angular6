namespace Examples.Charge.Application.AutoMapper
{
    using AutoMapper;
    using Examples.Charge.Application.Dtos;
    using Examples.Charge.Domain.Aggregates.PersonAggregate;
    using global::AutoMapper;

    public class PersonPhoneProfile : Profile
    {
        public PersonPhoneProfile()
        {
            CreateMap<PersonPhone, PersonPhoneDto>()
               .ReverseMap()
               .ForMember(dest => dest.BusinessEntityID,opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))
               .ForMember(dest => dest.PhoneNumberTypeID, opt => opt.MapFrom(src => src.PhoneNumberTypeID))
               .ForPath(dest => dest.PhoneNumberType.Name, opt => opt.MapFrom(src => src.PhoneNumberTypeName)
               );
        }
    }
}
