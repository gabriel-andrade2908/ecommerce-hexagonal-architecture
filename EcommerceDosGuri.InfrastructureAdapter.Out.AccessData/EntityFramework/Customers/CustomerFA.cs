using EcommerceDosGuri.Application.DomainModel.Administration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EcommerceDosGuri.InfrastructureAdapter.Out.AccessData.EntityFramework.Customers
{
    public class CustomerFA : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Name).HasMaxLength(100).IsRequired();
            builder.Property(customer => customer.Email).HasMaxLength(100).IsRequired();
            builder.Property(customer => customer.IsActive).IsRequired();
            builder.Property(customer => customer.CreationTime).IsRequired();
            builder.Property(customer => customer.PhoneNumber).HasMaxLength(11).IsRequired();
            builder.Property(customer => customer.Document).HasMaxLength(14).IsRequired();
            builder.Property(customer => customer.InativatedDate);
        }
    }
}
