using Microsoft.EntityFrameworkCore;

namespace MigrationsPostgre.Models
{
    public class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public FuncionarioContext(DbContextOptions<FuncionarioContext> options) :
            base(options)
        {
        }

    }
}
