using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationsPostgre.Models
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        
        [StringLength(200)]
        public string Funcao { get; set; }

        public DateTime DataHoraCadastro { get; set; }
    }
}