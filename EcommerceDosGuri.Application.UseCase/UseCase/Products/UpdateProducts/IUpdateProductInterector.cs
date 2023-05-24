using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.UpdateProducts
{
    public interface IUpdateCustomerInterector
    {
        Task ExecuteAsync(UpdateCustomerPortIn dataPortIn);
    }
}
