using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodo
{
    class Carro //Classe carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano) //Os 3 parametros começam com letra minuscula por se tratar de um método, e os da classe com maiuscula
        {
            //O parametro que recebi no construtor de carro, que é modelo (minusculo), etou pegando esse valor e atribuindo ao Modelo que é o atributo do carro,
            //Ou seja, estou alterando alterando o atributo do objeto que está sendo criado nesse momento.
            Modelo = modelo; 
            Fabricante = fabricante;
            Ano = ano; //Se vc colocar o nome do atributo Ano = Ano, vc estará setando o proprio atributo nele mesmo, ou seja não estaria fazendo absolutamente nada,
            //Nesse caso, vc poderia usar a palavra this, que quer dizer o objeto que está sendo usado naquele momento, ou seja, o objeto atual. Quando vc tem uma classe e a partir dessa classe, vc cria um objeto, dentro dessa classe vc vcpode
            //instanciar um objeto corrente que está sendo criado naquele momento como sendo this. Então vc tem como referênciar mesmo que haja o mesmo nome. Maiusculo e Maiusculo. Quando o nome é igual, o this serve pra dizer:
            //Esse Ano pertence ao objeto: this.Ano (O primeiro ano é da Classe, e o segundo Ano é o parametro que recebi dento do construtor ()
        }
        public Carro() { } //posso criar mais de um construtor com o mesmo nome, com parametros diferêntes ()

        //O construtor padrão existe quando vc não tem outro e quando vc de forma explicita não cria um, ou eu info
    }
    class Construtores //Classe
    {
        public static void Executar() //Metodo

        {

            //FORMAS DE CRIAR INSTANCIAR UM OBJETO

            //Passar o construtor e chamar ele em cada linha 
            var Carro1 = new Carro(); //Passando os atributos pelo metodo Carro()
            Carro1.Fabricante = "BMW";
            Carro1.Modelo = "3251";
            Carro1.Ano = 2024;
            Console.WriteLine($"O {Carro1.Fabricante} {Carro1.Modelo} {Carro1.Ano}");
             

            //Criar passando o construtor
            var Carro2 = new Carro("Ka", "Ford", 1254); //passando os atributos pelo método  Carro(string modelo, string fabricante, int Ano)
            Console.WriteLine($"{Carro2.Fabricante} {Carro2.Modelo} {Carro2.Ano}");


            //Criando o objeto sem ter um construtor especifico pra passar
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019

            }; Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}
