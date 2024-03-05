using System;
using System.Reflection.Metadata.Ecma335;
//BASE é o método que vc chama na classe que vc herda
namespace CursoCSharp.OO {
    public class Animal {
        public string Name { get; set; }
        public Animal(string nome) {
            Name = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }
        public Cachorro(string nome) : base(nome) {//usando base pra chamar o construtor da classe pai, pelo menos um construtor precisa chamar o base pra criar a herança
            Console.WriteLine($"Cachorro {nome} inicializado");
        }
        //Nesse caso, o construtor cachorro vai chamar o construtor da própria classe pra setar o nome, então usamos : this pra chamar  o construtor da própria classe
        //no this(nome), estou passando o nome para o construtor de cima e o de cima vai chamar o base, o nome, seta o nome do animal termina esse construtor e por fim
        //volta pra esse construtor Cachorro. Lembrando que pelo menos um dos construtores precisa chamar o base, pra que tenha uma hierarquia.
        public Cachorro (string nome, double altura) : this(nome) {//usando this pra chamar o construtor do próprio código
            Altura = altura;
        }
        //ToString, quando vc tem um objeto e quer converter esse objeto pra uma string, se vc não tiver esse método ele vai simplesmente colocar o nome da classe e nao será algo representativa
        //esse método vai transformar uma instância em uma String. Nesse caso, quando eu usar o cachorro dentro de um contexto, que é necessário uma string, ele vai chamar
        //esse metodo e automaticamente, converte um objeto em string, é muito interessante e em várias situações ele vai te ajudar a imprimir um objeto de uma forma relevante
        public override string ToString() { 
            return $"{Name} tem {Altura} cm de altura!";
        }
    }
    public class ConstrutorThis {
        public static void Executar() {
            var spike = new Cachorro("Spike");
            Animal max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);//Vai transformar tudo em string conforme o método criado na linha 26, se eu comentar esse método ele vai simplesmente 
            Console.WriteLine(max);//retornar o nome da classe

        }
    }
}
