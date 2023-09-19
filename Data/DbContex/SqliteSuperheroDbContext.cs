using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex
{
    public class SqliteSuperheroDbContext : SuperheroDbContextBase
    {
        public SqliteSuperheroDbContext(DbContextOptions<SqliteSuperheroDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adjustments for SQLite:
            // SQLite doesn't have the uniqueidentifier type, it uses TEXT for Guids by default.
            // Still, being explicit helps for clarity.
            modelBuilder.Entity<Movie>().Property(m => m.Id).HasColumnType("TEXT");
            modelBuilder.Entity<Superhero>().Property(s => s.Id).HasColumnType("TEXT");
            modelBuilder.Entity<Superpower>().Property(sp => sp.Id).HasColumnType("TEXT");

            // SQLite doesn't have an 'nvarchar(max)' equivalent like SQL Server, but this is implicitly handled by EF Core.
            // Therefore, no specific adjustment is needed for string fields unless you have a specific length requirement.
        }
    }
}