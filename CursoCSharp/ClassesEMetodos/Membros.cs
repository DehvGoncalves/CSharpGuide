using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar()
        {
            //Instanciando um objeto da classe Pessoa. pessoa() é o construtor padrão da classe Pessoa
            Pessoa p1 = new Pessoa(); //Tipo é pessoa, nome da variável é p1, e chamando o operador new, jundo do construtor padrão Pessoa() eu crio um objeto do tipo Pessoa.
            
            //Com o novo objeto criado, eu coloco os atributos que eu quero
            p1.Nome = "Leandro";
            p1.Idade = 21;
            
            //Uma vez que eu preenchi os dados desse objeto, eu posso usar esses daddos como eu quiser
            Console.WriteLine($"{p1.Nome} tem {p1.Idade} anos de idade");
            p1.ApresentarNoConsole(); //Chamando o método ApresentarNoConsole() do objeto p1
            p1.Zerar(); //Chamando o método Zerar() do objeto p1
            p1.ApresentarNoConsole(); //Chamando o método ApresentarNoConsole() do objeto p1


            var p2 = new Pessoa();
            p2.Nome = "Beto";
            p2.Idade = 22;

            var apresentacaoDoBeto = p2.Apresentar();
            Console.WriteLine(apresentacaoDoBeto);
        }
    }
}
//Nesse exercico, criei uma classe Pessoa (Tipo), com dois atributos (Nome e Idade), incluí os dados usando a notação ponto (p1.Nome = "Leandro";), que é a forma que eu tenho de acessar os membros de uma classe que são: Atributos e Métodos.
//E imprimo os dados na tela.
