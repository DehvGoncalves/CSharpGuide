using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("De 1 a 10, como você avalia o atendimento recebido? ");
            int.TryParse(Console.ReadLine(), out int nota);


            switch (nota)
            {
                case 0:
                    Console.WriteLine("Detrator");
                    break;
                case 1:
                    Console.WriteLine("Detrador");
                    break;
                case 2:
                    Console.WriteLine("Detrador");
                    break;
                case 3:
                    Console.WriteLine("Detrador");
                    break;
                case 4:
                    Console.WriteLine("Detrador");
                    break;
                case 5:
                    Console.WriteLine("Detrador");
                    break;
                case 6:
                    Console.WriteLine("Detrador");
                    break;
                case 7:
                    Console.WriteLine("Neutro");
                    break;
                case 8:
                    Console.WriteLine("Neutro");
                    break;
                case 9:
                    Console.WriteLine("Promotor");
                    break;
                case 10:
                    Console.WriteLine("Promotor");
                    break;
                default:
                    Console.WriteLine("Nota Inválida");
                    break;
            }
            Console.WriteLine("A nota digitada, foi {0} ", nota, "obrigada por responder.");


        }
    }
}
