using COMP003B.Assignment7.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment7.Data
{
    public class WebActorMovieContext : DbContext
    {
        public WebActorMovieContext(DbContextOptions<WebActorMovieContext> options)
            : base(options) 
        {
        }

        public DbSet<Actor> Actors { get; set;}

        public DbSet<Movie> Movies { get; set;}

        public DbSet<MovieActor> MovieActors { get; set;}
    }
}
