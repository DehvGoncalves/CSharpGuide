using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class usandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0}! ", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                { //Se o resto da divsão for = 1 significa que o número é impar e não é divisivel por 2
                    continue;
                }//basicamento se o restro da divão for 1, eu ignoro e imprimo o próximo número
                Console.Write(i + " ");

            }
        }//o continue ao invez de sair do bloco, ele vai ignorar oque for positivo e ir p/ frente
    }
}
