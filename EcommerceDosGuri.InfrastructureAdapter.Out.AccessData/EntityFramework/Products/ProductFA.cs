using EcommerceDosGuri.Application.DomainModel.Catalog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Products
{
    public class ProductFA : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name).HasMaxLength(100).IsRequired();
            builder.Property(product => product.Value).IsRequired();
        }
    }
}
