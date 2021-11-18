using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    public interface IPhoneNumberTypeRepository
    {
        Task<IEnumerable<PersonAggregate.PhoneNumberType>> FindAllAsync();


        Task<PersonAggregate.PhoneNumberType> FindByIdAsync(int id);

        Task<PersonAggregate.PhoneNumberType> FindByNameAsync(string name);

        Task<PersonAggregate.PhoneNumberType> UpdateAsync(PhoneNumberType entity);
    }
}
