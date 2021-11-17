using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync() => await Task.Run(() => _context.PersonPhone);

        public async Task<PersonPhone> FindByIdAsync(int id) => await _context.PersonPhone.FindAsync(id);

        public async Task<PersonPhone> FindByNameAsync(string name) => await _context.PersonPhone.FindAsync(name);

        public PersonPhone UpdateAsybc(PersonPhone entity)
        {
            var result = _context.PersonPhone.Update(entity);

            return result.Entity;
        }

    }
}
