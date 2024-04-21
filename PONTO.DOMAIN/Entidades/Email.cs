using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("CadEmail")]
    public class Email
    {
        [Key]
        public int IdEmail { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        [Required, MaxLength(100)]
        public string? EmailCliente { get; set; }

        [MaxLength(20)]
        public string? StatusEmail { get; set; }

        public int ScoreInterno { get; set; }

        public DateTime DataCadastro { get; set; }


    }
}
