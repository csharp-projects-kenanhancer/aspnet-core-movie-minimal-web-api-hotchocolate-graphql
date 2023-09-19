using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.ContextConfigurations;
using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex
{
    public class SuperheroDbContextBase : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Superhero> Superheroes { get; set; }
        public DbSet<Superpower> Superpowers { get; set; }

        public SuperheroDbContextBase(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new MovieContextConfiguration());
            modelBuilder.ApplyConfiguration(new SuperheroContextConfiguration());
            modelBuilder.ApplyConfiguration(new SuperpowerContextConfiguration());
        }
    }
}