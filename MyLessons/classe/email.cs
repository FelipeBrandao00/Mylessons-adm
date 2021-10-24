using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace MyLessons.classe
{
    public static class email
    {
        private static string remetente = "mylessonstcc@gmail.com";
        private static string senha = "h&*6@G7gy7d8he92o2fj";

        #region Manda um email de código novo apartir de nome e código
            public static bool mandarCodigo(string destinatario, string nome, int codigo)
            {
                MailMessage mensagem = new MailMessage(
                    new MailAddress(remetente, "MyLessons", Encoding.GetEncoding("UTF-8")),
                    new MailAddress(destinatario)
                );
                mensagem.Subject = "Mylessons - redefinição de senha";
                mensagem.IsBodyHtml = true;
                mensagem.Body = "<p>Olá " + nome + ", seu código é: <b>" + codigo + "</b></p>";
                mensagem.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mensagem.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(remetente, senha);
                smtpClient.EnableSsl = true;
                try { smtpClient.Send(mensagem); } catch { return false; } 
                return true;
            }
        #endregion

        #region Manda um email com título e conteúdo personalizado
            public static bool personalizado(string destinatario, string subject, string html)
            {
                MailMessage mensagem = new MailMessage(
                    new MailAddress(remetente, "MyLessons", Encoding.GetEncoding("UTF-8")),
                    new MailAddress(destinatario)
                );
                mensagem.Subject = subject;
                mensagem.IsBodyHtml = true;
                mensagem.Body = html;
                mensagem.SubjectEncoding = Encoding.GetEncoding("UTF-8");
                mensagem.BodyEncoding = Encoding.GetEncoding("UTF-8");

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(remetente, senha);
                smtpClient.EnableSsl = true;
                try { smtpClient.Send(mensagem); }
                catch { return false; }
                return true;
            }
        #endregion
    }
}
