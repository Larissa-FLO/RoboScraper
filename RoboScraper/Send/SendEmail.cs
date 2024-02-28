using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace RoboScraper.Send
{

    public class SendEmail
    {
        static void EnviarEmail(string nomeProdutoMercadoLivre, string precoProdutoMercadoLivre, string nomeProdutoMagazineLuiza, string precoProdutoMagazineLuiza)
        {
            // Configurações do servidor SMTP do Gmail
            string smtpServer = "smtp-mail.outlook.com"; // Servidor SMTP do Gmail
            int porta = 587; // Porta SMTP do Gmail para TLS/STARTTLS
            string remetente = "wallacemaximus@hotmail.com"; // Seu endereço de e-mail do Gmail
            string senha = "teste"; // Sua senha do Gmail

            // Configurar cliente SMTP
            using (SmtpClient client = new SmtpClient(smtpServer, porta))
            {
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(remetente, senha);
                client.EnableSsl = true; // Habilitar SSL/TLS

                // Construir mensagem de e-mail
                MailMessage mensagem = new MailMessage(remetente, "wallace@docente.senai.br")
                {
                    Subject = "Resultado da comparação de preços",
                    Body = $"Produto do Mercado Livre: {nomeProdutoMercadoLivre} - Preço: {precoProdutoMercadoLivre}\n" +
                           $"Produto do Magazine Luiza: {nomeProdutoMagazineLuiza} - Preço: {precoProdutoMagazineLuiza}\n"

                };

                // Enviar e-mail
                client.Send(mensagem);


                Console.WriteLine(nomeProdutoMercadoLivre);
                Console.WriteLine(precoProdutoMercadoLivre);
                Console.WriteLine(nomeProdutoMagazineLuiza);
                Console.WriteLine(precoProdutoMagazineLuiza);

            }
        }
    }
}
