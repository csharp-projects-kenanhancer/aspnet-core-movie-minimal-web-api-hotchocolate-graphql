namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Configurations
{
    public class DatabaseSettings
    {
        public DatabaseType UseDatabase { get; set; } = DatabaseType.SQLite; // Default to SQLite
    }
}