using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("category");

            builder.HasKey(c => c.Id);
            builder.HasAlternateKey(c => c.PublicId);

            builder.Property(c => c.Id).HasColumnName("id").IsRequired();
            builder.Property(c => c.PublicId).HasColumnName("public_id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("name").HasMaxLength(50).IsRequired();
            builder.Property(c => c.Description).HasColumnName("description").HasMaxLength(1500);

            builder
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}