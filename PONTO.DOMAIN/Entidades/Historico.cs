using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("CadHistorico")]
    public class Historico
    {
        [Key]
        public int IdHist { get; set; }

        [Required, MaxLength(20)]
        public string? CPF {get; set;}

        [MaxLength(20)]
        public string? Status {get; set;}

        [MaxLength(20)]
        public string? Matricula {get; set;}

        [MaxLength(20)]
        public string? Contrato {get; set;}

        [MaxLength(240)]
        public string? HistoricoContato {get; set;}

        [MaxLength(20)]
        public string? Agente {get; set;}

        [MaxLength(50)]
        public string? LoginUsuario { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
