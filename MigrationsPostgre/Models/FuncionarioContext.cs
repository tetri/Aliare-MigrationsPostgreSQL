using Microsoft.EntityFrameworkCore;

namespace MigrationsPostgre.Models
{
    public class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public FuncionarioContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //NÃO RESOLVE optionsBuilder.ReplaceService<ISqlGenerationHelper, SqlGenerationHelper>();
        }
    }
}
