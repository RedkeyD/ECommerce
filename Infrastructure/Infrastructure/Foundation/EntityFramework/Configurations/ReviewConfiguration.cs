using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure( EntityTypeBuilder<Review> builder )
        {
            builder.HasKey( r => r.Id );

            builder
                .HasOne( r => r.Product )
                .WithMany( p => p.Reviews );

            builder
                .HasOne( r => r.User )
                .WithMany();

        }
    }
}