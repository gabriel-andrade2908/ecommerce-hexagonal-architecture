using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Products
{
    internal class OrderRepository : BaseRepository<Product>, IProductRepository
    {
        internal OrderRepository(AppDb db) : base(db)
        {
        }
    }
}
