using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class operadoresUnarios
    {
        public static void Executar()

        {
            var valorNegativo = -5; //valor unário
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); //quando coloca - associado a um operando, ele torna o operando negativo, ou inverte se já for negativo
            Console.WriteLine(!booleano); //negação lógica, se for true muda pra false, se for false vira true

            numero1++; //vai acrescentar 1, pós fixado. Pode colocar o ++ antes ou depois, assim como o sinal de -
            Console.WriteLine(numero1);

            --numero1;//decremento, pre fixado
            Console.WriteLine(numero1);


            //Bom evitar pois só trás confusão do que esclarecimento
            Console.WriteLine(numero1++ == --numero2); //quando coloca ++depois do numero da variável, significa que vc nao está apressao pra fazer a operação. Quando vc coloca antes, ele tem precedêmcia
            Console.WriteLine($"{numero1} {numero2}");//Muito importante, digamos uma das maiores qualidades que o código pode ter é vc ter um código de fácil leitura, que
            //olhe o código e saiba resolver
        }
    }
}
