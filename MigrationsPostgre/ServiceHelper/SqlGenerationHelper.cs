using Microsoft.EntityFrameworkCore.Storage;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsPostgre.ServiceHelper
{
    public class SqlGenerationHelper : RelationalSqlGenerationHelper
    {
        private static string Customize(string input) => input.ToLower();
        public SqlGenerationHelper([NotNull] RelationalSqlGenerationHelperDependencies dependencies) : base(dependencies) { }
        public override string DelimitIdentifier(string identifier) => base.DelimitIdentifier(Customize(identifier));
        public override void DelimitIdentifier(StringBuilder builder, string identifier) => base.DelimitIdentifier(builder, Customize(identifier));
    }
}
