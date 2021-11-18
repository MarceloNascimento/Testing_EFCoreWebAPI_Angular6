namespace Examples.Charge.Application.Interfaces
{
    using Examples.Charge.Application.Messages.Response;
    using System.Threading.Tasks;
    public interface IPersonFacade
    {
        Task<PersonResponse> FindAllAsync();
        Task<PersonResponse> FindByIdAsync(int id);

    }
}