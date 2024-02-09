using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Carro
    {
        public String Modelo;
        public String Fabricante;
        public int Ano;

        public Carro(string modelo, string Fabricante, int ano) //Método construtor
            //A partir do momento que eu crio um método construtor, o método construtor padrão não é mais criado automaticamente.
            //Com isso, você deverá criar um método construtor padrão, caso queira que ele exista.
        {
            Modelo = modelo; //O parmetro modelo do método é atribuido ao atributo Modelo
            this.Fabricante = Fabricante; //This é usado para referenciar o objeto atual, você usa o this pra dizer, esse modelo pertence a esse objeto.
            Ano = ano;
        }
        public Carro() //Método construtor padrão
        {
            return;
        }
    }


    class Construtores
    {
        public static void Executar()
        {
            //Atribuindo os valores em linhas separadas
            var carro1 = new Carro(); //Usando o método construtor padrão para instanciar o objeto. O construtor qaundo não é definido, é o padrão. O c# cria um construtor padrão para nós. Porém os parameteos só podem ser passados por meio de um método construtor.
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            //atribuindo os valores em linhas separadas, dentro de chaves
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

            //Atribuindo os valores em uma linha
            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

        }
    }

}
