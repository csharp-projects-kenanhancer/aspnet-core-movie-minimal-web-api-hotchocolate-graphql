using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public class PostgresDatabaseStrategy : IDatabaseStrategy
    {
        public void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<PostgresSuperheroDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("superheroesPostgresql")));

            builder.Services.AddScoped<SuperheroDbContextBase, PostgresSuperheroDbContext>();
        }
    }
}