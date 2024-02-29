using System;
using System.Collections;
using System.Collections.Generic;

// O princípio da fila é: o primeiro a entrar é o primeiro a sair.

namespace CursoCSharp.Colecoes {

    public class ColecoesQueueFila {
        public static void Executar() {
            // Instanciando um objeto Queue<string> para representar uma fila de nomes.
            var nomeFila = new Queue<string>();

            // Adicionando elementos à fila.
            nomeFila.Enqueue("Fulano");
            nomeFila.Enqueue("Ciclano");
            nomeFila.Enqueue("Beltrano");

            // Exibindo quem será o próximo a sair da fila sem removê-lo.
            Console.WriteLine($" O próximo a sair da fila é: {nomeFila.Peek()}"); // O método Peek não remove o elemento, apenas o mostra.

            // Exibindo a quantidade de pessoas na fila.
            Console.WriteLine($" Quantidade de pessoas na fila: {nomeFila.Count}");

            // Removendo o próximo da fila e exibindo quem foi removido.
            Console.WriteLine($"Removendo a próxima pessoa da fila: {nomeFila.Dequeue()}");

            // Exibindo a quantidade de pessoas na fila após a remoção.
            Console.WriteLine($"Quantidade de pessoas na fila atualmente: {nomeFila.Count}");

            // Iterando sobre os elementos restantes na fila e exibindo-os.
            Console.WriteLine("Elementos restantes na fila:");
            foreach (var item in nomeFila) {
                Console.WriteLine(item);
            }

            // Criando uma nova fila sem tipo específico (não genérica).
            var salada = new Queue();

            // Adicionando elementos de diferentes tipos à nova fila.
            salada.Enqueue(3);
            salada.Enqueue("Hello");
            salada.Enqueue(true);
            salada.Enqueue(3.5);

            // Verificando se a nova fila contém elementos específicos.
            Console.WriteLine($"A fila contém o número 3? {salada.Contains(3)}"); // Retorna true ou false
            Console.WriteLine($"A fila contém a string 'Hello'? {salada.Contains("Hello")}"); // Retorna true ou false
        }
    }
}
