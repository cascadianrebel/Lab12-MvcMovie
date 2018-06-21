using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab12_MvcMovie.Models
{
    public class Lab12_MvcMovieContext : DbContext
    {
        public Lab12_MvcMovieContext (DbContextOptions<Lab12_MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Lab12_MvcMovie.Models.Movie> Movie { get; set; }
    }
}
