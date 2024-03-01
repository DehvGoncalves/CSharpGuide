using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    public class ColecoesStack {

        //A pilha usa os comandos: Push pra adcionar, Pop pra remover o ultimo elemento, Peek pra mostrar quem será o próximo da fila.
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);    
            pilha.Push(3.14f);// Em C#, quando você escreve um número decimal, ele é automaticamente considerado um double. Para indicar que o número é um float, você adiciona o sufixo "f"

            Console.WriteLine("Itens da coleção Pilha:");
            foreach (var item in pilha){
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");//O pop vai remover o ultimo elemento da fila

            Console.WriteLine("Novos itens da coleção Pilha, após remover o ultimo item");
            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");//Vai pegar o valor no topo da fila mas não vai remover
            Console.WriteLine(pilha.Count);
        }
    }
}
