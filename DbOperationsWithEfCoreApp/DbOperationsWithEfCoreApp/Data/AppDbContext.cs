using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEfCoreApp.Data
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyType>().HasData(
                new CurrencyType() { Id = 1, Currency = "INR", Description = "Indian INR"},
                new CurrencyType() { Id = 2, Currency = "Dollar", Description = "Dollar"},
                new CurrencyType() { Id = 3, Currency = "Euro", Description = "Euro"},
                new CurrencyType() { Id = 4, Currency = "Dhinar", Description = "Dhinar"}
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "Hindi", Description = "Hindi"},
                new Language() { Id = 2, Title = "English", Description = "English"},
                new Language() { Id = 3, Title = "Marathi", Description = "Marathi"},
                new Language() { Id = 4, Title = "Urdu", Description = "Urdu"}
                );
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<CurrencyType> Currencies { get; set; }
    }
}
