using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonPhoneFacade
    {
        Task<PersonResponse> FindAllAsync();
        Task<PersonResponse> FindByIdAsync(int id);

    }
}