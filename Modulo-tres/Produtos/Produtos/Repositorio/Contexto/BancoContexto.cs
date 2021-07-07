using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Contexto
{
    public class BancoContexto : DbContext
    {
        DbSet<Produto> Produtos { get; set; }

        public BancoContexto(DbContextOptions options) : base(options)
        {
        }
    }
}
