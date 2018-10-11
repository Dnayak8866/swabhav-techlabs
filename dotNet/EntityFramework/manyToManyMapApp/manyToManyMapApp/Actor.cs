using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manyToManyMapApp
{
   public class Actor
    {
        public virtual List<Movie> Movies { get; set; }

        public Guid Id { get; set; }
        public string ActorName { get; set; }
        public int ActorAge { get; set;}

        public Actor()
        {
            Id = Guid.NewGuid();
        }
        
    }
}
