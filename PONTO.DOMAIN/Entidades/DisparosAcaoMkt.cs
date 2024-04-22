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
        public string NomeCliente { get; set; }
        public string CPF { get; set; }
        public string CanalEnvio { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string NomeMailing { get; set; }
        public string StatusEnvio { get; set; }
        public DateTime DataEnvio { get; set; }
    }
}
