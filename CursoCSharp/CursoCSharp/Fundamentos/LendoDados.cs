using System;
using System.Globalization; //para pegar pontos e não virgula, no salário

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine(); // POR PADRÃO OQUE EU RECEBO É STRING, P/ MUDAR É NECESSÁRIO AJUSTE USANDO O PARSE

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine()); //Transforma ex: "1" para 1

            Console.WriteLine("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), 
                CultureInfo.InvariantCulture); //Não olha para o simbolo da cultura, que a maquina está configurado e sim o . ou seja converte , em . em qualquer maquina pega o . como separador de casas decimais


            Console.WriteLine($"Seu nome é {nome} sua idade é {idade} e seu salário é R${salario}"); //Dolar vem antes p/ que as variáveis sem interpoladas corretamente.
        }
    }
}