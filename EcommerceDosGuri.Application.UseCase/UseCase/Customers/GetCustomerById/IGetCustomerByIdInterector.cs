using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetCustomerById
{
    public interface IGetCustomerByIdInterector
    {
        Task<GetCustomerByIdPortOut> ExecuteAsync(GetCustomerByIdPortIn dataPortIn);
    }
}
