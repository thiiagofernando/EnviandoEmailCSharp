using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace EnviarEmailCSharp
{
    class EnviarEmail
    {
        public EnviarEmail()
        {

        }
        public string Enviar(string menssagem,string para)
        {
            string resposta;
            try
            {
                var server = WebMail.SmtpServer = "smtp.gmail.com";
                var port = WebMail.SmtpPort = 587;
                var ssl = WebMail.EnableSsl = true;
                var contaEnvio = WebMail.UserName = "Conta_Usada_Para_Envio@gmail.com";
                var senhaContaEnvio  = WebMail.Password = "Senha_Da_Conta_De_Envio";
                var enviarpara = WebMail.From = para;
                var corpoEmail = $@"
                                  <!DOCTYPE html>
                                    <html>
                                    <head><title>Novo E-mail</title></head>
                                    <body>
                                     <p>Ola {para}, {menssagem}</p>
                                    </body>
                                    </html>";
                WebMail.Send(to: enviarpara, subject: "Novo Email Recebido", body: corpoEmail);
                resposta = "Email Enviado com Sucesso !!!";
               
            }
            catch (Exception)
            {
                resposta = "Não Foi Possivel Enviar!!";
            }

            return resposta;
        }
    }
}
