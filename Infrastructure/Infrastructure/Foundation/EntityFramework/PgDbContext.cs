using Domain.Entities;
using Infrastructure.CartItems;
using Infrastructure.Carts;
using Infrastructure.Categories;
using Infrastructure.OrderItems;
using Infrastructure.Orders;
using Infrastructure.Products;
using Infrastructure.Reviews;
using Infrastructure.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Foundation.EntityFramework
{
    public class PgDbContext : DbContext
    {
        public PgDbContext( DbContextOptions<PgDbContext> options ) : base( options )
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration( new UserConfiguration() );
            modelBuilder.ApplyConfiguration( new CartConfiguration() );
            modelBuilder.ApplyConfiguration( new CartItemConfiguration() );
            modelBuilder.ApplyConfiguration( new OrderConfiguration() );
            modelBuilder.ApplyConfiguration( new OrderItemConfiguration() );
            modelBuilder.ApplyConfiguration( new ProductConfiguration() );
            modelBuilder.ApplyConfiguration( new CategoryConfiguration() );
            modelBuilder.ApplyConfiguration( new ReviewConfiguration() );

            base.OnModelCreating( modelBuilder );
        }
    }
}