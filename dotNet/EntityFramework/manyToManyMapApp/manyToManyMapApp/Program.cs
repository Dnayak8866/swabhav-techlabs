using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyMapApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SwabhavDbContext dbContext = new SwabhavDbContext();
        //    AddActors(dbContext);
          AddMovies(dbContext);

          
           
           
        }

        private static void AddMovies(SwabhavDbContext dbContext)
        {
            Movie movie = new Movie { MovieName = "StudentOfYear", MovieDirector="Karan Johar"};
            movie.Actors = new List<Actor>();
            movie.Actors.Add(new Actor { ActorName="Varun Dhavan",ActorAge=32});
            movie.Actors.Add(new Actor { ActorName="Sidharth Malhotra",ActorAge=33});
            movie.Actors.Add(new Actor { ActorName="Alia Bhatt",ActorAge=25});

            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }

        private static void AddActors(SwabhavDbContext dbContext)
        {
            Actor actor = new Actor { ActorName="Salman Khan",ActorAge=52};
           
            actor.Movies = new List<Movie>();
            actor.Movies.Add(new Movie { MovieName="TigerZindaHe",MovieDirector="Ali Abbas Zafar",MovieReleaseDate="22/12/2017"});
            actor.Movies.Add(new Movie { MovieName = "Wanted", MovieDirector = "Prabhu deva", MovieReleaseDate = "18/09/2009" });
            actor.Movies.Add(new Movie { MovieName = "Dabang2", MovieDirector = "Arbaaz Khan", MovieReleaseDate = "21/12/2012" });
            dbContext.Actors.Add(actor);

            dbContext.SaveChanges();
        }
    }
}
