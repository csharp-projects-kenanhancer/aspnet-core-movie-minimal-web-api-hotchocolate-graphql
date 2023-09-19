using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Data.DbContex;
using aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.GraphQL.Queries
{
    [ExtendObjectType<Query>()]
    public class MovieQuery
    {
        public IQueryable<Movie> GetMovies([Service(ServiceKind.Resolver)] SuperheroDbContextBase superheroDbContext)
        {
            var movies = superheroDbContext.Movies.AsQueryable();

            return movies;
        }

        public async Task<Movie?> GetMovie([Service(ServiceKind.Resolver)] SuperheroDbContextBase superheroDbContext, Guid Id)
        {
            var movie = await superheroDbContext.Movies.SingleOrDefaultAsync(movie => movie.Id == Id);

            return movie;
        }
    }
}