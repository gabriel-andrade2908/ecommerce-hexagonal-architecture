using System;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Products.GetProductById
{
    public interface IGetProductByIdInterector
    {
        Task<GetProductByIdPortOut> ExecuteAsync(Guid id);
    }
}
