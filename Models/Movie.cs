namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Instructor { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Guid SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}