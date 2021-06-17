using apiDoZeroAoUm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiDoZeroAoUm.Data
{
    public class DataContext : DbContext
    {
        internal object Profissional;

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }
    }
}
