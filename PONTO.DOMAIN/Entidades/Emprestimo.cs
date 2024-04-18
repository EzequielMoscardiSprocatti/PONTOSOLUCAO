using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("Emprestimos")]
    public  class Emprestimo
    {
        [Key]
        public int IdEmprestimo { get; set; }

        [MaxLength(20)]
        public string? Contrato { get; set; }

        [MaxLength(50)]
        public string? Tipo { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        [MaxLength(30)]
        public string? Matricula { get; set; }

        [MaxLength(50)]
        public string? Orgao { get; set; }

        [MaxLength(20)]
        public string? ValorParcela { get; set; }

        public DateTime DataContracao { get; set; }

        public int QtdParcelas { get; set; }

        public int ParcelasPagas { get; set; }

        [MaxLength(50)]
        public string? Empregador { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
