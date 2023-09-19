using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex
{
    public class PostgresSuperheroDbContext : SuperheroDbContextBase
    {
        public PostgresSuperheroDbContext(DbContextOptions<PostgresSuperheroDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().Property(m => m.Id).HasColumnType("uuid");
            modelBuilder.Entity<Superhero>().Property(s => s.Id).HasColumnType("uuid");
            modelBuilder.Entity<Superpower>().Property(sp => sp.Id).HasColumnType("uuid");
        }
    }
}