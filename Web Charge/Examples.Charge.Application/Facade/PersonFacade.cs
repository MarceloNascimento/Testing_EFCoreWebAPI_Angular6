

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
    public class PersonFacade : IPersonFacade
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonFacade(IPersonService service, IMapper mapper)
        {
            this._personService = service;
            _mapper = mapper;
        }

        public async Task<PersonResponse> FindAllAsync()
        {
            var result = await _personService.FindAllAsync();
            var response = new PersonResponse();
            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }

        public async Task<PersonResponse> FindByIdAsync(int id)
        {
            var entity = await _personService.FindByIdAsync(id);
            var entityDto = _mapper.Map<PersonDto>(entity);
            var response = new PersonResponse(); //TODO: Should be resolving DI for these line


            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.Add(entityDto);


            return response;
        }

    }
}
