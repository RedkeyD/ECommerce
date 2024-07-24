using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure( EntityTypeBuilder<Review> builder )
        {
            builder.ToTable( "review" );

            builder.HasKey( r => r.Id );
            builder.HasAlternateKey( r => r.PublicId );

            builder.Property( r => r.Id ).HasColumnName( "id" ).IsRequired();
            builder.Property( r => r.PublicId ).HasColumnName( "public_id" ).IsRequired();
            builder.Property( r => r.ProductId ).HasColumnName( "product_id" ).IsRequired();
            builder.Property( r => r.UserId ).HasColumnName( "user_id" ).IsRequired();
            builder.Property( r => r.Rating ).HasColumnName( "rating" ).IsRequired();
            builder.Property( r => r.Comment ).HasColumnName( "comment" ).HasMaxLength( 1500 ).IsRequired();
            builder.Property( r => r.ReviewDate ).HasColumnName( "review_date" ).IsRequired();

            builder
                .HasOne( r => r.Product )
                .WithMany( p => p.Reviews );

            builder
                .HasOne( r => r.User )
                .WithMany();
        }
    }
}