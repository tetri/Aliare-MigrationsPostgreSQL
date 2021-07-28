using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationsPostgre.Models
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string funcao { get; set; }
    }
}