using System;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            /* 
               Em C#, podemos inferir o tipo da variável com base no valor atribuído, mesmo sendo uma linguagem fortemente tipada.
               A inferência ocorre durante a compilação e não pode ser alterada depois de determinada pelo compilador.
               Basicamente,  você cria a variável com o tipo "var" o compilador identifica o tipo da variável automaticamente com base no valor atribuído. 
               Lembrando que se o tipode variável for "Var", você devera atribuir um valor já no ato da criação da variável.
             */

            var nome = "Leonardo"; // O compilador infere que a variável 'nome' é do tipo string.
            var idade = 25; // O compilador infere que a variável 'idade' é do tipo int.
            Console.WriteLine($"Nome: {nome}, Idade{idade}");
            nome.GetType(); // Retorna o tipo da variável 'nome'.
            Console.WriteLine(nome.GetType());

        }
    }
}
