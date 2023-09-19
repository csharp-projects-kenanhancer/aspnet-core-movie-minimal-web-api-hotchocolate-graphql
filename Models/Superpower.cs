namespace aspnet_core_movie_minimal_web_api_hotchocolate_graphql.Models
{
    public class Superpower
    {
        public Guid Id { get; set; }
        public string SuperPower { get; set; }
        public string Description { get; set; }

        public Guid SuperheroId { get; set; }
        public Superhero Superhero { get; set; }
    }
}