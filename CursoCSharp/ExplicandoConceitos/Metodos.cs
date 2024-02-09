using System;

namespace CursoCSharp.ExplicandoConceitos
{
    public class Metodos
    {
        string nome;
        int idade;

        // Construtor sem return e exibindo valores diretamente
        public Metodos(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

        public static void Executar()
        {
            // Criando uma instância da classe Metodos
            Metodos metodos = new Metodos("João", 20);
        }
    }
}
