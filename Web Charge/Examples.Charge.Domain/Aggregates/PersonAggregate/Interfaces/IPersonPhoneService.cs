

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    public interface IPersonPhoneService
    {
        Task<IEnumerable<PersonPhone>> FindAllAsync();

        Task<PersonPhone> FindByIdAsync(int id);

    }
}
