using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IMDB.Models;

    public class IMDBContext : DbContext
    {
        public IMDBContext (DbContextOptions<IMDBContext> options)
            : base(options)
        {
        }

        public DbSet<IMDB.Models.Movie> Movie { get; set; } = default!;
    }
