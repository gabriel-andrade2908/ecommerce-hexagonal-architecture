using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.AddCustomers
{
    public interface IAddCostumerInterector
    {
        Task<AddCustomerPortOut> ExecuteAsync(AddCustomerPortIn dataPortIn);
    }
}
