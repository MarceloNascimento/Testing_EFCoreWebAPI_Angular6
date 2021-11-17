using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPhoneNumberTypeFacade
    {
        Task<PhoneNumberTypeResponse> FindAllAsync();
        Task<PhoneNumberTypeResponse> FindByIdAsync(int id);
    }
}