﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex;

#nullable disable

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Migrations.PostgresMigrations
{
    [DbContext(typeof(PostgresSuperheroDbContext))]
    [Migration("20230919220112_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Instructor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0db1fb50-cc4f-429f-8dbb-cb2685662917"),
                            Description = "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "Batman Begins"
                        },
                        new
                        {
                            Id = new Guid("fd9e996d-26fb-4fcb-8d6a-bd27173ee079"),
                            Description = "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "The Dark Knight"
                        },
                        new
                        {
                            Id = new Guid("f4fc6e00-c401-4326-809a-c0a7b81c7727"),
                            Description = "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.",
                            Instructor = "Christopher Nolan",
                            ReleaseDate = new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001"),
                            Title = "The Dark Knight Rises"
                        },
                        new
                        {
                            Id = new Guid("930b7389-214d-4edb-b5ed-ef4928d4ae12"),
                            Description = "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.",
                            Instructor = "George Lucas",
                            ReleaseDate = new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Star Wars: Episode IV – A New Hope"
                        },
                        new
                        {
                            Id = new Guid("b2e90458-dadd-4c95-888d-457eaf54bd44"),
                            Description = "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.",
                            Instructor = "Irvin Kershner",
                            ReleaseDate = new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Star Wars: Episode V – The Empire Strikes Back"
                        },
                        new
                        {
                            Id = new Guid("9536955a-7ddf-4c9d-9aa4-fbc72f954948"),
                            Description = "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.",
                            Instructor = "Richard Marquand",
                            ReleaseDate = new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000002"),
                            Title = "Star Wars: Episode VI – Return of the Jedi"
                        },
                        new
                        {
                            Id = new Guid("a2d31f02-96b6-44ec-bf53-0ea43b648bb5"),
                            Description = "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).",
                            Instructor = "Cate Shortland",
                            ReleaseDate = new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Utc),
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000003"),
                            Title = "Black Widow"
                        });
                });

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superhero", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<double>("Height")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("Superheroes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.",
                            Height = 1.9299999999999999,
                            Name = "Batman"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.",
                            Height = 1.7,
                            Name = "Luke Skywalker"
                        },
                        new
                        {
                            Id = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.",
                            Height = 1.7,
                            Name = "Black Widow"
                        });
                });

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superpower", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SuperPower")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SuperheroId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SuperheroId");

                    b.ToTable("Superpowers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a79bb267-79de-4232-b147-77b4d7d8fe10"),
                            Description = "He's always a step ahead.",
                            SuperPower = "Intellect.",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("2664ae30-ec96-4bbf-aa91-51a4465776ae"),
                            Description = "Sublime fighting skills.",
                            SuperPower = "Fighting",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("feaa7d42-8e80-46d9-84b8-278e1ce0f505"),
                            Description = "He got a lot of money",
                            SuperPower = "Wealth.",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000001")
                        },
                        new
                        {
                            Id = new Guid("9b22b5f0-0076-4ce8-96df-22bf0cfd91c5"),
                            Description = "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.",
                            SuperPower = "Deflect blaster power.",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000002")
                        },
                        new
                        {
                            Id = new Guid("cd3165ab-858f-4b7d-88bd-239c0ca83336"),
                            Description = "She's good at spying at people.",
                            SuperPower = "Espionage",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("d3fd6f07-22b4-46f2-b47f-186b8c93507c"),
                            Description = "She knows how to infiltrate the enemy.",
                            SuperPower = "Infiltration",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                        },
                        new
                        {
                            Id = new Guid("4dce5727-3d87-4fc0-bcbc-b5071b11af6c"),
                            Description = "The knowledge of how to undermine others.",
                            SuperPower = "Subterfuge",
                            SuperheroId = new Guid("00000000-0000-0000-0000-000000000003")
                        });
                });

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Movie", b =>
                {
                    b.HasOne("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superhero", "Superhero")
                        .WithMany("Movies")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superpower", b =>
                {
                    b.HasOne("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superhero", "Superhero")
                        .WithMany("Superpowers")
                        .HasForeignKey("SuperheroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superhero");
                });

            modelBuilder.Entity("aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models.Superhero", b =>
                {
                    b.Navigation("Movies");

                    b.Navigation("Superpowers");
                });
#pragma warning restore 612, 618
        }
    }
}