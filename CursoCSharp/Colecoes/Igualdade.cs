using System;
using System.Collections.Generic;


namespace CursoCSharp.Colecoes {
    public class Igualdade {
        public static void Executar() {
            var p0 = new Produto("Perfume", 200);
            var p1 = new Produto("Perfume", 200);
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2; //os dois apontam p/ mesmo local de memória

            //comparando endereços de memórias e não o objeto em si
            Console.WriteLine(p1 == p2); //os produtos são iguais?, nesse caso eles estão comparando referências de memorias. Os produtos estão apontado pra espaços diferentes de memória
            Console.WriteLine(p2 == p3); //os dois apontam p mesmo espaço de memória

            //usando o método Equals para comparar tbm, o Equals tbm compara endereço de memória
            //Pra mudar e fazer com que o Equals passe a comparar os valores e não o espaço de memória é necessário criar um "Método na classe do tipo dos dados que no caso é Produto,
            //Já fiz isso, vou colocar aqui comentado pra que veja como ficou, se vc for na classe Protuto verá que está lá a partir da linha 14
            /*        //Criando método para que o Equals mude o jeito de comparar pelo espaço de memória para que ele passe a comparar em termos de valores
            public override bool Equals(object obj) {
            Produto outro = (Produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;

            o método Equals sendo sobrescrito na classe Produto
            }*/
            Console.WriteLine("Comparando após o método Equals sendo sobrescrito na classe Produto ***************** ");
            Console.WriteLine(p0.Equals(p1));
            //E se eu quiser comparar os valores e não o endereço de memória?

        }
    }
}
