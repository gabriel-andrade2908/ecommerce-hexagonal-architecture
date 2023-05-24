using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceDosGuri.Application.UseCase.UseCase.Customers.GetAllCustomers
{
    public interface IGetAllCustomersInterector
    {
        Task<IReadOnlyCollection<GetAllCustomersPortOut>> ExecuteAsync();
    }
}
