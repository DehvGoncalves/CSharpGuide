using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 1.75; // Define uma variável double chamada "valor" com o valor 1.75.

            Console.WriteLine(valor.ToString("F1")); // Converte o valor para uma string formatada com uma casa decimal usando "F1" e imprime.
            Console.WriteLine(valor.ToString("C")); // Converte o valor para uma string formatada como moeda local e imprime.
            Console.WriteLine(valor.ToString("P")); // Converte o valor para uma string formatada como percentual e imprime.
            Console.WriteLine(valor.ToString("#.##")); // Converte o valor para uma string formatada com até duas casas decimais e imprime.
            Console.WriteLine(valor.ToString("C0"));// Converte o valor para uma string formatada como moeda local sem casas decimais e imprime.


            CultureInfo cultura = new CultureInfo("pt-BR"); // Cria uma instância de CultureInfo para forçar a formatação como dinheiro real do Brasil.
            Console.WriteLine(valor.ToString("C0", cultura)); // Converte o valor para uma string formatada como moeda local sem casas decimais usando a cultura brasileira e imprime.
            
            CultureInfo cultura2 = new CultureInfo("en-US"); // Cria uma instância de CultureInfo para forçar a formatação como dinheiro real do Brasil.
            Console.WriteLine(valor.ToString("C3", cultura2)); // Converte o valor para uma string formatada como moeda local com três casas decimais usando a cultura dos Estados Unidos e imprime.

            int CPF = 254789632;
            Console.WriteLine(CPF.ToString("D12")); //Completo com 0 a esquerda, até atingir a quantidade de caracters necessários
        }
    }
}

