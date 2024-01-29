using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class esruturaIfElse
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua notaaaaa ");
            double nota = double.Parse(Console.ReadLine());

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
                    Console.WriteLine("Não fez mais que sua obrogação");
            }else
                Console.WriteLine("Reprovado");
        }
    }
}
