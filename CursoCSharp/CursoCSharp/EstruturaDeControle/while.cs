using System;
using System.Collections.Generic;
using System.Threading.Channels;
using CursoCSharp;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Estruturawhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random(); //vou criar um valor aleatório usando uma classe existente chamada Random

            int numeroSecreto = random.Next(1, 16); //Em cima de Random vou gerar um valor aleatório, passando o parametro 1, 16. o valor 16 não entra. Vai gerar entre 1 e 15
            bool numeroEncontrado = false; //começar um palpite com valor diferente do chute
            int tentativasRestantes = 5; //ele tem 5 tentativas
            int tentativas = 0; //começa com 0

            while(tentativasRestantes > 0 && !numeroEncontrado){//enquanto as tentativas restantes for >0 e p numero encontrado for diferente do que tem agora (falso), entre no whilee fique executando várias vezes até que o numero seja encontrado ou a quantidade de tentativas tenha esgotado
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine(); //armazena o palpita na variável entrada como String
                int.TryParse(entrada, out palpite); //transforma o palpite em inteiro e usa o metodo TryParse p/ transformar em 0 caso seja diferente de número

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)//Se o palpite do usuário for igual ao numero secreto
                {
                    numeroEncontrado |= true; //vou mudar o numero encontrado de falso para verdadeiro
                    var corAnterior = Console.BackgroundColor; //vou pegar uma variavel com a cor anterior do console pra depois eu restaurar e voltar p/ cor anterir
                    Console.BackgroundColor = ConsoleColor.Green; // altero a cor do console pra verde
                    Console.WriteLine("Número encontrado em {0} tentativas", tentativas);

                    Console.BackgroundColor = corAnterior; //Depois disso volto pra cor origial
                }
                else if (tentativasRestantes == 0)
                {
                    var corAnterior2 = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número de tentativas rsgotado");
                    Console.BackgroundColor = corAnterior2;
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Maior... Tente ourtra vez. Tentativas restantes {0}", tentativasRestantes);
                }
               
                else if(palpite <  numeroSecreto)
                {
                    Console.WriteLine("Palpite Menor... Tente outra vez. Tentativas restantes {0}", tentativasRestantes);
                }
               


            }
            
        } 
    }
}
