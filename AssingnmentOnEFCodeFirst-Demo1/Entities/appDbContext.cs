using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingnmentOnEFCodeFirst_Demo1.Entities
{
    internal class appDbContext :DbContext
    {
        //Configure the connectionstring using app.config file
        public appDbContext() : base("name=MovieDbConnection")
        {

        }
        //define the set
        public DbSet<Movie> Movies { get; set; }
    }
}
