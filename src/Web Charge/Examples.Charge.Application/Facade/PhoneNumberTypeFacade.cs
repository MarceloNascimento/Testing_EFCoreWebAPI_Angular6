

namespace Examples.Charge.Application.Facade
{
    using AutoMapper;
    using Examples.Charge.Application.Dtos;
    using Examples.Charge.Application.Interfaces;
    using Examples.Charge.Application.Messages.Response;
    using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
    using global::AutoMapper;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class PhoneNumberTypeFacade : IPhoneNumberTypeFacade
    {
        private readonly IPhoneNumberTypeService _phoneNumberTypeService;
        private readonly IMapper _mapper;

        public PhoneNumberTypeFacade(IPhoneNumberTypeService phoneNumberTypeServiceService, IMapper mapper)
        {
            _phoneNumberTypeService = phoneNumberTypeServiceService;
            _mapper = mapper;
        }


        public async Task<PhoneNumberTypeResponse> FindByIdAsync(int id)
        {
            var result = await _phoneNumberTypeService.FindByIdAsync(id);
            var resultDto = _mapper.Map<PersonPhoneDto>(result);

            var response = new PhoneNumberTypeResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDto>();
            response.PersonPhoneObjects.Add(resultDto);

            return response;
        }

    

    }
}
