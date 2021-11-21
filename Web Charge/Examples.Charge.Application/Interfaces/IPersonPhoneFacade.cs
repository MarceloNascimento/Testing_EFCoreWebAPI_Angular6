namespace Examples.Charge.Application.Interfaces
{
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;
    public interface IPersonPhoneFacade
    {
        Task<PersonPhoneResponse> FindAllAsync();
        Task<PersonPhoneResponse> FindEntityAsync(int personId, string phoneNumber);

    }
}