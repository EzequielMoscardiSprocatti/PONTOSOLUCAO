using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("CadEndereco")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }

        [Required, MaxLength(20)]
        public string? CPF { get; set; }

        public string? Rua { get; set; }

        public string? Numero { get; set; }

        [Required, MaxLength(20)]
        public string? Cep { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cidade { get; set; }

        public string? Uf { get; set; }

        public string? Pais { get; set; }

        public string? Tipo { get; set; }

        public int ScoreInterno { get; set; }

        public string? StatusEndereco { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
