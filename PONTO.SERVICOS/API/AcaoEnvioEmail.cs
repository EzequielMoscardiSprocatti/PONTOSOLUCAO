using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PONTO.DAO;
using PONTO.DAO.Funcao;
using PONTO.DOMAIN;
using PONTO.DOMAIN.Entidades;

namespace PONTO.SERVICOS.API
{
    public class AcaoEnvioEmail : IDisposable
    {
        appDbContext db = new appDbContext();
        EnvioAcaoMkt envioAcao = new EnvioAcaoMkt();

        public void Dispose()
        {

        }

        public async Task<string> EnviarEmailJson(DisparosAcaoMkt acaoMkt, string Assunto, string Mensagem, string assinatura)
        {

            //EnvioViaSSMTP("", acaoMkt.Email, "Promoção Relampago", acaoMkt.NomeCliente, Mensagem, assinatura);

            try
            {
                var url_ = "https://painel.mailgrid.com.br/api/send/";

                var httpRequest_ = (HttpWebRequest)WebRequest.Create(url_);
                httpRequest_.Method = "POST";

                httpRequest_.Headers["Authorization"] = "Content-Type: application/json";
                httpRequest_.ContentType = "application/json";

                var data = @"{""host_smtp"": ""server11.mailgrid.com.br"",""usuario_smtp"": ""emkt@emkt.pontopromotora.com.br"", ""senha_smtp"": ""nd050b35i4"", ""emailRemetente"": ""emkt@emkt.pontopromotora.com.br"", 
                            ""nomeRemetente"": ""@NomeRemetente"",""emailDestino"": [""@emailDestino""], 
                            ""assunto"": ""@AssuntoEmail"", ""mensagem"": ""@msgEmail""}";

                // Remover espaços em branco, tabulações e quebras de linha
                string htmlCompactado = Regex.Replace(Mensagem.Replace("\r\n","").Replace("          ","").Replace("    ",""), @"(?<=>)\s+(?=<)|(?<=>)\s+(?=</)", string.Empty);


                // Substituir valores na string 'data'
                data = data.Replace("@AssuntoEmail", Assunto)
                           .Replace("@emailDestino", acaoMkt.Email)
                           .Replace("@NomeRemetente", acaoMkt.NomeCliente)
                           .Replace("@msgEmail", htmlCompactado);


                using (var streamWriter = new StreamWriter(httpRequest_.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest_.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result_ = streamReader.ReadToEnd();
                }

                Console.WriteLine(httpResponse.StatusCode);
            }
            catch (Exception)
            {

            }



            string status = "";
            string jsonData = "";

            var url = "https://painel.mailgrid.com.br/api/send/";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";


            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            try
            {
                jsonData = "{" +
                          "\"host_smtp\": \"server11.mailgrid.com.br\"," +
                          "\"senha_smtp\": \"nd050b35i4\"," +
                          "\"usuario_smtp\": \"emkt@emkt.pontopromotora.com.br\"," +
                          "\"emailRemetente\":\"emkt@emkt.pontopromotora.com.br\"," +
                          "\"nomeRemetente\": \"" + acaoMkt.NomeCliente + "\"," +
                          "\"emailDestino\": [\"" + acaoMkt.Email + "\"]," +
                          "\"assunto\": \"" + Assunto + "\"," +
                          "\"mensagem\":\"" + Mensagem + assinatura + "\"}";
            }
            catch (Exception)
            {

            }



            try
            {
                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonData);
                }


                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    status = streamReader.ReadToEnd();

                }

                acaoMkt.StatusEnvio = httpResponse.StatusCode.ToString();
            }
            catch (Exception)
            {
                status = "Falha no Envio";
                acaoMkt.StatusEnvio = status;
            }
           

            var result = await envioAcao.InsertDados(acaoMkt);

            return status;
        }

        public string EnvioViaSSMTP(DisparosAcaoMkt acaoMkt, string Apresentacao, string TituloEmail, string CorpoEmail, string assinatura)
        {
            string  StatusEnvio = "";

            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587);
                client.Host = "server11.mailgrid.com.br";
                client.Port = 587;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("emkt@emkt.pontopromotora.com.br", "nd050b35i4");
                MailMessage mail = new MailMessage();

                if (Apresentacao != "")
                {
                    System.Net.Mail.Attachment anex;
                    anex = new System.Net.Mail.Attachment(Apresentacao);
                    mail.Attachments.Add(anex);
                }

                mail.Sender = new System.Net.Mail.MailAddress("emkt@emkt.pontopromotora.com.br", "nd050b35i4");
                mail.From = new MailAddress("emkt@emkt.pontopromotora.com.br", "Ponto Promotora");
                mail.To.Add(new MailAddress(acaoMkt.Email.Replace(">", "").Replace("<", "").Replace("\n", "").Replace(" ", ""), acaoMkt.Email.Replace(">", "").Replace("<", "").Replace("\n", "").Replace(" ", "")));
                mail.Subject = TituloEmail;
                mail.Body = "Olá " + acaoMkt.NomeCliente + " Tudo Bem! <br/> " + CorpoEmail + "<br/>" + assinatura;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                try
                {
                    client.Send(mail);
                    
                    

                    return StatusEnvio = "Enviado";
                }
                catch (System.Exception ex)
                {
                    string erro = ex.ToString();
                    return StatusEnvio = "Erro";
                }
                finally
                {
                    mail = null;
                }
            }
            catch (Exception)
            {
                return StatusEnvio = "Erro";
            }
        }

    }
}
