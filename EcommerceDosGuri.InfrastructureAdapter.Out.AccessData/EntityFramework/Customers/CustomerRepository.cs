using EcommerceDosGuri.Application.DomainModel.Administration;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Customers
{
    internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppDb db) : base(db)
        {
        }
    }
}
