namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Configurations
{
    public static class ConfigurationExtensions
    {
        public static T GetOrDefault<T>(this IConfigurationSection section, T? defaultValue = default) where T : new()
        {
            return section.Get<T>() ?? defaultValue ?? new T();
        }
    }
}