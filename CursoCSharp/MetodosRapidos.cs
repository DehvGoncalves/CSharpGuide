using System;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            /*Em C#, a notação ponto (.) é utilizada para acessar membros de uma classe, objeto ou tipo.*/

            // Exemplo com tipos primitivos:
            int numero = 10;
            Console.WriteLine(numero.ToString()); // Converte o valor inteiro para uma string.

            // Exemplo com strings:
            string texto = "Olá, mundo!";
            Console.WriteLine(texto.Length); // Retorna o número de caracteres na string.

            // Utilizando métodos da classe string:
            Console.WriteLine(texto.ToUpper()); // Converte todos os caracteres para maiúsculas.
            Console.WriteLine(texto.ToLower()); // Converte todos os caracteres para minúsculas.
            Console.WriteLine(texto.Substring(0, 3)); // Retorna uma substring com os primeiros 3 caracteres.

            // Exemplo com arrays:
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array.Length); // Retorna o número de elementos no array.

            // Exemplo com objetos DateTime:
            DateTime agora = DateTime.Now;
            Console.WriteLine(agora.Hour); // Obtém a hora atual do objeto DateTime.

            // Exemplo com métodos da classe Math:
            Console.WriteLine(Math.Ceiling(4.5)); // Arredonda para o número inteiro mais próximo acima.

            // Exemplo com tipos anônimos:
            var pessoa = new { Nome = "João", Idade = 30 };
            Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}"); // Acessa as propriedades do tipo anônimo.

            // Exemplo com membros de tipos complexos:
            Console.WriteLine(Console.WindowWidth); // Obtém a largura da janela do console.

            // Exemplo com métodos de leitura de dados:
            Console.WriteLine(Console.ReadLine()); // Lê uma linha de texto do console.

            // A notação ponto é fundamental para acessar membros e funcionalidades em C#.
        }
    }
}
