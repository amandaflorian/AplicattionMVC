using Microsoft.EntityFrameworkCore;
using AplicattionMVC.Models;

namespace AplicattionMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
            
        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
