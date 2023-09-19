using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public class SqliteDatabaseStrategy : IDatabaseStrategy
    {
        public void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<SqliteSuperheroDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("SuperheroesSqlite")));

            builder.Services.AddScoped<SuperheroDbContextBase, SqliteSuperheroDbContext>();
        }
    }
}