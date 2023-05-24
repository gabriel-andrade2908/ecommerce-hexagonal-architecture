using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.AddProducts
{
    public interface IAddCostumerInterector
    {
        Task<AddCustomerPortOut> ExecuteAsync(AddCustomerPortIn dataPortIn);
    }
}
