using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPersonPhoneRepository
    {
        Task<IEnumerable<PersonAggregate.PersonPhone>> FindAllAsync();

        Task<PersonAggregate.PersonPhone> FindEntityAsync(int personId, string phoneNumber);

        Task<PersonAggregate.PersonPhone> UpdateAsync(PersonPhone entity);
    }
}
