namespace Examples.Charge.Application.Interfaces
{
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;
    public interface IPhoneNumberTypeFacade
    {  
        Task<PhoneNumberTypeResponse> FindByIdAsync(int id);
    }
}