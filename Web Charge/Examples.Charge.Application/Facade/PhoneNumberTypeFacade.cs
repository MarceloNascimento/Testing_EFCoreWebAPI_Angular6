using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PhoneNumberTypeFacade : IPhoneNumberTypeFacade
    {
        private readonly IPhoneNumberTypeService _phoneNumberTypeService;
        private readonly IMapper _mapper;

        public PhoneNumberTypeFacade(IPhoneNumberTypeService phoneNumberTypeServiceService, IMapper mapper)
        {
            _phoneNumberTypeService = phoneNumberTypeServiceService;
            _mapper = mapper;
        }

        public async Task<PhoneNumberTypeResponse> FindAllAsync()
        {
            var result = await _phoneNumberTypeService.FindAllAsync();
            var response = new ExampleListResponse();
            response.ExampleObjects = new List<PersonPhoneDto>();
            response.ExampleObjects.AddRange(result.Select(x => _mapper.Map<ExampleDto>(x)));
            return response;
        }

        public async Task<PhoneNumberTypeResponse> FindAllAsync()
        {
            var result = await _phoneNumberTypeService.FindAllAsync();
            var response = new PhoneNumberTypeResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDto>();
            response.PersonPhoneObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }

        public async Task<PhoneNumberTypeResponse> FindByIdAsync(int id)
        {
            var entity = await _phoneNumberTypeService.FindByIdAsync(id);
            var entityDto = _mapper.Map<PersonDto>(entity);
            var response = new PersonResponse(); //TODO: Should be resolving DI for these line


            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.Add(entityDto);


            return response;
        }

    }
}
