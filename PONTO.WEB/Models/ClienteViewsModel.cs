using PONTO.DOMAIN.Entidades;

namespace PONTO.WEB.Models
{
    public class ClienteViewsModel
    {
        public Cliente Cliente { get; set; }
        public List<Email>? Emails { get; set; }
        public List<Beneficios>? Beneficios { get; set; }
        public List<Contratacao>? Contratos { get; set; }
        public List<DisparosAcaoMkt>? DisparosAcaos { get; set; }
        public List<Emprestimo>? Emprestimos { get; set; }
        public List<Endereco>? Enderecos { get; set; }
        public List<Historico>? Historicos { get; set; }
        public List<ResultadoBot>? ResultadoBots { get; set; }
        public List<Telefone>? Telefones { get; set; }

    }
}
