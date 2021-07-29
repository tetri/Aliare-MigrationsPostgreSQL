using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationsPostgre.Models
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        [Column(TypeName = "citext")]
        public int Id { get; set; }
        [Column(TypeName = "citext")]
        public string Nome { get; set; }
        [Column(TypeName = "citext")]
        public int Idade { get; set; }
        [Column(TypeName = "citext")]
        public string Funcao { get; set; }
    }
}