using PONTO.DAO;
using PONTO.DOMAIN.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PONTO.BOT.Funcoes
{
    public class ImportacaoCliente
    {
        public static void ImportarTxtsParaBancoEmLote(string pastaTxts)
        {
            var arquivosTxt = Directory.GetFiles(pastaTxts, "*.txt");

            Parallel.ForEach(arquivosTxt, (caminhoArquivoTxt) =>
            {
                ImportarArquivoTxtParaBanco(caminhoArquivoTxt);
            });
        }

        private static void ImportarArquivoTxtParaBanco(string caminhoArquivoTxt)
        {
            using (var db = new appDbContext())
            {
                try
                {
                    var linhas = File.ReadAllLines(caminhoArquivoTxt);

                    foreach (var linha in linhas)
                    {
                        if (string.IsNullOrWhiteSpace(linha)) continue;

                        var valores = linha.Split(';');

                        Cliente cliente = new Cliente();

                        if (valores[0].Trim() != null || valores[0].Trim() != "")
                        {
                            cliente.Nome = valores[0].Trim();
                        }

                        if (valores[1].Trim() != null || valores[1].Trim() != "")
                        {
                            cliente.CPF = valores[1].Trim();
                        }

                        if (valores[2].Trim() != null || valores[2].Trim() != "")
                        {
                            cliente.RG = valores[2].Trim();
                        }

                        if (valores[3].Trim() != null || valores[3].Trim() != "")
                        {
                            if (valores[3].Trim().Length > 8 && valores[3].Trim().Contains("-") && valores[3].Trim().Contains(":"))
                            {
                                cliente.DataNascimento = DateTime.Parse(valores[3].Trim());
                            }
                        }

                        if (valores[4].Trim() != null || valores[4].Trim() != "")
                        {
                            cliente.Aposentado = valores[4].Trim();
                        }

                        if (valores[5].Trim() != null || valores[5].Trim() != "")
                        {
                            cliente.NomeMae = valores[5].Trim();
                        }

                        if (valores[6].Trim() != null || valores[6].Trim() != "")
                        {
                            cliente.NomePai = valores[6].Trim();
                        }

                        if (valores[7].Trim() != null || valores[7].Trim() != "")
                        {
                            cliente.LocalNasc = valores[7].Trim();
                        }

                        if (valores[8].Trim() != null || valores[8].Trim() != "")
                        {
                            cliente.StatusCad = valores[8].Trim();
                        }


                        cliente.DataCadastro = DateTime.Now;


                        var clienteExistente = db.Clientes.FirstOrDefault(c => c.CPF == cliente.CPF);

                        if (clienteExistente == null)
                        {
                            db.Clientes.Add(cliente);
                            db.SaveChanges();
                        }
                        else
                        {
                            clienteExistente.Nome = cliente.Nome;
                            clienteExistente.RG = cliente.RG;
                            clienteExistente.DataNascimento = cliente.DataNascimento;
                            clienteExistente.Aposentado = cliente.Aposentado;
                            clienteExistente.NomeMae = cliente.NomeMae;
                            clienteExistente.NomePai = cliente.NomePai;
                            clienteExistente.LocalNasc = cliente.LocalNasc;
                            clienteExistente.StatusCad = cliente.StatusCad;
                            clienteExistente.DataCadastro = DateTime.Now;
                        }

                        cliente = null;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao importar arquivo '{caminhoArquivoTxt}': {ex.Message}");
                }
            }
        }
    }
}
