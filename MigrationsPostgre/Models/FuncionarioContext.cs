using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MigrationsPostgre.ServiceHelper;
using System.Data.Common;

namespace MigrationsPostgre.Models
{
    public class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public FuncionarioContext(DbConnection connection) :
            base(new DbContextOptionsBuilder().UseNpgsql(connection)
                                                 .ReplaceService<ISqlGenerationHelper, SqlGenerationHelper>()
                                                 .Options)
        {
            
        }

        
    }
}
