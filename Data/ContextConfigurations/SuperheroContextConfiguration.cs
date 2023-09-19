using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.ContextConfigurations
{
    public class SuperheroContextConfiguration : IEntityTypeConfiguration<Superhero>
    {
        public void Configure(EntityTypeBuilder<Superhero> builder)
        {
            builder.HasKey(s => s.Id);// Primary Key

            // Property Configurations
            builder.Property(s => s.Name).IsRequired().HasMaxLength(255);
            builder.Property(s => s.Description).IsRequired().HasMaxLength(1000);
            builder.Property(s => s.Height).IsRequired();

            // Relationship Configurations
            builder.HasMany(s => s.Movies)
                .WithOne(m => m.Superhero)
                .HasForeignKey(m => m.SuperheroId);

            builder.HasMany(s => s.Superpowers)
                   .WithOne(s => s.Superhero)
                   .HasForeignKey(sh => sh.SuperheroId);

            this.Seed(builder);
        }

        private void Seed(EntityTypeBuilder<Superhero> builder)
        {
            builder
            .HasData(
                new Superhero
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Name = "Batman",
                    Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                    Height = 1.93
                },
                new Superhero
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000002"),
                    Name = "Luke Skywalker",
                    Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                    Height = 1.70
                },
                new Superhero
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000003"),
                    Name = "Black Widow",
                    Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                    Height = 1.70
                });
        }
    }
}