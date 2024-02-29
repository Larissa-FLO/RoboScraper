using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboScraper.Send
{
    public class SendZap
    {
        //Verificar se o usuário deseja receber mensagem no whatsapp
        public static void verificarMensagem(string Comparacao, string nomeProdutoMercadoLivre, string precoProdutoMercadoLivre, string nomeProdutoMagazineLuiza, string precoProdutoMagazineLuiza)
        {
            Console.WriteLine("Deseja receber a comparação via WhatsApp?\nTecle 1 para sim e 2 para não");
            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 1)
            {
                ////Enviar mensagem no whatsapp
                static void SendWhatsApp(string Comparacao, string nomeProdutoMercadoLivre, string precoProdutoMercadoLivre, string nomeProdutoMagazineLuiza, string precoProdutoMagazineLuiza)
                {

                    string numUsuario = "";
                    string message = $"Produto do Mercado Livre: {nomeProdutoMercadoLivre} - Preço: {precoProdutoMercadoLivre}\n" +
                                     $"Produto do Magazine Luiza: {nomeProdutoMagazineLuiza} - Preço: {precoProdutoMagazineLuiza}\n" +
                                     $"{Comparacao}.\n";
                   

                    try
                    {
                            Console.WriteLine("Digite o número de celular (com DDD) que receberá a mensagem");
                            numUsuario = Console.ReadLine();

                        var parameters = new System.Collections.Specialized.NameValueCollection();
                        var client = new System.Net.WebClient();
                        var url = "https://app.whatsgw.com.br/api/WhatsGw/Send/";

                        parameters.Add("apikey", "87878cb7-1e0f-446c-9af8-981934964bac"); //switch to your api key
                        parameters.Add("phone_number", "5579996313498"); //switch to your connected number
                        parameters.Add("contact_phone_number", numUsuario); //switch to your number text to received message

                        parameters.Add("message_custom_id", "tste");

                        parameters.Add("message_type", "text");
                        parameters.Add("message_body", message);

                        string responseString = "";
                        byte[] response_data;

                        response_data = client.UploadValues(url, "POST", parameters);
                        responseString = UnicodeEncoding.UTF8.GetString(response_data);

                        Console.WriteLine(responseString);

                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine($"FAIL: {ex.Message}");
                    }

                    Console.ReadLine();


                    Environment.Exit(0);
                }
            }

        }
    } 
}

       

    

