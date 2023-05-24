using EcommerceDosGuri.Application.UseCase.UseCase.Customers.DeleteCustomers;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.DeleteProducts
{
    public interface IDeleteProductInterector
    {
        Task ExecuteAsync(DeleteCustomerPortIn dataPortIn);
    }
}
