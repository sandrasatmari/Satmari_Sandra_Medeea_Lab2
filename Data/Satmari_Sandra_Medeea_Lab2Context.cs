using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Satmari_Sandra_Medeea_Lab2.Models;

namespace Satmari_Sandra_Medeea_Lab2.Data
{
    public class Satmari_Sandra_Medeea_Lab2Context : DbContext
    {
        public Satmari_Sandra_Medeea_Lab2Context (DbContextOptions<Satmari_Sandra_Medeea_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Satmari_Sandra_Medeea_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Satmari_Sandra_Medeea_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Satmari_Sandra_Medeea_Lab2.Models.Author> Authors { get; set; }
    }
}
