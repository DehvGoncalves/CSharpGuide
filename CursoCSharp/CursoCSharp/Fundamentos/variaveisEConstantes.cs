using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class variaveisEConstantes
    {
        public static void executar()
        {
            //area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5; //mudando o valor de raio

            double area = PI * raio * raio;

            Console.WriteLine(area);
            Console.WriteLine("Área é " + area); //o + é usado para concatenar, juntando todos os textos


            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo "+ estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            sbyte saldoGols = sbyte.MinValue;
            Console.WriteLine("Saldo de gols" +  saldoGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario" + salario);

            int menorValorInt = int.MinValue; //mais usado dos inteiros
            Console.WriteLine("Menor inteiro" + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira" +populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor Long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000_000;
            Console.WriteLine("Populacao Mundial " + populacaoMundial);

        }
    }
}
