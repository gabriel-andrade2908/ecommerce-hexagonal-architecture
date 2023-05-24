using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.UpdateCustomers
{
    public interface IUpdateCustomerInterector
    {
        Task ExecuteAsync(UpdateCustomerPortIn dataPortIn);
    }
}
