namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies
{
    public interface IDatabaseStrategy
    {
        void Configure(WebApplicationBuilder builder);
    }
}