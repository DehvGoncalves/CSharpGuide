using CursoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.diarioDeUmDev
{
    internal class aprendendo
    {
        public static void executar()
        {
            var corAtual = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("@date");
            Console.WriteLine("Em 24/01/2024, finalizei mais uma etapa do curso, referente a estrutura de repetição. Estou anciosa para falarmos de Classes e métodos. Nos vemos amanhã.");
            Console.BackgroundColor = corAtual; //voltando pra cor atual


            //Estruturas condicionais
            Console.WriteLine("Me informe sua nota");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota < 0)
            {
                Console.WriteLine("Reprovado");
            }
            else
                Console.WriteLine("Aprovado");

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Ruim");
                    break;
                case 1:
                    Console.WriteLine("Medio");
                    break;
                case 2:
                    Console.WriteLine("Bom");
                    break;
            }

            //Estruturas de repetição
            nota = 0;
            while (nota < 5)
            {
                Console.WriteLine(nota);
                nota++;
            }

            do
            {
                Console.WriteLine(nota);
                    nota++;
            } while (nota < 5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


        }

    }
}
