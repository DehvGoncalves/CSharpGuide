using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estruturaBreak
    {
        public static void Executar() {

            //Exemplo COM o break

            Random random = new Random(); //criar um número aleatório entre 1 e 50
            int numero = random.Next(1, 51);

            Console.WriteLine("O numero que queremos é {0}", numero);
            for (int i = 0; i < 50; i++) 
            {

                Console.WriteLine("{0},  é o número que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim");
                    break;
                }
                else
                {
                    Console.WriteLine("Não");
                }
                Console.WriteLine("FIM");
            }
        
        }

    }
}
