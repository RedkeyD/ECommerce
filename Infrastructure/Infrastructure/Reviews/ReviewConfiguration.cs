using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(r => r.Id);
            builder.HasAlternateKey(r => r.PublicId);

            builder.Property( r => r.ProductId ).HasColumnName( nameof( Review.ProductId ) ).IsRequired();
            builder.Property( r => r.UserId ).HasColumnName( nameof( Review.UserId ) ).IsRequired();
            builder.Property( r => r.Rating ).HasColumnName( nameof( Review.Rating ) ).IsRequired();
            builder.Property( r => r.Comment ).HasColumnName( nameof( Review.ProductId ) ).HasMaxLength(1500).IsRequired();
            builder.Property( r => r.ReviewDate ).HasColumnName( nameof( Review.ReviewDate ) ).IsRequired();

            builder
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews);

            builder
                .HasOne(r => r.User)
                .WithMany();

        }
    }
}