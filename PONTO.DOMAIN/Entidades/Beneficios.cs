using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("Beneficios")]
    public class Beneficios
    {
        [Key]
        public int IdBeneficio { get; set; }

        [MaxLength(50)]
        public string? Tipo { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        [MaxLength(20)]
        public string? Matricula { get; set; }

        [MaxLength(50)]
        public string? ConvenioOrgao { get; set; }

        [MaxLength(50)]
        public string? Consignatorio { get; set; }

        [MaxLength(20)]
        public string? ValorBeneficio { get; set; }

        [MaxLength(30)]
        public string? RegistroFuncional { get; set; }

        [MaxLength(20)]
        public string? TempoRegistro { get; set; }

        [MaxLength(30)]
        public string? StatusBenef { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
