using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.ContextConfigurations
{
    public class SuperpowerContextConfiguration : IEntityTypeConfiguration<Superpower>
    {
        public void Configure(EntityTypeBuilder<Superpower> builder)
        {
            builder.HasKey(sp => sp.Id);// Primary Key

            // Property Configurations
            builder.Property(sp => sp.SuperPower).IsRequired();
            builder.Property(sp => sp.Description);

            // Relationship Configuration
            builder.HasOne(sp => sp.Superhero)
                   .WithMany(sh => sh.Superpowers)
                   .HasForeignKey(sp => sp.SuperheroId);

            this.Seed(builder);
        }

        private void Seed(EntityTypeBuilder<Superpower> builder)
        {
            builder
                .HasData(
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Intellect.",
                        Description = "He's always a step ahead.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Fighting",
                        Description = "Sublime fighting skills.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Wealth.",
                        Description = "He got a lot of money",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Deflect blaster power.",
                        Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000002")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Espionage",
                        Description = "She's good at spying at people.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Infiltration",
                        Description = "She knows how to infiltrate the enemy.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                    },
                    new Superpower
                    {
                        Id = Guid.NewGuid(),
                        SuperPower = "Subterfuge",
                        Description = "The knowledge of how to undermine others.",
                        SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                    });
        }
    }
}