using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex
{
    public class SqlServerSuperheroDbContext : SuperheroDbContextBase
    {
        public SqlServerSuperheroDbContext(DbContextOptions<SqlServerSuperheroDbContext> options) : base(options)
        {
        }
    }
}