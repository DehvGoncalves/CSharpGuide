using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class operadoresRelacionais
    {
        public static void Executar()
        {
            Console.WriteLine("Informe sua nota ");
            double.TryParse(Console.ReadLine(), out double nota); //Tenta converter a string obtida do Console.ReadLine() para um número decimal (double). Se a conversão for bem-sucedida, o valor convertido é armazenado na variável nota, e a função retorna true. Se a conversão falhar, a variável nota permanece com o valor padrão para double (normalmente 0.0), e a função retorna false.
           
            double notaDeCorte = 7.0;

            Console.WriteLine("Reprovado? {0}", nota < 7);
            Console.WriteLine("Aprovado? {0}", nota >=7);
            Console.WriteLine("Tirou o total? {0}", nota == 10);
            Console.WriteLine("Tem como melhorar? {0}", nota != 8);
            Console.WriteLine("Na média? {0}",  nota != notaDeCorte);

        }
    }
}
