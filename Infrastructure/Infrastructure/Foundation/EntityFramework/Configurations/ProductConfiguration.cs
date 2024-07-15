using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure( EntityTypeBuilder<Product> builder )
        {
            builder.HasKey( p => p.Id );

            builder
                .HasOne( p => p.Category )
                .WithMany( c => c.Products );

            builder
                .HasMany( p => p.Reviews )
                .WithOne( r => r.Product )
                .HasForeignKey( r => r.ProductId );

        }
    }
}