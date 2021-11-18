using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PhoneNumberTypeRepository : IPhoneNumberTypeRepository
    {
        private readonly ExampleContext _context;

        public PhoneNumberTypeRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PhoneNumberType>> FindAllAsync() => await Task.Run(() => _context.PhoneNumberType);

        public async Task<PhoneNumberType> FindByIdAsync(int id) => await _context.PhoneNumberType.FindAsync(id);

        public async Task<PhoneNumberType> FindByNameAsync(string name) => await _context.PhoneNumberType.FindAsync(name);

        public async Task<PhoneNumberType> UpdateAsync(PhoneNumberType entity)
        {
            var result = (await _context.PhoneNumberType.AddAsync(entity)).Entity;
            _ = await _context.SaveChangesAsync();

            return result;
        }
    }
}
