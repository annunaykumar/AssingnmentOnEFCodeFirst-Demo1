using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingnmentOnEFCodeFirst_Demo1.Entities
{
    internal class Movie
    {
        public int MovieId { get; set; }    
        public string MovieName { get; set; }
        public string Actor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Producer { get; set; }
    }
}
