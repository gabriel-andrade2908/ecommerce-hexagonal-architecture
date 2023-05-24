using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers
{
    public interface IDeleteCustomerInterector
    {
        Task ExecuteAsync(DeleteCustomerPortIn dataPortIn);
    }
}
