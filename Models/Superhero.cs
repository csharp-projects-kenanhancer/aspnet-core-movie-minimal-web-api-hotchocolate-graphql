namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models
{
    public class Superhero
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Height { get; set; }

        public ICollection<Superpower> Superpowers { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}