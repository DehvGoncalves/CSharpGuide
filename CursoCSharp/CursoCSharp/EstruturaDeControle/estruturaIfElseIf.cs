using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class estruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota");
            double nota = double.Parse(Console.ReadLine());

            if (nota == 9)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else
            {
                if (nota >= 7 || nota <= 8)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    if (nota == 6)
                    {
                        Console.WriteLine("Na média");
                    }
                    else
                    {
                        Console.WriteLine("Sei lá");

                    };
                }
            }
        }
    }
}
