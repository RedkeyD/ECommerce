using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Foundation.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure( EntityTypeBuilder<User> builder )
        {
            builder.HasKey( u => u.Id );

            builder.Property( u => u.Username ).HasMaxLength( 20 ).IsRequired();
            builder.Property( u => u.Email ).HasMaxLength( 50 ).IsRequired();
            builder.Property( u => u.PasswordHash ).HasMaxLength( 50 ).IsRequired();

            builder
                .HasOne( u => u.Cart )
                .WithOne( c => c.User )
                .HasForeignKey<Cart>( c => c.UserId );

            builder
                .HasMany( u => u.Orders )
                .WithOne( o => o.User )
                .HasForeignKey( o => o.UserId );
        }
    }
}