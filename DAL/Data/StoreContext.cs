using BLL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection;

namespace DAL.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // convert all values stored in decimal property to double type. Decimal datatype is 
            // not supported in sqlite
            //if (Database.ProviderName == "Microsoft.EntityFrameworkCore.SqlServer")
            //{
            //    foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            //    {
            //        var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType
            //        == typeof(decimal));

            //        foreach (var property in properties)
            //        {
            //            modelBuilder.Entity(entityType.Name).Property(property.Name)
            //            .HasConversion<double>();
            //        }
            //    }

            //}
        }
    }
}
