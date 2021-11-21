using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => (await _personPhoneRepository.FindAllAsync());


        public async Task<PersonPhone> FindEntityAsync(int personId, string phoneNumber) => (await _personPhoneRepository.FindEntityAsync(personId, phoneNumber));

       
    }
}
