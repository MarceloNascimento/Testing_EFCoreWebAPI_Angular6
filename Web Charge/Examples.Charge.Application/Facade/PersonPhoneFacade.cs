

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

        public PersonPhoneFacade(IPersonPhoneService personPhoneService, IMapper mapper)
        {
            _personPhoneService = personPhoneService;
            _mapper = mapper;
        }

        public async Task<PersonResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new PersonResponse();
            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }

        public async Task<PersonResponse> FindByIdAsync(int id)
        {
            var entity = await _personPhoneService.FindByIdAsync(id);
            var entityDto = _mapper.Map<PersonDto>(entity);
            var response = new PersonResponse(); //TODO: Should be resolving DI for these line


            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.Add(entityDto);


            return response;
        }

    }
}
