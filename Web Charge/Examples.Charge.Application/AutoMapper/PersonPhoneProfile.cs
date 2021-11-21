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

              .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BusinessEntityID))
              .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.PhoneNumber))

              .ForMember(dest => dest.PhoneNumberTypeID, opt => opt.MapFrom(src => src.PhoneNumberTypeID))
              .ForPath(dest => dest.PhoneNumberTypeName, opt => opt.MapFrom(src => src.PhoneNumberType.Name))

              .ForPath(dest => dest.PersonID, opt => opt.MapFrom(src => src.Person.BusinessEntityID))
              .ForPath(dest => dest.PersonName, opt => opt.MapFrom(src => src.Person.Name)

              ).ReverseMap();
        }
    }
}
