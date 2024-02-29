using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }
    }

    public class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);
            var carrinho = new List<Produto>();//Criando lista carrinho do tipo Produto
            var combo = new List<Produto>();//Criando lista combo do tipo Produto

            // Adicionando um produto ao carrinho
            carrinho.Add(livro);

            // Exibindo os produtos no carrinho
            foreach (var produto in carrinho) {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: R${produto.Preco}");
            }

            // Adicionando produtos ao combo, usando o método Add
            combo.Add(new Produto("Camisa", 29.9));
            combo.Add(new Produto("8° temporada de Game Of Thrones", 99.9));
            combo.Add(new Produto("Poster", 10));

            // Adicionando todos os produtos do combo ao carrinho, o método AddRange permite insetir vários produtos de uma vez
            carrinho.AddRange(combo);

            // Exibindo os produtos no carrinho após adicionar o combo
            foreach (var produto in carrinho) {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: R${produto.Preco}");
            }

            // Exibindo a quantidade de itens no carrinho
            Console.WriteLine($"Quantidade de itens no carrinho: {carrinho.Count}");

            // Removendo um item específico do carrinho pelo índice
            carrinho.RemoveAt(3);

            // Exibindo os produtos no carrinho após remover um item
            foreach (var produto in carrinho) {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: R${produto.Preco}");
            }

            // Encontrando o índice de um item específico no carrinho
            int indice = carrinho.IndexOf(livro);
            Console.WriteLine($"O livro 'Game of Thrones' está no índice {indice} do carrinho.");
        }
    }
}
