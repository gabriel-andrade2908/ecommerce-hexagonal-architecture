using EcommerceDosGuri.Application.DomainModel.Payment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Orders
{
    public class OrderFA : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.ProductId);
            builder.Property(product => product.CustomerId);
            builder.Property(product => product.ProductQuantity).IsRequired();
            builder.Property(product => product.TotalValue).IsRequired();

            builder.HasOne(x => x.Product)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Customer)
                   .WithMany(x => x.Orders)
                   .HasForeignKey(x => x.CustomerId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
