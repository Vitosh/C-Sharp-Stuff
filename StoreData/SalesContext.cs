namespace StoreData
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SalesContext : DbContext
    {
        public SalesContext(): base("name=SalesContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<SalesContext>());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<StoreLocation> Locations{ get; set; }        
    }

}