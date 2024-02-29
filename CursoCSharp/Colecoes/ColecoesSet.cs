using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    //Ao trabalhar com set e não list algumas coisas mudam. O Set não tem índice, então não tenho mais a possibilidade de remover um índice específico ou retornar um índice, pois é não indexado.
    //O Set também é uma estrutura que não aceita repetição. Usamos o método UnionWith para fazer união de listas.

    public class ColecoesSet {
        // Lembrando que Produto é um tipo de classe criada em ColecoesList.
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            // Criando lista carrinho do tipo Produto.
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                // Inicializando combo com alguns produtos.
                new Produto("Camisa", 29.9),
                new Produto("8° temporada de Game Of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            // União de carrinho com combo.
            carrinho.UnionWith(combo);

            // Exibindo a quantidade de itens no carrinho.
            Console.WriteLine(carrinho.Count);

            // Iterando sobre os itens no carrinho e exibindo nome e preço.
            foreach (var item in carrinho) {
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            // Exibindo novamente a quantidade de itens no carrinho.
            Console.WriteLine(carrinho.Count);

            // Adicionando novamente o livro ao carrinho.
            carrinho.Add(livro);

            // Exibindo a quantidade de itens no carrinho após adicionar novamente o livro.
            Console.WriteLine(carrinho.Count);
        }
    }
}
