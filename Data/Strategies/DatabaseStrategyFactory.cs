using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Configurations;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public static class DatabaseStrategyFactory
    {
        public static IDatabaseStrategy GetStrategy(DatabaseType type)
        {
            return type switch
            {
                DatabaseType.SQLServer => new SqlServerDatabaseStrategy(),
                DatabaseType.SQLite => new SqliteDatabaseStrategy(),
                DatabaseType.PostgreSQL => new PostgresDatabaseStrategy(),
                _ => throw new NotSupportedException($"Database type {type} is not supported.")
            };
        }
    }
}