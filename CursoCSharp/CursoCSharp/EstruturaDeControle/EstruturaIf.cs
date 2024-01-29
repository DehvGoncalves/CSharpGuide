using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno; ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double notaConvert);

            Console.WriteLine("Possui bom comportamento? (S/N) ");
            entrada = Console.ReadLine();


            if (entrada != "S" || entrada != "s")
            {
                Console.WriteLine("Digite apenas S ou N");
            }
            else
            {
                Console.WriteLine("Quadro de honra");
            }

        }

    }
}
