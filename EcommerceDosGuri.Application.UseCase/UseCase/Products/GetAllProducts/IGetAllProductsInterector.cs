using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetAllProducts
{
    public interface IGetAllProductsInterector
    {
        Task<IReadOnlyCollection<GetAllProductsPortOut>> ExecuteAsync();
    }
}
