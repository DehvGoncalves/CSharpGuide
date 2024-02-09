using System;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        /* Existem várias formas de converter um tipo de dado para outro.
         * A primeira é a conversão implícita, que ocorre sem perda de dados.
         * A segunda é a conversão explícita, que ocorre quando há perda de dados.
         */

        /* Em algumas situações, é necessário converter um valor com possível perda de informações. 
         * Por exemplo, ao converter de double para int, você perde a parte decimal. 
         * Nesses casos, é necessária uma conversão explícita, indicando ao compilador que você está ciente da perda de dados e deseja realizar a conversão mesmo assim. 
         * Para isso, coloque o tipo de dado desejado entre parênteses antes do valor a ser convertido. É como se você estivesse dizendo:
         "COMPREENDO QUE TEREI PERDA E DESEJO CONTINUAR"
         */

        public static void Executar()
        {
            // Conversão explícita de double para int (com perda de dados)
            double numeroDouble = 10.5;
            int numeroInteiro = (int)numeroDouble;
            Console.WriteLine($"Conversão explícita: double para int - Resultado: {numeroInteiro}");

            // Conversão implícita de int para double (sem perda de dados)
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine($"Conversão implícita: int para double - Resultado: {quebrado}");

            // Conversão implícita de float para double (sem perda de dados)
            float numeroFloat = 5.7f;
            double numeroDouble2 = numeroFloat;
            Console.WriteLine($"Conversão implícita: float para double - Resultado: {numeroDouble2}");

            // Conversão explícita de decimal para int (com arredondamento e possível perda de dados)
            decimal valorDecimal = 15.8m;
            int valorInteiro = (int)Math.Round(valorDecimal);
            Console.WriteLine($"Conversão explícita: decimal para int com arredondamento - Resultado: {valorInteiro}");

            // Conversão implícita de char para int (código ASCII)
            char caractere = 'A';
            int codigoAscii = caractere;
            Console.WriteLine($"Conversão implícita: char para int (código ASCII) - Resultado: {codigoAscii}");


            // Conversão explícita de String para int usando o TryParse. O TryParse tenta converter a string para o tipo de dado desejado e retorna true se a conversão for bem-sucedida ou false se não for.
            Console.WriteLine("Digite um número");  // Solicita ao usuário que digite um número
            string palavra = Console.ReadLine();    // Lê a entrada do usuário como uma string chamada 'palavra'
            int numero;                             // Declaração da variável 'numero' que será usada para armazenar o valor convertido
            int.TryParse(palavra, out numero);       // Tenta converter a string 'palavra' para um número inteiro usando o método TryParse

        }
    }
}


