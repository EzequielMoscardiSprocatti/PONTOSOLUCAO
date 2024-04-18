using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("CadTelefone")]
    public class Telefone
    {
        [Key]
        public int IdTelefone { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        public string? TipoTelefone { get; set; }

        [Required, MaxLength(4)]
        public string? DD { get; set; }

        [Required, MaxLength(20)]
        public string? NumTelefone { get; set; }

        public int ScoreInterno { get; set; }

        [MaxLength(20)]
        public string? StatusTelefone { get; set; }
    }
}
