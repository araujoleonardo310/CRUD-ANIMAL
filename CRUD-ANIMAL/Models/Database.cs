using Microsoft.EntityFrameworkCore;

namespace DesenvolvendoCRUDdeAnimal.Models {
    public class Database : DbContext {
        public DbSet<Animal>? Animal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Animal>().HasKey(x => x.ANI_COD);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(connectionString: @"Server=172.16.1.119;Database=ZOOLOGICO;User Id=mirela;Password=123456;");
        }
    }
}