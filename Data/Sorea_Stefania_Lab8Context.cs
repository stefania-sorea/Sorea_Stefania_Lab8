using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sorea_Stefania_Lab8.Models;

namespace Sorea_Stefania_Lab8.Data
{
    public class Sorea_Stefania_Lab8Context : DbContext
    {
        public Sorea_Stefania_Lab8Context (DbContextOptions<Sorea_Stefania_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Sorea_Stefania_Lab8.Models.Book> Book { get; set; }

        public DbSet<Sorea_Stefania_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Sorea_Stefania_Lab8.Models.Category> Category { get; set; }
    }
}
