using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Configurations;
using WebAPI.Core.Enum;
using WebAPI.Core.Models;

namespace WebAPI.Core.Connection
{
    public class ShopDbContext : IdentityDbContext<UserApplication, RoleApplication, int>
    {
        #region properties
        public DbSet<Boutique> Boutiques { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<RoleApplication> RoleApplications { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<UserApplication> UserApplications { get; set; }
        #endregion properties

        #region construcor
        public ShopDbContext(DbContextOptions options) : base(options)
        {

        }
        #endregion construcor

        #region method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Identity configure
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());

            //configure table name and Key
            builder.Entity<IdentityUserClaim<int>>().ToTable("UserClaims");
            builder.Entity<IdentityUserRole<int>>().ToTable("UserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<int>>().ToTable("UserLogins").HasKey(x => x.UserId);
            builder.Entity<IdentityRoleClaim<int>>().ToTable("RoleClaims");
            builder.Entity<IdentityUserToken<int>>().ToTable("UserTokens").HasKey(x => x.UserId);
            #endregion Identity configure

            builder.Entity<Product>()
                .HasKey(p => p.ProductId);

            //configure relationship many to many
            builder.Entity<ProductStock>()
                .HasKey(ps => new { ps.StockId, ps.ProductId });
            builder.Entity<ProductStock>()
                .HasOne(ps => ps.Product)
                .WithMany(p => p.ProductStocks);
            builder.Entity<OrderProduct>()
                .HasKey(od => new { od.OrderId, od.ProductId });
            builder.Entity<OrderProduct>()
                .HasOne(ps => ps.Order)
                .WithMany(p => p.OrderProducts);
            builder.Entity<ColorProduct>()
                .HasKey(cp => new { cp.ColorId, cp.ProductId });
            builder.Entity<ColorProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.ColorProducts);
            builder.Entity<CartProduct>()
                .HasKey(cp => new { cp.CartId, cp.ProductId });
            builder.Entity<CartProduct>()
                .HasOne(cp => cp.Product)
                .WithMany(p => p.CartProducts);

            this.SeedData(builder);
        }

        /// <summary>
        /// Init data
        /// </summary>
        /// <param name="builder"></param>
        protected void SeedData(ModelBuilder builder)
        {
            builder.Entity<RoleApplication>().HasData(
                 new RoleApplication
                 {
                     Id = 1,
                     Name = "Admin",
                     NormalizedName = "ADMIN",
                     Description = "Description admin"
                 },
                 new RoleApplication
                 {
                     Id = 2,
                     Name = "User",
                     NormalizedName = "TEACHER",
                     Description = "Description user"
                 }
            );

            var hasher = new PasswordHasher<UserApplication>();
            builder.Entity<UserApplication>().HasData(
                 new UserApplication
                 {
                     Id = 1,
                     UserName = "hl.4bros",
                     Email = "hl.4bros@gmail.com",
                     NormalizedEmail = "HL.4BROS@GMAIL.COM",
                     PhoneNumber = "0337578949",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     FirstName = "Hieu Linh",
                     LastName = "Lam",
                     Title = Title.Mrs,
                     Avatar = "avatar.png"
                 }
            );
        }
        #endregion method
    }
}
