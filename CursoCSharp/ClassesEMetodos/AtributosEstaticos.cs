using System;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        //public double Desconto; //Atributo não estático, ou seja, cada objeto terá um valor de desconto diferente.
                                  //Para passar o valor de desconto para cada objeto: var produto1 = new Produto("Caneta", 3, 0.1);
        public static double Desconto = 0.1; //Atributo estático não sérá possivel passar o valor de desconto para cada objeto.
                                             //O desconto será o mesmo para todos os objetos da classe Produto. Para passar um valor Produto.Desconto = 0.5;

        public Produto(string nome, double preco, double desconto)
        {   //Como existe diferença na primeira letra do nome do atributo e do parâmetro, eu preciso usar o this para diferenciar
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {
        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    public class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto.Desconto = 0.5;//Colocando o mesmo descoto para todos os objetos da classe Produto

            var produto1 = new Produto("Caderno", 25, 0.5);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 98,
                //Desconto = 0.1 //Dará erro pois o atributo agora pertence a classe e não é mais possível passar um valor para cada objeto.
            };

            Console.WriteLine($" O produto {produto1.Nome} tem o preço de {produto1.Preco}, com o desconto de {Produto.Desconto} o preço final é {produto1.CalcularDesconto()}");
            Console.WriteLine($" O produto {produto2.Nome} tem o preço de {produto2.Preco}, com o desconto de {Produto.Desconto} o preço final é {produto2.CalcularDesconto()}");



            Produto.Desconto = 1.0;//Colocando o mesmo descoto para todos os objetos da classe Produto, a partir de agora o desconto será de 100%
            var produto4 = new Produto()
            {
                Nome = "Borracha",
                Preco = 98,
                //Desconto = 0.1 //Dará erro pois o atributo agora pertence a classe e não é mais possível passar um valor para cada objeto.
            };

            Console.WriteLine($" O produto {produto1.Nome} tem o preço de {produto1.Preco}, com o desconto de {Produto.Desconto} o preço final é {produto1.CalcularDesconto()}");
        } 
    }
}
