using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class operadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3; //começa com 3
            num1 = 7; //muda pra 7

            num1 += 10; // num1 = num1 + 10

            Console.WriteLine(num1);

            num1 -= 3; // num1 = num1 - 3
            Console.WriteLine(num1);

            num1 *= 5; // num1 = num1 * 5
            Console.WriteLine(num1);

            num1 /= 2; // num1 = num1 / 2
            Console.WriteLine(num1);

            int a = 1; //atribuição literal
            int b = a; //atribuição por cópia/referência, será abordado em POO

            a++; // a = a +1, incremento
            b--; // b = b -1, decremento

            Console.WriteLine($"{a} {b}");

        }
    }
}
