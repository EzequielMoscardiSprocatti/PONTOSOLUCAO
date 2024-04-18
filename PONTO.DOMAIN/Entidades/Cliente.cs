using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.DOMAIN.Entidades
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required, MaxLength(150)]
        public string? Nome { get; set; }

        [Required, MaxLength(20)]
        public string? Cpf { get; set; }

        [Required, MaxLength(20)]
        public string? RG { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required, MaxLength(30)]
        public string? Aposentado { get; set; }

        [Required, MaxLength(150)]
        public string? NomeMae { get; set; }

        [Required, MaxLength(150)]
        public string? NomePai { get; set; }

        [Required, MaxLength(150)]
        public string? LocalNasc { get; set; }

        [MaxLength(30)]
        public string? StatusCad { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
