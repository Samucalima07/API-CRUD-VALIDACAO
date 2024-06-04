using API_CRUD_VALIDAÇÃO.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_VALIDAÇÃO.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd(); // Configurando o ID para ser gerado Automaticamente.
        }
    }
}
