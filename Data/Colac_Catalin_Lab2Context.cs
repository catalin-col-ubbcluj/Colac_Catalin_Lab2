using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Colac_Catalin_Lab2.Models;

namespace Colac_Catalin_Lab2.Data
{
    public class Colac_Catalin_Lab2Context : DbContext
    {
        public Colac_Catalin_Lab2Context (DbContextOptions<Colac_Catalin_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Colac_Catalin_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Colac_Catalin_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Colac_Catalin_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
