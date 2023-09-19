using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Configurations;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public static class DatabaseStrategyExtensions
    {
        public static void UseDatabase(this WebApplicationBuilder builder, DatabaseType type)
        {
            var databaseStrategy = DatabaseStrategyFactory.GetStrategy(type);

            databaseStrategy.Configure(builder);
        }
    }
}