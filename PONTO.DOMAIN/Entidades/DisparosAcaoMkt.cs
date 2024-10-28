using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    public  class DisparosAcaoMkt
    {
        [Key]
        public int IdDisparo { get; set; }

        [MaxLength(150)]
        public string? NomeCliente { get; set; }

        [MaxLength(20)]
        public string? CPF { get; set; }

        [MaxLength(20)]
        public string? CanalEnvio { get; set; }

        [MaxLength(120)]
        public string? Email { get; set; }

        [MaxLength(20)]
        public string? Telefone { get; set; }

        [MaxLength(50)]
        public string? NomeMailing { get; set; }

        [MaxLength(20)]
        public string? StatusEnvio { get; set; }

        [MaxLength(50)]
        public string? InfoAdicional { get; set; }

        public DateTime DataEnvio { get; set; }
    }
}
