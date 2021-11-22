using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class PersonPhoneRepository : IPersonPhoneRepository
    {
        private readonly ExampleContext _context;

        public PersonPhoneRepository(ExampleContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<PersonPhone>> FindAllAsync()
        {
            var result = from person in _context.Set<Person>()
                         join phone in _context.Set<PersonPhone>()
                             on person.BusinessEntityID equals phone.BusinessEntityID
                         select new PersonPhone
                         {
                             BusinessEntityID = person.BusinessEntityID,
                             PhoneNumber = phone.PhoneNumber,
                             PhoneNumberType = phone.PhoneNumberType,
                             PhoneNumberTypeID = phone.PhoneNumberTypeID,
                             Person = new Person { BusinessEntityID = person.BusinessEntityID, Name = person.Name }
                         };

            return await Task.Run(() => result);

        }

        public async Task<PersonPhone> FindEntityAsync(int personId, string phoneNumber) => await _context.PersonPhone
             .Where(personPhone => personPhone.PhoneNumber == phoneNumber && personPhone.BusinessEntityID == personId)
                .Include(personPhone => personPhone.Person)
                .Include(personPhone => personPhone.PhoneNumberType)
                .FirstOrDefaultAsync();


        //TODO: It will be used for grid search bar
        public async Task<IEnumerable<PersonPhone>> FindByNameAsync(string name) => await _context.PersonPhone
                .Where(personPhone => personPhone.Person.Name.Contains(name))
                .Include(personPhone => personPhone.Person)
                .Include(personPhone => personPhone.PhoneNumberType)
                .ToListAsync();




        public async Task<PersonPhone> UpdateAsync(PersonPhone entity)
        {
            try
            {
                /*
                 * TODO: need to fix update here
                 * 
                 */ 

                _context.Database.OpenConnection();
                await _context.Database.BeginTransactionAsync();
                var person = entity.Person;
                var phoneNumberType = entity.PhoneNumberType;

                entity.PhoneNumberType = null;
                entity.Person = null;

                var result = await Task.Run(() => _context.PersonPhone.Update(entity).Entity);
                await Task.Run(() => _context.Entry<PersonPhone>(entity).State = EntityState.Modified);
                  
                await _context.SaveChangesAsync();
                _context.Database.CommitTransaction();

                _context.Database.CloseConnection();
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }


        public async Task<PersonPhone> InsertAsync(PersonPhone entity)
        {
            var result = (await _context.AddAsync<PersonPhone>(entity)).Entity;
            await _context.SaveChangesAsync();

            return result;
        }

    }
}
