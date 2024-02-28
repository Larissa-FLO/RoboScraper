using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboScraper.ComparacaoDePrecos
{
    internal class ComparacaoPreco
    {
        public static string CompararPreco(string precoMerL, string precoMagL)
        {
            char[] removerCaracteres = { 'R', '$', ' ' };

            double precoMagazine = Convert.ToDouble(precoMagL.Trim(removerCaracteres));
            double precoMercado = Convert.ToDouble(precoMerL.Trim(removerCaracteres));

            Console.WriteLine(precoMercado);
            Console.WriteLine(precoMagazine);

            if (precoMagazine > precoMercado)
            {
                return "Melhor preço: Mercado Livre";
            }
            else if (precoMercado > precoMagazine)
            {
                return "Melhor preço: Magazine Luíza";
            }
            else
            {
                return "Preços iguais";
            }
        }
    }
}
