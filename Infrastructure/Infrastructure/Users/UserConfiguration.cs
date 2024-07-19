using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Users
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure( EntityTypeBuilder<User> builder )
        {
            builder.HasKey( u => u.Id );
            builder.HasAlternateKey( u => u.PublicId );

            builder.Property( u => u.Id ).HasColumnName( "id" ).IsRequired();
            builder.Property( u => u.PublicId ).HasColumnName( "public_id" ).IsRequired();
            builder.Property( u => u.Username ).HasColumnName( "username" ).HasMaxLength( 20 ).IsRequired();
            builder.Property( u => u.Email ).HasColumnName( "email" ).HasMaxLength( 50 ).IsRequired();
            builder.Property( u => u.PasswordHash ).HasColumnName( "passsword_hash" ).HasMaxLength( 50 ).IsRequired();

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