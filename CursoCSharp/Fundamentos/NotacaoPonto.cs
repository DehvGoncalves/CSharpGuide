using System;

namespace CursoCSharp.Fundamentos
{
    internal class MetodosRapidos
    {
        public static void Executar()
        {
            /*Em C#, a notação ponto (.) é utilizada para acessar membros de uma classe, objeto ou tipo.
             É a forma que você tem para acessar membros de uma função/Método, quando você coloca o . 
            Após um dado o editor te dá várias opções para usar, de acordo com o tipo de dado */

            //Mais explicações no arquivo NotacaoPonto.cs
            /* Em C#, a notação ponto (.) é uma sintaxe fundamental para acessar membros de uma classe, objeto ou tipo. 
             Ela oferece uma maneira de explorar e utilizar funcionalidades associadas a uma determinada instância. 
             Quando você coloca o ponto após um objeto no código, o editor apresenta opções relevantes com base no tipo de dado, 
             permitindo que você acesse métodos, propriedades e outras características específicas.

             Essa notação é especialmente poderosa ao trabalhar com funções e métodos, possibilitando a descoberta e utilização de diversas opções 
             oferecidas pela classe ou objeto. Ao explorar essas opções, você pode interagir de maneira eficaz com o sistema, 
             aproveitando as funcionalidades disponíveis de acordo com o contexto e tipo de dado em questão. */


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

            // A notação ponto é fundamental para acessar membros e funcionalidades em C#.
        }
    }
}
