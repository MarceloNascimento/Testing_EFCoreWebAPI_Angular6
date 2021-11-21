

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
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personPhoneService;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService service, IMapper mapper)
        {
            _personPhoneService = service;
            _mapper = mapper;
        }

        public async Task<PersonPhoneResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonPhoneResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDto>();          
            var range = _mapper.Map<List<PersonPhoneDto>>(result);
            response.PersonPhoneObjects.AddRange(range);
            return response;
        }

        public async Task<PersonPhoneResponse> FindEntityAsync(int personId, string phoneNumber)
        {
            var entity = await _personPhoneService.FindEntityAsync(personId, phoneNumber);
            var entityDto = _mapper.Map<PersonPhoneDto>(entity);
            var response = new PersonPhoneResponse(); //TODO: Should be resolving DI for these line

            response.PersonPhoneObjects = new List<PersonPhoneDto>();
            response.PersonPhoneObjects.Add(entityDto);


            return response;
        }
             
    }
}
