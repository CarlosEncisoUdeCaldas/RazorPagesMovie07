using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie07.Models;

    public class RazorPagesMovie07Context : DbContext
    {
        // constructor de la clase RazorPagesMovie07Context
        public RazorPagesMovie07Context (DbContextOptions<RazorPagesMovie07Context> options) : base(options)
        {
        }

        public DbSet<RazorPagesMovie07.Models.Movie> Movie { get; set; } = default!;
    }
