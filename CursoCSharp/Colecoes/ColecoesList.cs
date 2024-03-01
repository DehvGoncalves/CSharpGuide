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

        //Criando método para que o Equals mude o jeito de comparar pelo espaço de memória para que ele passe a comparar em termos de valores
        public override bool Equals(object obj) {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;

        }
        //O HashCode é como se fosse um indice de banco de dados, é como se fosse uma forma rápida de agrupar um conjunto de dados, e depois ele vai ser verificado com o Equals
        //Imagine que vc tem uma lista de nomes com: Ana, Rafa e Bia, ana e bia tem 3 letras e Rafa com 4 letras, hascod 4. Dado a lista com 4 elementos ele vai procurar oque tem o mesmo hascod, e já vai cortar pela metade pra filtrar mais rápido.
        //Uma vez que vc definiu o Equals vc tem que definir um Hashcod
        public override int GetHashCode() {
            return Nome.Length;
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


    public class TesteListaClientes {
        public string Nome;
        public int Idade;

        public TesteListaClientes(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }
        public TesteListaClientes() { }

    }
    public class Cliente {
        public static void Executar() {
            var clientes = new TesteListaClientes("Debora", 31);
            var listaDeClientes = new List<TesteListaClientes>();

            listaDeClientes.Add(clientes);
            listaDeClientes.Add(new TesteListaClientes("Poloana", 33));
            listaDeClientes.Add(new TesteListaClientes("Carla", 34));
            listaDeClientes.Add(new TesteListaClientes("Karla", 35));

            int indice = listaDeClientes.IndexOf(clientes);

            foreach (var id in listaDeClientes) {
                Console.WriteLine($"Nome: {id.Nome}, Idade: {id.Idade}");
            }

            //Excluir o nome que escrevi errado, Karla
            Console.WriteLine($"Excluí o último nome '{listaDeClientes[3].Nome}', que estava escrito errado. Idade: {listaDeClientes[3].Idade}");

            listaDeClientes.RemoveAt(3);
            foreach (var cont in listaDeClientes) {
                Console.WriteLine($"Nova Lista, após a exclusão:");
                Console.WriteLine($" {cont.Nome}, {cont.Idade}");
            }


        }

    }

}
