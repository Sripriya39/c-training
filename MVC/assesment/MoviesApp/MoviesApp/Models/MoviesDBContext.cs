using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesApp.Models
{
    public class MoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}