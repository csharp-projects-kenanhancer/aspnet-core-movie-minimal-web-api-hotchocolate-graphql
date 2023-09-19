using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public class SqlServerDatabaseStrategy : IDatabaseStrategy
    {
        public void Configure(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<SqlServerSuperheroDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SuperheroesSqlServer")));

            builder.Services.AddScoped<SuperheroDbContextBase, SqlServerSuperheroDbContext>();
        }
    }
}