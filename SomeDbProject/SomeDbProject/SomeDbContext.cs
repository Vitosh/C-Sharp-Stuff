namespace SomeDbProject
{
    using System.Data.Entity;

    class SomeDbContext : DbContext
    {
        public SomeDbContext() : base("name=SomeDbProjectConnectionString")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SomeDbContext>());
        }
        public DbSet <Car> Cars { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}