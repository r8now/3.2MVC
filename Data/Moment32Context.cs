#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moment32.Models;

namespace Moment32.Data
{
    public class Moment32Context : DbContext
    {
        public Moment32Context (DbContextOptions<Moment32Context> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artist { get; set; }
        public DbSet<Album> Album { get; set; }

    }
}
