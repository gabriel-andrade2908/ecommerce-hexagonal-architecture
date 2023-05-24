using EcommerceDosGuri.Application.DomainModel.Catalog;
using EcommerceDosGuri.Application.UseCase.Ports.Out;
using EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Contexts;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Products
{
    internal class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        internal ProductRepository(AppDb db) : base(db)
        {
        }
    }
}
