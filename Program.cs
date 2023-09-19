using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Configurations;
using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.Strategies;
using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));

var databaseSettings = builder.Configuration.GetSection("DatabaseSettings").GetOrDefault<DatabaseSettings>();

builder.UseDatabase(databaseSettings.UseDatabase);

builder.Services
       .AddGraphQLServer()
       .AddQueryType<Query>()
       .AddType<MovieQuery>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
