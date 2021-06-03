using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBanco.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Models.Cliente> Clientes { get; set; }
        public DbSet<Models.ContaCorrente> ContaCorrentes { get; set; }
        public DbSet<Models.Transacao> Transacoes { get; set;  }
    }
}
