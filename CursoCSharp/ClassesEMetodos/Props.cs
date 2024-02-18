using System;
using System.Globalization;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        //atributos privados começam com letras minúsculas e os públicos com letras maiúsculas
        double desconto = 0.1;
        string nome; //Atributo privado que será acessado através da propriedade Nome com N maiúsculo, que é uma propriedade pública

        //PRIMEIRA FORMA DE CRIAR UMA PROPRIEDADE COM GET E SET
        public string Nome //publico, dentro do atributo Nome, no par de chaves associado a ele, eu vou criar o get e o set
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {//nesse caso estou passando o valor e salvando dentro do atributo nome que é privado. O criado com letra maiúscula é apenas para acessar o atributo privado
                nome = value; //Em set o valor que está sendo passado é acessado a partir da palavra reservada value
            }
        }

        //PROPRIEDADE AUTOIMPLEMENTADA (MELHOR E MAIS SIMPLES)
        //SEGUNDA FORMA DE CRIAR UMA PROPRIEDADE COM GET E SET
        public double Preco { get; set; } 

        //SOMENTE LEITURA, VALORES CALCULADOS
        //TERCEIRA FORMA DE CRIAR UMA PROPRIEDADE COM GET E CALCULO
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //=> é uma ^lambda, e tbm a forma simplificada de criar um get, mesma coisa que o return abaixo comentado.

            //get
            //{
            //    return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            this.nome = nome; //Setando o atributo do objeto com o valor passado no parâmetro
            Preco = preco;
        }

    }
    public class Props
    {
        public static void Execurar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.PrecoComDesconto);//Nesse contexto eu estou tentando lê o valor, então ele entende que deve retornar um get
            //op1.PrecoComDesconto = 3000; //Nesse contexto eu estou tentando setar um valor, porém não criei um set para a propriedade PrecoComDesconto, então ele não permite a alteração
            
            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.PrecoComDesconto);

            /*Nesse caso nós fizemos um exemplo mostramdo o conceito de propridade que é como se fosse um atributo, que associado a ele tem um método get e um método set
             * A grande questão é que você não precisa implementar o método get e set quando não for necessário e quando ele for de fato necessário
             * você simplesmente vai lá e implementa o get e set. Outra questão é que vc não precisa obrigatoriamente ciar uma uma propriedade, você pode
             * simplesmente criar um atributo normal sem ser uma propriedade e quando for necessário você transforma um atributo em uma propriedade.
             * Do ponto de vista de quem está acessando um atributo, não sabe se é um atributo ou simplesmente uma propriedade pública. Então essa é uma das vantagens.
             */


        }
    }
}
