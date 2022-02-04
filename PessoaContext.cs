using Microsoft.EntityFrameworkCore;

namespace CadastroAPI.Models
{
    public class PessoaContext : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options) : base(options) 
        { 
            Database.EnsureCreated();
        }

        //Mapeamento das Tabelas.
        public DbSet<Pessoa> Pessoas { get; set; }

    }
}
