using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyMapApp
{
    public class Movie
    {
        public  List<Actor> Actors { get; set; }

        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
        public string MovieReleaseDate { get; set; }

        public Movie()
        {
            Id = Guid.NewGuid();
        }

    }
}
